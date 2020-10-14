using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamAssigner2._0
{
    public partial class BoxConfirm : UserControl
    {
        public static string[] lackBox;//缺少的人物
        public BoxConfirm()
        {
            InitializeComponent();
        }

        private void finish_button_MouseClick(object sender, MouseEventArgs e)
        {
            //将文本框中的角色信息存储刀数组中
            lackBox = lack_box_textBox.Text.Replace(" ", "").Split(new char[2] { ',', '，' });
            //存储lackbox的信息
            Properties.Settings.Default.lackbox = lack_box_textBox.Text;
            Properties.Settings.Default.Save();
            //激活作业按钮
            boolDelegate changeTeamButton = new boolDelegate(Base_Form.base_form.enableTeamButton);
            changeTeamButton(true);
        }

        private void BoxConfirm_Load(object sender, EventArgs e)
        {
            lack_box_textBox.Text = Properties.Settings.Default.lackbox;
        }
    }
}
