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

        //消息设置
        public string GroupWelcomeMessage { get; set; }
        public string NewFriendMessage { get; set; }

        //开关设置
        public bool AutoAgreeGroup { get; set; }
        public bool AutoRepeat { get; set; }
        public bool GroupWelcomeMessageEnable { get; set; }

        public bool AutoAgreeNewFriend { get; set; }

        //屏蔽词
        public List<string> SensitiveWords;

        //WebApi
        public bool WebApiEnable { get; set; }
        public string WebApiUrl { get; set; }
        public string WebApiKey { get; set; }
        public string WebApiSecret { get; set; }

        public Settings()
        {
            SensitiveWords = new List<string>();
            //默认设置
            AutoAgreeGroup = false;
            AutoRepeat = true;
            GroupWelcomeMessageEnable = true;
            GroupWelcomeMessage = "欢迎入群~";

            AutoAgreeNewFriend = true;

            WebApiEnable = false;
        }        

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
