using System;

namespace AnkhMorporkWebApp.Models
{
    public class Player
    {
        public decimal Balance { get; set; } = 100;
        public bool IsAlive { get; set; } = true;
        public int BeerAmount { get; set; }

        public Player()
        {
        }

        public Player(decimal balance)
        {
            this.Balance = balance;
        }

        public Player(decimal balance, int beerAmount)
        {
            this.Balance = balance;
            this.BeerAmount = beerAmount;
        }

        public void GetMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public void GiveMoney(decimal amount, ref bool isValidInput)
        {
            isValidInput = true;
            this.Balance -= amount;
            if (this.Balance <= 0)
            {
                IsAlive = false;
                isValidInput = false;
            }
        }
        
        public string Skip(Type enemy)
        {
            switch (enemy)
            {
                case var _ when enemy.Equals(typeof(Thief)) || enemy.Equals(typeof(Assassin)):
                    IsAlive = false;
                    return "You're killed! Game is over.";
                case var _ when enemy.Equals(typeof(Beggar)):
                    IsAlive = false;
                    return "You're chased to death! Game is over.";
                case var _ when enemy.Equals(typeof(Fool)):
                    return "You rejected the offer.";
                default:
                    return "";
            }
        }
    }
}