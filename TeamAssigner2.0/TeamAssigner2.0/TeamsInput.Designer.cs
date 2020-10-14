namespace TeamAssigner2._0
{
    partial class TeamsInput
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.teams_listBox = new System.Windows.Forms.ListBox();
            this.team_label = new System.Windows.Forms.Label();
            this.team_textBox = new System.Windows.Forms.TextBox();
            this.damage_label = new System.Windows.Forms.Label();
            this.damage_textBox = new System.Windows.Forms.TextBox();
            this.remark_label = new System.Windows.Forms.Label();
            this.remark_textBox = new System.Windows.Forms.TextBox();
            this.amend_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teams_listBox
            // 
            this.teams_listBox.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teams_listBox.FormattingEnabled = true;
            this.teams_listBox.ItemHeight = 19;
            this.teams_listBox.Location = new System.Drawing.Point(50, 30);
            this.teams_listBox.Margin = new System.Windows.Forms.Padding(0);
            this.teams_listBox.Name = "teams_listBox";
            this.teams_listBox.Size = new System.Drawing.Size(550, 251);
            this.teams_listBox.TabIndex = 0;
            this.teams_listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.teams_listBox_MouseDoubleClick);
            // 
            // team_label
            // 
            this.team_label.AutoSize = true;
            this.team_label.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.team_label.Location = new System.Drawing.Point(50, 335);
            this.team_label.Name = "team_label";
            this.team_label.Size = new System.Drawing.Size(51, 19);
            this.team_label.TabIndex = 1;
            this.team_label.Text = "作业";
            // 
            // team_textBox
            // 
            this.team_textBox.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.team_textBox.Location = new System.Drawing.Point(110, 330);
            this.team_textBox.Name = "team_textBox";
            this.team_textBox.Size = new System.Drawing.Size(420, 29);
            this.team_textBox.TabIndex = 2;
            // 
            // damage_label
            // 
            this.damage_label.AutoSize = true;
            this.damage_label.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.damage_label.Location = new System.Drawing.Point(555, 335);
            this.damage_label.Name = "damage_label";
            this.damage_label.Size = new System.Drawing.Size(51, 19);
            this.damage_label.TabIndex = 3;
            this.damage_label.Text = "伤害";
            // 
            // damage_textBox
            // 
            this.damage_textBox.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.damage_textBox.Location = new System.Drawing.Point(615, 330);
            this.damage_textBox.Name = "damage_textBox";
            this.damage_textBox.Size = new System.Drawing.Size(100, 29);
            this.damage_textBox.TabIndex = 4;
            // 
            // remark_label
            // 
            this.remark_label.AutoSize = true;
            this.remark_label.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remark_label.Location = new System.Drawing.Point(50, 390);
            this.remark_label.Name = "remark_label";
            this.remark_label.Size = new System.Drawing.Size(51, 19);
            this.remark_label.TabIndex = 5;
            this.remark_label.Text = "备注";
            // 
            // remark_textBox
            // 
            this.remark_textBox.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remark_textBox.Location = new System.Drawing.Point(110, 385);
            this.remark_textBox.Name = "remark_textBox";
            this.remark_textBox.Size = new System.Drawing.Size(490, 29);
            this.remark_textBox.TabIndex = 6;
            // 
            // amend_button
            // 
            this.amend_button.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.amend_button.Location = new System.Drawing.Point(630, 30);
            this.amend_button.Name = "amend_button";
            this.amend_button.Size = new System.Drawing.Size(85, 40);
            this.amend_button.TabIndex = 7;
            this.amend_button.Text = "修改";
            this.amend_button.UseVisualStyleBackColor = true;
            this.amend_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.amend_button_MouseClick);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete_button.Location = new System.Drawing.Point(630, 100);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(85, 40);
            this.delete_button.TabIndex = 8;
            this.delete_button.Text = "删除";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.delete_button_MouseClick);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save_button.Location = new System.Drawing.Point(630, 170);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(85, 40);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "保存";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.save_button_MouseClick);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_button.Location = new System.Drawing.Point(630, 380);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(85, 40);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "添加";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.add_button_MouseClick);
            // 
            // TeamsInput
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.amend_button);
            this.Controls.Add(this.remark_textBox);
            this.Controls.Add(this.remark_label);
            this.Controls.Add(this.damage_textBox);
            this.Controls.Add(this.damage_label);
            this.Controls.Add(this.team_textBox);
            this.Controls.Add(this.team_label);
            this.Controls.Add(this.teams_listBox);
            this.Name = "TeamsInput";
            this.Size = new System.Drawing.Size(750, 450);
            this.Load += new System.EventHandler(this.TeamsInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teams_listBox;
        private System.Windows.Forms.Label team_label;
        private System.Windows.Forms.TextBox team_textBox;
        private System.Windows.Forms.Label damage_label;
        private System.Windows.Forms.TextBox damage_textBox;
        private System.Windows.Forms.Label remark_label;
        private System.Windows.Forms.TextBox remark_textBox;
        private System.Windows.Forms.Button amend_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button add_button;
    }
}
