using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamAssigner2._0
{
    public delegate void boolDelegate(bool b);//激活方法的委托
    public partial class Base_Form : Form
    {
        public static Base_Form base_form = null;
        //声明窗口变量
        public UserControl boxConfirm;
        public UserControl teamsInput;
        public UserControl planCreate;
        //窗口显示方法
        private void PanelShow(UserControl userControl)
        {
            userControl.Show();
            muti_window_groupBox.Controls.Clear();
            muti_window_groupBox.Controls.Add(userControl);
        }
        public Base_Form()
        {
            InitializeComponent();
            base_form = this;
        }

        private void Base_Form_Load(object sender, EventArgs e)
        {
            //给窗口变量赋值
            boxConfirm = new BoxConfirm();
            teamsInput = new TeamsInput();
            planCreate = new PlanCreate();
            //加载完成时显示窗口
            PanelShow(boxConfirm);
        }

        private void box_button_MouseClick(object sender, MouseEventArgs e)
        {
            PanelShow(boxConfirm);
        }

        private void team_button_MouseClick(object sender, MouseEventArgs e)
        {
            PanelShow(teamsInput);
        }

        private void plan_button_MouseClick(object sender, MouseEventArgs e)
        {
            PanelShow(planCreate);
        }
        //激活team_button
        public void enableTeamButton(bool b)
        {
            this.team_button.Enabled = b;
        }
        //激活plan_button
        public void enablePlanButton(bool b)
        {
            this.plan_button.Enabled = b;
        }
    }
}
