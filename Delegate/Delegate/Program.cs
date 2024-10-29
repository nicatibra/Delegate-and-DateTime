using Delegate.Models;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Nicat", "Ibrahimli", 19);
            Person person2 = new Person("Azad", "Ashurov", 19);
            Person person3 = new Person("Kamil", "Zeynalov", 19);
            Person person4 = new Person("Aygun", "Kazimova", 34);


            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            Console.WriteLine("---Adi Kamil olanlar:");
            people.FindAll(s => s.Name == "Kamil").ForEach(s => Console.WriteLine(s.Name));

            Console.WriteLine("\n---Soyadi ov ve ova ile bitenler:");
            people.FindAll(s => s.Surname.EndsWith("ova") || s.Surname.EndsWith("ov")).ForEach(s => Console.WriteLine(s.Name + " " + s.Surname));

            Console.WriteLine("\n---Yasi 20+ olanlar:");
            people.FindAll(s => s.Age > 20).ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + "'s age is greater than 20.\n"));


            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            List<Exam> exams = new List<Exam>();
            string subject1 = "Math";
            DateTime start1 = DateTime.Now.AddHours(-1);
            int duration1 = 3;

            string subject2 = "History";
            DateTime start2 = DateTime.Now.AddDays(-2);
            int duration2 = 2;

            string subject3 = "English";
            DateTime start3 = DateTime.Now.AddDays(-3);
            int duration3 = 2;

            Exam exam1 = new Exam(subject1, duration1, start1);
            Exam exam2 = new Exam(subject2, duration2, start2);
            Exam exam3 = new Exam(subject3, duration3, start3);

            exams.Add(exam1);
            exams.Add(exam2);
            exams.Add(exam3);

            Console.WriteLine("\n---2 saatdan uzun olan imtahanlar:");
            exams.FindAll(e => e.ExamDuration > 2).ForEach(exam => Console.WriteLine(exam.Subject + ": " + exam.ExamDuration + " hours."));

            Console.WriteLine("\n---Son 1 hefte erzinde imtahanlar:");
            exams.FindAll(e => e.StartDate >= DateTime.Now.AddDays(-7)).ForEach(exam => Console.WriteLine(exam.Subject + ": " + exam.ExamDuration + " hours."));

            Console.WriteLine("\n---Hal hazirda davam imtahanlar:");
            exams.FindAll(e => e.StartDate <= DateTime.Now && e.EndDate > DateTime.Now).ForEach(exam => Console.WriteLine(exam.Subject + ": " + exam.ExamDuration + " hours."));







        }
    }
}
