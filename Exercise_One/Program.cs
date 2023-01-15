namespace Exercise_One
{
    public delegate void Event(Kindergarten kinder);
    internal class Program
    {
        static void Main(string[] args)
        {
            Kindergarten kinder = new Kindergarten("Паша", 8);
            Kindergarten kinder1 = new Kindergarten("Юля", 6);
            Kindergarten kinder2 = new Kindergarten("Даша", 9);
            School school = new School();
            kinder.MyEvent += school.OnReacheadAge;
            kinder.InvokeEvent(kinder);
            kinder1.MyEvent += school.OnReacheadAge;
            kinder1.InvokeEvent(kinder1);
            kinder2.MyEvent += school.OnReacheadAge;
            kinder2.InvokeEvent(kinder2);

            school.Show();

        }
    }

    //public class ThresholdReachedEventArgs : EventArgs 
    //{
    //    public int Threshold { get; set; }
    //}

}

/*Создать классы школа и детский садик.
Школа должна подписываться на событие садика,цель события: 
когда ребенок оканчивает садик, он должен быть принят в школу.*/