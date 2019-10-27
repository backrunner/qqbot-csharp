/*
 *	�˴����� T4 ������� StatusExport.tt ģ������, �������˽����´�����ô�, �����޸�!
 *	
 *	���ļ�������Ŀ Json �ļ�����������������.
 */
using System;
using System.Runtime.InteropServices;
using System.Text;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;
using Unity;

namespace Native.Csharp.App.Core
{
    public class StatusExport
    {
		#region --���캯��--
		/// <summary>
		/// ��̬���캯��, ע������ע��ص�
		/// </summary>
        static StatusExport ()
        {
			// �ַ�Ӧ�����¼�
			ResolveAppbackcall ();
        }
        #endregion

		#region --˽�з���--
		/// <summary>
		/// ��ȡ���е�ע����, �ַ�����Ӧ���¼�
		/// </summary>
		private static void ResolveAppbackcall ()
		{
			/*
			 * Name: ����ʱ��
			 * Function: _statusUptime
			 */
			if (Common.UnityContainer.IsRegistered<ICqStatus> ("����ʱ��") == true)
			{
				Status_UPTIME = Common.UnityContainer.Resolve<ICqStatus> ("����ʱ��").CqStatus;
			}


		}
        #endregion

		#region --��������--
		/*
		 * Id: 1
		 * Name: ����ʱ��
		 * Title: UPTIME
		 * Function: _statusUptime
		 * Period: 1000
		 */
		public static event EventHandler<CqStatusEventArgs> Status_UPTIME;
		[DllExport (ExportName = "_statusUptime", CallingConvention = CallingConvention.StdCall)]
		private static string Evnet__statusUptime ()
		{
			CqStatusEventArgs args = new CqStatusEventArgs (1, "����ʱ��", "UPTIME", 1000);
			if (Status_UPTIME != null)
			{
				Status_UPTIME (null, args);
			}
			return args.FloatWindowData;
		}


        #endregion
	}
}

