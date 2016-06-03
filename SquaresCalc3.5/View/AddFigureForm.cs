using System;
using System.ComponentModel;
using System.Windows.Forms;
using Shapes;

namespace SquaresCalc3._5.View
{
    /// <summary>
    /// Класс формы добавления/изменения фигуры
    /// </summary>
    public partial class AddFigureForm : Form
    {
        /// <summary>
        /// Свойство для хранения данных таблицы
        /// </summary>
        public BindingList<IShape> Data { get; set; }

        /// <summary>
        /// Поле для хранения индекса выбранной фигуры для ее последующего изменения
        /// </summary>
        private int _selectedShapeIndex;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public AddFigureForm()
        {
            InitializeComponent();
            Data = new BindingList<IShape>();
        }

        /// <summary>
        /// Метод, меняющий форму в форму для добавления фигур
        /// </summary>
        public void SetAsAddForm()
        {
            addShapeButton.Click -= EditShapeButton_Click;
            addShapeButton.Click += AddShapeButton_Click;
            addShapeButton.Enabled = true;
            addShapeButton.Text = "Добавить";
#if DEBUG
            addRandomDataButton.Hide();
            Height += 30;
            groupBox1.Height += 30;
            addRandomDataButton.Show();
#endif
        }

        /// <summary>
        /// Метод, меняющий форму в форму для изменения фигур
        /// </summary>
        /// <param name="shape">Выбранная фигура</param>
        /// <param name="index">Индекс выбранной фигуры</param>
        public void SetAsModifyForm(IShape shape, int index)
        {
            addShapeButton.Enabled = true;
#if DEBUG
            if (groupBox1.Height == 180)
            {
                Height -= 30;
                groupBox1.Height -= 30;
            }
            addRandomDataButton.Hide();
#endif
            _selectedShapeIndex = index;
            if (shape is Circle)
            {
                addShapePropertiesObjectControl.FigureTypeComboBoxSelectedIndex = 2;
                addShapePropertiesObjectControl.ParBTextBoxText =
                  ((Circle) shape).Radius.ToString();
            }
            if (shape is Triangle)
            {
                addShapePropertiesObjectControl.FigureTypeComboBoxSelectedIndex = 0;
                addShapePropertiesObjectControl.ParATextBoxText =
                  (shape as Triangle).LegA.ToString();
                addShapePropertiesObjectControl.ParBTextBoxText =
                  (shape as Triangle).LegB.ToString();
                addShapePropertiesObjectControl.ParCTextBoxText =
                  (shape as Triangle).LegC.ToString();
            }
            if (shape is Quadrate)
            {
                addShapePropertiesObjectControl.FigureTypeComboBoxSelectedIndex = 1;
                addShapePropertiesObjectControl.ParATextBoxText =
                  (shape as Quadrate).SideA.ToString();
                addShapePropertiesObjectControl.ParBTextBoxText =
                  (shape as Quadrate).SideB.ToString();
            }

            addShapeButton.Click -= AddShapeButton_Click;
            addShapeButton.Click += EditShapeButton_Click;
            addShapeButton.Text = "Изменить";
        }

