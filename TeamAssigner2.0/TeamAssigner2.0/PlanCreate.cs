using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TeamAssigner2._0
{
    public partial class PlanCreate : UserControl
    {
        public static PlanCreate planCreate = null;
        public struct oneTeam
        {//方案中的一队
            public string[] team;
            public int damage;
            public string remark;
            public bool borrow;//是否借人
            public int borrowIndex;//借人下标
            public oneTeam(string[] t,int d,string r,bool b,int bi)
            {
                List<string> ls = new List<string>();
                for(int i = 0;i < t.Length; i++)
                {
                    ls.Add(string.Copy(t[i]));
                }
                team = ls.ToArray();
                damage = d;
                remark = r;
                borrow = b;
                borrowIndex = bi;
            }

        }
        public struct plan
        {//存储单位结果方案的结构
            public oneTeam team1;
            public oneTeam team2;
            public oneTeam team3;
            public int totalDamege;
        }

        public static List<plan> plans = new List<plan>();//方案List

        public static int[] sameCheck(string[] lackBox,string[] team)
        {//检测队伍缺人情况，返回缺少人数以及下标
            List<int> resultList = new List<int>();//动态结果数组
            resultList.Add(0);
            for (int i = 0;i < team.Length; i++)
            {
                for(int j = 0;j < lackBox.Length; j++)
                {
                    if(team[i] == lackBox[j])
                    {
                        resultList[0] += 1;
                        resultList.Add(i);
                    }
                }
            }
            int[] result = resultList.ToArray();
            return result;
        }

        public PlanCreate()
        {
            InitializeComponent();
            planCreate = this;
        }

        private void create_button_MouseClick(object sender, MouseEventArgs e)
        {
            plans.Clear();
            for(int i = 0;i < TeamsInput.teamworks.Count - 2; i++)
            {
                for (int j = i + 1; j < TeamsInput.teamworks.Count - 1; j++)
                {
                    for (int k = j + 1; k < TeamsInput.teamworks.Count; k++)
                    {//每次为一个plan（ijk3队）
                        plan tempPlan;

                        //第一队
                        //与lackbox比较
                        string[] tempS1 = TeamsInput.teamworks[i].team.Replace(" ", "").Split(new char[2] { ',', '，' });
                        int[] lackArray1 = sameCheck(BoxConfirm.lackBox, tempS1);
                        if(lackArray1[0] == 0 && lackArray1.Length == lackArray1[0] + 1)
                        {//不缺人
                            tempPlan.team1 = new oneTeam(tempS1, TeamsInput.teamworks[i].damage, TeamsInput.teamworks[i].remark, false, -1);
                        }
                        else if(lackArray1[0] == 1 && lackArray1.Length == lackArray1[0] + 1)
                        {//缺1人
                            tempPlan.team1 = new oneTeam(tempS1, TeamsInput.teamworks[i].damage, TeamsInput.teamworks[i].remark, true, lackArray1[1]);
                        }
                        else
                        {//缺2人以上
                            continue;
                        }

                        //第二队
                        //与lackbox比较
                        string[] tempS2 = TeamsInput.teamworks[j].team.Replace(" ", "").Split(new char[2] { ',', '，' });
                        int[] lackArray2 = sameCheck(BoxConfirm.lackBox, tempS2);
                        if (lackArray2[0] == 0 && lackArray2.Length == lackArray2[0] + 1)
                        {//不缺人
                            tempPlan.team2 = new oneTeam(tempS2, TeamsInput.teamworks[j].damage, TeamsInput.teamworks[j].remark, false, -1);
                        }
                        else if (lackArray2[0] == 1 && lackArray2.Length == lackArray2[0] + 1)
                        {//缺1人
                            tempPlan.team2 = new oneTeam(tempS2, TeamsInput.teamworks[j].damage, TeamsInput.teamworks[j].remark, true, lackArray2[1]);
                        }
                        else
                        {//缺2人以上
                            continue;
                        }
                        //与1队比较
                        int[] teamArray12 = sameCheck(tempS1, tempS2);
                        if (teamArray12[0] == 0 && teamArray12.Length == teamArray12[0] + 1)
                        {//不缺人
                            
                        }
                        else if (teamArray12[0] == 1 && teamArray12.Length == teamArray12[0] + 1)
                        {//缺1人
                            if(tempPlan.team2.borrow)
                            {
                                continue;
                            }
                            tempPlan.team2.borrow = true;
                            tempPlan.team2.borrowIndex = teamArray12[1];
                        }
                        else if(teamArray12[0] == 2 && teamArray12.Length == teamArray12[0] + 1)
                        {//缺2人，如果1队和2队都没有借人，可以各借一人
                            if (tempPlan.team1.borrow || tempPlan.team2.borrow)
                            {
                                continue;
                            }
                            tempPlan.team1.borrow = true;
                            tempPlan.team1.borrowIndex = teamArray12[1];
                            tempPlan.team2.borrow = true;
                            tempPlan.team2.borrowIndex = teamArray12[2];
                        }
                        else
                        {//缺3人以上
                            continue;
                        }

                        //第三队
                        //与lackbox比较
                        string[] tempS3 = TeamsInput.teamworks[k].team.Replace(" ", "").Split(new char[2] { ',', '，' });
                        int[] lackArray3 = sameCheck(BoxConfirm.lackBox, tempS3);
                        if (lackArray3[0] == 0 && lackArray3.Length == lackArray3[0] + 1)
                        {//不缺人
                            tempPlan.team3 = new oneTeam(tempS3, TeamsInput.teamworks[k].damage, TeamsInput.teamworks[k].remark, false, -1);
                        }
                        else if (lackArray3[0] == 1 && lackArray3.Length == lackArray3[0] + 1)
                        {//缺1人
                            tempPlan.team3 = new oneTeam(tempS3, TeamsInput.teamworks[k].damage, TeamsInput.teamworks[k].remark, true, lackArray3[1]);
                        }
                        else
                        {//缺2人以上
                            continue;
                        }
                        //与1队比较
                        int[] teamArray13 = sameCheck(tempS1, tempS3);
                        if (teamArray13[0] == 0 && teamArray13.Length == teamArray13[0] + 1)
                        {//不缺人

                        }
                        else if (teamArray13[0] == 1 && teamArray13.Length == teamArray13[0] + 1)
                        {//缺1人
                            if (tempPlan.team3.borrow)
                            {
                                continue;
                            }
                            tempPlan.team3.borrow = true;
                            tempPlan.team3.borrowIndex = teamArray13[1];
                        }
                        else if(teamArray13[0] == 2 && teamArray13.Length == teamArray13[0] + 1)
                        {//缺2人
                            if (tempPlan.team1.borrow || tempPlan.team3.borrow)
                            {
                                continue;
                            }
                            tempPlan.team1.borrow = true;
                            tempPlan.team1.borrowIndex = teamArray13[1];
                            tempPlan.team3.borrow = true;
                            tempPlan.team3.borrowIndex = teamArray13[2];
                        }
                        else
                        {//缺3人以上
                            continue;
                        }
                        //与2队比较
                        int[] teamArray23 = sameCheck(tempS2, tempS3);
                        if (teamArray23[0] == 0 && teamArray23.Length == teamArray23[0] + 1)
                        {//不缺人

                        }
                        else if (teamArray23[0] == 1 && teamArray23.Length == teamArray23[0] + 1)
                        {//缺1人
                            if (tempPlan.team3.borrow)
                            {
                                continue;
                            }
                            tempPlan.team3.borrow = true;
                            tempPlan.team3.borrowIndex = teamArray23[1];
                        }
                        else if (teamArray23[0] == 2 && teamArray23.Length == teamArray23[0] + 1)
                        {//缺2人
                            if (tempPlan.team2.borrow || tempPlan.team3.borrow)
                            {
                                continue;
                            }
                            tempPlan.team2.borrow = true;
                            tempPlan.team2.borrowIndex = teamArray12[1];
                            tempPlan.team3.borrow = true;
                            tempPlan.team3.borrowIndex = teamArray12[2];
                        }
                        else
                        {//缺3人以上
                            continue;
                        }
                        tempPlan.totalDamege = tempPlan.team1.damage + tempPlan.team2.damage + tempPlan.team3.damage;
                        plans.Add(tempPlan);
                    }
                }
            }
            //按伤害排序(插入)
            if(plans.Count > 1)
            {
                for (int i = 1; i < plans.Count; i++)
                {
                    for (int j = i; j > 0; j--)
                    {
                        if (plans[j].totalDamege > plans[j - 1].totalDamege)
                        {
                            plan tp = plans[j];
                            plans[j] = plans[j - 1];
                            plans[j - 1] = tp;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            //屏幕输出
            plan_textBox.Clear();
            plan_textBox.Text += "共生成" + plans.Count + "种方案";
            plan_textBox.Text += "\r\n";
            for (int i = 0;i < plans.Count; i++)
            {
                plan_textBox.Text += "第" + (i + 1) + "种方案:";
                plan_textBox.Text += "\r\n";
                plan_textBox.Text += " 第一队:";
                plan_textBox.Text += "\r\n";
                printTeam(plans[i].team1);
                plan_textBox.Text += " 第二队:";
                plan_textBox.Text += "\r\n";
                printTeam(plans[i].team2);
                plan_textBox.Text += " 第三队:";
                plan_textBox.Text += "\r\n";
                printTeam(plans[i].team3);
                plan_textBox.Text += " 总伤害:" + plans[i].totalDamege.ToString();
                plan_textBox.Text += "\r\n";
                plan_textBox.Text += "\r\n";
            }
            plan_textBox.Select(plan_textBox.Text.Length - 1,0);
            create_button.Enabled = false;
            select_button.Enabled = true;
        }

        public void printTeam(oneTeam t)
        {
            for (int j = 0; j < t.team.Length; j++)
            {
                //输出阵容
                if (j == 0)
                {
                    plan_textBox.Text += "  ";
                }
                else
                {
                    plan_textBox.Text += "，";
                }
                if (t.borrow)
                {
                    if(j == t.borrowIndex)
                    {
                        plan_textBox.Text += "(借)";
                    }
                }
                plan_textBox.Text += t.team[j];
            }
            //输出伤害
            plan_textBox.Text += " " + t.damage;
            //输出备注
            plan_textBox.Text += "\r\n";
            plan_textBox.Text += "  " + t.remark;
            plan_textBox.Text += "\r\n";
        }

        //激活team_button
        public void enableCreateButton(bool b)
        {
            this.create_button.Enabled = b;
        }

        private void select_button_MouseClick(object sender, MouseEventArgs e)
        {
            plan_textBox.Focus();
            plan_textBox.SelectAll();
        }
    }
}
