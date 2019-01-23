using BackRunner.QQBot.Controller;
using Native.Csharp.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackRunner.QQBot.Processors
{
    public static class OwnerNotificationProcessor
    {
        /// <summary>
        /// 向主人发送通知
        /// </summary>
        /// <param name="content"></param>
        public static void NotifyOwner(string content)
        {
            if (SettingsController.settings.OwnerNotificationEnabled && SettingsController.settings.OwnerQQ > 0)
            {
                Common.CqApi.SendPrivateMessage(SettingsController.settings.OwnerQQ, content);
            }
        }
        /// <summary>
        /// 向主人发送通知（附带时间）
        /// </summary>
        /// <param name="content"></param>
        public static void NotifyOwner(string content, DateTime time)
        {
            if (SettingsController.settings.OwnerNotificationEnabled && SettingsController.settings.OwnerQQ > 0) {
                Common.CqApi.SendPrivateMessage(SettingsController.settings.OwnerQQ, "事件触发时间：" + time.ToString() + "\n" + content);
            }
        }
    }
}
