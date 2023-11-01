using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Human
{
    public class Human
    { 
        //СТАТИЧНО ПОЛЕ И СВОЙСТВО - СПИСЪК СЪС СЪЗДАДЕНИТЕ ОБЕКТИ
        private static List<Human> people = new List<Human>();
        public static List<Human> People 
        {
            get 
            {
                return Human.people;
            }
        }
        //СВОЙСТВО - ИМЕ
        public string Name { get; }
        
        //СВОЙСТВО И ПОЛЕ - ГОДИНИ
        private int age;
        public int Age {
            get 
            {
                return this.age;
            }
            private set 
            {
                if (value < 0) throw new ArgumentException("Грешка!");
                else this.age = value;
            } 
        }
        //СВОЙСТВО И ПОЛЕ - ЕГН
        public string EGN { get;}

        //КОНСТРУКТОР
        public Human(string name, int age, string Egn) 
        {
            this.Name = name;
            this.Age = age;
            this.EGN = Egn;
            people.Add(this);
        }

        //МЕТОДИ НА ОБЕКТА
        public void Print() 
        {
            Console.WriteLine("Име: {0}, Години: {1}, ЕГН: {2}", this.Name, this.Age, this.EGN);
        }

        public void GetOlder() 
        {
            this.Age += 1;
        }

        public Human CopyObject() 
        {
            return new Human(this.Name, this.Age, this.EGN);
        }

        //СТАТИЧЕН МЕТОД
        public static void ListPeople() 
        {
            foreach (Human person in People)
            {
                Console.WriteLine("Име: {0}, Години: {1}, ЕГН: {2}", person.Name, person.Age, person.EGN);
            }
        }
    }
}
