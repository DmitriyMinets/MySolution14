namespace Exercise_One
{
    public class Kindergarten
    {
        public string Name { get;}
        public int Age { get;}

        public Kindergarten(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public event Event MyEvent = null;

        public void InvokeEvent(Kindergarten kinder)
        {
            if (MyEvent != null)
            {
                MyEvent.Invoke(kinder);
            }
        }
    }
}

/*Создать классы школа и детский садик.
Школа должна подписываться на событие садика,цель события: 
когда ребенок оканчивает садик, он должен быть принят в школу.*/