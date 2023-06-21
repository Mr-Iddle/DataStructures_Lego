namespace LegoAlgorithm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.result_TB = new System.Windows.Forms.RichTextBox();
            this.import_bttn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.sort_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result_TB
            // 
            this.result_TB.Location = new System.Drawing.Point(272, 82);
            this.result_TB.Name = "result_TB";
            this.result_TB.Size = new System.Drawing.Size(499, 307);
            this.result_TB.TabIndex = 0;
            this.result_TB.Text = "";
            // 
            // import_bttn
            // 
            this.import_bttn.Location = new System.Drawing.Point(150, 366);
            this.import_bttn.Name = "import_bttn";
            this.import_bttn.Size = new System.Drawing.Size(84, 35);
            this.import_bttn.TabIndex = 1;
            this.import_bttn.Text = "Import Csv";
            this.import_bttn.UseVisualStyleBackColor = true;
            this.import_bttn.Click += new System.EventHandler(this.import_bttn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(85, 123);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "quicksort_radio";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // sort_bttn
            // 
            this.sort_bttn.Location = new System.Drawing.Point(36, 366);
            this.sort_bttn.Name = "sort_bttn";
            this.sort_bttn.Size = new System.Drawing.Size(80, 36);
            this.sort_bttn.TabIndex = 3;
            this.sort_bttn.Text = "Sort";
            this.sort_bttn.UseVisualStyleBackColor = true;
            this.sort_bttn.Click += new System.EventHandler(this.sort_bttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sort_bttn);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.import_bttn);
            this.Controls.Add(this.result_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox result_TB;
        private System.Windows.Forms.Button import_bttn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button sort_bttn;
    }
}

