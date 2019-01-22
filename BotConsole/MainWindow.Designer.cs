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
            this.cb_ownerNotification = new System.Windows.Forms.CheckBox();
            this.lbl_otherSwitches = new System.Windows.Forms.Label();
            this.cb_enableBotinGroup = new System.Windows.Forms.CheckBox();
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
            this.tb_ownerQQ = new System.Windows.Forms.TextBox();
            this.lbl_botQQ = new System.Windows.Forms.Label();
            this.gb_msgSettings = new System.Windows.Forms.GroupBox();
            this.tb_groupWelcomeMsg = new System.Windows.Forms.TextBox();
            this.lbl_groupWelcomeMsg = new System.Windows.Forms.Label();
            this.tb_newFriendMsg = new System.Windows.Forms.TextBox();
            this.lbl_newFriendMsg = new System.Windows.Forms.Label();
            this.gb_WebApi = new System.Windows.Forms.GroupBox();
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
            this.gb_limitGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_groupWhiteList = new System.Windows.Forms.ListBox();
            this.btn_removeGroupWhiteList = new System.Windows.Forms.Button();
            this.tb_enableGroupNumber = new System.Windows.Forms.TextBox();
            this.btn_addGroupWhiteList = new System.Windows.Forms.Button();
            this.cb_seriousWordCheck = new System.Windows.Forms.CheckBox();
            this.lbl_swBanTime = new System.Windows.Forms.Label();
            this.tb_sensitiveWordBanTime = new System.Windows.Forms.TextBox();
            this.gb_switches.SuspendLayout();
            this.gb_sensitiveWords.SuspendLayout();
            this.gb_operation.SuspendLayout();
            this.gb_basic.SuspendLayout();
            this.gb_msgSettings.SuspendLayout();
            this.gb_WebApi.SuspendLayout();
            this.gb_limitGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_switches
            // 
            this.gb_switches.Controls.Add(this.cb_seriousWordCheck);
            this.gb_switches.Controls.Add(this.cb_ownerNotification);
            this.gb_switches.Controls.Add(this.lbl_otherSwitches);
            this.gb_switches.Controls.Add(this.cb_enableBotinGroup);
            this.gb_switches.Controls.Add(this.cb_autoAgreePersonal);
            this.gb_switches.Controls.Add(this.lbl_personalSwitches);
            this.gb_switches.Controls.Add(this.lbl_groupSwitches);
            this.gb_switches.Controls.Add(this.cb_autoRepeat);
            this.gb_switches.Controls.Add(this.cb_autoAgreeGroup);
            this.gb_switches.Controls.Add(this.cb_welcomeMsg);
            this.gb_switches.Location = new System.Drawing.Point(12, 12);
            this.gb_switches.Name = "gb_switches";
            this.gb_switches.Size = new System.Drawing.Size(158, 437);
            this.gb_switches.TabIndex = 0;
            this.gb_switches.TabStop = false;
            this.gb_switches.Text = "开关";
            // 
            // cb_ownerNotification
            // 
            this.cb_ownerNotification.AutoSize = true;
            this.cb_ownerNotification.Location = new System.Drawing.Point(10, 231);
            this.cb_ownerNotification.Name = "cb_ownerNotification";
            this.cb_ownerNotification.Size = new System.Drawing.Size(96, 16);
            this.cb_ownerNotification.TabIndex = 8;
            this.cb_ownerNotification.Text = "启用主人通知";
            this.cb_ownerNotification.UseVisualStyleBackColor = true;
            this.cb_ownerNotification.CheckedChanged += new System.EventHandler(this.cb_ownerNotification_CheckedChanged);
            // 
            // lbl_otherSwitches
            // 
            this.lbl_otherSwitches.AutoSize = true;
            this.lbl_otherSwitches.BackColor = System.Drawing.Color.Transparent;
            this.lbl_otherSwitches.Location = new System.Drawing.Point(8, 208);
            this.lbl_otherSwitches.Name = "lbl_otherSwitches";
            this.lbl_otherSwitches.Size = new System.Drawing.Size(29, 12);
            this.lbl_otherSwitches.TabIndex = 7;
            this.lbl_otherSwitches.Text = "其他";
            // 
            // cb_enableBotinGroup
            // 
            this.cb_enableBotinGroup.AutoSize = true;
            this.cb_enableBotinGroup.Location = new System.Drawing.Point(10, 108);
            this.cb_enableBotinGroup.Name = "cb_enableBotinGroup";
            this.cb_enableBotinGroup.Size = new System.Drawing.Size(132, 16);
            this.cb_enableBotinGroup.TabIndex = 6;
            this.cb_enableBotinGroup.Text = "启用部分功能白名单";
            this.cb_enableBotinGroup.UseVisualStyleBackColor = true;
            this.cb_enableBotinGroup.CheckedChanged += new System.EventHandler(this.cb_enableBotinGroup_CheckedChanged);
            // 
            // cb_autoAgreePersonal
            // 
            this.cb_autoAgreePersonal.AutoSize = true;
            this.cb_autoAgreePersonal.Location = new System.Drawing.Point(10, 180);
            this.cb_autoAgreePersonal.Name = "cb_autoAgreePersonal";
            this.cb_autoAgreePersonal.Size = new System.Drawing.Size(108, 16);
            this.cb_autoAgreePersonal.TabIndex = 5;
            this.cb_autoAgreePersonal.Text = "自动同意加好友";
            this.cb_autoAgreePersonal.UseVisualStyleBackColor = true;
            this.cb_autoAgreePersonal.CheckedChanged += new System.EventHandler(this.cb_autoAgreePersonal_CheckedChanged);
            // 
            // lbl_personalSwitches
            // 
            this.lbl_personalSwitches.AutoSize = true;
            this.lbl_personalSwitches.BackColor = System.Drawing.Color.Transparent;
            this.lbl_personalSwitches.Location = new System.Drawing.Point(8, 158);
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
            this.cb_autoRepeat.CheckedChanged += new System.EventHandler(this.cb_autoRepeat_CheckedChanged);
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
            this.cb_autoAgreeGroup.CheckedChanged += new System.EventHandler(this.cb_autoAgreeGroup_CheckedChanged);
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
            this.cb_welcomeMsg.CheckedChanged += new System.EventHandler(this.cb_welcomeMsg_CheckedChanged);
            // 
            // gb_sensitiveWords
            // 
            this.gb_sensitiveWords.Controls.Add(this.tb_sensitiveWordBanTime);
            this.gb_sensitiveWords.Controls.Add(this.lbl_swBanTime);
            this.gb_sensitiveWords.Controls.Add(this.lbl_newSensitiveWord);
            this.gb_sensitiveWords.Controls.Add(this.btn_delSensitiveWord);
            this.gb_sensitiveWords.Controls.Add(this.btn_addSensitiveWord);
            this.gb_sensitiveWords.Controls.Add(this.tb_newSensitiveWord);
            this.gb_sensitiveWords.Controls.Add(this.lb_sensitiveWords);
            this.gb_sensitiveWords.Location = new System.Drawing.Point(176, 12);
            this.gb_sensitiveWords.Name = "gb_sensitiveWords";
            this.gb_sensitiveWords.Size = new System.Drawing.Size(262, 215);
            this.gb_sensitiveWords.TabIndex = 1;
            this.gb_sensitiveWords.TabStop = false;
            this.gb_sensitiveWords.Text = "屏蔽词";
            // 
            // lbl_newSensitiveWord
            // 
            this.lbl_newSensitiveWord.AutoSize = true;
            this.lbl_newSensitiveWord.BackColor = System.Drawing.Color.Transparent;
            this.lbl_newSensitiveWord.Location = new System.Drawing.Point(146, 106);
            this.lbl_newSensitiveWord.Name = "lbl_newSensitiveWord";
            this.lbl_newSensitiveWord.Size = new System.Drawing.Size(53, 12);
            this.lbl_newSensitiveWord.TabIndex = 5;
            this.lbl_newSensitiveWord.Text = "新屏蔽词";
            // 
            // btn_delSensitiveWord
            // 
            this.btn_delSensitiveWord.Enabled = false;
            this.btn_delSensitiveWord.Location = new System.Drawing.Point(146, 182);
            this.btn_delSensitiveWord.Name = "btn_delSensitiveWord";
            this.btn_delSensitiveWord.Size = new System.Drawing.Size(109, 23);
            this.btn_delSensitiveWord.TabIndex = 4;
            this.btn_delSensitiveWord.Text = "移除选中";
            this.btn_delSensitiveWord.UseVisualStyleBackColor = true;
            this.btn_delSensitiveWord.Click += new System.EventHandler(this.btn_delSensitiveWord_Click);
            // 
            // btn_addSensitiveWord
            // 
            this.btn_addSensitiveWord.Location = new System.Drawing.Point(146, 153);
            this.btn_addSensitiveWord.Name = "btn_addSensitiveWord";
            this.btn_addSensitiveWord.Size = new System.Drawing.Size(109, 23);
            this.btn_addSensitiveWord.TabIndex = 3;
            this.btn_addSensitiveWord.Text = "添加";
            this.btn_addSensitiveWord.UseVisualStyleBackColor = true;
            this.btn_addSensitiveWord.Click += new System.EventHandler(this.btn_addSensitiveWord_Click);
            // 
            // tb_newSensitiveWord
            // 
            this.tb_newSensitiveWord.Location = new System.Drawing.Point(146, 126);
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
            this.lb_sensitiveWords.Size = new System.Drawing.Size(134, 184);
            this.lb_sensitiveWords.TabIndex = 0;
            this.lb_sensitiveWords.SelectedIndexChanged += new System.EventHandler(this.lb_sensitiveWords_SelectedIndexChanged);
            // 
            // gb_operation
            // 
            this.gb_operation.Controls.Add(this.btn_apply);
            this.gb_operation.Controls.Add(this.btn_save);
            this.gb_operation.Controls.Add(this.btn_cancel);
            this.gb_operation.Controls.Add(this.btn_reset);
            this.gb_operation.Location = new System.Drawing.Point(444, 405);
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
            this.btn_save.Enabled = false;
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
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.gb_basic.Controls.Add(this.tb_ownerQQ);
            this.gb_basic.Controls.Add(this.lbl_botQQ);
            this.gb_basic.Location = new System.Drawing.Point(444, 13);
            this.gb_basic.Name = "gb_basic";
            this.gb_basic.Size = new System.Drawing.Size(335, 57);
            this.gb_basic.TabIndex = 3;
            this.gb_basic.TabStop = false;
            this.gb_basic.Text = "基本设置";
            // 
            // tb_ownerQQ
            // 
            this.tb_ownerQQ.Location = new System.Drawing.Point(77, 20);
            this.tb_ownerQQ.Name = "tb_ownerQQ";
            this.tb_ownerQQ.Size = new System.Drawing.Size(252, 21);
            this.tb_ownerQQ.TabIndex = 1;
            this.tb_ownerQQ.TextChanged += new System.EventHandler(this.tb_ownerQQ_TextChanged);
            this.tb_ownerQQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ownerQQ_KeyPress);
            // 
            // lbl_botQQ
            // 
            this.lbl_botQQ.AutoSize = true;
            this.lbl_botQQ.Location = new System.Drawing.Point(6, 24);
            this.lbl_botQQ.Name = "lbl_botQQ";
            this.lbl_botQQ.Size = new System.Drawing.Size(53, 12);
            this.lbl_botQQ.TabIndex = 0;
            this.lbl_botQQ.Text = "主人QQ号";
            // 
            // gb_msgSettings
            // 
            this.gb_msgSettings.Controls.Add(this.tb_groupWelcomeMsg);
            this.gb_msgSettings.Controls.Add(this.lbl_groupWelcomeMsg);
            this.gb_msgSettings.Controls.Add(this.tb_newFriendMsg);
            this.gb_msgSettings.Controls.Add(this.lbl_newFriendMsg);
            this.gb_msgSettings.Location = new System.Drawing.Point(444, 76);
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
            this.tb_groupWelcomeMsg.TextChanged += new System.EventHandler(this.tb_groupWelcomeMsg_TextChanged);
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
            this.tb_newFriendMsg.TextChanged += new System.EventHandler(this.tb_newFriendMsg_TextChanged);
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
            // gb_WebApi
            // 
            this.gb_WebApi.Controls.Add(this.lbl_webApiConfig);
            this.gb_WebApi.Controls.Add(this.btn_webApiTest);
            this.gb_WebApi.Controls.Add(this.rb_webApiConfig);
            this.gb_WebApi.Controls.Add(this.tb_webApiSecret);
            this.gb_WebApi.Controls.Add(this.lbl_webApiSecret);
            this.gb_WebApi.Controls.Add(this.tb_webApiKey);
            this.gb_WebApi.Controls.Add(this.lbl_webApiKey);
            this.gb_WebApi.Controls.Add(this.tb_webApi);
            this.gb_WebApi.Controls.Add(this.lbl_webApi);
            this.gb_WebApi.Location = new System.Drawing.Point(444, 194);
            this.gb_WebApi.Name = "gb_WebApi";
            this.gb_WebApi.Size = new System.Drawing.Size(335, 205);
            this.gb_WebApi.TabIndex = 5;
            this.gb_WebApi.TabStop = false;
            this.gb_WebApi.Text = "后台对接";
            // 
            // lbl_webApiConfig
            // 
            this.lbl_webApiConfig.AutoSize = true;
            this.lbl_webApiConfig.Location = new System.Drawing.Point(7, 108);
            this.lbl_webApiConfig.Name = "lbl_webApiConfig";
            this.lbl_webApiConfig.Size = new System.Drawing.Size(53, 12);
            this.lbl_webApiConfig.TabIndex = 12;
            this.lbl_webApiConfig.Text = "配置信息";
            // 
            // btn_webApiTest
            // 
            this.btn_webApiTest.Location = new System.Drawing.Point(255, 101);
            this.btn_webApiTest.Name = "btn_webApiTest";
            this.btn_webApiTest.Size = new System.Drawing.Size(75, 23);
            this.btn_webApiTest.TabIndex = 11;
            this.btn_webApiTest.Text = "测试";
            this.btn_webApiTest.UseVisualStyleBackColor = true;
            // 
            // rb_webApiConfig
            // 
            this.rb_webApiConfig.Location = new System.Drawing.Point(8, 130);
            this.rb_webApiConfig.Name = "rb_webApiConfig";
            this.rb_webApiConfig.ReadOnly = true;
            this.rb_webApiConfig.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rb_webApiConfig.Size = new System.Drawing.Size(322, 64);
            this.rb_webApiConfig.TabIndex = 10;
            this.rb_webApiConfig.Text = "";
            // 
            // tb_webApiSecret
            // 
            this.tb_webApiSecret.Location = new System.Drawing.Point(78, 75);
            this.tb_webApiSecret.Name = "tb_webApiSecret";
            this.tb_webApiSecret.Size = new System.Drawing.Size(252, 21);
            this.tb_webApiSecret.TabIndex = 9;
            // 
            // lbl_webApiSecret
            // 
            this.lbl_webApiSecret.AutoSize = true;
            this.lbl_webApiSecret.Location = new System.Drawing.Point(7, 79);
            this.lbl_webApiSecret.Name = "lbl_webApiSecret";
            this.lbl_webApiSecret.Size = new System.Drawing.Size(59, 12);
            this.lbl_webApiSecret.TabIndex = 8;
            this.lbl_webApiSecret.Text = "ApiSecret";
            // 
            // tb_webApiKey
            // 
            this.tb_webApiKey.Location = new System.Drawing.Point(78, 48);
            this.tb_webApiKey.Name = "tb_webApiKey";
            this.tb_webApiKey.Size = new System.Drawing.Size(252, 21);
            this.tb_webApiKey.TabIndex = 7;
            // 
            // lbl_webApiKey
            // 
            this.lbl_webApiKey.AutoSize = true;
            this.lbl_webApiKey.Location = new System.Drawing.Point(7, 52);
            this.lbl_webApiKey.Name = "lbl_webApiKey";
            this.lbl_webApiKey.Size = new System.Drawing.Size(41, 12);
            this.lbl_webApiKey.TabIndex = 6;
            this.lbl_webApiKey.Text = "ApiKey";
            // 
            // tb_webApi
            // 
            this.tb_webApi.Location = new System.Drawing.Point(78, 21);
            this.tb_webApi.Name = "tb_webApi";
            this.tb_webApi.Size = new System.Drawing.Size(252, 21);
            this.tb_webApi.TabIndex = 5;
            // 
            // lbl_webApi
            // 
            this.lbl_webApi.AutoSize = true;
            this.lbl_webApi.Location = new System.Drawing.Point(7, 25);
            this.lbl_webApi.Name = "lbl_webApi";
            this.lbl_webApi.Size = new System.Drawing.Size(29, 12);
            this.lbl_webApi.TabIndex = 4;
            this.lbl_webApi.Text = "Api ";
            // 
            // cb_webApiEnable
            // 
            this.cb_webApiEnable.AutoSize = true;
            this.cb_webApiEnable.Location = new System.Drawing.Point(445, 168);
            this.cb_webApiEnable.Name = "cb_webApiEnable";
            this.cb_webApiEnable.Size = new System.Drawing.Size(168, 16);
            this.cb_webApiEnable.TabIndex = 0;
            this.cb_webApiEnable.Text = "启用需要WebApi的高级服务";
            this.cb_webApiEnable.UseVisualStyleBackColor = true;
            this.cb_webApiEnable.CheckedChanged += new System.EventHandler(this.cb_webApiEnable_CheckedChanged);
            // 
            // gb_limitGroup
            // 
            this.gb_limitGroup.Controls.Add(this.label1);
            this.gb_limitGroup.Controls.Add(this.lb_groupWhiteList);
            this.gb_limitGroup.Controls.Add(this.btn_removeGroupWhiteList);
            this.gb_limitGroup.Controls.Add(this.tb_enableGroupNumber);
            this.gb_limitGroup.Controls.Add(this.btn_addGroupWhiteList);
            this.gb_limitGroup.Location = new System.Drawing.Point(176, 233);
            this.gb_limitGroup.Name = "gb_limitGroup";
            this.gb_limitGroup.Size = new System.Drawing.Size(262, 216);
            this.gb_limitGroup.TabIndex = 6;
            this.gb_limitGroup.TabStop = false;
            this.gb_limitGroup.Text = "群管部分功能白名单";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(146, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "群号";
            // 
            // lb_groupWhiteList
            // 
            this.lb_groupWhiteList.FormattingEnabled = true;
            this.lb_groupWhiteList.ItemHeight = 12;
            this.lb_groupWhiteList.Location = new System.Drawing.Point(6, 20);
            this.lb_groupWhiteList.Name = "lb_groupWhiteList";
            this.lb_groupWhiteList.Size = new System.Drawing.Size(134, 184);
            this.lb_groupWhiteList.TabIndex = 6;
            this.lb_groupWhiteList.SelectedIndexChanged += new System.EventHandler(this.lb_groupWhiteList_SelectedIndexChanged);
            // 
            // btn_removeGroupWhiteList
            // 
            this.btn_removeGroupWhiteList.Enabled = false;
            this.btn_removeGroupWhiteList.Location = new System.Drawing.Point(146, 181);
            this.btn_removeGroupWhiteList.Name = "btn_removeGroupWhiteList";
            this.btn_removeGroupWhiteList.Size = new System.Drawing.Size(109, 23);
            this.btn_removeGroupWhiteList.TabIndex = 8;
            this.btn_removeGroupWhiteList.Text = "移除选中";
            this.btn_removeGroupWhiteList.UseVisualStyleBackColor = true;
            this.btn_removeGroupWhiteList.Click += new System.EventHandler(this.btn_removeGroupWhiteList_Click);
            // 
            // tb_enableGroupNumber
            // 
            this.tb_enableGroupNumber.Location = new System.Drawing.Point(146, 125);
            this.tb_enableGroupNumber.Name = "tb_enableGroupNumber";
            this.tb_enableGroupNumber.Size = new System.Drawing.Size(109, 21);
            this.tb_enableGroupNumber.TabIndex = 6;
            this.tb_enableGroupNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_enableGroupNumber_KeyPress);
            // 
            // btn_addGroupWhiteList
            // 
            this.btn_addGroupWhiteList.Location = new System.Drawing.Point(146, 152);
            this.btn_addGroupWhiteList.Name = "btn_addGroupWhiteList";
            this.btn_addGroupWhiteList.Size = new System.Drawing.Size(109, 23);
            this.btn_addGroupWhiteList.TabIndex = 7;
            this.btn_addGroupWhiteList.Text = "添加";
            this.btn_addGroupWhiteList.UseVisualStyleBackColor = true;
            this.btn_addGroupWhiteList.Click += new System.EventHandler(this.btn_addGroupWhiteList_Click);
            // 
            // cb_seriousWordCheck
            // 
            this.cb_seriousWordCheck.AutoSize = true;
            this.cb_seriousWordCheck.Location = new System.Drawing.Point(10, 130);
            this.cb_seriousWordCheck.Name = "cb_seriousWordCheck";
            this.cb_seriousWordCheck.Size = new System.Drawing.Size(132, 16);
            this.cb_seriousWordCheck.TabIndex = 9;
            this.cb_seriousWordCheck.Text = "启用严格敏感词检查";
            this.cb_seriousWordCheck.UseVisualStyleBackColor = true;
            // 
            // lbl_swBanTime
            // 
            this.lbl_swBanTime.AutoSize = true;
            this.lbl_swBanTime.Location = new System.Drawing.Point(146, 21);
            this.lbl_swBanTime.Name = "lbl_swBanTime";
            this.lbl_swBanTime.Size = new System.Drawing.Size(53, 12);
            this.lbl_swBanTime.TabIndex = 6;
            this.lbl_swBanTime.Text = "封禁时长";
            // 
            // tb_sensitiveWordBanTime
            // 
            this.tb_sensitiveWordBanTime.Location = new System.Drawing.Point(146, 37);
            this.tb_sensitiveWordBanTime.Name = "tb_sensitiveWordBanTime";
            this.tb_sensitiveWordBanTime.Size = new System.Drawing.Size(109, 21);
            this.tb_sensitiveWordBanTime.TabIndex = 7;
            this.tb_sensitiveWordBanTime.TextChanged += new System.EventHandler(this.tb_sensitiveWordBanTime_TextChanged);
            this.tb_sensitiveWordBanTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sensitiveWordBanTime_KeyPress);
            // 
            // ConsoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(792, 461);
            this.Controls.Add(this.gb_limitGroup);
            this.Controls.Add(this.gb_WebApi);
            this.Controls.Add(this.gb_msgSettings);
            this.Controls.Add(this.gb_basic);
            this.Controls.Add(this.gb_operation);
            this.Controls.Add(this.gb_sensitiveWords);
            this.Controls.Add(this.gb_switches);
            this.Controls.Add(this.cb_webApiEnable);
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
            this.gb_WebApi.ResumeLayout(false);
            this.gb_WebApi.PerformLayout();
            this.gb_limitGroup.ResumeLayout(false);
            this.gb_limitGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox tb_ownerQQ;
        private System.Windows.Forms.Label lbl_botQQ;
        private System.Windows.Forms.GroupBox gb_msgSettings;
        private System.Windows.Forms.TextBox tb_groupWelcomeMsg;
        private System.Windows.Forms.Label lbl_groupWelcomeMsg;
        private System.Windows.Forms.TextBox tb_newFriendMsg;
        private System.Windows.Forms.Label lbl_newFriendMsg;
        private System.Windows.Forms.CheckBox cb_autoAgreePersonal;
        private System.Windows.Forms.Label lbl_personalSwitches;
        private System.Windows.Forms.GroupBox gb_WebApi;
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
        private System.Windows.Forms.CheckBox cb_enableBotinGroup;
        private System.Windows.Forms.GroupBox gb_limitGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_groupWhiteList;
        private System.Windows.Forms.Button btn_removeGroupWhiteList;
        private System.Windows.Forms.TextBox tb_enableGroupNumber;
        private System.Windows.Forms.Button btn_addGroupWhiteList;
        private System.Windows.Forms.CheckBox cb_ownerNotification;
        private System.Windows.Forms.Label lbl_otherSwitches;
        private System.Windows.Forms.CheckBox cb_seriousWordCheck;
        private System.Windows.Forms.TextBox tb_sensitiveWordBanTime;
        private System.Windows.Forms.Label lbl_swBanTime;
    }
}

