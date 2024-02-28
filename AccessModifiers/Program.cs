using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        //eg. private int ... sadece tanımlandığı sınıf içerisinde kullanılabilir
        //eg. protected int .. İnherit edildiği sınıflarda kullanılabilir.
        protected int Id { get; set; }
        public void Save()
        {
            Id++;
        }
        public void Delete()
        {
            Id--;
        }
    }
    class Student : Customer
    {
        public void Save2()
        {
            Id = 1;

        }
    }
    public class Course
    {
        public string Name { get; set; }
    }
}