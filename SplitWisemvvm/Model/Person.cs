using System;
using System.Collections.Generic;
using System.Text;

namespace SplitWisemvvm.Model
{
    public class Person
    {
        public string Name { get; set; }

        public float Spent { get; set; }

        public float Share { get; set; }

        public Person(string name, float spent, float share)
        {
            this.Name = name;
            this.Spent = spent;
            this.Share = share;
        }
    }
}
