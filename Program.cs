using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//Завдання 1
//Запрограмуйте клас Money (об'єкт класу оперує однією
//валютою) для роботи з грошима.
//У класі мають бути передбачені: поле для зберігання
//цілої частини грошей (долари, євро, гривні тощо) і поле
//для зберігання копійок (центи, євроценти, копійки тощо)
//Реалізувати методи виведення суми на екран, задання
//значень частин.
//На базі класу Money створити клас Product для роботи
//з продуктом або товаром. Реалізувати метод, який дозволяє
//зменшити ціну на задане число.
//Для кожного з класів реалізувати необхідні методи і
//поля.

//Завдання 3
//Створити базовий клас «Музичний інструмент» і похідні
//класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». За
//допомогою конструктора, встановити назву до кожного
//музичного інструменту і його характеристики.
//Реалізуйте для кожного з класів методи:
//■ Sound — видає звук музичного інструменту (пишемо
//текстом у консоль);
//■ Show — відображає назву музичного інструменту;
//■ Desc — відображає опис музичного інструменту;
//■ History — відображає історію створення музичного
//інструменту.
namespace HW_04_05_06_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(100.98);
            Console.WriteLine(money);
            try
            {
                Product newProd = new Product("banana", 15.44);
                Console.WriteLine(newProd);
                newProd.makeMoreExpensive(10.99);
                Console.WriteLine(newProd);
                newProd.makeCheaper(13.50);
                Console.WriteLine(newProd);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }


            Console.WriteLine("================================================");
            MusicalInstrument instrument = new Violin();
            Console.WriteLine(instrument);
            instrument.Sound();
            instrument.Desc();
            instrument.History();
            Console.WriteLine("================================================");
            instrument = new Trombone();
            Console.WriteLine(instrument);
            instrument.Sound();
            instrument.Desc();
            instrument.History();
            Console.WriteLine("================================================");
            instrument = new Ukulele();
            Console.WriteLine(instrument);
            instrument.Sound();
            instrument.Desc();
            instrument.History();
            Console.WriteLine("================================================");
            instrument = new Cello();
            Console.WriteLine(instrument);
            instrument.Sound();
            instrument.Desc();
            instrument.History();

        }
    }
}
