using BackRunner.QQBot.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BackRunner.QQBot.BotConsole;
using System.Windows.Forms;
using BackRunner.QQBot.Utils;
using Native.Csharp.App;

namespace BackRunner.QQBot.Controller
{
    public static class SettingsController
    {
        public static Settings settings = null;

        #region == 窗体控件声明 ==
        private static CheckBox cb_autoAgreeGroup;
        private static CheckBox cb_autoRepeat;
        private static CheckBox cb_welcomeMsg;
        private static CheckBox cb_autoAgreePersonal;
        private static CheckBox cb_enableBotinGroup;
        private static ListBox lb_sensitiveWords;
        private static ListBox lb_groupWhiteList;
        private static GroupBox gb_limitGroup;
        private static TextBox tb_ownerQQ;
        private static TextBox tb_groupWelcomeMsg;
        private static TextBox tb_newFriendMsg;
        private static GroupBox gb_WebApi;
        private static CheckBox cb_webApiEnable;
        private static TextBox tb_webApi;
        private static TextBox tb_webApiKey;
        private static TextBox tb_webApiSecret;
        private static Button btn_save;
        private static Button btn_apply;
        private static Button btn_reset;
        #endregion

        public static bool CheckSettingsFile()
        {
            return File.Exists(Common.SettingFile);
        }

        #region == 初始化 ==
        public static void Init()
        {
            if (CheckSettingsFile())
            {
                string json = File.ReadAllText(Common.SettingFile);
                settings = JsonConvert.DeserializeObject<Settings>(json);
            } else
            {
                settings = new Settings();
            }
        }

        public static void InitUI(Control window)
        {
            //定位控件
            #region == 开关 ==
            cb_autoAgreeGroup = (CheckBox)WinformHelper.FindControl(window, "cb_autoAgreeGroup");
            cb_autoRepeat = (CheckBox)WinformHelper.FindControl(window, "cb_autoRepeat");
            cb_welcomeMsg = (CheckBox)WinformHelper.FindControl(window, "cb_welcomeMsg");            
            cb_autoAgreePersonal = (CheckBox)WinformHelper.FindControl(window, "cb_autoAgreePersonal");
            cb_enableBotinGroup = (CheckBox)WinformHelper.FindControl(window, "cb_enableBotinGroup");
            #endregion

            #region == 敏感词 ==
            lb_sensitiveWords = (ListBox)WinformHelper.FindControl(window, "lb_sensitiveWords");
            lb_groupWhiteList = (ListBox)WinformHelper.FindControl(window, "lb_groupWhiteList");
            #endregion

            #region == 群白名单 ==
            gb_limitGroup = (GroupBox)WinformHelper.FindControl(window, "gb_limitGroup");
            #endregion

            #region == 基本信息 ==
            tb_ownerQQ = (TextBox)WinformHelper.FindControl(window, "tb_ownerQQ");
            #endregion

            #region == 消息 ==
            tb_groupWelcomeMsg = (TextBox)WinformHelper.FindControl(window, "tb_groupWelcomeMsg");
            tb_newFriendMsg = (TextBox)WinformHelper.FindControl(window, "tb_newFriendMsg");
            #endregion

            #region == WebApi ==
            gb_WebApi = (GroupBox)WinformHelper.FindControl(window, "gb_WebApi");
            cb_webApiEnable = (CheckBox)WinformHelper.FindControl(window, "cb_webApiEnable");
            tb_webApi = (TextBox)WinformHelper.FindControl(window, "tb_webApi");
            tb_webApiKey = (TextBox)WinformHelper.FindControl(window, "tb_webApiKey");
            tb_webApiSecret = (TextBox)WinformHelper.FindControl(window, "tb_webApiSecret");
            #endregion

            #region == 操作按钮 ==
            btn_save = (Button)WinformHelper.FindControl(window, "btn_save");
            btn_apply = (Button)WinformHelper.FindControl(window, "btn_apply");
            btn_reset = (Button)WinformHelper.FindControl(window, "btn_reset");
            #endregion

            //初始化
            #region == 基本信息 ==
            tb_ownerQQ.Text = settings.OwnerQQ.ToString();
            #endregion

            #region == 开关 ==
            cb_autoAgreeGroup.Checked = settings.AutoAgreeGroup;
            cb_autoRepeat.Checked = settings.AutoRepeat;
            cb_welcomeMsg.Checked = settings.GroupWelcomeMessageEnabled;
            cb_autoAgreePersonal.Checked = settings.AutoAgreeNewFriend;
            cb_enableBotinGroup.Checked = settings.GroupWhiteListEnabled;
            #endregion

            #region == 敏感词 ==
            foreach (string word in settings.SensitiveWords)
            {
                lb_sensitiveWords.Items.Add(word);
            }
            #endregion

            #region == 群白名单 ==
            gb_limitGroup.Enabled = settings.GroupWhiteListEnabled;
            #endregion

            #region == 消息 ==
            tb_groupWelcomeMsg.Text = settings.GroupWelcomeMessage;
            tb_newFriendMsg.Text = settings.NewFriendMessage;
            #endregion

            #region == WebApi ==
            cb_webApiEnable.Checked = settings.WebApiEnabled;
            gb_WebApi.Enabled = settings.WebApiEnabled;
            tb_webApi.Text = settings.WebApiUrl;
            tb_webApiKey.Text = settings.WebApiKey;
            tb_webApiSecret.Text = settings.WebApiSecret;

            if (settings.WebApiEnabled)
            {
                tb_webApi.Enabled = false;
                tb_webApiKey.Enabled = false;
                tb_webApiSecret.Enabled = false;
            }
            #endregion

            //按钮事件绑定
            btn_apply.Click += Btn_apply_Click;
            btn_save.Click += Btn_save_Click;
        }

