using System;
using System.Windows.Forms;
using ClassLibrary1;

namespace calculator_tp_lab_1
{
    public partial class Form1 : Form
    {
        Class1 operation = new Class1(); //создаем экземпляр класса с операциями
        double result, number; //поля
        bool active_operation1 = false, active_operation2 = false;//поля
        bool active_result = false;//поля
        char operation_key;//поля
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("US"); //меняем глобализацию
            InitializeComponent();
            Config();
        }

        //Проверка на правильность ввода после изменения окна textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double a = 0;
            if (textBox1.Text == "" || textBox1.Text == "-" || textBox1.Text == "+")
                return;
            try
            {
                a = double.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                textBox1.Text = "Overflow"; //проверка на переполнение
            }

            if (textBox1.Text[0]=='.')
                textBox1.Text = textBox1.Text.Substring(1, textBox1.Text.Length-1); //проверка на запятые

            if (textBox1.Text.LastIndexOf('.') != -1)
            {
                a = (textBox1.Text.Length - 1) - textBox1.Text.LastIndexOf('.');
                if (a > 2)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); //проверка на колличество символов после запятой
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
                return;
            }
            if (active_result == true)
                return;
            if (a > 1000000)    //проверка входных данных (диапазон)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox1.SelectionStart = textBox1.Text.Length;
                return;
            }
            if (a < -1000000)   //проверка входных данных (диапазон)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        //Проверка на правильность ввода после ввода с клавиатуры
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '+' || e.KeyChar == '-') || e.KeyChar == 8 || e.KeyChar == '.') //разрешение ввода только этих символов
            {
                if (active_result == true)
                {
                    e.Handled = true;
                    return;
                }
                if (textBox1.Text.Length > 0 && (e.KeyChar == '+' || e.KeyChar == '-')) //запрет на ввод + или - не в начале 
                {
                    e.Handled = true;
                    return;
                }

                if (e.KeyChar == '.' && (textBox1.Text.Length == 0 || textBox1.Text.LastIndexOf('.') != -1)) //если запятая вводится в начало или она уже есть - запретить
                {
                    e.Handled = true;
                    return;
                }
            }
            else
                e.Handled = true; //иначе - запретить

        }

        //кнопка 1
        private void One_Click(object sender, EventArgs e)
        {

            if (active_result == true)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text += "1";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;// фокус в окно текстбокс
        }

        //кнопка 2
        private void Two_Click(object sender, EventArgs e)
        {
            if (active_result == true)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text += "2";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;// фокус в окно текстбокс
        }

        //кнопка 3
        private void Button_Three(object sender, EventArgs e)
        {
            if (active_result == true)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text += "3";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;// фокус в окно текстбокс
        }

        //кнопка 4
        private void Button_Four(object sender, EventArgs e)
        {
            if (active_result == true)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text += "4";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;// фокус в окно текстбокс
        }

        //кнопка 5
        private void Button_Five(object sender, EventArgs e)
        {
            if (active_result == true)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text += "5";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;// фокус в окно текстбокс
        }

        //кнопка 6
        private void Button_Six(object sender, EventArgs e)
        {
            if (active_result == true)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text += "6";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;// фокус в окно текстбокс
        }

        //кнопка 7
        private void Button_Seven(object sender, EventArgs e)
        {
            if (active_result == true)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text += "7";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;// фокус в окно текстбокс
        }
        //кнопка 8
        private void Button_Eight(object sender, EventArgs e)
        {
            if (active_result == true)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text += "8";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;// фокус в окно текстбокс

        }

        //кнопка 9
        private void Button_Nine(object sender, EventArgs e)
        {
            if (active_result == true)
                return;
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text += "9";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;// фокус в окно текстбокс
        }

        //кнопка 0
        private void Button_Zero(object sender, EventArgs e)
        {
            if (active_result == true)
                return;
            if (textBox1.Text == "0")
                return;
            textBox1.Text += "0";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length; //фокус в окно текстбокс

        }

        //кнопка очистки 1 символа
        private void Button_Clear_1(object sender, EventArgs e)
        {
            if (active_result == true)
                return;
            if (string.IsNullOrEmpty(textBox1.Text)) //если строка пустая - выходим
                return;
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            textBox1.Focus();
        }

        //кнопка очистки всего калькулятора
        private void Button_ClearAll(object sender, EventArgs e)
        {
            textBox1.Text = null;
            active_result = false;
            active_operation1 = false;  
            active_operation2 = false;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;//разблокировка остальных кнопок
            button18.Enabled = true;
            button19.Enabled = true;
            textBox1.Focus();

        }

        //кнопка точки
        private void Button_Point(object sender, EventArgs e)
        {
            if (active_result == true)
                return;
            if (textBox1.Text.Length == 0 || textBox1.Text.LastIndexOf('.') != -1)
                return;
            textBox1.Text += ".";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        //кнопка операции плюс
        private void Button_Plus(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "+" || textBox1.Text == "-")
            {
                textBox1.Text = "+";
                return;
            }
            button15.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;//блокировка остальных кнопок
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            active_result = false;
            operation_key = '+';
            operation.Operations(ref operation_key, textBox1.Text, ref result, ref active_operation1, ref number, ref active_operation2);
            textBox1.Text = null;
            textBox1.Focus();

        }

        //кнопка операции минуса
        private void Button_Minus(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "+" || textBox1.Text == "-")
            {
                textBox1.Text = "-";
                return;
            }
            active_result = false;
            button12.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;//блокировка остальных кнопок
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            operation_key = '-';
            operation.Operations(ref operation_key, textBox1.Text, ref result, ref active_operation1, ref number, ref active_operation2);
            textBox1.Text = null;
            textBox1.Focus();

        }

        //кнопка операции деления
        private void Button_Division(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "+" || textBox1.Text == "-")
            {
                return;
            }
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;//блокировка остальных кнопок
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            active_result = false;
            operation_key = '/';
            operation.Operations(ref operation_key, textBox1.Text, ref result, ref active_operation1, ref number, ref active_operation2);
            textBox1.Text = null;
            textBox1.Focus();

        }

        //кнопка операции квадратного корня
        private void Button_Sin(object sender, EventArgs e)
        {
            active_result = false;
            operation_key = 's';
            operation.Operations(ref operation_key, textBox1.Text, ref result, ref active_operation1, ref number, ref active_operation2);
            textBox1.Text = Convert.ToString(result);
            textBox1.Focus();
        }

        //кнопка операции синуса
        private void Button_Cos(object sender, EventArgs e)
        {
            active_result = false;
            operation_key = 'c';
            operation.Operations(ref operation_key, textBox1.Text, ref result, ref active_operation1, ref number, ref active_operation2);
            textBox1.Text = Convert.ToString(result);
            textBox1.Focus();

        }

        //кнопка операции дроби
        private void Button_Drop(object sender, EventArgs e)
        {
            active_result = false;
            operation_key = 'd';
            operation.Operations(ref operation_key, textBox1.Text, ref result, ref active_operation1, ref number, ref active_operation2);
            textBox1.Text = Convert.ToString(result);
            textBox1.Focus();

        }

        //кнопка нахождения результата
        private void Button_result(object sender, EventArgs e)
        {
            if (textBox1.Text == ""||operation_key == 0)
                return;
            operation.Result(operation_key, ref result, ref number, textBox1.Text, ref active_operation1, ref active_operation2);
            active_result = true;
            textBox1.Text = Convert.ToString(result);
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button18.Enabled = true;//разблокировка остальных кнопок
            button19.Enabled = true;
            button20.Enabled = true;
        }

        //кнопка блокировки кнопки delete
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                e.SuppressKeyPress = true;
        }

       


        //кнопка операции умножения
        private void Button_Multiplication(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "+" || textBox1.Text == "-")
            {
                return;
            }
            button12.Enabled = false;
            button13.Enabled = false;
            button15.Enabled = false;
            button18.Enabled = false; //блокировка остальных кнопок
            button19.Enabled = false;
            button20.Enabled = false;
            active_result = false;
            operation_key = '*';
            operation.Operations(ref operation_key, textBox1.Text, ref result, ref active_operation1, ref number, ref active_operation2);
            textBox1.Text = null;
            textBox1.Focus();

        }

        //функция настройки кнопок
        private void Config ()
        {
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent; //делает все кнопки прозрачными

            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.One.BackColor = System.Drawing.Color.Transparent;
            this.One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.One.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными

            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;//делает все кнопки прозрачными
        }

    }
}
