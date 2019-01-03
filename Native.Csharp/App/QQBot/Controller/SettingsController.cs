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

        public static bool CheckFile()
        {
            return File.Exists(Common.SettingFile);
        }

        public static void Init()
        {
            if (CheckFile())
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
            CheckBox cb_autoAgreeGroup = (CheckBox)WinformHelper.FindControl(window, "cb_autoAgreeGroup");
            CheckBox cb_autoRepeat = (CheckBox)WinformHelper.FindControl(window, "cb_autoRepeat");
            CheckBox cb_welcomeMsg = (CheckBox)WinformHelper.FindControl(window, "cb_welcomeMsg");
            
            CheckBox cb_autoAgreePersonal = (CheckBox)WinformHelper.FindControl(window, "cb_autoAgreePersonal");
            #endregion

            #region == 敏感词 ==
            ListBox lb_sensitiveWords = (ListBox)WinformHelper.FindControl(window, "lb_sensitiveWords");
            #endregion

            #region == 基本信息 ==
            TextBox tb_botQQ = (TextBox)WinformHelper.FindControl(window, "tb_botQQ");
            #endregion

            #region == 消息 ==
            TextBox tb_groupWelcomeMsg = (TextBox)WinformHelper.FindControl(window, "tb_groupWelcomeMsg");
            TextBox tb_newFriendMsg = (TextBox)WinformHelper.FindControl(window, "tb_newFriendMsg");
            #endregion

            #region == WebApi ==
            CheckBox cb_webApiEnable = (CheckBox)WinformHelper.FindControl(window, "cb_webApiEnable");
            TextBox tb_webApi = (TextBox)WinformHelper.FindControl(window, "tb_webApi");
            TextBox tb_webApiKey = (TextBox)WinformHelper.FindControl(window, "tb_webApiKey");
            TextBox tb_webApiSecret = (TextBox)WinformHelper.FindControl(window, "tb_webApiSecret");
            #endregion

            //初始化
            #region == 基本信息 ==
            tb_botQQ.Text = settings.BotQQ.ToString();
            #endregion

            #region == 开关 ==
            cb_autoAgreeGroup.Checked = settings.AutoAgreeGroup;
            cb_autoRepeat.Checked = settings.AutoRepeat;
            cb_welcomeMsg.Checked = settings.GroupWelcomeMessageEnable;

            cb_autoAgreePersonal.Checked = settings.AutoAgreeNewFriend;
            #endregion

            #region == 敏感词 ==
            foreach (string word in settings.SensitiveWords)
            {
                lb_sensitiveWords.Items.Add(word);
            }
            #endregion

            #region == 消息 ==
            tb_groupWelcomeMsg.Text = settings.GroupWelcomeMessage;
            tb_newFriendMsg.Text = settings.NewFriendMessage;
            #endregion

            #region == WebApi ==
            cb_webApiEnable.Checked = settings.WebApiEnable;
            tb_webApi.Text = settings.WebApiUrl;
            tb_webApiKey.Text = settings.WebApiKey;
            tb_webApiSecret.Text = settings.WebApiSecret;
            if (settings.WebApiEnable)
            {
                tb_webApi.Enabled = false;
                tb_webApiKey.Enabled = false;
                tb_webApiSecret.Enabled = false;
            }
            #endregion
        }
    }
}
