using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackRunner.QQBot
{
    public static class BotConfig
    {
        #region === 基础设置 ===
        public static long BotQQ = 779796391;

        public static void SetBotQQ(long qq)
        {
            BotQQ = qq;
        }
        #endregion

        #region === 群相关设置 ===
        public static string WelcomeMsg = "欢迎入群~";
        #endregion
    }
}
