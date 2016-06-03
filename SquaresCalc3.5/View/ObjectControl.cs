using System;
using System.Windows.Forms;

namespace SquaresCalc3._5.View
{
    /// <summary>
    /// Пользовательский контрол с комбобоксом типа фигуры и текстбоксами для ввода параметров фигуры
    /// </summary>
    public partial class ObjectControl : UserControl
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public ObjectControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свойство для задания/получения значения первого текстбокса
        /// </summary>
        public string ParATextBoxText
        {
            get { return parATextBox.Text; }
            set { parATextBox.Text = value; }
        }

        /// <summary>
        /// Свойство для задания/получения значения второго текстбокса
        /// </summary>
        public string ParBTextBoxText
        {
            get { return parBTextBox.Text; }
            set { parBTextBox.Text = value; }
        }

        /// <summary>
        /// Свойство для задания/получения значения третьего текстбокса
        /// </summary>
        public string ParCTextBoxText
        {
            get { return parCTextBox.Text; }
            set { parCTextBox.Text = value; }
        }

        /// <summary>
        /// Свойство для задания/получения значения комбобокса выбора фигуры
        /// </summary>
        public int FigureTypeComboBoxSelectedIndex
        {
            get { return figureTypeComboBox.SelectedIndex; }
            set { figureTypeComboBox.SelectedIndex = value; }
        }

        /// <summary>
        /// Свойство для включения/выключения контролов
        /// </summary>
        public bool ControlsEnabled
        {
            set { parATextBox.Enabled = parBTextBox.Enabled = parCTextBox.Enabled = figureTypeComboBox.Enabled = value; }
        }

        /// <summary>
        /// Специфическое изменения состояния контролов для квадрата
        /// </summary>
        public void ParametrsAreaSetTo(string parATextBoxLabelValue, string parBTextBoxLabelValue)
        {
            parATextBoxLabel.Text = parATextBoxLabelValue;
            parBTextBoxLabel.Text = parBTextBoxLabelValue;
            parATextBox.Clear();
            parBTextBox.Clear();
            parATextBox.Enabled = true;
            parBTextBox.Enabled = true;
            parCTextBox.Enabled = false;
            parCTextBox.Visible = false;
            parСTextBoxLabel.Visible = false;
        }

        /// <summary>
        /// Специфическое изменения состояния контролов для круга
        /// </summary
        public void ParametrsAreaSetTo(string parATextBoxLabelValue, string parBTextBoxLabelValue, bool setParATextBoxToPi)
        {
            parATextBoxLabel.Text = parATextBoxLabelValue;
            parBTextBoxLabel.Text = parBTextBoxLabelValue;
            parBTextBox.Clear();
            parATextBox.Enabled = false;
            parBTextBox.Enabled = true;
            parCTextBox.Visible = false;
            parСTextBoxLabel.Visible = false;
            parATextBox.Text = Math.Round(Math.PI, 2).ToString();
        }

        /// <summary>
        /// Специфическое изменения состояния контролов для треугольника
        /// </summary
        public void ParametrsAreaSetTo(string parATextBoxLabelValue, string parBTextBoxLabelValue, string parСTextBoxLabelValue)
        {
            parATextBoxLabel.Text = parATextBoxLabelValue;
            parBTextBoxLabel.Text = parBTextBoxLabelValue;
            parСTextBoxLabel.Text = parСTextBoxLabelValue;
            parATextBox.Clear();
            parBTextBox.Clear();
            parCTextBox.Clear();
            parATextBox.Enabled = true;
            parBTextBox.Enabled = true;
            parCTextBox.Visible = true;
            parCTextBox.Enabled = true;
            parСTextBoxLabel.Visible = true;
        }

        /// <summary>
        /// Обработчик события изменения индекса выбранного элемента в комбобоксе выбора фигуры
        /// </summary>
        private void figureTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).SelectedIndex)
            {
                case 0:
                    ParametrsAreaSetTo("Сторона 1:", "Сторона 2:", "Сторона 3:");
                    break;
                case 1:
                    ParametrsAreaSetTo("Сторона 1:", "Сторона 2:");
                    break;
                case 2:
                    ParametrsAreaSetTo("Число Пи:", "Радиус:", true);
                    break;
            }
        }
    }
}
