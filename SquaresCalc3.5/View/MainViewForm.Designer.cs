using System.ComponentModel;
using System.Windows.Forms;

namespace SquaresCalc3._5.View
{
    partial class MainViewForm
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
            this.workspaceGroupBox = new System.Windows.Forms.GroupBox();
            this.showShapePropertiesObjectControl = new SquaresCalc3._5.View.ObjectControl();
            this.callModifyFigureFormButton = new System.Windows.Forms.Button();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.removeFigureButton = new System.Windows.Forms.Button();
            this.callAddFigureFormButton = new System.Windows.Forms.Button();
            this.shapesDataGridView = new System.Windows.Forms.DataGridView();
            this.workspaceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workspaceGroupBox
            // 
            this.workspaceGroupBox.Controls.Add(this.showShapePropertiesObjectControl);
            this.workspaceGroupBox.Controls.Add(this.callModifyFigureFormButton);
            this.workspaceGroupBox.Controls.Add(this.saveDataButton);
            this.workspaceGroupBox.Controls.Add(this.loadDataButton);
            this.workspaceGroupBox.Controls.Add(this.searchLabel);
            this.workspaceGroupBox.Controls.Add(this.SearchTextBox);
            this.workspaceGroupBox.Controls.Add(this.removeFigureButton);
            this.workspaceGroupBox.Controls.Add(this.callAddFigureFormButton);
            this.workspaceGroupBox.Controls.Add(this.shapesDataGridView);
            this.workspaceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workspaceGroupBox.Location = new System.Drawing.Point(12, 12);
            this.workspaceGroupBox.Name = "workspaceGroupBox";
            this.workspaceGroupBox.Size = new System.Drawing.Size(969, 439);
            this.workspaceGroupBox.TabIndex = 0;
            this.workspaceGroupBox.TabStop = false;
            this.workspaceGroupBox.Text = "Рабочая область";
            // 
            // showShapePropertiesObjectControl
            // 
            this.showShapePropertiesObjectControl.FigureTypeComboBoxSelectedIndex = -1;
            this.showShapePropertiesObjectControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showShapePropertiesObjectControl.Location = new System.Drawing.Point(761, 57);
            this.showShapePropertiesObjectControl.Margin = new System.Windows.Forms.Padding(4);
            this.showShapePropertiesObjectControl.Name = "showShapePropertiesObjectControl";
            this.showShapePropertiesObjectControl.ParATextBoxText = "";
            this.showShapePropertiesObjectControl.ParBTextBoxText = "";
            this.showShapePropertiesObjectControl.ParCTextBoxText = "";
            this.showShapePropertiesObjectControl.Size = new System.Drawing.Size(201, 120);
            this.showShapePropertiesObjectControl.TabIndex = 7;
            // 
            // callModifyFigureFormButton
            // 
            this.callModifyFigureFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.callModifyFigureFormButton.Location = new System.Drawing.Point(195, 403);
            this.callModifyFigureFormButton.Name = "callModifyFigureFormButton";
            this.callModifyFigureFormButton.Size = new System.Drawing.Size(183, 30);
            this.callModifyFigureFormButton.TabIndex = 6;
            this.callModifyFigureFormButton.Text = "Изменить фигуру";
            this.callModifyFigureFormButton.UseVisualStyleBackColor = true;
            this.callModifyFigureFormButton.Click += new System.EventHandler(this.CallModifyFigureFormButton_Click);
            // 
            // saveDataButton
            // 
            this.saveDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDataButton.Location = new System.Drawing.Point(573, 403);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(183, 30);
            this.saveDataButton.TabIndex = 3;
            this.saveDataButton.Text = "Сохранить данные";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // loadDataButton
            // 
            this.loadDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadDataButton.Location = new System.Drawing.Point(762, 403);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(183, 30);
            this.loadDataButton.TabIndex = 4;
            this.loadDataButton.Text = "Загрузить данные";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.Location = new System.Drawing.Point(7, 25);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(74, 25);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Поиск:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(87, 25);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(667, 26);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // removeFigureButton
            // 
            this.removeFigureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeFigureButton.Location = new System.Drawing.Point(384, 403);
            this.removeFigureButton.Name = "removeFigureButton";
            this.removeFigureButton.Size = new System.Drawing.Size(183, 30);
            this.removeFigureButton.TabIndex = 2;
            this.removeFigureButton.Text = "Удалить фигуру";
            this.removeFigureButton.UseVisualStyleBackColor = true;
            this.removeFigureButton.Click += new System.EventHandler(this.RemoveFigureButton_Click);
            // 
            // callAddFigureFormButton
            // 
            this.callAddFigureFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.callAddFigureFormButton.Location = new System.Drawing.Point(6, 403);
            this.callAddFigureFormButton.Name = "callAddFigureFormButton";
            this.callAddFigureFormButton.Size = new System.Drawing.Size(183, 30);
            this.callAddFigureFormButton.TabIndex = 1;
            this.callAddFigureFormButton.Text = "Добавить фигуру";
            this.callAddFigureFormButton.UseVisualStyleBackColor = true;
            this.callAddFigureFormButton.Click += new System.EventHandler(this.AddFigureButton_Click);
            // 
            // shapesDataGridView
            // 
            this.shapesDataGridView.AllowUserToResizeColumns = false;
            this.shapesDataGridView.AllowUserToResizeRows = false;
            this.shapesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shapesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shapesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.shapesDataGridView.Location = new System.Drawing.Point(6, 57);
            this.shapesDataGridView.Name = "shapesDataGridView";
            this.shapesDataGridView.ReadOnly = true;
            this.shapesDataGridView.RowTemplate.Height = 24;
            this.shapesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shapesDataGridView.Size = new System.Drawing.Size(748, 341);
            this.shapesDataGridView.TabIndex = 5;
            this.shapesDataGridView.SelectionChanged += new System.EventHandler(this.ShapesDataGridView_SelectionChanged);
            // 
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 463);
            this.Controls.Add(this.workspaceGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рассчет площадей простых фигур 2.0";
            this.Load += new System.EventHandler(this.MainViewForm_Load);
            this.workspaceGroupBox.ResumeLayout(false);
            this.workspaceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox workspaceGroupBox;
        private DataGridView shapesDataGridView;
        private Button removeFigureButton;
        private Button callAddFigureFormButton;
        private TextBox SearchTextBox;
        private Label searchLabel;
        private Button saveDataButton;
        private Button loadDataButton;
        private Button callModifyFigureFormButton;
        private ObjectControl showShapePropertiesObjectControl;
    }
}

