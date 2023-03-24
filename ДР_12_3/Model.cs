using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР_12_3
{
    class Model
    {
        public string Add(int a, int b) //Метод сложения чисел
        {
            return (a + b).ToString();
        }
        public string Sub(int a, int b) //Метод вычитания чисел
        {
            return (a - b).ToString();
        }
        public string Multi(int a, int b) //Метод умножения чисел
        {
            return (a * b).ToString();
        }
        public string Div(int a, int b) //Метод деления чисел
        {
            if (b != 0)
                return ((double)a / b).ToString();
            return "На нуль делить нельзя";
        }
    }
}
