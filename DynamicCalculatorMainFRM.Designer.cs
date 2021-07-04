namespace DynamicCalculator.Presentation
{
    partial class DynamicCalculatorMainFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicCalculatorMainFRM));
            this.txt_Screen = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_Addition = new System.Windows.Forms.Button();
            this.btn_Subtractiona = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_Multiplication = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Equal = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Screen
            // 
            this.txt_Screen.Font = new System.Drawing.Font("Arial", 14F);
            this.txt_Screen.Location = new System.Drawing.Point(5, 5);
            this.txt_Screen.MaxLength = 100;
            this.txt_Screen.Multiline = true;
            this.txt_Screen.Name = "txt_Screen";
            this.txt_Screen.ReadOnly = true;
            this.txt_Screen.Size = new System.Drawing.Size(208, 47);
            this.txt_Screen.TabIndex = 0;
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_1.Location = new System.Drawing.Point(5, 58);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(51, 39);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_2.Location = new System.Drawing.Point(58, 58);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(51, 39);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(111, 58);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(51, 39);
            this.btn_3.TabIndex = 3;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_Addition
            // 
            this.btn_Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Addition.Location = new System.Drawing.Point(165, 58);
            this.btn_Addition.Name = "btn_Addition";
            this.btn_Addition.Size = new System.Drawing.Size(48, 39);
            this.btn_Addition.TabIndex = 4;
            this.btn_Addition.Text = "+";
            this.btn_Addition.UseVisualStyleBackColor = true;
            this.btn_Addition.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_Subtractiona
            // 
            this.btn_Subtractiona.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Subtractiona.Location = new System.Drawing.Point(165, 102);
            this.btn_Subtractiona.Name = "btn_Subtractiona";
            this.btn_Subtractiona.Size = new System.Drawing.Size(48, 39);
            this.btn_Subtractiona.TabIndex = 8;
            this.btn_Subtractiona.Text = "-";
            this.btn_Subtractiona.UseVisualStyleBackColor = true;
            this.btn_Subtractiona.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_6.Location = new System.Drawing.Point(111, 102);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(51, 39);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_5.Location = new System.Drawing.Point(58, 102);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(51, 39);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_4.Location = new System.Drawing.Point(5, 102);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(51, 39);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_Multiplication
            // 
            this.btn_Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Multiplication.Location = new System.Drawing.Point(165, 145);
            this.btn_Multiplication.Name = "btn_Multiplication";
            this.btn_Multiplication.Size = new System.Drawing.Size(48, 39);
            this.btn_Multiplication.TabIndex = 12;
            this.btn_Multiplication.Text = "*";
            this.btn_Multiplication.UseVisualStyleBackColor = true;
            this.btn_Multiplication.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_9.Location = new System.Drawing.Point(111, 145);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(51, 39);
            this.btn_9.TabIndex = 11;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_8.Location = new System.Drawing.Point(58, 145);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(51, 39);
            this.btn_8.TabIndex = 10;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_7.Location = new System.Drawing.Point(5, 145);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(51, 39);
            this.btn_7.TabIndex = 9;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_Division
            // 
            this.btn_Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Division.Location = new System.Drawing.Point(165, 189);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(48, 39);
            this.btn_Division.TabIndex = 16;
            this.btn_Division.Text = "/";
            this.btn_Division.UseVisualStyleBackColor = true;
            this.btn_Division.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_Equal
            // 
            this.btn_Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Equal.Location = new System.Drawing.Point(111, 189);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Size = new System.Drawing.Size(51, 39);
            this.btn_Equal.TabIndex = 15;
            this.btn_Equal.Text = "=";
            this.btn_Equal.UseVisualStyleBackColor = true;
            this.btn_Equal.Click += new System.EventHandler(this.btn_Equal_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_0.Location = new System.Drawing.Point(58, 189);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(51, 39);
            this.btn_0.TabIndex = 14;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.PNumber);
            // 
            // btn_C
            // 
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_C.Location = new System.Drawing.Point(5, 189);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(51, 39);
            this.btn_C.TabIndex = 13;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            // 
            // DynamicCalculatorMainFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 234);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_Equal);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_Multiplication);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_Subtractiona);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_Addition);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.txt_Screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DynamicCalculatorMainFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Screen;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_Addition;
        private System.Windows.Forms.Button btn_Subtractiona;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_Multiplication;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_C;
    }
}

