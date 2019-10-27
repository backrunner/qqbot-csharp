/*
 *	�˴����� T4 ������� MenuExport.tt ģ������, �������˽����´�����ô�, �����޸�!
 *	
 *	���ļ�������Ŀ Json �ļ��Ĳ˵���������.
 */
using System;
using System.Runtime.InteropServices;
using System.Text;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;
using Unity;

namespace Native.Csharp.App.Core
{
    public class MenuExport
    {
		#region --���캯��--
		/// <summary>
		/// ��̬���캯��, ע������ע��ص�
		/// </summary>
        static MenuExport ()
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
			 * Name: ����A
			 * Function: _menuA
			 */
			if (Common.UnityContainer.IsRegistered<ICallMenu> ("����A") == true)
			{
				Menu__menuA = Common.UnityContainer.Resolve<ICallMenu> ("����A").CallMenu;
			}

			/*
			 * Name: ����B
			 * Function: _menuB
			 */
			if (Common.UnityContainer.IsRegistered<ICallMenu> ("����B") == true)
			{
				Menu__menuB = Common.UnityContainer.Resolve<ICallMenu> ("����B").CallMenu;
			}


		}
        #endregion

		#region --��������--
		/*
		 * Name: ����A
		 * Function: _menuA
		 */
		public static event EventHandler<CqCallMenuEventArgs> Menu__menuA;
		[DllExport (ExportName = "_menuA", CallingConvention = CallingConvention.StdCall)]
		private static int Evnet__menuA ()
		{
			if (Menu__menuA != null)
			{
				Menu__menuA (null, new CqCallMenuEventArgs ("����A"));
			}
			return 0;
		}

		/*
		 * Name: ����B
		 * Function: _menuB
		 */
		public static event EventHandler<CqCallMenuEventArgs> Menu__menuB;
		[DllExport (ExportName = "_menuB", CallingConvention = CallingConvention.StdCall)]
		private static int Evnet__menuB ()
		{
			if (Menu__menuB != null)
			{
				Menu__menuB (null, new CqCallMenuEventArgs ("����B"));
			}
			return 0;
		}


		#endregion
    }
}

