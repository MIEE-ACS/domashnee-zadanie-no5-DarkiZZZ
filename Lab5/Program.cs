using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Counter counter = new Counter();
            Console.WriteLine(counter.getCondition);
            while (counter.error == null)
            {
                counter.Increase();
                Console.WriteLine(counter.getCondition);
            }
            Console.WriteLine(counter.error);
            while (counter.getCondition != 0)
            {
                counter.Decrease();
                Console.WriteLine(counter.getCondition);
            }
            Console.WriteLine(counter.error);
            Console.ReadKey(true);
        }
    }

    public class Counter
    {
        int presentCondition;
        int upperStop;
        int lowerStop;
        public string error;
        

        public Counter()
        {
            this.presentCondition = 0;
            this.lowerStop = 0;
            this.upperStop = 10;
        }

        public Counter(int x, int MinValue, int MaxValue)
        {

            int T = Math.Min(MinValue, MaxValue);
            if (T != MinValue)
            {
                MaxValue = MinValue;
                MinValue = T;
            }
            if (presentCondition < MinValue || presentCondition > MaxValue)
            {
                this.presentCondition = MinValue;
            }
            else
            {
                this.presentCondition = presentCondition;
            }
            this.lowerStop = MinValue;
            this.upperStop = MaxValue;
        }

        public int getCondition
        {
            get
            {
                return this.presentCondition;
            }
        }

        public void Increase()
        {
            this.presentCondition++;
            if (this.presentCondition >= this.upperStop)
            {
                this.presentCondition = this.upperStop;
                this.error = "Превышено допустимое значение";
            }
        }

        public void Decrease()
        {
            this.presentCondition--;
            if (this.presentCondition <= this.lowerStop)
            {
                this.presentCondition = this.lowerStop;
                this.error = "Превышено допустимое значение";
            }
        }
    }
}

        
        
        

