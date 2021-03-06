﻿using System;

namespace simpleinheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion simba = new Lion(true, 456, "Simba");
            AfricanLion mufasa = new AfricanLion(true, 400, "Mufasa");


            Console.WriteLine($"{simba.Name}, {simba.Male}, {simba.Weight}");
        }
    }

    public class Felidae
    {
        private bool male;
        //This constructor calls another contructor
        public Felidae() : this(true)
        {

        }
        // This is the constructor that is inherited
        public Felidae(bool male)
        {
            this.male = male;
        }
        public bool Male
        {
            get
            {
                return this.male;
            }
            set
            {
                this.male = value;
            }
        }

        public virtual void Walk()
        {

        }

        private void LionRoar()
        {
            Console.WriteLine("Roar");
        }
    }
    public class Lion : Felidae, IReproducible<Lion>
    {
        private int weight;
        private string name;


        public Lion(bool male, int weight, string name) : base(male)
        {
            this.weight = weight;
            this.name = name;
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Lion[] IReproducible<Lion>.Reproduce(Lion mate)
        {
            return new Lion[] { new Lion(true, 12, "Charlie"), new Lion(false, 10, "Rose") };
        }


    }

    public class AfricanLion : Lion
    {
        public AfricanLion(bool male, int weight, string name) : base(male, weight, name)
        {

        }
        public override string ToString()
        {
            return string.Format("(AfricanLion, male: {0}, weight: {1}", this.Male, this.Weight);
        }
    }


}
