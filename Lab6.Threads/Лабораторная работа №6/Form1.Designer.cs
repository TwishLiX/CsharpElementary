namespace Лабораторная_работа__6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayBox = new System.Windows.Forms.RichTextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.SelectReadLabel = new System.Windows.Forms.Label();
            this.SelectWriteLabel = new System.Windows.Forms.Label();
            this.ReadPriorityChoosing = new System.Windows.Forms.ComboBox();
            this.WritePriorityChoosing = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DisplayBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.Size = new System.Drawing.Size(533, 262);
            this.DisplayBox.TabIndex = 0;
            this.DisplayBox.Text = "";
            // 
            // StartBtn
            // 
            this.StartBtn.Enabled = false;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StartBtn.Location = new System.Drawing.Point(218, 400);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(115, 38);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectLabel.Location = new System.Drawing.Point(153, 288);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(247, 20);
            this.SelectLabel.TabIndex = 3;
            this.SelectLabel.Text = "Select priority for each thread";
            // 
            // SelectReadLabel
            // 
            this.SelectReadLabel.AutoSize = true;
            this.SelectReadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectReadLabel.Location = new System.Drawing.Point(400, 322);
            this.SelectReadLabel.Name = "SelectReadLabel";
            this.SelectReadLabel.Size = new System.Drawing.Size(111, 20);
            this.SelectReadLabel.TabIndex = 4;
            this.SelectReadLabel.Text = "Read priority";
            // 
            // SelectWriteLabel
            // 
            this.SelectWriteLabel.AutoSize = true;
            this.SelectWriteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectWriteLabel.Location = new System.Drawing.Point(43, 322);
            this.SelectWriteLabel.Name = "SelectWriteLabel";
            this.SelectWriteLabel.Size = new System.Drawing.Size(110, 20);
            this.SelectWriteLabel.TabIndex = 5;
            this.SelectWriteLabel.Text = "Write priority";
            // 
            // ReadPriorityChoosing
            // 
            this.ReadPriorityChoosing.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ReadPriorityChoosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReadPriorityChoosing.FormattingEnabled = true;
            this.ReadPriorityChoosing.Items.AddRange(new object[] {
            "Lowest",
            "BelowNormal",
            "Normal",
            "AboveNormal",
            "Highest"});
            this.ReadPriorityChoosing.Location = new System.Drawing.Point(394, 351);
            this.ReadPriorityChoosing.Name = "ReadPriorityChoosing";
            this.ReadPriorityChoosing.Size = new System.Drawing.Size(121, 28);
            this.ReadPriorityChoosing.TabIndex = 6;
            this.ReadPriorityChoosing.Text = "Select...";
            this.ReadPriorityChoosing.SelectedIndexChanged += new System.EventHandler(this.ReadPriorityChoosing_SelectedIndexChanged);
            // 
            // WritePriorityChoosing
            // 
            this.WritePriorityChoosing.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WritePriorityChoosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WritePriorityChoosing.FormattingEnabled = true;
            this.WritePriorityChoosing.Items.AddRange(new object[] {
            "Lowest",
            "BelowNormal",
            "Normal",
            "AboveNormal",
            "Highest"});
            this.WritePriorityChoosing.Location = new System.Drawing.Point(39, 351);
            this.WritePriorityChoosing.Name = "WritePriorityChoosing";
            this.WritePriorityChoosing.Size = new System.Drawing.Size(121, 28);
            this.WritePriorityChoosing.TabIndex = 7;
            this.WritePriorityChoosing.Text = "Select...";
            this.WritePriorityChoosing.SelectedIndexChanged += new System.EventHandler(this.WritePriorityChoosing_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.WritePriorityChoosing);
            this.Controls.Add(this.ReadPriorityChoosing);
            this.Controls.Add(this.SelectWriteLabel);
            this.Controls.Add(this.SelectReadLabel);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.DisplayBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DisplayBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Label SelectReadLabel;
        private System.Windows.Forms.Label SelectWriteLabel;
        private System.Windows.Forms.ComboBox ReadPriorityChoosing;
        private System.Windows.Forms.ComboBox WritePriorityChoosing;
    }
}

