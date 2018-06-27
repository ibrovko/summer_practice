using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TP_WF_lab5
{
    public partial class Form3 : Form
    {
        public List<Color> colors = new List<Color>();
        int idx;
        public Form3()
        {
            InitializeComponent();
        }
        private void Primitive_Paint(object sender, PaintEventArgs e)
        {
            if (idx == 0)
                RectangleDraw(e.Graphics);
            else 
                CircleDraw();
        }
        List<int> mas = new List<int>();
        public void Mass(int[] mass, int index)
        {
            idx = index;
            mas.Clear();
            for (int i = 0; i < mass.Length; i++)
            {
                mas.Add(mass[i]);
            }
        }
        private void RectangleDraw(Graphics gr)//Гистограмма
        {
            Random rand = new Random();
            int k = mas.Count;
            int indentLeft = 30;
            int indentRight = 30;
            int indentTop = 30;
            int indentBottom = 30;

            // Ищем максимальный элемент вертикальной гисторгаммы
            int maxEl = 0;
            foreach (int y in mas)
            {
                maxEl = y > maxEl ? y : maxEl;
            }

            // Считаем коєфициент по оси Y
            double koefY = (this.ClientSize.Height - indentTop - indentBottom) / maxEl;
            // Длина одного сегмента
            int rectWidth = (this.ClientSize.Width - indentLeft - indentRight) / (2 * k + 1);
            for (int i = 0; i < k; i++)
            {
                string drawString = $"{mas[i]}"; //рисуем строку с таким именем

                Size sizeRect = new Size(rectWidth, (int)(koefY * mas[i]));//Размер прямоугольника

                Point pt1 = new Point(indentLeft + rectWidth * (2 * i + 1), this.ClientSize.Height - indentBottom - sizeRect.Height);

                Rectangle rect = new Rectangle(pt1, sizeRect);//инициалезируем экземпляр 

                gr.FillRectangle(new SolidBrush(colors[i]), rect);//рисуем прямоугольник

                gr.DrawString(drawString, new Font("Arial", 14), new SolidBrush(Color.Black), (indentLeft + rectWidth * (2 * i + 1)), (this.ClientSize.Height - indentBottom - sizeRect.Height - 25), new StringFormat());//делаем подпись
            }   

        }
        List<Label> label = new List<Label>(); //коллекция лейблов
        public void LabelAdd()
        {
            label.Clear();
            label.Add(label1);
            label.Add(label2);
            label.Add(label3);
            label.Add(label4);
            label.Add(label5);
            label.Add(label6);
            label.Add(label7); //добавление лейблов в коллекцию
            label.Add(label8);
            label.Add(label9);
            label.Add(label10);
        }
        public void CircleDraw()
        {
            Random rand = new Random();

            int indentLeft = 30;
            int indentRight = 30;
            int indentTop = 30;
            int indentBottom = 30;

            // Определяем координаты центра круговой диаграммы
            int centerX = (ClientSize.Width - indentLeft - indentRight) / 2;
            int centerY = (ClientSize.Height - indentTop - indentBottom) / 2;
            // Определяем радиус круговой диаграммы
            int radius = Math.Min(centerX, centerY);
            // Определяем координаты левого верхнего угла прямоугольника, описывающего окружность диаграммы
            int leftX = indentLeft + centerX - radius;
            int topY = indentTop + centerY - radius;
            // Создаем прямоугольник, описывающий окружность диаграммы
            Rectangle rect = new Rectangle(leftX, topY, 2 * radius, 2 * radius);
            Pen pen = new Pen(Color.Black);
            Graphics graph = CreateGraphics(); //экземпляр графа

            graph.DrawEllipse(pen, rect);

            // Считаем общую сумму ВСЕХ элементов диаграммы
            int totalValue = 0;
            foreach (var pt in mas)
            {
                totalValue += pt;
            }

            // Считаем угловой коэфициент
            float koef = (float)360 / totalValue;
            // Начальный угол сектора
            float startAngle = 0;
            for (int i = 0; i < mas.Count; i++)
            {
                // Для каждой точки вычисляем угол, соответствующий значению текщего элемента диаграммы
                float angle = mas[i] * koef;
                // Рисуме  сектор для текущего элемента диаграммы
                graph.FillPie(new SolidBrush(colors[i]), rect, startAngle, angle);
                // Вычисляем начальный угол для следующего элемента диаграммы
                startAngle += angle;
            }
            LabelAdd(); //добавление лейблов
            for (int i = 0; i < mas.Count; i++)
            {
                label[i].BackColor = colors[i];
                label[i].Text = $"{mas[i]}"; //запись лейбл в текст
            }
        }
    }
}
