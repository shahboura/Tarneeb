﻿namespace Tarneeb.Engine.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player() { }

        public Player(string name)
        {
            Name = name;
        }
    }
}