namespace MegaDesk
{
    partial class AddQuote
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
            this.label2 = new System.Windows.Forms.Label();
            this.calcQuote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelQuote = new System.Windows.Forms.Button();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumDrawersComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioRush7 = new System.Windows.Forms.RadioButton();
            this.radioRush5 = new System.Windows.Forms.RadioButton();
            this.radioRush3 = new System.Windows.Forms.RadioButton();
            this.noRush = new System.Windows.Forms.RadioButton();
            this.MessageBox = new System.Windows.Forms.Label();
            this.DisplayDeskQuote = new System.Windows.Forms.Label();
            this.ThankYouMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 495);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 592);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Depth";
            // 
            // calcQuote
            // 
            this.calcQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcQuote.Location = new System.Drawing.Point(70, 709);
            this.calcQuote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calcQuote.Name = "calcQuote";
            this.calcQuote.Size = new System.Drawing.Size(507, 58);
            this.calcQuote.TabIndex = 10;
            this.calcQuote.Text = "Calculate Quote";
            this.calcQuote.UseVisualStyleBackColor = true;
            this.calcQuote.Click += new System.EventHandler(this.CalcQuote_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fill in the information to calculate quote.";
            // 
            // cancelQuote
            // 
            this.cancelQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuote.Location = new System.Drawing.Point(654, 709);
            this.cancelQuote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelQuote.Name = "cancelQuote";
            this.cancelQuote.Size = new System.Drawing.Size(238, 58);
            this.cancelQuote.TabIndex = 11;
            this.cancelQuote.Text = "Cancel";
            this.cancelQuote.UseVisualStyleBackColor = true;
            this.cancelQuote.Click += new System.EventHandler(this.cancelQuote_Click);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthTextBox.Location = new System.Drawing.Point(396, 486);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(178, 44);
            this.WidthTextBox.TabIndex = 4;
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthBox_Validating);
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthTextBox.Location = new System.Drawing.Point(398, 583);
            this.DepthTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(178, 44);
            this.DepthTextBox.TabIndex = 5;
            this.DepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Customer";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerName.Location = new System.Drawing.Point(392, 115);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(499, 44);
            this.textBoxCustomerName.TabIndex = 1;
            this.textBoxCustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.WidthBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number of Drawers";
            // 
            // NumDrawersComboBox
            // 
            this.NumDrawersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDrawersComboBox.FormattingEnabled = true;
            this.NumDrawersComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.NumDrawersComboBox.Location = new System.Drawing.Point(394, 388);
            this.NumDrawersComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumDrawersComboBox.Name = "NumDrawersComboBox";
            this.NumDrawersComboBox.Size = new System.Drawing.Size(180, 45);
            this.NumDrawersComboBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Surface Material";
            // 
            // comboBoxSurfaceMaterial
            // 
            this.comboBoxSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSurfaceMaterial.FormattingEnabled = true;
            this.comboBoxSurfaceMaterial.Location = new System.Drawing.Point(396, 291);
            this.comboBoxSurfaceMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSurfaceMaterial.Name = "comboBoxSurfaceMaterial";
            this.comboBoxSurfaceMaterial.Size = new System.Drawing.Size(180, 45);
            this.comboBoxSurfaceMaterial.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioRush7);
            this.groupBox1.Controls.Add(this.radioRush5);
            this.groupBox1.Controls.Add(this.radioRush3);
            this.groupBox1.Controls.Add(this.noRush);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(654, 291);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(238, 342);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rush Order";
            // 
            // radioRush7
            // 
            this.radioRush7.AutoSize = true;
            this.radioRush7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRush7.Location = new System.Drawing.Point(28, 275);
            this.radioRush7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioRush7.Name = "radioRush7";
            this.radioRush7.Size = new System.Drawing.Size(110, 33);
            this.radioRush7.TabIndex = 9;
            this.radioRush7.TabStop = true;
            this.radioRush7.Text = "7 Days";
            this.radioRush7.UseVisualStyleBackColor = true;
            // 
            // radioRush5
            // 
            this.radioRush5.AutoSize = true;
            this.radioRush5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRush5.Location = new System.Drawing.Point(28, 206);
            this.radioRush5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioRush5.Name = "radioRush5";
            this.radioRush5.Size = new System.Drawing.Size(110, 33);
            this.radioRush5.TabIndex = 8;
            this.radioRush5.TabStop = true;
            this.radioRush5.Text = "5 Days";
            this.radioRush5.UseVisualStyleBackColor = true;
            // 
            // radioRush3
            // 
            this.radioRush3.AutoSize = true;
            this.radioRush3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRush3.Location = new System.Drawing.Point(28, 137);
            this.radioRush3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioRush3.Name = "radioRush3";
            this.radioRush3.Size = new System.Drawing.Size(110, 33);
            this.radioRush3.TabIndex = 7;
            this.radioRush3.TabStop = true;
            this.radioRush3.Text = "3 Days";
            this.radioRush3.UseVisualStyleBackColor = true;
            // 
            // noRush
            // 
            this.noRush.AutoSize = true;
            this.noRush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRush.Location = new System.Drawing.Point(28, 68);
            this.noRush.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noRush.Name = "noRush";
            this.noRush.Size = new System.Drawing.Size(97, 33);
            this.noRush.TabIndex = 6;
            this.noRush.TabStop = true;
            this.noRush.Text = "None";
            this.noRush.UseVisualStyleBackColor = true;
            // 
            // MessageBox
            // 
            this.MessageBox.AutoSize = true;
            this.MessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.Location = new System.Drawing.Point(70, 233);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(0, 29);
            this.MessageBox.TabIndex = 7;
            // 
            // DisplayDeskQuote
            // 
            this.DisplayDeskQuote.AutoSize = true;
            this.DisplayDeskQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayDeskQuote.Location = new System.Drawing.Point(77, 873);
            this.DisplayDeskQuote.Name = "DisplayDeskQuote";
            this.DisplayDeskQuote.Size = new System.Drawing.Size(0, 25);
            this.DisplayDeskQuote.TabIndex = 8;
            // 
            // ThankYouMessage
            // 
            this.ThankYouMessage.AutoSize = true;
            this.ThankYouMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYouMessage.Location = new System.Drawing.Point(77, 803);
            this.ThankYouMessage.Name = "ThankYouMessage";
            this.ThankYouMessage.Size = new System.Drawing.Size(0, 29);
            this.ThankYouMessage.TabIndex = 9;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 923);
            this.Controls.Add(this.ThankYouMessage);
            this.Controls.Add(this.DisplayDeskQuote);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSurfaceMaterial);
            this.Controls.Add(this.NumDrawersComboBox);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelQuote);
            this.Controls.Add(this.calcQuote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddQuote";
            this.Text = "a";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcQuote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelQuote;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NumDrawersComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSurfaceMaterial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioRush7;
        private System.Windows.Forms.RadioButton radioRush5;
        private System.Windows.Forms.RadioButton radioRush3;
        private System.Windows.Forms.RadioButton noRush;
        private System.Windows.Forms.Label MessageBox;
        private System.Windows.Forms.Label DisplayDeskQuote;
        private System.Windows.Forms.Label ThankYouMessage;
    }
}