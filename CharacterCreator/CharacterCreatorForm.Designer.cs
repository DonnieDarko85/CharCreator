namespace CharacterCreator
{
    partial class CharacterCreatorForm
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
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatsTextBox = new System.Windows.Forms.TextBox();
            this.LevelTextBox = new System.Windows.Forms.TextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.GeneratePDFButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(15, 25);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassComboBox.Sorted = true;
            this.ClassComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classe";
            // 
            // StatsTextBox
            // 
            this.StatsTextBox.AcceptsReturn = true;
            this.StatsTextBox.Location = new System.Drawing.Point(15, 52);
            this.StatsTextBox.Name = "StatsTextBox";
            this.StatsTextBox.Size = new System.Drawing.Size(168, 20);
            this.StatsTextBox.TabIndex = 2;
            this.StatsTextBox.Text = "Caratteristiche";
            // 
            // LevelTextBox
            // 
            this.LevelTextBox.Location = new System.Drawing.Point(142, 26);
            this.LevelTextBox.Name = "LevelTextBox";
            this.LevelTextBox.Size = new System.Drawing.Size(41, 20);
            this.LevelTextBox.TabIndex = 3;
            this.LevelTextBox.Text = "Livello";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(200, 23);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(93, 23);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Esporta";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // GeneratePDFButton
            // 
            this.GeneratePDFButton.Location = new System.Drawing.Point(200, 52);
            this.GeneratePDFButton.Name = "GeneratePDFButton";
            this.GeneratePDFButton.Size = new System.Drawing.Size(93, 23);
            this.GeneratePDFButton.TabIndex = 5;
            this.GeneratePDFButton.Text = "Genera Scheda";
            this.GeneratePDFButton.UseVisualStyleBackColor = true;
            // 
            // CharacterCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 85);
            this.Controls.Add(this.GeneratePDFButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.LevelTextBox);
            this.Controls.Add(this.StatsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassComboBox);
            this.Name = "CharacterCreatorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StatsTextBox;
        private System.Windows.Forms.TextBox LevelTextBox;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button GeneratePDFButton;
    }
}

