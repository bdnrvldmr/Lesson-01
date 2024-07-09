using System;
using System.Linq.Expressions;

namespace Lesson_01
{

    
    internal class Human
    {
        public string name { get; set; }
        public int age { get; set; }
        public string lastName { get; set; }
    }

    internal class Builder:Human
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; }= string.Empty;
        public string Robota = "Builder";

        public string ToString() => $"Robota: {Robota}\nName: {this.name}\nLast Name: {this.lastName}\nAge:{this.age}\nPhone number:{PhoneNumber}";
    }

    internal class Sailor : Human
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Robota = "Sailor";
        public string ToString() => $"Robota: {Robota}\nName: {this.name}\nLast Name: {this.lastName}\nAge:{this.age}\nPhone number:{PhoneNumber}";
    }

    internal class Pilot : Human
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Robota = "Pilot";
        public string ToString() => $"Robota: {Robota}\nName: {this.name}\nLast Name: {this.lastName}\nAge:{this.age}\nPhone number:{PhoneNumber}";
    }

    public static class App
    {
        public static void Main()
        {
            Builder firstB = new Builder();
            firstB.ToString();
        }
    }
}


