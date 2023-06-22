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
            this.searchButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.linearSearchRadio = new System.Windows.Forms.RadioButton();
            this.binarySearchRadio = new System.Windows.Forms.RadioButton();
            this.quickSortRadio = new System.Windows.Forms.RadioButton();
            this.bubbleSortRadio = new System.Windows.Forms.RadioButton();
            this.integerInput = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(30, 322);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseMnemonic = false;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(228, 322);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 1;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // linearSearchRadio
            // 
            this.linearSearchRadio.AutoSize = true;
            this.linearSearchRadio.Location = new System.Drawing.Point(31, 197);
            this.linearSearchRadio.Name = "linearSearchRadio";
            this.linearSearchRadio.Size = new System.Drawing.Size(111, 20);
            this.linearSearchRadio.TabIndex = 2;
            this.linearSearchRadio.TabStop = true;
            this.linearSearchRadio.Text = "Linear Search";
            this.linearSearchRadio.UseVisualStyleBackColor = true;
            // 
            // binarySearchRadio
            // 
            this.binarySearchRadio.AutoSize = true;
            this.binarySearchRadio.Location = new System.Drawing.Point(30, 246);
            this.binarySearchRadio.Name = "binarySearchRadio";
            this.binarySearchRadio.Size = new System.Drawing.Size(112, 20);
            this.binarySearchRadio.TabIndex = 3;
            this.binarySearchRadio.TabStop = true;
            this.binarySearchRadio.Text = "Binary Search";
            this.binarySearchRadio.UseVisualStyleBackColor = true;
            // 
            // quickSortRadio
            // 
            this.quickSortRadio.AutoSize = true;
            this.quickSortRadio.Location = new System.Drawing.Point(228, 246);
            this.quickSortRadio.Name = "quickSortRadio";
            this.quickSortRadio.Size = new System.Drawing.Size(89, 20);
            this.quickSortRadio.TabIndex = 4;
            this.quickSortRadio.TabStop = true;
            this.quickSortRadio.Text = "Quick Sort";
            this.quickSortRadio.UseVisualStyleBackColor = true;
            // 
            // bubbleSortRadio
            // 
            this.bubbleSortRadio.AutoSize = true;
            this.bubbleSortRadio.Location = new System.Drawing.Point(228, 197);
            this.bubbleSortRadio.Name = "bubbleSortRadio";
            this.bubbleSortRadio.Size = new System.Drawing.Size(98, 20);
            this.bubbleSortRadio.TabIndex = 5;
            this.bubbleSortRadio.TabStop = true;
            this.bubbleSortRadio.Text = "Bubble Sort";
            this.bubbleSortRadio.UseVisualStyleBackColor = true;
            // 
            // integerInput
            // 
            this.integerInput.Location = new System.Drawing.Point(228, 59);
            this.integerInput.Name = "integerInput";
            this.integerInput.Size = new System.Drawing.Size(98, 22);
            this.integerInput.TabIndex = 6;
            this.integerInput.TextChanged += new System.EventHandler(this.integerInput_TextChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(526, 59);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(230, 286);
            this.richTextBox.TabIndex = 7;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.integerInput);
            this.Controls.Add(this.bubbleSortRadio);
            this.Controls.Add(this.quickSortRadio);
            this.Controls.Add(this.binarySearchRadio);
            this.Controls.Add(this.linearSearchRadio);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.RadioButton linearSearchRadio;
        private System.Windows.Forms.RadioButton binarySearchRadio;
        private System.Windows.Forms.RadioButton quickSortRadio;
        private System.Windows.Forms.RadioButton bubbleSortRadio;
        private System.Windows.Forms.TextBox integerInput;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

