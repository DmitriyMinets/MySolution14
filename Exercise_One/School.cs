using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_One
{
    public class School
    {
        private List<Kindergarten> nameList = new List<Kindergarten>();

        private const int AGE_FOR_SCHOOL = 7;

        public void OnReacheadAge(Kindergarten kinder)
        {
            if(kinder.Age >= AGE_FOR_SCHOOL)
            {
                nameList.Add(kinder);
            }
        }

        public void Show()
        {
            Console.WriteLine(nameList.Count);
            foreach(var item in nameList)
            {
                Console.Write(item.Name + " - " + item.Age + " лет принят(a) в школу\n");
            }
        }
    }
}


/*Создать классы школа и детский садик.
Школа должна подписываться на событие садика,цель события: 
когда ребенок оканчивает садик, он должен быть принят в школу.*/