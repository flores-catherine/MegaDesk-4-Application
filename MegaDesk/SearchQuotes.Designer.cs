namespace MegaDesk
{
    partial class SearchQuotes
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
            this.returnMainMenu = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.ResultsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // returnMainMenu
            // 
            this.returnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMainMenu.Location = new System.Drawing.Point(1056, 1009);
            this.returnMainMenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.returnMainMenu.Name = "returnMainMenu";
            this.returnMainMenu.Size = new System.Drawing.Size(196, 88);
            this.returnMainMenu.TabIndex = 2;
            this.returnMainMenu.Text = "Back to Main Menu";
            this.returnMainMenu.UseVisualStyleBackColor = true;
            this.returnMainMenu.Click += new System.EventHandler(this.returnMainMenu_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(640, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(612, 88);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Quotes";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxSurfaceMaterial
            // 
            this.comboBoxSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSurfaceMaterial.FormattingEnabled = true;
            this.comboBoxSurfaceMaterial.Location = new System.Drawing.Point(28, 63);
            this.comboBoxSurfaceMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSurfaceMaterial.Name = "comboBoxSurfaceMaterial";
            this.comboBoxSurfaceMaterial.Size = new System.Drawing.Size(550, 50);
            this.comboBoxSurfaceMaterial.TabIndex = 3;
            // 
            // ResultsListView
            // 
            this.ResultsListView.Location = new System.Drawing.Point(12, 199);
            this.ResultsListView.Name = "ResultsListView";
            this.ResultsListView.Size = new System.Drawing.Size(1224, 777);
            this.ResultsListView.TabIndex = 4;
            this.ResultsListView.UseCompatibleStateImageBehavior = false;
            this.ResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 1137);
            this.Controls.Add(this.ResultsListView);
            this.Controls.Add(this.comboBoxSurfaceMaterial);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.returnMainMenu);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnMainMenu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxSurfaceMaterial;
        private System.Windows.Forms.ListView ResultsListView;
    }
}