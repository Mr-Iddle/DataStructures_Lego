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
            this.bubble_radio = new System.Windows.Forms.RadioButton();
            this.linear_bttn = new System.Windows.Forms.RadioButton();
            this.binary_bttn = new System.Windows.Forms.RadioButton();
            this.input_txt = new System.Windows.Forms.TextBox();
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
            this.radioButton1.Location = new System.Drawing.Point(36, 273);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "quicksort_radio";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // sort_bttn
            // 
            this.sort_bttn.Location = new System.Drawing.Point(36, 336);
            this.sort_bttn.Name = "sort_bttn";
            this.sort_bttn.Size = new System.Drawing.Size(108, 66);
            this.sort_bttn.TabIndex = 3;
            this.sort_bttn.Text = "Sort";
            this.sort_bttn.UseVisualStyleBackColor = true;
            this.sort_bttn.Click += new System.EventHandler(this.sort_bttn_Click);
            // 
            // bubble_radio
            // 
            this.bubble_radio.AutoSize = true;
            this.bubble_radio.Location = new System.Drawing.Point(36, 247);
            this.bubble_radio.Name = "bubble_radio";
            this.bubble_radio.Size = new System.Drawing.Size(137, 20);
            this.bubble_radio.TabIndex = 4;
            this.bubble_radio.TabStop = true;
            this.bubble_radio.Text = "bubble_sort_radio";
            this.bubble_radio.UseVisualStyleBackColor = true;
            // 
            // linear_bttn
            // 
            this.linear_bttn.AutoSize = true;
            this.linear_bttn.Location = new System.Drawing.Point(36, 221);
            this.linear_bttn.Name = "linear_bttn";
            this.linear_bttn.Size = new System.Drawing.Size(147, 20);
            this.linear_bttn.TabIndex = 5;
            this.linear_bttn.TabStop = true;
            this.linear_bttn.Text = "linear_search_radio";
            this.linear_bttn.UseVisualStyleBackColor = true;
            // 
            // binary_bttn
            // 
            this.binary_bttn.AutoSize = true;
            this.binary_bttn.Location = new System.Drawing.Point(36, 195);
            this.binary_bttn.Name = "binary_bttn";
            this.binary_bttn.Size = new System.Drawing.Size(151, 20);
            this.binary_bttn.TabIndex = 6;
            this.binary_bttn.TabStop = true;
            this.binary_bttn.Text = "binary_search_radio";
            this.binary_bttn.UseVisualStyleBackColor = true;
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(49, 28);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(220, 22);
            this.input_txt.TabIndex = 7;
            this.input_txt.TextChanged += new System.EventHandler(this.input_txt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.input_txt);
            this.Controls.Add(this.binary_bttn);
            this.Controls.Add(this.linear_bttn);
            this.Controls.Add(this.bubble_radio);
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
        private System.Windows.Forms.RadioButton bubble_radio;
        private System.Windows.Forms.RadioButton linear_bttn;
        private System.Windows.Forms.RadioButton binary_bttn;
        private System.Windows.Forms.TextBox input_txt;
    }
}

