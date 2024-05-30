using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class UnitConverter
    {
        public void add1 (double a) //Метр в фут
        {
            double Fout = a * 3.28084;
            Console.WriteLine("КГ В Футах" + Fout.ToString());
        } 
        public void add2(double a) //Метров в дюйм
        {
            double Duims = a * 39.37;
            Console.WriteLine("Метров в Дюймах: " + Duims.ToString());
        }
       
        public void add3(double a) //Фута в метр
        { 
            double Metr = a * 0.3048;
            Console.WriteLine("Футов в Метрах: " + Metr.ToString());
        } 
        public void add4(double a) //Фута в дюйм
        {
            double Duims = a * 12;
            Console.WriteLine("Футов в Дюймах: " + Duims.ToString());
        }
        public void add5(double a) //Дюйм в метры
        {
            double Metrs = a * 0.0254;
            Console.WriteLine("Дюймов в Метрах: " + Metrs.ToString());
        }
        public void add6(double a) // Дюйма в фут
        {
            double Duims = a / 12;
            Console.WriteLine("дюймов в футах:" + Duims.ToString());
        }
        public void add77(double a) //КГ В ФТ
             
        {
            double Duims = a * 2.20462;
            Console.WriteLine("Фунты:" + Duims.ToString());
        }
        public void add8(double a) // КГ В Унции
        {
            double Duims = a * 35.2739619;
            Console.WriteLine("Фунты:" + Duims.ToString());
        }
        public void add9(double a) // КГ В Унции
        {
            double Duims = a * 0.453592;
            Console.WriteLine("Фунты:" + Duims.ToString());
        }
        public void add10(double a) 
        {
            double Duims = a * 12;
            Console.WriteLine("Дюймов: " + Duims.ToString());
        }
        public void add11(double a)
        {
            double Duims = a * 12;
            Console.WriteLine("Дюймов: " + Duims.ToString());
        }
        public void add12(double a)
        {
            double Duims = a * 12;
            Console.WriteLine("Дюймов: " + Duims.ToString());
        }

        public void add13(double a) 
        {
            double Metrs = a * 0.0254;
            Console.WriteLine("Дюймов в Метрах: " + Metrs.ToString());

        }
        public void add14(double a) 
        {
            double Metrs = a * 0.0254;
            Console.WriteLine("Дюймов в Метрах: " + Metrs.ToString());
        }
        public void add15(double a)
        { 
            double Metrs = a * 0.0254;
            Console.WriteLine("Дюймов в Метрах: " + Metrs.ToString());
        }
        public void add16(double a) 
        {
            double Metrs = a * 0.0254;
            Console.WriteLine("Дюймов в Метрах: " + Metrs.ToString());
        }
        public void add17(double a)
        {
            double Metrs = a * 0.0254;
            Console.WriteLine("Дюймов в Метрах: " + Metrs.ToString());
        }
        public void add18(double a) 
        {
            double Metrs = a * 0.0254;
            Console.WriteLine("Дюймов в Метрах: " + Metrs.ToString());
        }
        public void add19(double a) 
        {
            double Duims = a * 39.37;
            Console.WriteLine("Метров в Дюймах: " + Duims.ToString());
        }
        public void add20(double a)
        {
            double Duims = a - 32 * 5/9;
            Console.WriteLine("из фарингейта в цельсию: " + Duims.ToString());
        }

    }
}