        /// <summary>
        /// Метод для отображения предупреждающей таблички
        /// </summary>
        /// <param name="alertMessage">Предупреждающее сообщение</param>
        public void ShowAlert(string alertMessage)
        {
            if (MessageBox.Show(alertMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Close();
            }
        }

        /// <summary>
        /// Метод валидации текстовых полей
        /// </summary>
        /// <returns>Логическое значение: валидно/не валидно</returns>
        public bool ParametrsTextBoxValidate()
        {
            bool isValid = true;
            int tempVar;
            if (!(int.TryParse(addShapePropertiesObjectControl.ParATextBoxText, out tempVar))
                || !(int.TryParse(addShapePropertiesObjectControl.ParBTextBoxText, out tempVar)))
            {
                isValid = false;
            }
            else
            {
                if ((Convert.ToInt32(addShapePropertiesObjectControl.ParATextBoxText) <= 0)
                    || (Convert.ToInt32(addShapePropertiesObjectControl.ParBTextBoxText) <= 0))
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        /// <summary>
        /// Перегрузка метода валидации текстовых полей
        /// </summary>
        /// <param name="shape">Название формы</param>
        /// <returns>Логическое значение: валидно/не валидноы</returns>
        public bool ParametrsTextBoxValidate(string shape)
        {
            bool isValid = true;
            int tempVar;
            if (shape == "circle")
            {
                if (!(int.TryParse(addShapePropertiesObjectControl.ParBTextBoxText, out tempVar))
                    || (Convert.ToInt32(addShapePropertiesObjectControl.ParBTextBoxText) <= 0))
                {
                    isValid = false;
                }
            }
            else
            {
                if (!(int.TryParse(addShapePropertiesObjectControl.ParATextBoxText, out tempVar)) 
                    || !(int.TryParse(addShapePropertiesObjectControl.ParBTextBoxText, out tempVar)) 
                    || !(int.TryParse(addShapePropertiesObjectControl.ParCTextBoxText, out tempVar)))
                {
                    isValid = false;
                }
                else
                {
                    if ((Convert.ToInt32(addShapePropertiesObjectControl.ParATextBoxText) <= 0)
                        || (Convert.ToInt32(addShapePropertiesObjectControl.ParBTextBoxText) <= 0)
                        || (Convert.ToInt32(addShapePropertiesObjectControl.ParCTextBoxText) <= 0))
                    {
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        /// <summary>
        /// Обработчки клика кнопки добавления фигуры
        /// </summary>
        /// <param name="sender">Ссылка на объект-отправитель</param>
        /// <param name="e">Параметры события</param>
        private void AddShapeButton_Click(object sender, EventArgs e)
        {
            switch (addShapePropertiesObjectControl.FigureTypeComboBoxSelectedIndex)
            {
                case -1:
                    ShowAlert("Выберите фигуру!");
                    break;
                case 0:
                    if (ParametrsTextBoxValidate("triangle"))
                    {
                        int parATextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParATextBoxText, out parATextBoxValue);

                        int parBTextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParBTextBoxText, out parBTextBoxValue);

                        int parCTextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParCTextBoxText, out parCTextBoxValue);

                        if (!(parATextBoxValue >= (parBTextBoxValue + parCTextBoxValue)) &&
                            !(parBTextBoxValue >= (parATextBoxValue + parCTextBoxValue)) &&
                            !(parCTextBoxValue >= (parBTextBoxValue + parATextBoxValue)))
                        {
                            Data.Add(new Triangle(parATextBoxValue, parBTextBoxValue, parCTextBoxValue));
                        }
                        else
                        {
                            ShowAlert("Одна сторона должна быть меньше, чем сумма двух других!");
                        }
                    }
                    else
                    {
                        ShowAlert("Параметры должны быть введены в целочисленном виде!");
                    }
                    break;
                case 1:
                    if (ParametrsTextBoxValidate())
                    {
                        int parATextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParATextBoxText, out parATextBoxValue);

                        int parBTextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParBTextBoxText, out parBTextBoxValue);

                        Data.Add(new Quadrate(parATextBoxValue, parBTextBoxValue));
                    }
                    else
                    {
                        ShowAlert("Параметры должны быть введены в целочисленном виде!");
                    }
                    break;
                case 2:
                    if (ParametrsTextBoxValidate("circle"))
                    {
                        int parBTextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParBTextBoxText, out parBTextBoxValue);

                        Data.Add(new Circle(parBTextBoxValue));
                    }
                    else
                    {
                        ShowAlert("Параметры должны быть введены в целочисленном виде!");
                    }
                    break;
            }
        }

        /// <summary>
        /// Обработчки клика кнопки изменения фигуры
        /// </summary>
        /// <param name="sender">Ссылка на объект-отправитель</param>
        /// <param name="e">Параметры события</param>
        private void EditShapeButton_Click(object sender, EventArgs e)
        {
            switch (addShapePropertiesObjectControl.FigureTypeComboBoxSelectedIndex)
            {
                case -1:
                    ShowAlert("Выберите фигуру!");
                    break;
                case 0:
                    if (ParametrsTextBoxValidate("triangle"))
                    {
                        int parATextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParATextBoxText, out parATextBoxValue);

                        int parBTextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParBTextBoxText, out parBTextBoxValue);

                        int parCTextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParCTextBoxText, out parCTextBoxValue);

                        if (!(parATextBoxValue >= (parBTextBoxValue + parCTextBoxValue)) &&
                            !(parBTextBoxValue >= (parATextBoxValue + parCTextBoxValue)) &&
                            !(parCTextBoxValue >= (parBTextBoxValue + parATextBoxValue)))
                        {
                            Data[_selectedShapeIndex] = new Triangle(parATextBoxValue, parBTextBoxValue, parCTextBoxValue);
                        }
                        else
                        {
                            ShowAlert("Одна сторона должна быть меньше, чем сумма двух других!");
                        }
                    }
                    else
                    {
                        ShowAlert("Параметры должны быть введены в целочисленном виде!");
                    }
                    break;
                case 1:
                    if (ParametrsTextBoxValidate())
                    {
                        int parATextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParATextBoxText, out parATextBoxValue);

                        int parBTextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParBTextBoxText, out parBTextBoxValue);
                        
                        Data[_selectedShapeIndex] = new Quadrate(parATextBoxValue, parBTextBoxValue);
                    }
                    else
                    {
                        ShowAlert("Параметры должны быть введены в целочисленном виде!");
                    }
                    break;
                case 2:
                    if (ParametrsTextBoxValidate("circle"))
                    {
                        int parBTextBoxValue;
                        int.TryParse(addShapePropertiesObjectControl.ParBTextBoxText, out parBTextBoxValue);

                        Data[_selectedShapeIndex] = new Circle(parBTextBoxValue);
                    }
                    else
                    {
                        ShowAlert("Параметры должны быть введены в целочисленном виде!");
                    }
                    break;
            }
        }

#if DEBUG
        private void addRandomDataButton_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            switch (rand.Next(3))
            {
                case 0:
                    int legA = rand.Next(1, 100);
                    int legB = rand.Next(1, 100);
                    int legC = rand.Next(Math.Max(legA,legB),legA + legB);
                    
                    Data.Add(new Triangle(legA, legB, legC));
                    break;
                case 1:
                    Data.Add(new Quadrate(rand.Next(1, 100), rand.Next(1, 100)));
                    break;
                case 2:
                    Data.Add(new Circle(rand.Next(1, 100)));
                    break;
            }
        }
#endif

        /// <summary>
        /// Обработчки закрытия формы
        /// </summary>
        /// <param name="sender">Ссылка на объект-отправитель</param>
        /// <param name="e">Параметры события</param>
        private void AddFigureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            (sender as AddFigureForm).Hide();
            e.Cancel = true;
        }
    }
}
