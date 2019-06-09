using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class SmithingItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsBar { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

        public SmithingItem(int id, string name, bool isBar, int value, string description)
        {
            ID = id;
            Name = name;
            IsBar = isBar;
            Value = value;
            Description = description;
        }
    }
}
