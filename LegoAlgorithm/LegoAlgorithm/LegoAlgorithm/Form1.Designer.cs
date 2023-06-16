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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Krys = new System.Windows.Forms.TabPage();
            this.Corvin = new System.Windows.Forms.TabPage();
            this.Arian = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Krys);
            this.tabControl1.Controls.Add(this.Corvin);
            this.tabControl1.Controls.Add(this.Arian);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // Krys
            // 
            this.Krys.Location = new System.Drawing.Point(4, 25);
            this.Krys.Name = "Krys";
            this.Krys.Padding = new System.Windows.Forms.Padding(3);
            this.Krys.Size = new System.Drawing.Size(787, 415);
            this.Krys.TabIndex = 0;
            this.Krys.Text = "Krys";
            this.Krys.UseVisualStyleBackColor = true;
            // 
            // Corvin
            // 
            this.Corvin.Location = new System.Drawing.Point(4, 25);
            this.Corvin.Name = "Corvin";
            this.Corvin.Padding = new System.Windows.Forms.Padding(3);
            this.Corvin.Size = new System.Drawing.Size(787, 415);
            this.Corvin.TabIndex = 1;
            this.Corvin.Text = "Corvin";
            this.Corvin.UseVisualStyleBackColor = true;
            // 
            // Arian
            // 
            this.Arian.Location = new System.Drawing.Point(4, 25);
            this.Arian.Name = "Arian";
            this.Arian.Size = new System.Drawing.Size(787, 415);
            this.Arian.TabIndex = 2;
            this.Arian.Text = "Arian";
            this.Arian.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Krys;
        private System.Windows.Forms.TabPage Corvin;
        private System.Windows.Forms.TabPage Arian;
    }
}

