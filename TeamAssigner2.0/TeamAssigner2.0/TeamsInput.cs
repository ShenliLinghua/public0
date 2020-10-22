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
    public partial class TeamsInput : UserControl
    {
        public struct teamwork
        {//作业结构
            public string team;
            public int damage;
            public string remark;
        }
        public static List<teamwork> teamworks = new List<teamwork>();//作业List

        public void addCurrentItem()
        {//在末尾添加作业
            teamwork teamwork0 = new teamwork();
            teamwork0.team = team_textBox.Text;
            if (damage_textBox.Text == "")
            {
                teamwork0.damage = 0;
            }
            else
            {
                teamwork0.damage = int.Parse(damage_textBox.Text);
            }
            teamwork0.remark = remark_textBox.Text;
            teamworks.Add(teamwork0);
            teams_listBox.Items.Add(team_textBox.Text);
        }

        public void deleteCurrentItem()
        {//删除当前焦点的作业
            teamworks.RemoveAt(teams_listBox.SelectedIndex);
            teams_listBox.Items.RemoveAt(teams_listBox.SelectedIndex);
        }
        public TeamsInput()
        {
            InitializeComponent();
        }

        private void TeamsInput_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.teams == "")
            {
                return;
            }
            string[] tempTeams = { };
            string[] tempDamages = { };
            string[] tempRemarks = { };
            tempTeams = Properties.Settings.Default.teams.Replace(" ","").Split('*');
            tempDamages = Properties.Settings.Default.damages.Replace(" ", "").Split('*');
            tempRemarks = Properties.Settings.Default.remarks.Replace(" ", "").Split('*');
            for (int i = 0; i < tempTeams.Length; i++)
            {
                teamwork teamwork0 = new teamwork();
                teamwork0.team = tempTeams[i];
                if (tempDamages[i] == "")
                {
                    teamwork0.damage = 0;
                }
                else
                {
                    teamwork0.damage = int.Parse(tempDamages[i]);
                }
                teamwork0.remark = tempRemarks[i];
                teamworks.Add(teamwork0);
                teams_listBox.Items.Add(tempTeams[i]);
            }
        }
            private void save_button_MouseClick(object sender, MouseEventArgs e)
        {
            if (teamworks.Count < 3)
            {//作业数量检测
                MessageBox.Show("请给出3队以上作业", "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                return;
            }
            string tempTeams = "";
            string tempDamages = "";
            string tempRemarks = "";
            for (int i = 0; i < teams_listBox.Items.Count; i++)
            {
                if (i != 0)
                {
                    tempTeams += "*";
                    tempDamages += "*";
                    tempRemarks += "*";
                }
                tempTeams += teamworks[i].team;
                tempDamages += teamworks[i].damage.ToString();
                tempRemarks += teamworks[i].remark;
            }
            Properties.Settings.Default.teams = tempTeams;
            Properties.Settings.Default.damages = tempDamages;
            Properties.Settings.Default.remarks = tempRemarks;
            Properties.Settings.Default.Save();
            //激活生成界面
            boolDelegate changePlanbutton = new boolDelegate(Base_Form.base_form.enablePlanButton);
            changePlanbutton(true);
            //激活生成按钮
            boolDelegate changeCreatebutton = new boolDelegate(PlanCreate.planCreate.enableCreateButton);
            changeCreatebutton(true);
        }

        private void add_button_MouseClick(object sender, MouseEventArgs e)
        {
            if(team_textBox.Text == "")
            {//空阵容检测
                MessageBox.Show("请输入作业阵容", "",MessageBoxButtons.OK,MessageBoxIcon.None,MessageBoxDefaultButton.Button1);
                return;
            }
            addCurrentItem();
            teams_listBox.SelectedIndex = teams_listBox.Items.Count - 1;
        }

        private void delete_button_MouseClick(object sender, MouseEventArgs e)
        {
            if (teams_listBox.SelectedIndex == -1)
            {
                return;
            }
            int ind = teams_listBox.SelectedIndex;
            deleteCurrentItem();
            if(ind == 0 && teams_listBox.Items.Count != 0)
            {
                teams_listBox.SelectedIndex = ind;
            }
            else
            {
                teams_listBox.SelectedIndex = ind - 1;
            }
        }

        private void amend_button_MouseClick(object sender, MouseEventArgs e)
        {
            if (teams_listBox.SelectedIndex == -1)
            {//检测焦点是否存在
                return;
            }
            int ind = teams_listBox.SelectedIndex;//在listbox修改前存好下标
            deleteCurrentItem();
            teamwork teamwork0 = new teamwork();
            teamwork0.team = team_textBox.Text;
            if (damage_textBox.Text == "")
            {
                teamwork0.damage = 0;
            }
            else
            {
                teamwork0.damage = int.Parse(damage_textBox.Text);
            }
            teamwork0.remark = remark_textBox.Text;
            teamworks.Insert(ind,teamwork0);
            teams_listBox.Items.Insert(ind, team_textBox.Text);
            teams_listBox.SelectedIndex = ind;
        }

        private void teams_listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {//双击作业将作业显示到文本框
            if (teams_listBox.SelectedIndex == -1)
            {//检测双击位置
                return;
            }
            team_textBox.Text = teamworks[teams_listBox.SelectedIndex].team;
            damage_textBox.Text = teamworks[teams_listBox.SelectedIndex].damage.ToString();
            remark_textBox.Text = teamworks[teams_listBox.SelectedIndex].remark;
        }
    }
}
