namespace SquaresCalc3._5.View
{
    partial class ObjectControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.parСTextBoxLabel = new System.Windows.Forms.Label();
            this.parCTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.figureTypeComboBox = new System.Windows.Forms.ComboBox();
            this.parBTextBoxLabel = new System.Windows.Forms.Label();
            this.parATextBoxLabel = new System.Windows.Forms.Label();
            this.parBTextBox = new System.Windows.Forms.TextBox();
            this.parATextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // parСTextBoxLabel
            // 
            this.parСTextBoxLabel.AutoSize = true;
            this.parСTextBoxLabel.Location = new System.Drawing.Point(3, 87);
            this.parСTextBoxLabel.Name = "parСTextBoxLabel";
            this.parСTextBoxLabel.Size = new System.Drawing.Size(86, 17);
            this.parСTextBoxLabel.TabIndex = 18;
            this.parСTextBoxLabel.Text = "Параметр 3";
            this.parСTextBoxLabel.Visible = false;
            // 
            // parCTextBox
            // 
            this.parCTextBox.Location = new System.Drawing.Point(95, 84);
            this.parCTextBox.Name = "parCTextBox";
            this.parCTextBox.Size = new System.Drawing.Size(100, 22);
            this.parCTextBox.TabIndex = 17;
            this.parCTextBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Фигура";
            // 
            // figureTypeComboBox
            // 
            this.figureTypeComboBox.FormattingEnabled = true;
            this.figureTypeComboBox.Items.AddRange(new object[] {
            "Треугольник",
            "Квадрат",
            "Круг"});
            this.figureTypeComboBox.Location = new System.Drawing.Point(74, 3);
            this.figureTypeComboBox.Name = "figureTypeComboBox";
            this.figureTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.figureTypeComboBox.TabIndex = 15;
            this.figureTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.figureTypeComboBox_SelectedIndexChanged);
            // 
            // parBTextBoxLabel
            // 
            this.parBTextBoxLabel.AutoSize = true;
            this.parBTextBoxLabel.Location = new System.Drawing.Point(3, 61);
            this.parBTextBoxLabel.Name = "parBTextBoxLabel";
            this.parBTextBoxLabel.Size = new System.Drawing.Size(86, 17);
            this.parBTextBoxLabel.TabIndex = 14;
            this.parBTextBoxLabel.Text = "Параметр 2";
            // 
            // parATextBoxLabel
            // 
            this.parATextBoxLabel.AutoSize = true;
            this.parATextBoxLabel.Location = new System.Drawing.Point(3, 36);
            this.parATextBoxLabel.Name = "parATextBoxLabel";
            this.parATextBoxLabel.Size = new System.Drawing.Size(86, 17);
            this.parATextBoxLabel.TabIndex = 13;
            this.parATextBoxLabel.Text = "Параметр 1";
            // 
            // parBTextBox
            // 
            this.parBTextBox.Location = new System.Drawing.Point(95, 58);
            this.parBTextBox.Name = "parBTextBox";
            this.parBTextBox.Size = new System.Drawing.Size(100, 22);
            this.parBTextBox.TabIndex = 12;
            // 
            // parATextBox
            // 
            this.parATextBox.Location = new System.Drawing.Point(95, 33);
            this.parATextBox.Name = "parATextBox";
            this.parATextBox.Size = new System.Drawing.Size(100, 22);
            this.parATextBox.TabIndex = 11;
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.parСTextBoxLabel);
            this.Controls.Add(this.parCTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.figureTypeComboBox);
            this.Controls.Add(this.parBTextBoxLabel);
            this.Controls.Add(this.parATextBoxLabel);
            this.Controls.Add(this.parBTextBox);
            this.Controls.Add(this.parATextBox);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(204, 112);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label parСTextBoxLabel;
        private System.Windows.Forms.TextBox parCTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox figureTypeComboBox;
        private System.Windows.Forms.Label parBTextBoxLabel;
        private System.Windows.Forms.Label parATextBoxLabel;
        private System.Windows.Forms.TextBox parBTextBox;
        private System.Windows.Forms.TextBox parATextBox;
    }
}
