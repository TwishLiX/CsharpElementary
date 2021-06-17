namespace Лабораторная_работа__2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NLabel = new System.Windows.Forms.Label();
            this.InputN = new System.Windows.Forms.TextBox();
            this.InputM = new System.Windows.Forms.TextBox();
            this.MLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.NBox = new System.Windows.Forms.RichTextBox();
            this.MBox = new System.Windows.Forms.RichTextBox();
            this.NLabel2 = new System.Windows.Forms.Label();
            this.MLabel2 = new System.Windows.Forms.Label();
            this.MinMaxBox = new System.Windows.Forms.RichTextBox();
            this.RepetitionsBox = new System.Windows.Forms.RichTextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NLabel.Location = new System.Drawing.Point(133, 17);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(203, 24);
            this.NLabel.TabIndex = 0;
            this.NLabel.Text = "Amount of triangles:";
            // 
            // InputN
            // 
            this.InputN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputN.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputN.Location = new System.Drawing.Point(392, 14);
            this.InputN.Multiline = true;
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(68, 25);
            this.InputN.TabIndex = 13;
            this.InputN.Text = "0";
            // 
            // InputM
            // 
            this.InputM.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputM.Location = new System.Drawing.Point(392, 52);
            this.InputM.Multiline = true;
            this.InputM.Name = "InputM";
            this.InputM.Size = new System.Drawing.Size(68, 25);
            this.InputM.TabIndex = 15;
            this.InputM.Text = "0";
            // 
            // MLabel
            // 
            this.MLabel.AutoSize = true;
            this.MLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLabel.Location = new System.Drawing.Point(133, 55);
            this.MLabel.Name = "MLabel";
            this.MLabel.Size = new System.Drawing.Size(253, 24);
            this.MLabel.TabIndex = 14;
            this.MLabel.Text = "Amount of right triangles:";
            // 
            // StartBtn
            // 
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.Location = new System.Drawing.Point(486, 26);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(105, 38);
            this.StartBtn.TabIndex = 16;
            this.StartBtn.Text = "GO";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // NBox
            // 
            this.NBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBox.Location = new System.Drawing.Point(16, 135);
            this.NBox.Name = "NBox";
            this.NBox.ReadOnly = true;
            this.NBox.Size = new System.Drawing.Size(384, 236);
            this.NBox.TabIndex = 17;
            this.NBox.Text = "";
            // 
            // MBox
            // 
            this.MBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBox.Location = new System.Drawing.Point(447, 135);
            this.MBox.Name = "MBox";
            this.MBox.ReadOnly = true;
            this.MBox.Size = new System.Drawing.Size(384, 236);
            this.MBox.TabIndex = 18;
            this.MBox.Text = "";
            // 
            // NLabel2
            // 
            this.NLabel2.AutoSize = true;
            this.NLabel2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NLabel2.Location = new System.Drawing.Point(159, 108);
            this.NLabel2.Name = "NLabel2";
            this.NLabel2.Size = new System.Drawing.Size(97, 24);
            this.NLabel2.TabIndex = 19;
            this.NLabel2.Text = "Triangles";
            // 
            // MLabel2
            // 
            this.MLabel2.AutoSize = true;
            this.MLabel2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLabel2.Location = new System.Drawing.Point(565, 108);
            this.MLabel2.Name = "MLabel2";
            this.MLabel2.Size = new System.Drawing.Size(148, 24);
            this.MLabel2.TabIndex = 20;
            this.MLabel2.Text = "Right triangles";
            // 
            // MinMaxBox
            // 
            this.MinMaxBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinMaxBox.Location = new System.Drawing.Point(16, 399);
            this.MinMaxBox.Name = "MinMaxBox";
            this.MinMaxBox.ReadOnly = true;
            this.MinMaxBox.Size = new System.Drawing.Size(384, 96);
            this.MinMaxBox.TabIndex = 21;
            this.MinMaxBox.Text = "";
            // 
            // RepetitionsBox
            // 
            this.RepetitionsBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepetitionsBox.Location = new System.Drawing.Point(447, 399);
            this.RepetitionsBox.Name = "RepetitionsBox";
            this.RepetitionsBox.ReadOnly = true;
            this.RepetitionsBox.Size = new System.Drawing.Size(384, 96);
            this.RepetitionsBox.TabIndex = 22;
            this.RepetitionsBox.Text = "";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBtn.Location = new System.Drawing.Point(608, 26);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(105, 38);
            this.ClearBtn.TabIndex = 23;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(853, 519);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RepetitionsBox);
            this.Controls.Add(this.MinMaxBox);
            this.Controls.Add(this.MLabel2);
            this.Controls.Add(this.NLabel2);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.InputM);
            this.Controls.Add(this.MLabel);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.NLabel);
            this.Font = new System.Drawing.Font("Magneto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Triangles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.TextBox InputN;
        private System.Windows.Forms.TextBox InputM;
        private System.Windows.Forms.Label MLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.RichTextBox NBox;
        private System.Windows.Forms.RichTextBox MBox;
        private System.Windows.Forms.Label NLabel2;
        private System.Windows.Forms.Label MLabel2;
        private System.Windows.Forms.RichTextBox MinMaxBox;
        private System.Windows.Forms.RichTextBox RepetitionsBox;
        private System.Windows.Forms.Button ClearBtn;
    }
}

