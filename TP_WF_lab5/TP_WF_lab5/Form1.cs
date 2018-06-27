using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP_WF_lab5
{
    public partial class Form1 : Form
    {
        public Form2 frm2 = new Form2();
        public Form3 frm3 = new Form3();
        public Form4 frm4 = new Form4();
        public void button_build(object sender, EventArgs e)
        {
            frm2.chart1.Series.Clear();
            frm2.chart1.ChartAreas.Clear(); //очищаем чарты
            frm2.chart1.Titles.Clear();
            if (comboBox1.SelectedIndex == 0)//с помощбю графических приметивов
            {
                Primitives();
            }
            else//с помощю chart
            {
                Chart();
            }
        }
        public void Chart()
        {
            if (comboBox2.SelectedIndex == 0)//гистограмма 
            {
                Gistogram();
            }
            if (comboBox2.SelectedIndex == 1)//круговая диаграмма
            {
                Diagram();
            }
            if (comboBox2.SelectedIndex == 2)//два графика по отдельности
            {
                DoubleDiagram();
            }
            if (comboBox2.SelectedIndex == 3)//два графика вмести
            {
                DoubleGistogram();
            }
            if (comboBox2.SelectedIndex == 4)//два графика вмести по два
            {
                DoubleDoubleGistogram();
            }
            frm2.chart1.BackColor = Color.White; //установка фона
            frm2.chart1.BackSecondaryColor = Color.MediumTurquoise;
            frm2.chart1.BackGradientStyle = GradientStyle.DiagonalRight;//тип градиента
            frm2.chart1.BorderlineDashStyle = ChartDashStyle.DashDotDot; //тип границ
            frm2.chart1.BorderlineColor = Color.Orange; //цвет границ
            frm2.chart1.BorderSkin.SkinStyle = BorderSkinStyle.FrameThin2;

            frm2.chart1.Titles.Add("График 1"); //название тайтла
            frm2.chart1.Titles[0].Font = new Font("Utopia", 16); //установка шрифта
            frm2.chart1.ChartAreas[0].BackColor = Color.PaleGreen; //установка фона
            frm2.chart1.ChartAreas[0].ShadowColor = Color.Black; //установка тени
            frm2.chart1.ChartAreas[0].Area3DStyle.Enable3D = true; //3д вид
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                frm2.chart1.Series[0].Points.AddXY(i + 1, dataGridView1.Rows[i].Cells[1].Value); //добавление точек
                frm2.chart1.Series[0].Points[i].Label = dataGridView1.Rows[i].Cells[1].Value.ToString(); //названия точек
            }
            frm2.chart1.Series[0].Font = new Font("Utopia", 10); //задание шрифта
            if ((comboBox2.SelectedIndex == 2) || comboBox2.SelectedIndex == 3)
            {
                if (comboBox2.SelectedIndex == 2)
                {
                    frm2.chart1.Titles.Add("График 2"); //название второго графика
                    frm2.chart1.Titles[1].Font = new Font("Utopia", 16); //шрифт
                    frm2.chart1.ChartAreas[1].BackColor = Color.PaleGreen;
                    frm2.chart1.ChartAreas[1].ShadowColor = Color.Aqua;
                    frm2.chart1.Titles[1].DockingOffset = 38; //отступ тайтла
                    frm2.chart1.ChartAreas[1].ShadowColor = Color.Black; //установка тени
                    frm2.chart1.ChartAreas[1].Area3DStyle.Enable3D = true; //3д вид
                }
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    frm2.chart1.Series[1].Points.AddXY(i + 1, dataGridView1.Rows[i].Cells[1].Value); //добавление точек
                    frm2.chart1.Series[1].Points[i].Label = dataGridView1.Rows[i].Cells[1].Value.ToString(); //названия точек
                }
                frm2.chart1.Series[1].Font = new Font("Utopia", 10); //задание шрифта
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                frm2.chart1.Titles.Add("График 2"); //название второго графика
                frm2.chart1.Titles[1].Font = new Font("Utopia", 16); //шрифт
                frm2.chart1.ChartAreas[1].BackColor = Color.Aqua;
                frm2.chart1.ChartAreas[1].ShadowColor = Color.Black;
                frm2.chart1.ChartAreas[1].ShadowColor = Color.Black; //установка тени
                frm2.chart1.Titles[1].DockingOffset = 38; //отступ тайтла
                frm2.chart1.ChartAreas[1].Area3DStyle.Enable3D = true; //3д вид
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    frm2.chart1.Series[1].Points.AddXY(i + 1, dataGridView1.Rows[i].Cells[1].Value); //добавление точек
                    frm2.chart1.Series[1].Points[i].Label = dataGridView1.Rows[i].Cells[1].Value.ToString(); //названия точек
                }
                frm2.chart1.Series[1].Font = new Font("Utopia", 10); //задание шрифта
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    frm2.chart1.Series[2].Points.AddXY(i + 1, dataGridView1.Rows[i].Cells[1].Value); //добавление точек
                    frm2.chart1.Series[2].Points[i].Label = dataGridView1.Rows[i].Cells[1].Value.ToString(); //названия точек
                }
                frm2.chart1.Series[2].Font = new Font("Utopia", 10); //задание шрифта
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    frm2.chart1.Series[3].Points.AddXY(i + 1, dataGridView1.Rows[i].Cells[1].Value); //добавление точек
                    frm2.chart1.Series[3].Points[i].Label = dataGridView1.Rows[i].Cells[1].Value.ToString(); //названия точек
                }
                frm2.chart1.Series[3].Font = new Font("Utopia", 10); //задание шрифта
            }
            frm2.ShowDialog();
        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Гистограмма");
                comboBox2.Items.Add("Круговоая диаграмма");
                comboBox2.SelectedIndex = 0;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Гистограмма");
                comboBox2.Items.Add("Круговоая диаграмма");
                comboBox2.Items.Add("Два графика по отдельности");
                comboBox2.Items.Add("Гистограмма и сплайн вмести");
                comboBox2.Items.Add("Гистограмма и сплайн поотдельности по два");
                comboBox2.SelectedIndex = 0;
            }
        }
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void buttom_gener(object sender, EventArgs e)
        {
            if ((numericUpDown3.Value <= 1) || (numericUpDown1.Value == 0))
            {
                MessageBox.Show("Ошибка ввода данных");
                return;
            }
            dataGridView1.Rows.Clear(); //очищение датагрид
            Random rand = new Random();//экземпляр рандома
            for (int i = 0; i < numericUpDown1.Value; i++)
                dataGridView1.Rows.Add($"{i}", rand.Next((int)numericUpDown2.Value, (int)numericUpDown3.Value));//добавление новых значений в датагрид
        }
        public void Diagram() //постройка круговой диаграммы
        {
            int k = frm2.chart1.ChartAreas.Count;
            frm2.chart1.ChartAreas.Add($"{k}"); //создание чарт эриа
            frm2.chart1.Series.Add(new Series()
            {
                ChartArea = $"{k}",
                ChartType = SeriesChartType.Pie //тип диаграммы
            });
        }
        public void Gistogram() //постройка круговой диаграммы
        {
            int k = frm2.chart1.ChartAreas.Count;
            frm2.chart1.ChartAreas.Add($"{k}"); //создание чарт эриа
            frm2.chart1.Series.Add(new Series()
            {
                ChartArea = $"{k}",
                ChartType = SeriesChartType.Column //тип диаграммы
            });
        }
        public void DoubleDiagram() //постройка круговой диаграммы
        {
            int k = frm2.chart1.ChartAreas.Count;
            frm2.chart1.ChartAreas.Add($"{k}"); //создание чарт эриа
            frm2.chart1.Series.Add(new Series()
            {
                ChartArea = $"{k}",
                ChartType = SeriesChartType.Column //тип диаграммы
            });
            frm2.chart1.ChartAreas.Add($"{k + 1}"); //создание чарт эриа
            frm2.chart1.Series.Add(new Series()
            {
                ChartArea = $"{k + 1}",
                ChartType = SeriesChartType.Pie //тип диаграммы
            });
        }
        public void DoubleGistogram() //постройка круговой диаграммы
        {
            int k = frm2.chart1.ChartAreas.Count;
            frm2.chart1.ChartAreas.Add($"{k}"); //создание чарт эриа
            frm2.chart1.Series.Add(new Series()
            {
                ChartArea = $"{k}",
                ChartType = SeriesChartType.Column //тип диаграммы
            });
            frm2.chart1.Series.Add(new Series()
            {
                ChartArea = $"{k}",
                ChartType = SeriesChartType.Line //тип диаграммы
            });
        }

        public void button_sort(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridView1.Rows.Count - 1];
            string s;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                s = dataGridView1.Rows[i].Cells[1].Value.ToString(); //запись в переменную
                arr[i] = Convert.ToInt16(s);
            }
            Array.Sort(arr); //сортировка
            Array.Reverse(arr);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = arr[i]; //запись в дата грид
            }
        }

        public void DoubleDoubleGistogram() //постройка круговой диаграммы
        {
            int k = frm2.chart1.ChartAreas.Count;
            frm2.chart1.ChartAreas.Add($"{k}"); //создание чарт эриа
            frm2.chart1.Series.Add(new Series()
            {
                ChartArea = $"{k}",
                ChartType = SeriesChartType.Column //тип диаграммы
            });
            frm2.chart1.Series.Add(new Series()
            {
                ChartArea = $"{k}",
                ChartType = SeriesChartType.Line //тип диаграммы
            });
            frm2.chart1.ChartAreas.Add($"{k + 1}"); //создание чарт эриа
            frm2.chart1.Series.Add(new Series()
            {
                ChartArea = $"{k + 1}",
                ChartType = SeriesChartType.Spline //тип диаграммы
            });
            frm2.chart1.Series.Add(new Series()
            {
                ChartArea = $"{k + 1}",
                ChartType = SeriesChartType.Area //тип диаграммы
            });
        }
        public void Primitives()
        {
            string k;
            int[] mas = new int[dataGridView1.Rows.Count - 1]; //создание массива
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                k = dataGridView1.Rows[i].Cells[1].Value.ToString();
                mas[i] = Convert.ToInt16(k); //инициализация массива
            }
            frm3.colors.Clear();//очищение колекции цветов
            Random rand = new Random();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                frm3.colors.Add(Color.FromArgb((int)rand.Next(255), (int)rand.Next(255), (int)rand.Next(255))); //генерация коллекции цветов
            frm3.label1.Text = "";
            frm3.label2.Text = "";
            frm3.label3.Text = "";
            frm3.label4.Text = "";
            frm3.label5.Text = "";
            frm3.label6.Text = "";
            frm3.label7.Text = "";
            frm3.label8.Text = "";
            frm3.label9.Text = "";
            frm3.label10.Text = ""; //очищение лейбл
            frm3.Mass(mas, comboBox2.SelectedIndex); //вызов функции записи массива
            frm3.ShowDialog(); // вызов второй формы
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm4.ShowDialog();
        }
    }
}
