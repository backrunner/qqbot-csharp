using System;
/// <summary>
/// 中文转数字
/// </summary>
/// <param name="src">中文数字 如：九亿八千七百六十五万四千三百二十一</param>
/// <returns></returns>

namespace BackRunner.QQBot.Utils
{
    public static class ChineseNumberConverter
    {
        public static int Chinese2Num(string src)
        {
            // 定义一个数组，用于接受分割字符串的结果
            string[] srcArr;
            // 定义计算结果
            int result = 0;
            // 如果字符串中包含'亿'则进行分割
            if (src.IndexOf("亿") != -1)
            {
                // 以字符'亿'分割源字符串
                srcArr = src.Split('亿');
                // 计算亿以上的数字
                result += Convert.ToInt32(Convert2Number(srcArr[0]) * Math.Pow(10, 8));
                // 如果剩余字符串中包括'万'，则再次进行分割
                if (src.IndexOf("万") != -1)
                {
                    // 以字符'万'分割源字符串
                    srcArr = srcArr[1].Split('万');
                    // 计算万以上亿以下的数字
                    result += Convert.ToInt32(Convert2Number(srcArr[0]) * Math.Pow(10, 4)) + Convert.ToInt32(Convert2Number(srcArr[1]));
                }
            }
            // 如果字符串中不包含字符'亿'
            else
            {
                // 如果源字符串中包括'万'，则以'万'字进行分割
                if (src.IndexOf("万") != -1)
                {
                    srcArr = src.Split('万');
                    result += Convert.ToInt32(Convert2Number(srcArr[0]) * Math.Pow(10, 4)) + Convert.ToInt32(Convert2Number(srcArr[1]));
                }
                else
                {
                    // 源文本为1万以下的数字
                    result += Convert.ToInt32(Convert2Number(src));
                }
            }
            return result;
        }
        /// <summary>
        /// 1万以内中文转数字
        /// </summary>
        /// <param name="src">源文本如：四千三百二十一</param>
        /// <returns></returns>
        public static int Convert2Number(string src)
        {
            // 定义包含所有数字的字符串，用以判断字符是否为数字。
            string numberString = "零一二三四五六七八九";
            // 定义单位字符串，用以判断字符是否为单位。
            string unitString = "零十百千";
            // 把数字字符串转换为char数组，方便截取。
            char[] charArr = src.Replace(" ", "").ToCharArray();
            // 返回结果
            int result = 0;
            // 如果源为空指针、空字符串、空白字符串 则返回0
            if (string.IsNullOrEmpty(src) || string.IsNullOrWhiteSpace(src))
            {
                return 0;
            }
            // 如果源的第一个字符不是数字 则返回0
            if (numberString.IndexOf(charArr[0]) == -1)
            {
                return 0;
            }
            // 遍历字符数组
            for (int i = 0; i < charArr.Length; i++)
            {
                // 遍历单位字符串
                for (int j = 0; j < unitString.Length; j++)
                {
                    // 如果字符为单位则进行计算
                    if (charArr[i] == unitString[j])
                    {
                        // 如果字符为非'零'字符，则计算出十位以上到万位以下数字的和
                        if (charArr[i] != '零')
                        {
                            result += Convert.ToInt32(int.Parse(numberString.IndexOf(charArr[i - 1]).ToString()) * Math.Pow(10, j));
                        }
                    }
                }
            }
            // 如果源文本末尾字符为'零'-'九'其中之一，则计算结果和个位数相加。
            if (numberString.IndexOf(charArr[charArr.Length - 1]) != -1)
            {
                result += numberString.IndexOf(charArr[charArr.Length - 1]);
            }
            // 返回计算结果。
            return result;
        }
    }
}