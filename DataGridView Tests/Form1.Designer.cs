namespace DataGridView_Tests
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
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._changeButton = new System.Windows.Forms.Button();
            this._sortButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 2;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel.Controls.Add(this._changeButton, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._sortButton, 1, 1);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 2;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(284, 261);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _changeButton
            // 
            this._changeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._changeButton.Location = new System.Drawing.Point(3, 224);
            this._changeButton.Name = "_changeButton";
            this._changeButton.Size = new System.Drawing.Size(136, 34);
            this._changeButton.TabIndex = 0;
            this._changeButton.Text = "Change Values";
            this._changeButton.UseVisualStyleBackColor = true;
            this._changeButton.Click += new System.EventHandler(this._changeButton_Click);
            // 
            // _sortButton
            // 
            this._sortButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sortButton.Location = new System.Drawing.Point(145, 224);
            this._sortButton.Name = "_sortButton";
            this._sortButton.Size = new System.Drawing.Size(136, 34);
            this._sortButton.TabIndex = 1;
            this._sortButton.Text = "Sort";
            this._sortButton.UseVisualStyleBackColor = true;
            this._sortButton.Click += new System.EventHandler(this._sortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this._tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Button _changeButton;
        private System.Windows.Forms.Button _sortButton;
    }
}

