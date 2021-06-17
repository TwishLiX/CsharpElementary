namespace Лабораторная_работа__3
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
            this.Box = new System.Windows.Forms.RichTextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.InitBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.labelAx = new System.Windows.Forms.Label();
            this.inputAx = new System.Windows.Forms.TextBox();
            this.inputAy = new System.Windows.Forms.TextBox();
            this.labelAy = new System.Windows.Forms.Label();
            this.inputAz = new System.Windows.Forms.TextBox();
            this.labelAz = new System.Windows.Forms.Label();
            this.inputBz = new System.Windows.Forms.TextBox();
            this.labelBz = new System.Windows.Forms.Label();
            this.inputBy = new System.Windows.Forms.TextBox();
            this.labelBy = new System.Windows.Forms.Label();
            this.inputBx = new System.Windows.Forms.TextBox();
            this.labelBx = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Font = new System.Drawing.Font("Consolas", 15F);
            this.Box.Location = new System.Drawing.Point(16, 112);
            this.Box.Name = "Box";
            this.Box.ReadOnly = true;
            this.Box.Size = new System.Drawing.Size(623, 285);
            this.Box.TabIndex = 29;
            this.Box.Text = "";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(12, 21);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(109, 23);
            this.labelA.TabIndex = 24;
            this.labelA.Text = "Vector A:";
            // 
            // InitBtn
            // 
            this.InitBtn.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitBtn.Location = new System.Drawing.Point(564, 19);
            this.InitBtn.Name = "InitBtn";
            this.InitBtn.Size = new System.Drawing.Size(75, 30);
            this.InitBtn.TabIndex = 32;
            this.InitBtn.Text = "Init";
            this.InitBtn.UseVisualStyleBackColor = true;
            this.InitBtn.Click += new System.EventHandler(this.InitBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBtn.Location = new System.Drawing.Point(564, 64);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 30);
            this.ClearBtn.TabIndex = 33;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // labelAx
            // 
            this.labelAx.AutoSize = true;
            this.labelAx.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAx.Location = new System.Drawing.Point(127, 21);
            this.labelAx.Name = "labelAx";
            this.labelAx.Size = new System.Drawing.Size(54, 23);
            this.labelAx.TabIndex = 34;
            this.labelAx.Text = "ax =";
            // 
            // inputAx
            // 
            this.inputAx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputAx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputAx.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputAx.Location = new System.Drawing.Point(187, 19);
            this.inputAx.Multiline = true;
            this.inputAx.Name = "inputAx";
            this.inputAx.Size = new System.Drawing.Size(60, 30);
            this.inputAx.TabIndex = 35;
            // 
            // inputAy
            // 
            this.inputAy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputAy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputAy.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputAy.Location = new System.Drawing.Point(319, 19);
            this.inputAy.Multiline = true;
            this.inputAy.Name = "inputAy";
            this.inputAy.Size = new System.Drawing.Size(60, 30);
            this.inputAy.TabIndex = 37;
            // 
            // labelAy
            // 
            this.labelAy.AutoSize = true;
            this.labelAy.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAy.Location = new System.Drawing.Point(259, 21);
            this.labelAy.Name = "labelAy";
            this.labelAy.Size = new System.Drawing.Size(54, 23);
            this.labelAy.TabIndex = 36;
            this.labelAy.Text = "ay =";
            // 
            // inputAz
            // 
            this.inputAz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputAz.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputAz.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputAz.Location = new System.Drawing.Point(457, 19);
            this.inputAz.Multiline = true;
            this.inputAz.Name = "inputAz";
            this.inputAz.Size = new System.Drawing.Size(60, 30);
            this.inputAz.TabIndex = 39;
            // 
            // labelAz
            // 
            this.labelAz.AutoSize = true;
            this.labelAz.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAz.Location = new System.Drawing.Point(397, 21);
            this.labelAz.Name = "labelAz";
            this.labelAz.Size = new System.Drawing.Size(54, 23);
            this.labelAz.TabIndex = 38;
            this.labelAz.Text = "az =";
            // 
            // inputBz
            // 
            this.inputBz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBz.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputBz.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBz.Location = new System.Drawing.Point(457, 64);
            this.inputBz.Multiline = true;
            this.inputBz.Name = "inputBz";
            this.inputBz.Size = new System.Drawing.Size(60, 30);
            this.inputBz.TabIndex = 46;
            // 
            // labelBz
            // 
            this.labelBz.AutoSize = true;
            this.labelBz.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBz.Location = new System.Drawing.Point(397, 66);
            this.labelBz.Name = "labelBz";
            this.labelBz.Size = new System.Drawing.Size(54, 23);
            this.labelBz.TabIndex = 45;
            this.labelBz.Text = "bz =";
            // 
            // inputBy
            // 
            this.inputBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputBy.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBy.Location = new System.Drawing.Point(319, 64);
            this.inputBy.Multiline = true;
            this.inputBy.Name = "inputBy";
            this.inputBy.Size = new System.Drawing.Size(60, 30);
            this.inputBy.TabIndex = 44;
            // 
            // labelBy
            // 
            this.labelBy.AutoSize = true;
            this.labelBy.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBy.Location = new System.Drawing.Point(259, 66);
            this.labelBy.Name = "labelBy";
            this.labelBy.Size = new System.Drawing.Size(54, 23);
            this.labelBy.TabIndex = 43;
            this.labelBy.Text = "by =";
            // 
            // inputBx
            // 
            this.inputBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputBx.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBx.Location = new System.Drawing.Point(187, 64);
            this.inputBx.Multiline = true;
            this.inputBx.Name = "inputBx";
            this.inputBx.Size = new System.Drawing.Size(60, 30);
            this.inputBx.TabIndex = 42;
            // 
            // labelBx
            // 
            this.labelBx.AutoSize = true;
            this.labelBx.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBx.Location = new System.Drawing.Point(127, 66);
            this.labelBx.Name = "labelBx";
            this.labelBx.Size = new System.Drawing.Size(54, 23);
            this.labelBx.TabIndex = 41;
            this.labelBx.Text = "bx =";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(12, 66);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(109, 23);
            this.labelB.TabIndex = 40;
            this.labelB.Text = "Vector B:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 414);
            this.Controls.Add(this.inputBz);
            this.Controls.Add(this.labelBz);
            this.Controls.Add(this.inputBy);
            this.Controls.Add(this.labelBy);
            this.Controls.Add(this.inputBx);
            this.Controls.Add(this.labelBx);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.inputAz);
            this.Controls.Add(this.labelAz);
            this.Controls.Add(this.inputAy);
            this.Controls.Add(this.labelAy);
            this.Controls.Add(this.inputAx);
            this.Controls.Add(this.labelAx);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.InitBtn);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.labelA);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Vectors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Box;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button InitBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label labelAx;
        private System.Windows.Forms.TextBox inputAx;
        private System.Windows.Forms.TextBox inputAy;
        private System.Windows.Forms.Label labelAy;
        private System.Windows.Forms.TextBox inputAz;
        private System.Windows.Forms.Label labelAz;
        private System.Windows.Forms.TextBox inputBz;
        private System.Windows.Forms.Label labelBz;
        private System.Windows.Forms.TextBox inputBy;
        private System.Windows.Forms.Label labelBy;
        private System.Windows.Forms.TextBox inputBx;
        private System.Windows.Forms.Label labelBx;
        private System.Windows.Forms.Label labelB;
    }
}

