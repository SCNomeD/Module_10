using System;

namespace Module_10_1
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();


            var worker1 = new Worker1(Logger);
            var worker2 = new Worker2(Logger);
            var worker3 = new Worker3(Logger);

            worker1.Work();
            worker2.Work();
            worker3.Work();

            Console.ReadKey();
        }
    }
    #region Start
    //public interface IWriter
    //{
    //    void Write()
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //}
    //public class Writer : IWriter
    //{

    //}
    #endregion
    #region Proceed
    //public interface ILogger
    //{
    //    void Write()
    //    {
    //        Console.WriteLine("Hello! I am Logger!");
    //    }
    //}
    //public interface IWriter
    //{
    //    void Write()
    //    {
    //        Console.WriteLine("Hello! I am Writer!");
    //    }
    //}
    //public class BuisnessLogic: ILogger, IWriter
    //{

    //}
    #endregion
    #region ScreenCast
    public interface ILogger
    {
        void Event(string massage);
        void Error(string massage);
    }
    public class Logger: ILogger
    {
        public void Event(string massage)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(massage);
        }
        public void Error(string massage)
        {
            Console.WriteLine(massage);
        }
    }
    public interface IWorker
    {
        void Work();
    }
    #endregion
}
