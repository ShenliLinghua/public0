namespace TeamAssigner2._0
{
    partial class BoxConfirm
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
            this.explain_label = new System.Windows.Forms.Label();
            this.lack_box_textBox = new System.Windows.Forms.TextBox();
            this.finish_button = new System.Windows.Forms.Button();
            this.remark_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // explain_label
            // 
            this.explain_label.AutoSize = true;
            this.explain_label.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.explain_label.Location = new System.Drawing.Point(50, 30);
            this.explain_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.explain_label.Name = "explain_label";
            this.explain_label.Size = new System.Drawing.Size(299, 21);
            this.explain_label.TabIndex = 0;
            this.explain_label.Text = "请输入您box中缺少的角色：";
            // 
            // lack_box_textBox
            // 
            this.lack_box_textBox.Location = new System.Drawing.Point(50, 70);
            this.lack_box_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.lack_box_textBox.Multiline = true;
            this.lack_box_textBox.Name = "lack_box_textBox";
            this.lack_box_textBox.Size = new System.Drawing.Size(650, 220);
            this.lack_box_textBox.TabIndex = 1;
            // 
            // finish_button
            // 
            this.finish_button.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.finish_button.Location = new System.Drawing.Point(330, 385);
            this.finish_button.Margin = new System.Windows.Forms.Padding(5);
            this.finish_button.Name = "finish_button";
            this.finish_button.Size = new System.Drawing.Size(90, 40);
            this.finish_button.TabIndex = 2;
            this.finish_button.Text = "完成";
            this.finish_button.UseVisualStyleBackColor = true;
            this.finish_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.finish_button_MouseClick);
            // 
            // remark_label
            // 
            this.remark_label.AutoSize = true;
            this.remark_label.Font = new System.Drawing.Font("仿宋", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remark_label.Location = new System.Drawing.Point(50, 320);
            this.remark_label.Name = "remark_label";
            this.remark_label.Size = new System.Drawing.Size(549, 20);
            this.remark_label.TabIndex = 3;
            this.remark_label.Text = "(角色名称之间仅需使用逗号分割，名称请与作业中保持一致)";
            // 
            // BoxConfirm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.remark_label);
            this.Controls.Add(this.finish_button);
            this.Controls.Add(this.lack_box_textBox);
            this.Controls.Add(this.explain_label);
            this.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BoxConfirm";
            this.Size = new System.Drawing.Size(750, 450);
            this.Load += new System.EventHandler(this.BoxConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label explain_label;
        private System.Windows.Forms.TextBox lack_box_textBox;
        private System.Windows.Forms.Button finish_button;
        private System.Windows.Forms.Label remark_label;
    }
}
