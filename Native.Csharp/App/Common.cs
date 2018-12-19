﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Native.Csharp.App
{
	/// <summary>
	/// 用于存放 App 数据的公共类
	/// </summary>
	public static class Common
	{
		/// <summary>
		/// 获取或设置 App 在运行期间所使用的数据路径
		/// </summary>
		public static string AppDirectory { get; set; }
		/// <summary>
		/// 获取或设置当前 App 是否处于运行状态
		/// </summary>
		public static bool IsRunning { get; set; }

        /// <summary>
		/// 程序共用的Random实例
		/// </summary>
        public static Random Random { get; set; }
	}
}
