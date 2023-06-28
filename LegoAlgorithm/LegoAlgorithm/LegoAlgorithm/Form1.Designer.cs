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
            this.label1 = new System.Windows.Forms.Label();
            this.importCSVBtn = new System.Windows.Forms.Button();
            this.BubbleSortRadio = new System.Windows.Forms.RadioButton();
            this.QuickSortRadio = new System.Windows.Forms.RadioButton();
            this.LinearSearchRadio = new System.Windows.Forms.RadioButton();
            this.BinarySearchRadio = new System.Windows.Forms.RadioButton();
            this.SentinelSearchRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SortBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ForwardTraversRadio = new System.Windows.Forms.RadioButton();
            this.BackwardsTraversRadio = new System.Windows.Forms.RadioButton();
            this.collectionChoice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chosenList = new System.Windows.Forms.Label();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose collection type";
            // 
            // importCSVBtn
            // 
            this.importCSVBtn.Location = new System.Drawing.Point(40, 528);
            this.importCSVBtn.Name = "importCSVBtn";
            this.importCSVBtn.Size = new System.Drawing.Size(118, 36);
            this.importCSVBtn.TabIndex = 4;
            this.importCSVBtn.Text = "Import CSV";
            this.importCSVBtn.UseVisualStyleBackColor = true;
            this.importCSVBtn.Click += new System.EventHandler(this.importCSVBtn_Click);
            // 
            // BubbleSortRadio
            // 
            this.BubbleSortRadio.AutoSize = true;
            this.BubbleSortRadio.Location = new System.Drawing.Point(40, 189);
            this.BubbleSortRadio.Name = "BubbleSortRadio";
            this.BubbleSortRadio.Size = new System.Drawing.Size(98, 20);
            this.BubbleSortRadio.TabIndex = 6;
            this.BubbleSortRadio.TabStop = true;
            this.BubbleSortRadio.Text = "Bubble Sort";
            this.BubbleSortRadio.UseVisualStyleBackColor = true;
            // 
            // QuickSortRadio
            // 
            this.QuickSortRadio.AutoSize = true;
            this.QuickSortRadio.Location = new System.Drawing.Point(40, 215);
            this.QuickSortRadio.Name = "QuickSortRadio";
            this.QuickSortRadio.Size = new System.Drawing.Size(89, 20);
            this.QuickSortRadio.TabIndex = 7;
            this.QuickSortRadio.TabStop = true;
            this.QuickSortRadio.Text = "Quick Sort";
            this.QuickSortRadio.UseVisualStyleBackColor = true;
            // 
            // LinearSearchRadio
            // 
            this.LinearSearchRadio.AutoSize = true;
            this.LinearSearchRadio.Location = new System.Drawing.Point(41, 385);
            this.LinearSearchRadio.Name = "LinearSearchRadio";
            this.LinearSearchRadio.Size = new System.Drawing.Size(111, 20);
            this.LinearSearchRadio.TabIndex = 8;
            this.LinearSearchRadio.TabStop = true;
            this.LinearSearchRadio.Text = "Linear Search";
            this.LinearSearchRadio.UseVisualStyleBackColor = true;
            // 
            // BinarySearchRadio
            // 
            this.BinarySearchRadio.AutoSize = true;
            this.BinarySearchRadio.Location = new System.Drawing.Point(41, 411);
            this.BinarySearchRadio.Name = "BinarySearchRadio";
            this.BinarySearchRadio.Size = new System.Drawing.Size(112, 20);
            this.BinarySearchRadio.TabIndex = 9;
            this.BinarySearchRadio.TabStop = true;
            this.BinarySearchRadio.Text = "Binary Search";
            this.BinarySearchRadio.UseVisualStyleBackColor = true;
            // 
            // SentinelSearchRadio
            // 
            this.SentinelSearchRadio.AutoSize = true;
            this.SentinelSearchRadio.Location = new System.Drawing.Point(40, 437);
            this.SentinelSearchRadio.Name = "SentinelSearchRadio";
            this.SentinelSearchRadio.Size = new System.Drawing.Size(122, 20);
            this.SentinelSearchRadio.TabIndex = 19;
            this.SentinelSearchRadio.TabStop = true;
            this.SentinelSearchRadio.Text = "Sentinel Search";
            this.SentinelSearchRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(36, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Choose sorting type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(36, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Choose search type";
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(238, 206);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(94, 39);
            this.SortBtn.TabIndex = 25;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(238, 411);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(97, 39);
            this.SearchBtn.TabIndex = 26;
            this.SearchBtn.Text = "Search for:";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // ForwardTraversRadio
            // 
            this.ForwardTraversRadio.AutoSize = true;
            this.ForwardTraversRadio.Location = new System.Drawing.Point(40, 241);
            this.ForwardTraversRadio.Name = "ForwardTraversRadio";
            this.ForwardTraversRadio.Size = new System.Drawing.Size(138, 20);
            this.ForwardTraversRadio.TabIndex = 27;
            this.ForwardTraversRadio.TabStop = true;
            this.ForwardTraversRadio.Text = "Forward Traversal";
            this.ForwardTraversRadio.UseVisualStyleBackColor = true;
            // 
            // BackwardsTraversRadio
            // 
            this.BackwardsTraversRadio.AutoSize = true;
            this.BackwardsTraversRadio.Location = new System.Drawing.Point(40, 267);
            this.BackwardsTraversRadio.Name = "BackwardsTraversRadio";
            this.BackwardsTraversRadio.Size = new System.Drawing.Size(156, 20);
            this.BackwardsTraversRadio.TabIndex = 28;
            this.BackwardsTraversRadio.TabStop = true;
            this.BackwardsTraversRadio.Text = "Backwards Traversal";
            this.BackwardsTraversRadio.UseVisualStyleBackColor = true;
            // 
            // collectionChoice
            // 
            this.collectionChoice.FormattingEnabled = true;
            this.collectionChoice.Items.AddRange(new object[] {
            "ArrayList",
            "LinkedList",
            "DoubleLinkedList"});
            this.collectionChoice.Location = new System.Drawing.Point(40, 85);
            this.collectionChoice.Name = "collectionChoice";
            this.collectionChoice.Size = new System.Drawing.Size(204, 24);
            this.collectionChoice.TabIndex = 29;
            this.collectionChoice.SelectedIndexChanged += new System.EventHandler(this.collectionChoice_SelectedIndexChanged);
            this.collectionChoice.SelectionChangeCommitted += new System.EventHandler(this.collectionChoice_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Your collection is:";
            // 
            // chosenList
            // 
            this.chosenList.AutoSize = true;
            this.chosenList.Location = new System.Drawing.Point(417, 90);
            this.chosenList.Name = "chosenList";
            this.chosenList.Size = new System.Drawing.Size(14, 16);
            this.chosenList.TabIndex = 31;
            this.chosenList.Text = "?";
            this.chosenList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(565, 103);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(496, 324);
            this.outputListBox.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 597);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.chosenList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.collectionChoice);
            this.Controls.Add(this.BackwardsTraversRadio);
            this.Controls.Add(this.ForwardTraversRadio);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuickSortRadio);
            this.Controls.Add(this.SentinelSearchRadio);
            this.Controls.Add(this.BinarySearchRadio);
            this.Controls.Add(this.LinearSearchRadio);
            this.Controls.Add(this.BubbleSortRadio);
            this.Controls.Add(this.importCSVBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importCSVBtn;
        private System.Windows.Forms.RadioButton BubbleSortRadio;
        private System.Windows.Forms.RadioButton QuickSortRadio;
        private System.Windows.Forms.RadioButton LinearSearchRadio;
        private System.Windows.Forms.RadioButton BinarySearchRadio;
        private System.Windows.Forms.RadioButton SentinelSearchRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.RadioButton ForwardTraversRadio;
        private System.Windows.Forms.RadioButton BackwardsTraversRadio;
        private System.Windows.Forms.ComboBox collectionChoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label chosenList;
        private System.Windows.Forms.ListBox outputListBox;
    }
}

