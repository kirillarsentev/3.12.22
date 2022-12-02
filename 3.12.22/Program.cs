using _3._12._22.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _3._12._22
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Задача 1");

            List<string> names1 = new List<string>();
            string path1 = "note1.txt";
            // асинхронное чтение
            using (StreamReader reader = new StreamReader(path1))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    names1.Add(line);
                }
                
            }
            Console.WriteLine("Студенты группы 09-221");
            for (int i = 0; i < names1.Count; i++)
            {
                Console.WriteLine(names1[i]);
            }



            List<Student> students = new List<Student>();

            Student student1 = new Student(names1[0]);
            Student student2 = new Student(names1[1]);
            Student student3 = new Student(names1[2]);

            students.Add(student1);
            students.Add(student3);
            students.Add(student2);



            Event @event = new Event();

            @event.WriteInfo();
            Random random = new Random();
            List<string> event_student = new List<string>();
            for (int i = 0; i < @event.student_count; i++)
            {

                event_student.Add(students[random.Next(0,@event.student_count)].name);
            }

            string path = "События.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLineAsync("Предстоящее событие :");
                writer.WriteLineAsync(@event.event_name);
                writer.WriteLineAsync("Дата проведения мероприятия :");
                writer.WriteLineAsync(@event.event_date);
                writer.WriteLineAsync("Участники предстоящего мероприятия : ");
                for(int i = 0; i < event_student.Count; i++)
                {
                    writer.WriteLineAsync(event_student[i]);
                }

            }
            Console.WriteLine("Мероприятие, дата и участники записаны в файл");




            Console.WriteLine("Задача 2");
            Employees employees1 = new Employees();
            Employees employees2 = new Employees();
            Employees employees3 = new Employees();
            Console.WriteLine("Введите предстоящее событие из списка" + '\n' +  "События : " + '\n' + "День первокурсника" + '\n' 
                + "Посвящение в первокурсники" + '\n' + "Студбатл");
            string event_name = Console.ReadLine();

            if (event_name == "День первокурсника")
            {
                Event += employees1.EmployeeReaction;
                Event("Ура!");
            }
            else if (event_name == "Посвящение в первокурсники")
            {
                Event += employees2.EmployeeReaction;
                Event("Ура! Снова пить!");
            }
            else if (event_name == "Студбатл")
            {
                Event += employees3.EmployeeReaction;
                Event("Фу, только не я");
            }
            else
            {
                Console.WriteLine("Нет такого предстоящего события, тупица");
            }




        }
        public static event ShowReaction Event;
        
    }
    public delegate void ShowReaction(string react);
}
