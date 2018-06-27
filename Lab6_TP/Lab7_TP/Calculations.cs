using System;

namespace Lab7_TP
{
    public class Calculations
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public Calculations()
        {

        }
        /// <summary>
        /// Расчет градуса часовой стрелки
        /// </summary>
        public float Hr(int Hour, int Minute, float PI)
        {
            return (Hour % 12 + Minute / 60F) * 30 * PI / 180;
        }
        /// <summary>
        /// Расчет градуса минутной стрелки
        /// </summary>
        public float Min(int Minute, float PI)
        {
            return (Minute) * 6 * PI / 180;
        }
        /// <summary>
        /// Расчет градуса секундной стрелки
        /// </summary>
        public float Sec(int Second, float PI)
        {
            return (Second) * 6 * PI / 180;
        }
    }
}
