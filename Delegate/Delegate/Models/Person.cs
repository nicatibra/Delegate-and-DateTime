namespace Delegate.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public Person(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
