using System;

namespace ConsoleApplication1
{
    // Event + delegate Ejemplo
    //public delegate void Notify(); // Declaracion del tipo delegado
    //class Program // Clase suscriptora
    //{
    //    static void Main(string[] args)
    //    {
    //        Counter c = new Counter(5);
    //        c.ThresholdReached += c_ThresholdReached; // Suscripcion al evento

    //        Console.WriteLine("press 'a' key to increase total");
    //        while (Console.ReadKey(true).KeyChar == 'a')
    //        {
    //            Console.WriteLine("adding one");
    //            c.Add(1);
    //        }
    //    }

    //    static void c_ThresholdReached() // Manejador del evento 
    //    {
    //        Console.WriteLine("The threshold was reached.");
    //        Environment.Exit(0);
    //    }
    //}

    //class Counter // Clase publicadora del evento 
    //{
    //    public event Notify ThresholdReached; // Declaracion del evento 
    //    private int threshold;
    //    private int total;

    //    public Counter(int passedThreshold)
    //    {
    //        threshold = passedThreshold;
    //    }

    //    public void Add(int x)
    //    {
    //        total += x;
    //        if (total >= threshold)
    //        {
    //            OnThresholdReached();
    //        }
    //    }

    //    protected virtual void OnThresholdReached()
    //    {
    //        ThresholdReached?.Invoke(); 
    //    }
    //}

    //public class ThresholdReachedEventArgs : EventArgs
    //{
    //    public int Threshold { get; set; }
    //    public DateTime TimeReached { get; set; }
    //}


    // Event + EventHandler
    //    public delegate void Notify(); // Declaracion del tipo delegado
    //    class Program // Clase suscriptora
    //    {
    //        static void Main(string[] args)
    //        {
    //            Counter c = new Counter(5);
    //            c.ThresholdReached += c_ThresholdReached; // Suscripcion al evento

    //            Console.WriteLine("press 'a' key to increase total");
    //            while (Console.ReadKey(true).KeyChar == 'a')
    //            {
    //                Console.WriteLine("adding one");
    //                c.Add(1);
    //            }
    //        }

    //        static void c_ThresholdReached(object sender, EventArgs e) // Manejador del evento 
    //        {
    //            Console.WriteLine("The threshold was reached.");
    //            Environment.Exit(0);
    //        }
    //    }

    //    class Counter // Clase publicadora del evento 
    //    {
    //        public event EventHandler ThresholdReached; // Declaracion del evento 
    //        private int threshold;
    //        private int total;

    //        public Counter(int passedThreshold)
    //        {
    //            threshold = passedThreshold;
    //        }

    //        public void Add(int x)
    //        {
    //            total += x;
    //            if (total >= threshold)
    //            {
    //                OnThresholdReached(EventArgs.Empty);
    //            }
    //        }

    //        protected virtual void OnThresholdReached(EventArgs e)
    //        {
    //            ThresholdReached?.Invoke(this, e); //Disparar el evento 
    //        }
    //    }
    //}

    // Event + EventHandler<TEventsArgs>
    using System;

    namespace ConsoleApplication1
    {
        class Program // Clase suscriptora 
        {
            static void Main(string[] args)
            {
                Counter c = new Counter(5);
                c.ThresholdReached += c_ThresholdReached; // Suscripcion al evento

                Console.WriteLine("press 'a' key to increase total");
                while (Console.ReadKey(true).KeyChar == 'a')
                {
                    Console.WriteLine("adding one");
                    c.Add(1);
                }
            }

            static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e) // Manejador de eventos 
            {
                Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
                Environment.Exit(0);
            }
        }

        class Counter // Clase publicadora del evento
        {
            public event EventHandler<ThresholdReachedEventArgs> ThresholdReached; // Declaracion del evento 
            private int threshold;
            private int total;

            public Counter(int passedThreshold)
            {
                threshold = passedThreshold; 
            }

            public void Add(int x)
            {
                total += x;
                if (total >= threshold)
                {
                    ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                    args.Threshold = threshold;
                    args.TimeReached = DateTime.Now;
                    OnThresholdReached(args);
                }
            }

            protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
            {
                ThresholdReached?.Invoke(this, e); //Disparar el evento 
            }


        }

        public class ThresholdReachedEventArgs : EventArgs
        {
            public int Threshold { get; set; }
            public DateTime TimeReached { get; set; }
        }
    }
}