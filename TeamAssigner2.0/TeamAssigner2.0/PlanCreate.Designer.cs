namespace TeamAssigner2._0
{
    partial class PlanCreate
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
            this.plan_textBox = new System.Windows.Forms.TextBox();
            this.create_button = new System.Windows.Forms.Button();
            this.select_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plan_textBox
            // 
            this.plan_textBox.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plan_textBox.Location = new System.Drawing.Point(50, 30);
            this.plan_textBox.Multiline = true;
            this.plan_textBox.Name = "plan_textBox";
            this.plan_textBox.ReadOnly = true;
            this.plan_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.plan_textBox.Size = new System.Drawing.Size(650, 330);
            this.plan_textBox.TabIndex = 0;
            this.plan_textBox.WordWrap = false;
            // 
            // create_button
            // 
            this.create_button.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.create_button.Location = new System.Drawing.Point(330, 385);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(90, 40);
            this.create_button.TabIndex = 1;
            this.create_button.Text = "生成";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.create_button_MouseClick);
            // 
            // select_button
            // 
            this.select_button.Enabled = false;
            this.select_button.Font = new System.Drawing.Font("仿宋", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.select_button.Location = new System.Drawing.Point(530, 385);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(80, 30);
            this.select_button.TabIndex = 2;
            this.select_button.Text = "选中全部";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.select_button_MouseClick);
            // 
            // PlanCreate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.plan_textBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PlanCreate";
            this.Size = new System.Drawing.Size(750, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plan_textBox;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button select_button;
    }
}
