namespace MegaDesk
{
    partial class ViewAllQuotes
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
            this.SuspendLayout();
            // 
            // returnMainMenu
            // 
            this.returnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMainMenu.Location = new System.Drawing.Point(37, 240);
            this.returnMainMenu.Name = "returnMainMenu";
            this.returnMainMenu.Size = new System.Drawing.Size(242, 56);
            this.returnMainMenu.TabIndex = 0;
            this.returnMainMenu.Text = "Back to Main Menu";
            this.returnMainMenu.UseVisualStyleBackColor = true;
            this.returnMainMenu.Click += new System.EventHandler(this.returnMainMenu_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 342);
            this.Controls.Add(this.returnMainMenu);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnMainMenu;
    }
}