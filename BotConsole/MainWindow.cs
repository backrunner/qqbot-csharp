using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackRunner.QQBot.BotConsole
{
    public partial class ConsoleWindow : Form
    {
        public ConsoleWindow()
        {
            InitializeComponent();
        }

        #region == WebApi ==
        private void cb_webApiEnable_CheckedChanged(object sender, EventArgs e)
        {
            EnableOperateButtons();
            gb_WebApi.Enabled = cb_webApiEnable.Checked;
        }
        #endregion

        #region == 开关 ==
        private void cb_autoAgreeGroup_CheckedChanged(object sender, EventArgs e)
        {
            EnableOperateButtons();
        }
        private void cb_autoRepeat_CheckedChanged(object sender, EventArgs e)
        {
            EnableOperateButtons();
        }
        private void cb_welcomeMsg_CheckedChanged(object sender, EventArgs e)
        {
            EnableOperateButtons();
        }
        private void cb_autoAgreePersonal_CheckedChanged(object sender, EventArgs e)
        {
            EnableOperateButtons();
        }
        private void cb_enableBotinGroup_CheckedChanged(object sender, EventArgs e)
        {
            EnableOperateButtons();
            gb_limitGroup.Enabled = cb_enableBotinGroup.Checked;
        }
        private void cb_ownerNotification_CheckedChanged(object sender, EventArgs e)
        {
            EnableOperateButtons();
        }
        #endregion       

        #region == 屏蔽词 ==
        private void btn_addSensitiveWord_Click(object sender, EventArgs e)
        {
            string sensitiveWord = tb_newSensitiveWord.Text.Trim();
            if (sensitiveWord.Length > 0)
            {
                lb_sensitiveWords.Items.Add(sensitiveWord);
                tb_newSensitiveWord.Text = string.Empty;
                EnableOperateButtons();
            }
            else
            {
                MessageBox.Show("请输入你需要添加的屏蔽词。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb_sensitiveWordBanTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInputCheck(sender, e);
        }

        private void tb_sensitiveWordBanTime_TextChanged(object sender, EventArgs e)
        {
            EnableOperateButtons();
        }

        private void btn_delSensitiveWord_Click(object sender, EventArgs e)
        {
            if (lb_sensitiveWords.SelectedIndex >= 0 && lb_sensitiveWords.SelectedIndex < lb_sensitiveWords.Items.Count)
            {
                lb_sensitiveWords.Items.RemoveAt(lb_sensitiveWords.SelectedIndex);
                lb_sensitiveWords.SelectedIndex = -1;
                EnableOperateButtons();
                btn_delSensitiveWord.Enabled = false;
            }
            else
            {
                MessageBox.Show("请选择你需要删除的屏蔽词。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lb_sensitiveWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_delSensitiveWord.Enabled = true;
        }
        #endregion

        #region == 群白名单 ==
        private void btn_addGroupWhiteList_Click(object sender, EventArgs e)
        {
            if (tb_enableGroupNumber.Text.Length > 0)
            {
                long groupnumber = -1;
                long.TryParse(tb_enableGroupNumber.Text, out groupnumber);
                if (groupnumber > 0)
                {
                    lb_groupWhiteList.Items.Add(groupnumber);
                    tb_enableGroupNumber.Text = string.Empty;
                    EnableOperateButtons();
                } else
                {
                    MessageBox.Show("您输入的数据有误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
            } else
            {
                MessageBox.Show("请输入你需要添加的群号。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb_enableGroupNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInputCheck(sender, e);
        }

        private void btn_removeGroupWhiteList_Click(object sender, EventArgs e)
        {
            if (lb_groupWhiteList.SelectedIndex >= 0 && lb_groupWhiteList.SelectedIndex < lb_groupWhiteList.Items.Count)
            {
                lb_groupWhiteList.Items.RemoveAt(lb_groupWhiteList.SelectedIndex);
                lb_groupWhiteList.SelectedIndex = -1;
                EnableOperateButtons();
                btn_removeGroupWhiteList.Enabled = false;
            }
            else
            {
                MessageBox.Show("请选择你需要删除的群。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lb_groupWhiteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_removeGroupWhiteList.Enabled = true;
        }
        #endregion        

        #region == 消息 ==
        private void tb_newFriendMsg_TextChanged(object sender, EventArgs e)
        {
            EnableOperateButtons();
        }

        private void tb_groupWelcomeMsg_TextChanged(object sender, EventArgs e)
        {
            EnableOperateButtons();
        }
        #endregion

        #region == 基本设置 ==
        private void tb_ownerQQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberInputCheck(sender, e);
        }
        private void tb_ownerQQ_TextChanged(object sender, EventArgs e)
        {
            EnableOperateButtons();
        }
        #endregion        

        #region == 其他 ==
        /// <summary>
        /// 启用操作区的保存和应用按钮。
        /// </summary>
        private void EnableOperateButtons()
        {
            btn_save.Enabled = true;
            btn_apply.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumberInputCheck(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            //小数点的处理。
            if ((int)e.KeyChar == 46)//小数点
            {
                if (tb_enableGroupNumber.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(tb_enableGroupNumber.Text, out oldf);
                    b2 = float.TryParse(tb_enableGroupNumber.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
        #endregion        
    }
}
