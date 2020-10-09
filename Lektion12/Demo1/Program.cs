using System;

namespace Demo1
    //Value and refenrece Type Variables
{
    struct MyDataType                //Vi ersätter class med struct
    {
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDataType my = default;     //new MyDataType(); <-- den ersätts med default. Då vi jobbar med struct skriver man default. När man jobbar med klass skriver man new. 
            my.Age = 58;
            Console.WriteLine(my.Age);      //58
            DoubleAge(my);
            Console.WriteLine(my.Age);      //116   --- När vi bytte class till struct så blev denna 58 istället
            //DoubleAge(my), my kopieras in från myparameter?
            //DoubleAge tilldelas: Myparameter = my;?
        }

        private static void DoubleAge(MyDataType myParameter)
        {
            myParameter.Age *= 2;
        }
    }
}
