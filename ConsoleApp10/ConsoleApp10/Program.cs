using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitConverter unit = new UnitConverter();
            Console.WriteLine("Выберите куда перевести: \n Для перевода из метров в футы нажмите 1 \n Для перевода из метров в дюймы напишите 2 \n Для перевода из футов в метры нажмите 3 \n Для перевода из футов в дюймы нажмите 4 \n Для перевода из дюймов в метры нажмите 5 \n Для перевода из дюймов в футы нажмите 6");
            Console.WriteLine("\n Для перевода из КГ В ФТ напишите 7 \n Для перевода из КГ В Уц напишите 8 \n Для перевода из ФТ В КГ напишите 9 \n Для перевода из ФТ В УЦ напишите 10 \n Для перевода из УЦ В КГ  напишите 11 \n Для перевода из УЦ В фт напишите 12 \n");
            Console.WriteLine(" Для перевода из литры В галлоны напишите 13 \n Для перевода из литров В куб метры напишите 14 \n Для перевода из галлонов В литры напишите 15 \n Для перевода из галлонов В Куб метры напишите 16 \n Для перевода из куб метров В литры  напишите 17 \n Для перевода из галлонов В литры напишите 18 \n");
            Console.WriteLine("Для перевода из цельсий в фарингейт 19 \n Для перевода из фарингейта в цельсию 20");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите единицу измерения");
            double a = double.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    unit.add1(a);
                    break;
                case 2:
                    unit.add2(a);
                    break;
                case 3:
                    unit.add3(a);
                    break;
                case 4:
                    unit.add4(a);
                    break;
                case 5:
                    unit.add5(a);
                    break;
                case 6:
                    unit.add6(a);
                    break;
                case 7:
                    unit.add77(a);
                    break;
                case 8:
                    unit.add8(a);

                    break;
                case 9:
                    unit.add9(a);
                    break;
                case 10:
                    unit.add10(a);

                    break;
                case 11:
                    unit.add11(a);
                    break;
                case 12:
                    unit.add12(a);
                    break;
                case 13:
                    unit.add13(a);
                    break;
                case 14:
                    unit.add14(a);
                    break;
                case 15:
                    unit.add15(a);
                    break;
                case 16:
                    unit.add16(a);
                    break;
                case 17:
                    unit.add17(a);
                    break;
                case 18:
                    unit.add18(a);
                    break;
                case 19:
                    unit.add19(a);
                    break;
                case 20:
                    unit.add20(a);
                    break;

            }
            Console.ReadKey();
        }
    }
}
