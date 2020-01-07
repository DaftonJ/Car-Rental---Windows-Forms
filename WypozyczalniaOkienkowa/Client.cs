using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaOkienkowa
{
    public class Client
    {
        public delegate void MoneyChange();
        public event MoneyChange OnMoneyChanged;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        private decimal money;

        public decimal Money
        {
            get => money;
            set
            {
                money = value;
                OnMoneyChanged?.Invoke();
            }
        }


        public string Login { get; set; }
        public string Password { get; set; }

        public List<Contract> Contracts { get; set; }= new List<Contract>();

        public Client(string name, string surname, int age, decimal money)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Money = money;
        }

        public void Register(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
