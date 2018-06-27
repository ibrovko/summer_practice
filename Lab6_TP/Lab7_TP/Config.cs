using System;
using System.Drawing;

namespace Clock1
{
    public struct ColorC
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
        public ColorC(Color color)
        {
            this.A = color.A;
            this.R = color.R;
            this.G = color.G;
            this.B = color.B;
        }
    }
    [Serializable]
    public class Config
    {
        /// <summary>
        /// Цвет фона
        /// </summary>
        public ColorC backGround;
        /// <summary>
        /// Цвет часовой стрелки
        /// </summary>
        public ColorC hourHand;
        /// <summary>
        /// Цвет минутной стрелки
        /// </summary>
        public ColorC minuteHand;
        /// <summary>
        /// Цвет секундной стрелки
        /// </summary>
        public ColorC secondHand;
        /// <summary>
        /// Размер
        /// </summary>
        public float size;
        /// <summary>
        /// Флаг отображения цифровых часов
        /// </summary>
        public bool shDigit;
        /// <summary>
        /// Конструктор
        /// </summary>
        public Config()
        { }
        /// <summary>
        /// Конструктор
        /// </summary>
        public Config(Color backGround, Color hourHand, Color minuteHand, Color secondHand, float size, bool showDigit)
        {
            //setting colors
            this.backGround = FromColorToARGB(backGround);
            this.hourHand = FromColorToARGB(hourHand);
            this.minuteHand = FromColorToARGB(minuteHand);
            this.secondHand = FromColorToARGB(secondHand);
            this.size = size;
            this.shDigit = showDigit;
        }
        /// <summary>
        /// Метод преобразования из Color в ARGB
        /// </summary>
        public ColorC FromColorToARGB(Color color)
        {
            ColorC newARGB;
            newARGB.A = color.A;
            newARGB.R = color.R;
            newARGB.G = color.G;
            newARGB.B = color.B;
            return newARGB;
        }
        /// <summary>
        /// Метод преобразования из ARGB в Color
        /// </summary>
        public Color ARGBToColor(ColorC colorC)
        {
            return Color.FromArgb(colorC.A, colorC.R, colorC.G, colorC.B);
        }

    }
}
