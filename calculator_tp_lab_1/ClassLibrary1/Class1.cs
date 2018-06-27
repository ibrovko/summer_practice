using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        //метод выбора операции
        public void Operations(ref char operation_key, string text, ref double result, ref bool operation_active1, ref double number, ref bool operation_active2)
        {
            try
                {
                switch (operation_key) //выбор операции
                {
                    case '+':
                        if (text == "" || text == "+" || text == "-") //проверка на правильность ввода
                            return;
                        if (operation_active1 == false)
                        {
                            if (operation_active2 == false)
                            {
                                result = Convert.ToDouble(text); //запись первого числа
                                operation_active2 = true;
                            }
                            else
                            {
                                number = Convert.ToDouble(text); //запись второго числа
                                Result1('+', ref result, ref number, text, ref operation_active1, ref operation_active2);
                                operation_active1 = true;
                                operation_active2 = true;
                            }
                        }
                        else
                        {
                            operation_active2 = true;
                            Result1('+', ref result, ref number, text, ref operation_active1, ref operation_active2); //нахождение результата, если все числа записаны
                        }
                        break;

                    case '-':
                        if (text == "" || text == "+" || text == "-") //проверка на корректность введенных данных
                            return;
                        if (operation_active1 == false)
                        {
                            if (operation_active2 == false)
                            {
                                result = Convert.ToDouble(text); //запись первого числа
                                operation_active2 = true;
                            }
                            else
                            {
                                number = Convert.ToDouble(text); //запись второго числа
                                Result1('-', ref result, ref number, text, ref operation_active1, ref operation_active2);
                                operation_active1 = true;
                                operation_active2 = true;
                            }
                        }
                        else
                        {
                            Result1('-', ref result, ref number, text, ref operation_active1, ref operation_active2); //нахождение результата, если все числа записаны
                        }
                        break;
                    case '*':
                        if (text == "" || text == "+" || text == "-") //проверка на корректность введенных данных
                            return;
                        if (operation_active1 == false)
                        {
                            if (operation_active2 == false)
                            {
                                result = Convert.ToDouble(text); //запись первого числа
                                operation_active2 = true;
                            }
                            else
                            {
                                number = Convert.ToDouble(text); //запись второго числа
                                Result1('*', ref result, ref number, text, ref operation_active1, ref operation_active2);
                                operation_active1 = true;
                                operation_active2 = true;
                            }
                        }
                        else
                        {
                            Result1('*', ref result, ref number, text, ref operation_active1, ref operation_active2); //подсчет результата, если введены 2 числа
                        }
                        break;
                    case '/':
                        if (text == "" || text == "+" || text == "-")//проверка на корректность введенных данных
                            return;
                        if (operation_active1 == false)
                        {
                            if (operation_active2 == false)
                            {
                                result = Convert.ToDouble(text); //запись первого числа
                                operation_active2 = true;
                            }
                            else
                            {
                                number = Convert.ToDouble(text);//запись второго числа
                                Result1('/', ref result, ref number, text, ref operation_active1, ref operation_active2);
                                operation_active1 = true;
                                operation_active2 = true;
                            }
                        }
                        else
                        {
                            Result1('/', ref result, ref number, text, ref operation_active1, ref operation_active2);//подсчет результата, если введены 2 числа
                        }
                        break;
                    case 's':
                        result = Math.Sin(Convert.ToDouble(text)); //подсчет результата операции синуса
                        break;
                    case 'c':
                        
                        result = Math.Cos(Convert.ToDouble(text));//подсчет результата операции косинуса
                        break;
                    case 'd':
                        result = 1 / Convert.ToDouble(text); //подсчет результата операции дроби
                        break;
                }
            }
            catch(Exception)
            {
                result = 0;
            }
        }
        public void Result1(char operation_key, ref double result,ref double number, string text, ref bool operation_active1, ref bool operation_active2) //нахождения результата из метода operations
        {
            switch (operation_key) //выбор операции 
            {
                case '+':
                    if (operation_active2 == true)
                        number = Convert.ToDouble(text); //считывание второго числа
                    result = result + number; //считаем результат
                    break;
                case '-':
                    if (operation_active2 == true)
                        number = Convert.ToDouble(text);//считывание второго числа
                    result = result - number;//считаем результат
                    break;
                case '*':
                    if (operation_active2 == true)
                        number = Convert.ToDouble(text);//считывание второго числа
                    result = result * number;//считаем результат
                    break;
                case '/':
                    if (operation_active2 == true)
                        number = Convert.ToDouble(text);//считывание второго числа
                    result = result / number;//считаем результат
                    break;
            }
        }
        //считаем результат из кнопки равно
        public void Result(char operation_key, ref double result, ref double number, string text, ref bool operation_active1, ref bool operation_active2)
        {
            switch (operation_key)
            {
                case '+':
                    if (operation_active2 == true)
                        number = Convert.ToDouble(text);//ввод второго числа, если не введено
                    operation_active1 = false;//сброс флага
                    operation_active2 = false;
                    result = result + number;//считаем результат
                    break;
                case '-':
                    if (operation_active2 == true)
                        number = Convert.ToDouble(text);//ввод второго числа, если не введено
                    operation_active1 = false;//сброс флага
                    operation_active2 = false;
                    result = result - number;//считаем результат
                    break;
                case '*':
                    if (operation_active2 == true)
                        number = Convert.ToDouble(text);//ввод второго числа, если не введено
                    operation_active1 = false;//сброс флага
                    operation_active2 = false;
                    result = result * number;//считаем результат
                    break;
                case '/':
                    if (operation_active2 == true)
                        number = Convert.ToDouble(text);//ввод второго числа, если не введено
                    operation_active1 = false;//сброс флага
                    operation_active2 = false;
                    result = result / number;//считаем результат
                    break;
            }
        }
    }
}
