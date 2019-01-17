using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BackRunner.QQBot.Models
{
    public class Settings
    {
        //基本信息
        public long BotQQ { get; set; }
        public long OwnerQQ { get; set; }

        //消息设置
        public string GroupWelcomeMessage { get; set; }
        public string NewFriendMessage { get; set; }

        //开关设置
        public bool AutoAgreeGroup { get; set; }
        public bool AutoRepeat { get; set; }
        public bool GroupWelcomeMessageEnabled { get; set; }
        public bool AutoAgreeNewFriend { get; set; }
        public bool GroupWhiteListEnabled { get; set; }

        //屏蔽词
        public List<string> SensitiveWords;

        //群白名单
        public List<long> GroupWhiteList;

        //WebApi
        public bool WebApiEnabled { get; set; }
        public string WebApiUrl { get; set; }
        public string WebApiKey { get; set; }
        public string WebApiSecret { get; set; }

        public Settings()
        {
            // 默认设置

            #region == 基本信息 ==
            BotQQ = -1;
            OwnerQQ = -1;
            #endregion

            #region == 列表 ==
            SensitiveWords = new List<string>();
            GroupWhiteList = new List<long>();
            #endregion
            
            #region == 开关 ==
            AutoAgreeGroup = false;
            AutoRepeat = true;
            GroupWelcomeMessageEnabled = true;
            GroupWelcomeMessage = "欢迎入群~";
            AutoAgreeNewFriend = false;
            GroupWhiteListEnabled = false;
            #endregion

            #region == WebApi ==
            WebApiEnabled = false;
            #endregion
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
