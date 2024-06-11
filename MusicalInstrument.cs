using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public abstract class MusicalInstrument
    {
        protected string _name;
        protected string _sound;
        protected string _description;
        protected string _history;
        protected MusicalInstrument(string name)
        {
            _name = name;
        }
        public string Name 
        {
            get { return _name; }
        }
        public abstract void Show();
        public abstract void Sound();
        public abstract void Desc(); 
        public abstract void History();
        public override string ToString()
        {
            return $"Название : {_name}";
        }
    }

    //Скрипка
    public class Violin : MusicalInstrument
    {
        public Violin() : base("Скрипка")
        {
            _sound = "Звук скрипки";
            _description = "Скрипка - струнно-смычковый музыкальный инструмент с четырьмя струнами";
            _history = "История скрипки";
        }
        public override void Show()
        {
            Console.WriteLine(_name);
        }
        public override void Sound()
        {
            Console.WriteLine(_sound);
        }
        public override void Desc()
        {
            Console.WriteLine(_description);
        }
        public override void History()
        {
            Console.WriteLine(_history);
        }
       
    }

    //Тромбон
    public class Trombone : MusicalInstrument
    {
        public Trombone() : base("Тромбон") 
        {
            _sound = "Звук тромбона";
            _description = "Тромбон - медный духовой музыкальный инструмент, отличительной особенностью которого является наличие передвижной кулисы";
            _history = "История тромбона";
        }
        public override void Show()
        {
            Console.WriteLine(_name);
        }
        public override void Sound()
        {
            Console.WriteLine(_sound);
        }
        public override void Desc()
        {
            Console.WriteLine(_description);
        }
        public override void History()
        {
            Console.WriteLine(_history);
        }

    }

    //Укулеле
    public class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Укулеле")
        {
            _sound = "Звук Укулеле";
            _description = "Укулеле - четырёхструнная разновидность гитары, используемая для аккордового сопровождения песен и игры соло.";
            _history = "История Укулеле";
        }
        public override void Show()
        {
            Console.WriteLine(_name);
        }
        public override void Sound()
        {
            Console.WriteLine(_sound);
        }
        public override void Desc()
        {
            Console.WriteLine(_description);
        }
        public override void History()
        {
            Console.WriteLine(_history);
        }
    }

    //Виолончель
    public class Cello : MusicalInstrument
    {
        public Cello() : base("Виолончель")
        {
            _sound = "Звук Виолончели";
            _description = "Виолончель -  смычковый музыкальный инструмент с 4-мя струнами, настроенными по квинтам";
            _history = "История Виолончели";
        }
        public override void Show()
        {
            Console.WriteLine(_name);
        }
        public override void Sound()
        {
            Console.WriteLine(_sound);
        }
        public override void Desc()
        {
            Console.WriteLine(_description);
        }
        public override void History()
        {
            Console.WriteLine(_history);
        }
    }
}
