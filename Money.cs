using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

namespace HW_04_05_06_2024
{
    internal class Money
    {
        private int _banknote;
        private int _coin;
        private void coinToBanknote()
        {
            if (_coin >= 100)
            {
                int var = _coin;
                _coin = var%100;
                _banknote += (var - _coin)/100;
            }
        }
        public Money() { }
        public Money(double money)
        {
            _banknote = (int)money;
            _coin = (int)(money*100%100);
        }
        public override string ToString()
        {
            return $"Banknote: {_banknote}, Coin: {_coin}";
        }
        public int Banknote
        {
            get { return _banknote; }
            set
            {
                _banknote = value;
            }
        }
        public int Coin
        {
            get { return _coin; }
            set
            {
                _coin = value;
            }
        }
        public void addBancnote(int money)
        {
            _banknote+=money;
        }
        public void addCoin(int coin)
        {
            _coin += coin;
            coinToBanknote();
        }
        public void takeBancnote(int money)
        {
            if (_banknote>money && _banknote!=0)
            {
                _banknote -= money;
            }
            else
            {
                throw new Exception("Not enough money!");
            }
        }
        public void takeCoin(int coin)
        {
            while (coin>_coin)
            {
                takeBancnote(1);
                _coin += 100;
            }
            _coin -= coin;
        }
    }

    internal class Product : Money
    {
        private string _name;

        public Product() { }
        public Product(string name) { }
        public Product(string name, double money) : base(money)
        {
            _name = name;
        }
        public void makeCheaper(double money)
        {
            if ((int)money < base.Banknote)
            {
                base.takeBancnote((int)money);
                base.takeCoin((int)(money * 100 % 100));
            }
            else
            {
                throw new Exception("Impossible to get cheaper 0!");
            }
            
        }
        public void makeMoreExpensive(double money)
        {
            int val, coin;
            val = (int)money;
            coin = (int)(money * 100 % 100);
            base.addBancnote(val);
            base.addCoin(coin);
        }
        public override string ToString()
        {
            return $"Product: {_name} Price: {base.Banknote}.{base.Coin}";
        }

    }
}
