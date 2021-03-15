namespace Fractal1
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
            this.treepanel = new System.Windows.Forms.Panel();
            this.txtforN = new System.Windows.Forms.TextBox();
            this.acceptbtn = new System.Windows.Forms.Button();
            this.labelforN = new System.Windows.Forms.Label();
            this.checkbranch1 = new System.Windows.Forms.CheckBox();
            this.checkbranch2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // treepanel
            // 
            this.treepanel.Location = new System.Drawing.Point(0, 0);
            this.treepanel.Name = "treepanel";
            this.treepanel.Size = new System.Drawing.Size(551, 407);
            this.treepanel.TabIndex = 0;
            this.treepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.treepanel_Paint);
            // 
            // txtforN
            // 
            this.txtforN.Location = new System.Drawing.Point(607, 44);
            this.txtforN.Name = "txtforN";
            this.txtforN.Size = new System.Drawing.Size(95, 20);
            this.txtforN.TabIndex = 1;
            this.txtforN.Text = "20";
            // 
            // acceptbtn
            // 
            this.acceptbtn.Location = new System.Drawing.Point(607, 116);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(95, 66);
            this.acceptbtn.TabIndex = 2;
            this.acceptbtn.Text = "Принять";
            this.acceptbtn.UseVisualStyleBackColor = true;
            this.acceptbtn.Click += new System.EventHandler(this.acceptbtn_Click);
            // 
            // labelforN
            // 
            this.labelforN.AutoSize = true;
            this.labelforN.Location = new System.Drawing.Point(607, 25);
            this.labelforN.Name = "labelforN";
            this.labelforN.Size = new System.Drawing.Size(61, 13);
            this.labelforN.TabIndex = 3;
            this.labelforN.Text = "Введите n:";
            // 
            // checkbranch1
            // 
            this.checkbranch1.AutoSize = true;
            this.checkbranch1.Location = new System.Drawing.Point(607, 70);
            this.checkbranch1.Name = "checkbranch1";
            this.checkbranch1.Size = new System.Drawing.Size(88, 17);
            this.checkbranch1.TabIndex = 4;
            this.checkbranch1.Text = "изменение1";
            this.checkbranch1.UseVisualStyleBackColor = true;
            // 
            // checkbranch2
            // 
            this.checkbranch2.AutoSize = true;
            this.checkbranch2.Location = new System.Drawing.Point(607, 93);
            this.checkbranch2.Name = "checkbranch2";
            this.checkbranch2.Size = new System.Drawing.Size(88, 17);
            this.checkbranch2.TabIndex = 5;
            this.checkbranch2.Text = "изменение2";
            this.checkbranch2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkbranch2);
            this.Controls.Add(this.checkbranch1);
            this.Controls.Add(this.labelforN);
            this.Controls.Add(this.acceptbtn);
            this.Controls.Add(this.txtforN);
            this.Controls.Add(this.treepanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel treepanel;
        private System.Windows.Forms.TextBox txtforN;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.Label labelforN;
        private System.Windows.Forms.CheckBox checkbranch1;
        private System.Windows.Forms.CheckBox checkbranch2;
    }
}