        private static void Btn_apply_Click(object sender, EventArgs e)
        {
            ApplySettings();
            btn_apply.Enabled = false;
        }

        private static void Btn_save_Click(object sender, EventArgs e)
        {
            SaveSettings();
            btn_save.Enabled = false;
            btn_apply.Enabled = false;
        }
        #endregion

        #region == 设置的保存 ==
        public static void ApplySettings()
        {
            #region == 开关 ==
            settings.AutoAgreeGroup = GetBoolFromCheckBox(cb_autoAgreeGroup, settings.AutoAgreeGroup);
            settings.AutoAgreeNewFriend = GetBoolFromCheckBox(cb_autoAgreePersonal, settings.AutoAgreeNewFriend);
            settings.AutoRepeat = GetBoolFromCheckBox(cb_autoRepeat, settings.AutoRepeat);
            settings.GroupWhiteListEnabled = GetBoolFromCheckBox(cb_enableBotinGroup, settings.GroupWhiteListEnabled);
            settings.GroupWelcomeMessageEnabled = GetBoolFromCheckBox(cb_welcomeMsg, settings.GroupWelcomeMessageEnabled);
            #endregion

            #region == 敏感词 ==
            settings.SensitiveWords = lb_sensitiveWords.Items.Cast<string>().ToList();
            #endregion

            #region == 群白名单 ==
            settings.GroupWhiteList = lb_groupWhiteList.Items.Cast<long>().ToList();
            #endregion

            #region == 基本信息 ==
            long ownerQQ = -1;
            long.TryParse(tb_ownerQQ.Text.ToString(), out ownerQQ);
            settings.OwnerQQ = ownerQQ;
            #endregion

            #region == 消息 ==
            settings.NewFriendMessage = GetStringFromTextBox(tb_newFriendMsg);
            settings.GroupWelcomeMessage = GetStringFromTextBox(tb_groupWelcomeMsg);
            #endregion

            #region == WebApi ==
            settings.WebApiEnabled = GetBoolFromCheckBox(cb_webApiEnable, settings.WebApiEnabled);
            settings.WebApiUrl = GetStringFromTextBox(tb_webApi);
            settings.WebApiKey = GetStringFromTextBox(tb_webApiKey);
            settings.WebApiSecret = GetStringFromTextBox(tb_webApiSecret);
            #endregion
        }        
        public static void SaveSettings()
        {
            ApplySettings();
            try
            {
                string json = JsonConvert.SerializeObject(settings);
                File.WriteAllText(Common.SettingFile, json);
            } catch (Exception e)
            {
                MessageBox.Show("保存设置出现错误:\n" + e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region == 控件获取值方法 ==
        private static bool GetBoolFromCheckBox(CheckBox cb, bool originValue)
        {
            if (cb == null)
            {
                return originValue;
            } else
            {
                return cb.Checked;
            }
        }

        private static string GetStringFromTextBox(TextBox tb)
        {
            if (tb == null)
            {
                return string.Empty;
            } else
            {
                return tb.Text;
            }
        }
        #endregion
    }
}
