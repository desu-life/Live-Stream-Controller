namespace Live_Stream_Controller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            wstextbox = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            wspwtextbox = new ToolStripTextBox();
            wsConnectButton = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            statusLable = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            sponsorSourceSetButton = new Button();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, wstextbox, toolStripLabel2, wspwtextbox, wsConnectButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(882, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(79, 22);
            toolStripLabel1.Text = "obs ws地址：";
            // 
            // wstextbox
            // 
            wstextbox.Name = "wstextbox";
            wstextbox.Size = new Size(150, 25);
            wstextbox.Text = "ws://127.0.0.1:4455";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(43, 22);
            toolStripLabel2.Text = "密码：";
            // 
            // wspwtextbox
            // 
            wspwtextbox.Name = "wspwtextbox";
            wspwtextbox.Size = new Size(100, 25);
            wspwtextbox.Text = "123456";
            // 
            // wsConnectButton
            // 
            wsConnectButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            wsConnectButton.Image = (Image)resources.GetObject("wsConnectButton.Image");
            wsConnectButton.ImageTransparentColor = Color.Magenta;
            wsConnectButton.Name = "wsConnectButton";
            wsConnectButton.Size = new Size(23, 22);
            wsConnectButton.Text = "连接至obs";
            wsConnectButton.Click += wsConnectButton_ClickAsync;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLable });
            statusStrip1.Location = new Point(0, 452);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(882, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLable
            // 
            statusLable.Name = "statusLable";
            statusLable.Size = new Size(114, 17);
            statusLable.Text = "Waiting connection.";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(882, 427);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(874, 399);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "欢迎";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(sponsorSourceSetButton);
            tabPage2.Controls.Add(radioButton7);
            tabPage2.Controls.Add(radioButton6);
            tabPage2.Controls.Add(radioButton5);
            tabPage2.Controls.Add(radioButton4);
            tabPage2.Controls.Add(radioButton3);
            tabPage2.Controls.Add(radioButton2);
            tabPage2.Controls.Add(radioButton1);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(874, 399);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "源设置";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // sponsorSourceSetButton
            // 
            sponsorSourceSetButton.Location = new Point(288, 38);
            sponsorSourceSetButton.Name = "sponsorSourceSetButton";
            sponsorSourceSetButton.Size = new Size(102, 23);
            sponsorSourceSetButton.TabIndex = 14;
            sponsorSourceSetButton.Text = "设置";
            sponsorSourceSetButton.UseVisualStyleBackColor = true;
            sponsorSourceSetButton.Click += sponsorSourceSetButton_Click;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(242, 188);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(14, 13);
            radioButton7.TabIndex = 13;
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(242, 158);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(14, 13);
            radioButton6.TabIndex = 12;
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(242, 128);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(14, 13);
            radioButton5.TabIndex = 11;
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(242, 99);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(14, 13);
            radioButton4.TabIndex = 10;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(242, 71);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 9;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(242, 44);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 8;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(242, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 192);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 6;
            label7.Text = "获胜界面：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 162);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "比赛界面：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 130);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "选图界面：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 103);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "开始界面：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 73);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "等待界面：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 42);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "轮播赞助源（小）：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "场景：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 474);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox wstextbox;
        private ToolStripButton wsConnectButton;
        private StatusStrip statusStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripStatusLabel statusLable;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button sponsorSourceSetButton;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox wspwtextbox;
    }
}
