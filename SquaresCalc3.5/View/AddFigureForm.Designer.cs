using System.ComponentModel;
using System.Windows.Forms;

namespace SquaresCalc3._5.View
{
    partial class AddFigureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.addShapeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addShapePropertiesObjectControl = new SquaresCalc3._5.View.ObjectControl();
#if DEBUG
            this.addRandomDataButton = new System.Windows.Forms.Button();
#endif
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addShapeButton
            // 
            this.addShapeButton.Enabled = false;
            this.addShapeButton.Location = new System.Drawing.Point(9, 140);
            this.addShapeButton.Name = "addShapeButton";
            this.addShapeButton.Size = new System.Drawing.Size(235, 35);
            this.addShapeButton.TabIndex = 6;
            this.addShapeButton.Text = "Добавить";
            this.addShapeButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addShapePropertiesObjectControl);
#if DEBUG
            this.groupBox1.Controls.Add(this.addRandomDataButton);
#endif
            this.groupBox1.Controls.Add(this.addShapeButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 185);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рабочая область";
            // 
            // addShapePropertiesObjectControl
            // 
            this.addShapePropertiesObjectControl.FigureTypeComboBoxSelectedIndex = -1;
            this.addShapePropertiesObjectControl.Location = new System.Drawing.Point(9, 21);
            this.addShapePropertiesObjectControl.Name = "addShapePropertiesObjectControl";
            this.addShapePropertiesObjectControl.ParATextBoxText = "";
            this.addShapePropertiesObjectControl.ParBTextBoxText = "";
            this.addShapePropertiesObjectControl.ParCTextBoxText = "";
            this.addShapePropertiesObjectControl.Size = new System.Drawing.Size(204, 112);
            this.addShapePropertiesObjectControl.TabIndex = 12;
            // 
            // addRandomDataButton
            // 
#if DEBUG
            this.addRandomDataButton.Location = new System.Drawing.Point(9, 181);
            this.addRandomDataButton.Name = "addRandomDataButton";
            this.addRandomDataButton.Size = new System.Drawing.Size(235, 35);
            this.addRandomDataButton.TabIndex = 11;
            this.addRandomDataButton.Text = "Добавить случайные данные";
            this.addRandomDataButton.UseVisualStyleBackColor = true;
            this.addRandomDataButton.Click += new System.EventHandler(this.addRandomDataButton_Click);
#endif
            // 
            // AddFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(284, 205);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddFigureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить фигуру";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFigureForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

#endregion
        private Button addShapeButton;
        private GroupBox groupBox1;
#if DEBUG
        private Button addRandomDataButton;
#endif
        private ObjectControl addShapePropertiesObjectControl;
    }
}

