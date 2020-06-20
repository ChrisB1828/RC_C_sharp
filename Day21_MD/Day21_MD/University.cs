using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_MD
{
    class University
    {
        private String name;
        private String lastName;
        private int cours;

        public University(String name, String lastName, int cours)
        {
            this.name = name;
            this.lastName = lastName;
            setCourse(cours);
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setSurname(String lastName)
        {
            this.lastName = lastName;
        }

        public void setCourse(int cours)
        {
            if (cours > 3)
            {
                cours = 3;
            }

            if (cours < 1)
            {
                cours = 1;
            }

            this.cours = cours;
        }

        public void print()
        {
            Console.WriteLine(name);
            Console.WriteLine(lastName);
            Console.WriteLine(cours);
        }

        public String getName()
        {
            return name;
        }

        public String getLastName()
        {
            return lastName;
        }

        public int getCours()
        {
            return cours;
        }
    }
}
