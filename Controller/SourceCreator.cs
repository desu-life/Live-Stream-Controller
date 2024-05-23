#pragma warning disable CS8602 // 解引用可能出现空引用
using System;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OBSWebsocketDotNet;
using OBSWebsocketDotNet.Types;
using static Live_Stream_Controller.Core.ObsBase;

namespace Live_Stream_Controller.Controller
{
    public static class SourceCreator
    {
        private static readonly string[] SponsorImagePaths = {
            @"data\sponsor_info\sponsored by.png",
            @"data\sponsor_info\meowpad.png",
            @"data\sponsor_info\visit.png",
        };

        private static readonly string[] SponsorBGImagePaths = {
            @"data\sponsor_info\background.png",
            @"data\sponsor_info\logo.png",
        };

        public static async Task CreateSponsorSourceAsync()
        {
            var sponsorSourceName = "SponsorInfo";
            var sponsorBGImageName = "SponsorBG";
            var sponsorLogoName = "SponsorLogo";
            var sceneName = "desu.life Sponsor Scene";

            // 检查并创建场景
            if (!_obs.GetSceneList().Scenes.Any(scene => scene.Name == sceneName))
            {
                _obs.CreateScene(sceneName);
                await Task.Delay(100);
            }

            // 检查输入源是否存在
            if (!_obs.GetInputList().Any(input => input.InputName == sponsorSourceName))
            {
                // 设置变换
                var transformSettings = new SceneItemTransformInfo
                {
                    BoundsType = SceneItemBoundsType.OBS_BOUNDS_SCALE_INNER,
                    BoundsAlignnment = 0,
                    Alignnment = 5,
                    BoundsWidth = 1920,
                    BoundsHeight = 1080,
                    CropTop = 0,
                    CropBottom = 0,
                    CropLeft = 0,
                    CropRight = 0,
                    X = 0.0,
                    Y = 0.0,
                    Width = 1920.0,
                    Height = 1080.0,
                    SourceWidth = 1920.0,
                    SourceHeight = 1080.0,
                    ScaleX = 1.0,
                    ScaleY = 1.0,
                    Rotation = 0.0
                };

                // 创建图片源和设置
                CreateImageSource(sceneName, sponsorBGImageName, SponsorBGImagePaths[0], transformSettings);
                CreateImageSource(sceneName, sponsorLogoName, SponsorBGImagePaths[1], transformSettings);
                CreateImageSource(sceneName, sponsorSourceName, SponsorImagePaths[2], transformSettings);

                // 创建并设置滤镜属性
                var filterSettings = new JObject { { "opacity", 100 } };
                _obs.CreateSourceFilter(sponsorSourceName, "Color Correction", "color_filter", filterSettings);
            }

            await AdjustOpacityAndImageLoop(sponsorSourceName);
        }

        private static void CreateImageSource(string sceneName, string sourceName, string filePath, SceneItemTransformInfo transformSettings)
        {
            var imageSourceSettings = new JObject { { "file", Application.StartupPath + filePath } };
            _obs.CreateInput(sceneName, sourceName, "image_source", imageSourceSettings, true);
            var sceneItemId = GetSceneItemId(sceneName, sourceName);
            if (sceneItemId != -1)
            {
                _obs.SetSceneItemTransform(sceneName, sceneItemId, transformSettings);
                _obs.SetSceneItemLocked(sceneName, sceneItemId, true);
            }
        }

        private static async Task AdjustOpacityAndImageLoop(string sponsorSourceName)
        {
            int opacity = 100;
            bool isIncreasingOpacity = false;
            int sponsorImageIndex = 0;

            while (true)
            {
                opacity = isIncreasingOpacity ? opacity + 1 : opacity - 1;

                if (opacity >= 100)
                {
                    isIncreasingOpacity = false;
                    await Task.Delay(2000);
                }
                if (opacity <= 0)
                {
                    sponsorImageIndex = (sponsorImageIndex + 1) % SponsorImagePaths.Length;
                    isIncreasingOpacity = true;

                    var imageSourceSettings = new JObject { { "file", System.Windows.Forms.Application.StartupPath + SponsorImagePaths[sponsorImageIndex] } };
                    _obs.SetInputSettings(sponsorSourceName, imageSourceSettings);
                    await Task.Delay(400);
                }

                var opacitySettings = new JObject { { "opacity", opacity } };
                _obs.SetSourceFilterSettings(sponsorSourceName, "Color Correction", opacitySettings);

                await Task.Delay(4);
            }
        }

        private static int GetSceneItemId(string sceneName, string sourceName)
        {
            var sceneItemList = _obs.GetSceneItemList(sceneName);
            var sceneItem = sceneItemList.FirstOrDefault(item => item.SourceName == sourceName);
            return sceneItem?.ItemId ?? -1;
        }
    }
}
