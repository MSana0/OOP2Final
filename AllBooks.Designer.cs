namespace FinalTermAssignment
{
    partial class AllBooks
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
            this.components = new System.ComponentModel.Container();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(275, 83);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 22);
            this.searchTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(189, 86);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(80, 17);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search Box";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(540, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(169, 146);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(478, 174);
            this.richTextBoxInfo.TabIndex = 4;
            this.richTextBoxInfo.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 155);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Name = "AllBooks";
            this.Text = "AllBooks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}