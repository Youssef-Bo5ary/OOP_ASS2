using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASS2.ASS_PART2
{
    internal struct Person
    {
       
       string[] Name; int[] Age; 
        public int Size { set; get; }

        public Person( int size)
        {
            Name = new string[size];
            Age = new int[size];
            this.Size = size;
        }
        public void AddPerson(int index, string name, int age)
        {
            if(name is not null && age >=0)
            {
                if(index<Size)
                    Name[index] = name; 
                    Age[index] = age;
            }
            Console.WriteLine("invalid");
        } 

        public string this[int index]
        {
            get
            {
                return $"the index is{index},the name is{Name[index]},the Age is{Age[index]}";
            }
        }

    }
}
