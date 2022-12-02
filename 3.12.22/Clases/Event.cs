using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12._22
{
    class Event
    {
        public string event_name;
        public string event_date;
        public int student_count;
        public void WriteInfo()
        {
            Console.WriteLine("Создайте новое событие" + '\n' + "Введите название события");
            event_name = Console.ReadLine();
            Console.WriteLine("Введите дату события");
            event_date = Console.ReadLine();
            Console.WriteLine("Введите количество участников мероприятия");
            student_count = Convert.ToInt32(Console.ReadLine());
        }
    }
}
