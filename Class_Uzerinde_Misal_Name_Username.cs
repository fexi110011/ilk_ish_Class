﻿namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human12 = new Human("Fexreddin");
            Human human123 = new Human("Fexreddin","Ehmedov");
            human1.ShowFullData();
            human12.ShowFullData();
            human123.ShowFullData();

            User adam1 = new User("Mehemmed","Rehmenov","Mehemmed12345","salam1234");
            adam1.ShowUserInfo();

        }
    }
    class Human
    {
        string name;
        string surname;
        byte[] age;

        public Human()
        {
            
        }
        public Human(string name)
        {
            this.name = name;
        }
        public Human(string name, string surname):this(name)
        {
            this.surname = surname;
        }

        public void ShowFullData()
        {
            Console.WriteLine("Ad: " + name + ",Soyad: " + surname + ",Age: " + age);
        }
        public string GetFullName()
        {

            return name + " " + surname;
        }
    }
    class User:Human
    {
        public string Username;
        public string Password;
        public User(string name, string surname, string username, string password):base(name,surname) 
        {
            Username = username;
            Password = password;
        }
        public void ShowUserInfo()
        {
            Console.WriteLine("Tam Ad:  " + GetFullName()+ "-------" + "UserName:  "+ Username);
        }
    }
}
