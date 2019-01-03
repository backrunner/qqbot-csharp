namespace BackRunner.QQBot.BotConsole
{
    partial class ConsoleWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_switches = new System.Windows.Forms.GroupBox();
            this.cb_autoAgreePersonal = new System.Windows.Forms.CheckBox();
            this.lbl_personalSwitches = new System.Windows.Forms.Label();
            this.lbl_groupSwitches = new System.Windows.Forms.Label();
            this.cb_autoRepeat = new System.Windows.Forms.CheckBox();
            this.cb_autoAgreeGroup = new System.Windows.Forms.CheckBox();
            this.cb_welcomeMsg = new System.Windows.Forms.CheckBox();
            this.gb_sensitiveWords = new System.Windows.Forms.GroupBox();
            this.lbl_newSensitiveWord = new System.Windows.Forms.Label();
            this.btn_delSensitiveWord = new System.Windows.Forms.Button();
            this.btn_addSensitiveWord = new System.Windows.Forms.Button();
            this.tb_newSensitiveWord = new System.Windows.Forms.TextBox();
            this.lb_sensitiveWords = new System.Windows.Forms.ListBox();
            this.gb_operation = new System.Windows.Forms.GroupBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.gb_basic = new System.Windows.Forms.GroupBox();
            this.tb_botQQ = new System.Windows.Forms.TextBox();
            this.lbl_botQQ = new System.Windows.Forms.Label();
            this.gb_msgSettings = new System.Windows.Forms.GroupBox();
            this.tb_groupWelcomeMsg = new System.Windows.Forms.TextBox();
            this.lbl_groupWelcomeMsg = new System.Windows.Forms.Label();
            this.tb_newFriendMsg = new System.Windows.Forms.TextBox();
            this.lbl_newFriendMsg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_webApiConfig = new System.Windows.Forms.Label();
            this.btn_webApiTest = new System.Windows.Forms.Button();
            this.rb_webApiConfig = new System.Windows.Forms.RichTextBox();
            this.tb_webApiSecret = new System.Windows.Forms.TextBox();
            this.lbl_webApiSecret = new System.Windows.Forms.Label();
            this.tb_webApiKey = new System.Windows.Forms.TextBox();
            this.lbl_webApiKey = new System.Windows.Forms.Label();
            this.tb_webApi = new System.Windows.Forms.TextBox();
            this.lbl_webApi = new System.Windows.Forms.Label();
            this.cb_webApiEnable = new System.Windows.Forms.CheckBox();
            this.gb_switches.SuspendLayout();
            this.gb_sensitiveWords.SuspendLayout();
            this.gb_operation.SuspendLayout();
            this.gb_basic.SuspendLayout();
            this.gb_msgSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_switches
            // 
            this.gb_switches.Controls.Add(this.cb_autoAgreePersonal);
            this.gb_switches.Controls.Add(this.lbl_personalSwitches);
            this.gb_switches.Controls.Add(this.lbl_groupSwitches);
            this.gb_switches.Controls.Add(this.cb_autoRepeat);
            this.gb_switches.Controls.Add(this.cb_autoAgreeGroup);
            this.gb_switches.Controls.Add(this.cb_welcomeMsg);
            this.gb_switches.Location = new System.Drawing.Point(12, 12);
            this.gb_switches.Name = "gb_switches";
            this.gb_switches.Size = new System.Drawing.Size(139, 437);
            this.gb_switches.TabIndex = 0;
            this.gb_switches.TabStop = false;
            this.gb_switches.Text = "开关";
            // 
            // cb_autoAgreePersonal
            // 
            this.cb_autoAgreePersonal.AutoSize = true;
            this.cb_autoAgreePersonal.Location = new System.Drawing.Point(10, 159);
            this.cb_autoAgreePersonal.Name = "cb_autoAgreePersonal";
            this.cb_autoAgreePersonal.Size = new System.Drawing.Size(108, 16);
            this.cb_autoAgreePersonal.TabIndex = 5;
            this.cb_autoAgreePersonal.Text = "自动同意加好友";
            this.cb_autoAgreePersonal.UseVisualStyleBackColor = true;
            // 
            // lbl_personalSwitches
            // 
            this.lbl_personalSwitches.AutoSize = true;
            this.lbl_personalSwitches.BackColor = System.Drawing.Color.Transparent;
            this.lbl_personalSwitches.Location = new System.Drawing.Point(8, 137);
            this.lbl_personalSwitches.Name = "lbl_personalSwitches";
            this.lbl_personalSwitches.Size = new System.Drawing.Size(53, 12);
            this.lbl_personalSwitches.TabIndex = 4;
            this.lbl_personalSwitches.Text = "个人相关";
            // 
            // lbl_groupSwitches
            // 
            this.lbl_groupSwitches.AutoSize = true;
            this.lbl_groupSwitches.BackColor = System.Drawing.Color.Transparent;
            this.lbl_groupSwitches.Location = new System.Drawing.Point(8, 21);
            this.lbl_groupSwitches.Name = "lbl_groupSwitches";
            this.lbl_groupSwitches.Size = new System.Drawing.Size(41, 12);
            this.lbl_groupSwitches.TabIndex = 1;
            this.lbl_groupSwitches.Text = "群相关";
            // 
            // cb_autoRepeat
            // 
            this.cb_autoRepeat.AutoSize = true;
            this.cb_autoRepeat.Location = new System.Drawing.Point(10, 64);
            this.cb_autoRepeat.Name = "cb_autoRepeat";
            this.cb_autoRepeat.Size = new System.Drawing.Size(96, 16);
            this.cb_autoRepeat.TabIndex = 3;
            this.cb_autoRepeat.Text = "群内自然复读";
            this.cb_autoRepeat.UseVisualStyleBackColor = true;
            // 
            // cb_autoAgreeGroup
            // 
            this.cb_autoAgreeGroup.AutoSize = true;
            this.cb_autoAgreeGroup.Location = new System.Drawing.Point(10, 42);
            this.cb_autoAgreeGroup.Name = "cb_autoAgreeGroup";
            this.cb_autoAgreeGroup.Size = new System.Drawing.Size(96, 16);
            this.cb_autoAgreeGroup.TabIndex = 2;
            this.cb_autoAgreeGroup.Text = "自动同意入群";
            this.cb_autoAgreeGroup.UseVisualStyleBackColor = true;
            // 
            // cb_welcomeMsg
            // 
            this.cb_welcomeMsg.AutoSize = true;
            this.cb_welcomeMsg.Location = new System.Drawing.Point(10, 86);
            this.cb_welcomeMsg.Name = "cb_welcomeMsg";
            this.cb_welcomeMsg.Size = new System.Drawing.Size(96, 16);
            this.cb_welcomeMsg.TabIndex = 1;
            this.cb_welcomeMsg.Text = "入群欢迎消息";
            this.cb_welcomeMsg.UseVisualStyleBackColor = true;
            // 
            // gb_sensitiveWords
            // 
            this.gb_sensitiveWords.Controls.Add(this.lbl_newSensitiveWord);
            this.gb_sensitiveWords.Controls.Add(this.btn_delSensitiveWord);
            this.gb_sensitiveWords.Controls.Add(this.btn_addSensitiveWord);
            this.gb_sensitiveWords.Controls.Add(this.tb_newSensitiveWord);
            this.gb_sensitiveWords.Controls.Add(this.lb_sensitiveWords);
            this.gb_sensitiveWords.Location = new System.Drawing.Point(157, 12);
            this.gb_sensitiveWords.Name = "gb_sensitiveWords";
            this.gb_sensitiveWords.Size = new System.Drawing.Size(274, 437);
            this.gb_sensitiveWords.TabIndex = 1;
            this.gb_sensitiveWords.TabStop = false;
            this.gb_sensitiveWords.Text = "屏蔽词";
            // 
            // lbl_newSensitiveWord
            // 
            this.lbl_newSensitiveWord.AutoSize = true;
            this.lbl_newSensitiveWord.BackColor = System.Drawing.Color.Transparent;
            this.lbl_newSensitiveWord.Location = new System.Drawing.Point(159, 322);
            this.lbl_newSensitiveWord.Name = "lbl_newSensitiveWord";
            this.lbl_newSensitiveWord.Size = new System.Drawing.Size(53, 12);
            this.lbl_newSensitiveWord.TabIndex = 5;
            this.lbl_newSensitiveWord.Text = "新屏蔽词";
            // 
            // btn_delSensitiveWord
            // 
            this.btn_delSensitiveWord.Location = new System.Drawing.Point(159, 398);
            this.btn_delSensitiveWord.Name = "btn_delSensitiveWord";
            this.btn_delSensitiveWord.Size = new System.Drawing.Size(109, 23);
            this.btn_delSensitiveWord.TabIndex = 4;
            this.btn_delSensitiveWord.Text = "删除";
            this.btn_delSensitiveWord.UseVisualStyleBackColor = true;
            // 
            // btn_addSensitiveWord
            // 
            this.btn_addSensitiveWord.Location = new System.Drawing.Point(159, 369);
            this.btn_addSensitiveWord.Name = "btn_addSensitiveWord";
            this.btn_addSensitiveWord.Size = new System.Drawing.Size(109, 23);
            this.btn_addSensitiveWord.TabIndex = 3;
            this.btn_addSensitiveWord.Text = "添加";
            this.btn_addSensitiveWord.UseVisualStyleBackColor = true;
            // 
            // tb_newSensitiveWord
            // 
            this.tb_newSensitiveWord.Location = new System.Drawing.Point(159, 342);
            this.tb_newSensitiveWord.Name = "tb_newSensitiveWord";
            this.tb_newSensitiveWord.Size = new System.Drawing.Size(109, 21);
            this.tb_newSensitiveWord.TabIndex = 1;
            // 
            // lb_sensitiveWords
            // 
            this.lb_sensitiveWords.FormattingEnabled = true;
            this.lb_sensitiveWords.ItemHeight = 12;
            this.lb_sensitiveWords.Location = new System.Drawing.Point(6, 21);
            this.lb_sensitiveWords.Name = "lb_sensitiveWords";
            this.lb_sensitiveWords.Size = new System.Drawing.Size(147, 400);
            this.lb_sensitiveWords.TabIndex = 0;
            // 
            // gb_operation
            // 
            this.gb_operation.Controls.Add(this.btn_apply);
            this.gb_operation.Controls.Add(this.btn_save);
            this.gb_operation.Controls.Add(this.btn_cancel);
            this.gb_operation.Controls.Add(this.btn_reset);
            this.gb_operation.Location = new System.Drawing.Point(437, 405);
            this.gb_operation.Name = "gb_operation";
            this.gb_operation.Size = new System.Drawing.Size(335, 44);
            this.gb_operation.TabIndex = 2;
            this.gb_operation.TabStop = false;
            this.gb_operation.Text = "操作";
            // 
            // btn_apply
            // 
            this.btn_apply.Enabled = false;
            this.btn_apply.Location = new System.Drawing.Point(254, 16);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "应用";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(173, 16);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(90, 16);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(7, 16);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 0;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // gb_basic
            // 
            this.gb_basic.Controls.Add(this.tb_botQQ);
            this.gb_basic.Controls.Add(this.lbl_botQQ);
            this.gb_basic.Location = new System.Drawing.Point(437, 13);
            this.gb_basic.Name = "gb_basic";
            this.gb_basic.Size = new System.Drawing.Size(335, 57);
            this.gb_basic.TabIndex = 3;
            this.gb_basic.TabStop = false;
            this.gb_basic.Text = "基本设置";
            // 
            // tb_botQQ
            // 
            this.tb_botQQ.Location = new System.Drawing.Point(77, 20);
            this.tb_botQQ.Name = "tb_botQQ";
            this.tb_botQQ.ReadOnly = true;
            this.tb_botQQ.Size = new System.Drawing.Size(252, 21);
            this.tb_botQQ.TabIndex = 1;
            // 
            // lbl_botQQ
            // 
            this.lbl_botQQ.AutoSize = true;
            this.lbl_botQQ.Location = new System.Drawing.Point(6, 24);
            this.lbl_botQQ.Name = "lbl_botQQ";
            this.lbl_botQQ.Size = new System.Drawing.Size(65, 12);
            this.lbl_botQQ.TabIndex = 0;
            this.lbl_botQQ.Text = "机器人QQ号";
            // 
            // gb_msgSettings
            // 
            this.gb_msgSettings.Controls.Add(this.tb_groupWelcomeMsg);
            this.gb_msgSettings.Controls.Add(this.lbl_groupWelcomeMsg);
            this.gb_msgSettings.Controls.Add(this.tb_newFriendMsg);
            this.gb_msgSettings.Controls.Add(this.lbl_newFriendMsg);
            this.gb_msgSettings.Location = new System.Drawing.Point(437, 76);
            this.gb_msgSettings.Name = "gb_msgSettings";
            this.gb_msgSettings.Size = new System.Drawing.Size(335, 85);
            this.gb_msgSettings.TabIndex = 4;
            this.gb_msgSettings.TabStop = false;
            this.gb_msgSettings.Text = "消息设置";
            // 
            // tb_groupWelcomeMsg
            // 
            this.tb_groupWelcomeMsg.Location = new System.Drawing.Point(77, 49);
            this.tb_groupWelcomeMsg.Name = "tb_groupWelcomeMsg";
            this.tb_groupWelcomeMsg.Size = new System.Drawing.Size(252, 21);
            this.tb_groupWelcomeMsg.TabIndex = 3;
            // 
            // lbl_groupWelcomeMsg
            // 
            this.lbl_groupWelcomeMsg.AutoSize = true;
            this.lbl_groupWelcomeMsg.Location = new System.Drawing.Point(6, 53);
            this.lbl_groupWelcomeMsg.Name = "lbl_groupWelcomeMsg";
            this.lbl_groupWelcomeMsg.Size = new System.Drawing.Size(65, 12);
            this.lbl_groupWelcomeMsg.TabIndex = 2;
            this.lbl_groupWelcomeMsg.Text = "群欢迎消息";
            // 
            // tb_newFriendMsg
            // 
            this.tb_newFriendMsg.Location = new System.Drawing.Point(77, 22);
            this.tb_newFriendMsg.Name = "tb_newFriendMsg";
            this.tb_newFriendMsg.Size = new System.Drawing.Size(252, 21);
            this.tb_newFriendMsg.TabIndex = 1;
            // 
            // lbl_newFriendMsg
            // 
            this.lbl_newFriendMsg.AutoSize = true;
            this.lbl_newFriendMsg.Location = new System.Drawing.Point(6, 26);
            this.lbl_newFriendMsg.Name = "lbl_newFriendMsg";
            this.lbl_newFriendMsg.Size = new System.Drawing.Size(65, 12);
            this.lbl_newFriendMsg.TabIndex = 0;
            this.lbl_newFriendMsg.Text = "新好友消息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_webApiConfig);
            this.groupBox1.Controls.Add(this.btn_webApiTest);
            this.groupBox1.Controls.Add(this.rb_webApiConfig);
            this.groupBox1.Controls.Add(this.tb_webApiSecret);
            this.groupBox1.Controls.Add(this.lbl_webApiSecret);
            this.groupBox1.Controls.Add(this.tb_webApiKey);
            this.groupBox1.Controls.Add(this.lbl_webApiKey);
            this.groupBox1.Controls.Add(this.tb_webApi);
            this.groupBox1.Controls.Add(this.lbl_webApi);
            this.groupBox1.Controls.Add(this.cb_webApiEnable);
            this.groupBox1.Location = new System.Drawing.Point(437, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 228);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "后台对接";
            // 
            // lbl_webApiConfig
            // 
            this.lbl_webApiConfig.AutoSize = true;
            this.lbl_webApiConfig.Location = new System.Drawing.Point(6, 140);
            this.lbl_webApiConfig.Name = "lbl_webApiConfig";
            this.lbl_webApiConfig.Size = new System.Drawing.Size(53, 12);
            this.lbl_webApiConfig.TabIndex = 12;
            this.lbl_webApiConfig.Text = "配置信息";
            // 
            // btn_webApiTest
            // 
            this.btn_webApiTest.Location = new System.Drawing.Point(254, 129);
            this.btn_webApiTest.Name = "btn_webApiTest";
            this.btn_webApiTest.Size = new System.Drawing.Size(75, 23);
            this.btn_webApiTest.TabIndex = 11;
            this.btn_webApiTest.Text = "测试";
            this.btn_webApiTest.UseVisualStyleBackColor = true;
            // 
            // rb_webApiConfig
            // 
            this.rb_webApiConfig.Location = new System.Drawing.Point(7, 158);
            this.rb_webApiConfig.Name = "rb_webApiConfig";
            this.rb_webApiConfig.ReadOnly = true;
            this.rb_webApiConfig.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rb_webApiConfig.Size = new System.Drawing.Size(322, 64);
            this.rb_webApiConfig.TabIndex = 10;
            this.rb_webApiConfig.Text = "";
            // 
            // tb_webApiSecret
            // 
            this.tb_webApiSecret.Location = new System.Drawing.Point(77, 103);
            this.tb_webApiSecret.Name = "tb_webApiSecret";
            this.tb_webApiSecret.Size = new System.Drawing.Size(252, 21);
            this.tb_webApiSecret.TabIndex = 9;
            // 
            // lbl_webApiSecret
            // 
            this.lbl_webApiSecret.AutoSize = true;
            this.lbl_webApiSecret.Location = new System.Drawing.Point(6, 107);
            this.lbl_webApiSecret.Name = "lbl_webApiSecret";
            this.lbl_webApiSecret.Size = new System.Drawing.Size(59, 12);
            this.lbl_webApiSecret.TabIndex = 8;
            this.lbl_webApiSecret.Text = "ApiSecret";
            // 
            // tb_webApiKey
            // 
            this.tb_webApiKey.Location = new System.Drawing.Point(77, 76);
            this.tb_webApiKey.Name = "tb_webApiKey";
            this.tb_webApiKey.Size = new System.Drawing.Size(252, 21);
            this.tb_webApiKey.TabIndex = 7;
            // 
            // lbl_webApiKey
            // 
            this.lbl_webApiKey.AutoSize = true;
            this.lbl_webApiKey.Location = new System.Drawing.Point(6, 80);
            this.lbl_webApiKey.Name = "lbl_webApiKey";
            this.lbl_webApiKey.Size = new System.Drawing.Size(41, 12);
            this.lbl_webApiKey.TabIndex = 6;
            this.lbl_webApiKey.Text = "ApiKey";
            // 
            // tb_webApi
            // 
            this.tb_webApi.Location = new System.Drawing.Point(77, 49);
            this.tb_webApi.Name = "tb_webApi";
            this.tb_webApi.Size = new System.Drawing.Size(252, 21);
            this.tb_webApi.TabIndex = 5;
            // 
            // lbl_webApi
            // 
            this.lbl_webApi.AutoSize = true;
            this.lbl_webApi.Location = new System.Drawing.Point(6, 53);
            this.lbl_webApi.Name = "lbl_webApi";
            this.lbl_webApi.Size = new System.Drawing.Size(29, 12);
            this.lbl_webApi.TabIndex = 4;
            this.lbl_webApi.Text = "Api ";
            // 
            // cb_webApiEnable
            // 
            this.cb_webApiEnable.AutoSize = true;
            this.cb_webApiEnable.Location = new System.Drawing.Point(7, 26);
            this.cb_webApiEnable.Name = "cb_webApiEnable";
            this.cb_webApiEnable.Size = new System.Drawing.Size(168, 16);
            this.cb_webApiEnable.TabIndex = 0;
            this.cb_webApiEnable.Text = "启用需要WebApi的高级服务";
            this.cb_webApiEnable.UseVisualStyleBackColor = true;
            this.cb_webApiEnable.CheckedChanged += new System.EventHandler(this.cb_webApiEnable_CheckedChanged);
            // 
            // ConsoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_msgSettings);
            this.Controls.Add(this.gb_basic);
            this.Controls.Add(this.gb_operation);
            this.Controls.Add(this.gb_sensitiveWords);
            this.Controls.Add(this.gb_switches);
            this.MaximizeBox = false;
            this.Name = "ConsoleWindow";
            this.Text = "空格二号机 - 控制台";
            this.gb_switches.ResumeLayout(false);
            this.gb_switches.PerformLayout();
            this.gb_sensitiveWords.ResumeLayout(false);
            this.gb_sensitiveWords.PerformLayout();
            this.gb_operation.ResumeLayout(false);
            this.gb_basic.ResumeLayout(false);
            this.gb_basic.PerformLayout();
            this.gb_msgSettings.ResumeLayout(false);
            this.gb_msgSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_switches;
        private System.Windows.Forms.CheckBox cb_autoRepeat;
        private System.Windows.Forms.CheckBox cb_autoAgreeGroup;
        private System.Windows.Forms.CheckBox cb_welcomeMsg;
        private System.Windows.Forms.Label lbl_groupSwitches;
        private System.Windows.Forms.GroupBox gb_sensitiveWords;
        private System.Windows.Forms.TextBox tb_newSensitiveWord;
        private System.Windows.Forms.ListBox lb_sensitiveWords;
        private System.Windows.Forms.Button btn_delSensitiveWord;
        private System.Windows.Forms.Button btn_addSensitiveWord;
        private System.Windows.Forms.GroupBox gb_operation;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_newSensitiveWord;
        private System.Windows.Forms.GroupBox gb_basic;
        private System.Windows.Forms.TextBox tb_botQQ;
        private System.Windows.Forms.Label lbl_botQQ;
        private System.Windows.Forms.GroupBox gb_msgSettings;
        private System.Windows.Forms.TextBox tb_groupWelcomeMsg;
        private System.Windows.Forms.Label lbl_groupWelcomeMsg;
        private System.Windows.Forms.TextBox tb_newFriendMsg;
        private System.Windows.Forms.Label lbl_newFriendMsg;
        private System.Windows.Forms.CheckBox cb_autoAgreePersonal;
        private System.Windows.Forms.Label lbl_personalSwitches;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_webApiSecret;
        private System.Windows.Forms.Label lbl_webApiSecret;
        private System.Windows.Forms.TextBox tb_webApiKey;
        private System.Windows.Forms.Label lbl_webApiKey;
        private System.Windows.Forms.TextBox tb_webApi;
        private System.Windows.Forms.Label lbl_webApi;
        private System.Windows.Forms.CheckBox cb_webApiEnable;
        private System.Windows.Forms.Label lbl_webApiConfig;
        private System.Windows.Forms.Button btn_webApiTest;
        private System.Windows.Forms.RichTextBox rb_webApiConfig;
    }
}

