using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class FishItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsRaw { get; set; }
        public int HealValue { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public FishItem(int id, string name, bool isRaw,
            int healValue, int value, string description)
        {
            ID = id;
            Name = name;
            IsRaw = isRaw;
            HealValue = healValue;
            Value = value;
            Description = description;
        }

        public FishItem()
        {

        }

        public void AddToAmount(int amount)
        {
            Amount += amount;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
