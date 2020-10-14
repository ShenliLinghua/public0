namespace TeamAssigner2._0
{
    partial class Base_Form
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base_Form));
            this.box_button = new System.Windows.Forms.Button();
            this.team_button = new System.Windows.Forms.Button();
            this.plan_button = new System.Windows.Forms.Button();
            this.muti_window_groupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // box_button
            // 
            this.box_button.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.box_button.Location = new System.Drawing.Point(0, 0);
            this.box_button.Name = "box_button";
            this.box_button.Size = new System.Drawing.Size(105, 50);
            this.box_button.TabIndex = 0;
            this.box_button.Text = "角色确认";
            this.box_button.UseVisualStyleBackColor = true;
            this.box_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.box_button_MouseClick);
            // 
            // team_button
            // 
            this.team_button.Enabled = false;
            this.team_button.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.team_button.Location = new System.Drawing.Point(105, 0);
            this.team_button.Name = "team_button";
            this.team_button.Size = new System.Drawing.Size(105, 50);
            this.team_button.TabIndex = 1;
            this.team_button.Text = "作业确认";
            this.team_button.UseVisualStyleBackColor = true;
            this.team_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.team_button_MouseClick);
            // 
            // plan_button
            // 
            this.plan_button.Enabled = false;
            this.plan_button.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_button.Location = new System.Drawing.Point(210, 0);
            this.plan_button.Name = "plan_button";
            this.plan_button.Size = new System.Drawing.Size(105, 50);
            this.plan_button.TabIndex = 2;
            this.plan_button.Text = "方案生成";
            this.plan_button.UseVisualStyleBackColor = true;
            this.plan_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plan_button_MouseClick);
            // 
            // muti_window_groupBox
            // 
            this.muti_window_groupBox.Location = new System.Drawing.Point(7, 50);
            this.muti_window_groupBox.Name = "muti_window_groupBox";
            this.muti_window_groupBox.Padding = new System.Windows.Forms.Padding(0);
            this.muti_window_groupBox.Size = new System.Drawing.Size(750, 450);
            this.muti_window_groupBox.TabIndex = 3;
            this.muti_window_groupBox.TabStop = false;
            // 
            // Base_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(764, 503);
            this.Controls.Add(this.muti_window_groupBox);
            this.Controls.Add(this.plan_button);
            this.Controls.Add(this.team_button);
            this.Controls.Add(this.box_button);
            this.Font = new System.Drawing.Font("仿宋", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Base_Form";
            this.Text = "分刀计算器2.0";
            this.Load += new System.EventHandler(this.Base_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button box_button;
        public System.Windows.Forms.Button team_button;
        public System.Windows.Forms.Button plan_button;
        private System.Windows.Forms.GroupBox muti_window_groupBox;
    }
}

