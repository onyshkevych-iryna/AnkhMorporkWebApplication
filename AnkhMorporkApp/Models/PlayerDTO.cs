﻿using System;

namespace AnkhMorporkApp.Models
{
    public class PlayerDTO
    {
        public decimal Balance { get; set; } = 100;
        public bool IsAlive { get; set; } = true;
        public int BeerAmount { get; set; }

        public PlayerDTO()
        {
        }

        public PlayerDTO(decimal balance)
        {
            this.Balance = balance;
        }

        public PlayerDTO(decimal balance, int beerAmount)
        {
            this.Balance = balance;
            this.BeerAmount = beerAmount;
        }

        public void GetMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public void GiveMoney(decimal amount, ref bool validOutput)
        {
            this.Balance -= amount;
            validOutput = true;

            if (this.Balance <= 0)
            {
                validOutput = false;
                IsAlive = false;
                //ConsoleColorChanger.ChangeColor("You don't have enough money! Game is over.", ConsoleColor.Red);
            }
        }

        public bool IsOutOfMoney(decimal input)
        {
            if (Balance >= input)
            {
                return false;
            }

            //ConsoleColorChanger.ChangeColor("You don't have enough money! Game is over.", ConsoleColor.Red);
            IsAlive = false;
            return true;
        }

        public bool EnteredSumIsCorrect(decimal input)
        {
            if (Balance >= input)
            {
                return true;
            }

            //Console.WriteLine("You don't have that sum of money! Please, try again:");
            return false;
        }

        public string Skip(Type enemy)
        {
            switch (enemy)
            {
                case var _ when (enemy.Equals(typeof(Thief)) || enemy.Equals(typeof(Assassin))):
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
        //public decimal Balance { get; set; } = 100;
        //public bool IsAlive { get; set; } = true;
        //public int BearAmount { get; set; }

        //public Player()
        //{
        //}

        //public Player(decimal balance)
        //{
        //    this.Balance = balance;
        //}

        //public void GetMoney(decimal amount, ref bool validOutput)
        //{
        //    this.Balance += amount;
        //    validOutput = true;
        //}

        //public void GiveMoney(decimal amount)
        //{
        //    this.Balance -= amount;
        //    if (this.Balance <= 0)
        //    {
        //        IsAlive = false;
        //        //ConsoleColorChanger.ChangeColor("You don't have enough money! Game is over.", ConsoleColor.Red);
        //    }
        //}

        //public bool IsOutOfMoney(decimal input)
        //{
        //    if (Balance >= input)
        //    {
        //        return false;
        //    }
        //    //ConsoleColorChanger.ChangeColor("You don't have enough money! Game is over.", ConsoleColor.Red);
        //    IsAlive = false;
        //    return true;
        //}

        //public bool EnteredSumIsCorrect(decimal input)
        //{
        //    if (Balance >= input)
        //    {
        //        return true;
        //    }
        //    //Console.WriteLine("You don't have that sum of money! Please, try again:");
        //    return false;
        //}

        //public string Skip(Type enemy)
        //{
        //    switch (enemy)
        //    {
        //        case var _ when (enemy.Equals(typeof(Thief)) || enemy.Equals(typeof(Assassin))):
        //            IsAlive = false;
        //            return "You're killed! Game is over.";
        //        case var _ when enemy.Equals(typeof(Beggar)):
        //            IsAlive = false;
        //            return "You're chased to death! Game is over.";
        //        case var _ when enemy.Equals(typeof(Fool)):
        //           return "You rejected the offer.";
        //        default:
        //            return "";
        //    }
        //}
    }
}