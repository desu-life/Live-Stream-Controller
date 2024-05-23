using OBSWebsocketDotNet;
using OBSWebsocketDotNet.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Stream_Controller.Core
{
    public static class ObsBase
    {
        public static OBSWebsocket? _obs;

        public async static Task<bool> Connect(string address, string password)
        {
            _obs = new OBSWebsocket();
            _obs.ConnectAsync(address, password);
            await Task.Delay(50);
            return _obs.IsConnected;
        }








    }
}
