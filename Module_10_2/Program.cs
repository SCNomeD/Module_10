using System;

namespace Module_10_2
{
    #region Start
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        NewMessenger newMessenger = new NewMessenger();

    //        ((IWhatsApp)newMessenger).SendMessage("Hello World!");
    //        ((IViber)newMessenger).SendMessage("Hello World!");

    //        Console.ReadKey();
    //    }
    //}
    //public class NewMessenger : IWhatsApp, IViber
    //{
    //    void IWhatsApp.SendMessage(string message)
    //    {
    //        Console.WriteLine("{0} : {1}", "WhatsApp", message);
    //    }

    //    void IViber.SendMessage(string message)
    //    {
    //        Console.WriteLine("{0} : {1}", "Viber", message);
    //    }
    //}
    //public interface IWhatsApp
    //{
    //    public void SendMessage(string message);
    //}
    //public interface IViber
    //{
    //    public void SendMessage(string message);
    //}
    #endregion
    #region ScreenCast
    //class Program
    //{

    //}
    //public interface ICalculator
    //{
    //    void Solve(int number);
    //    void Solve(int numberOne, int numberTwo);
    //}
    //public class BaseCalculator : ICalculator
    //{
    //    // Неявная реализация
    //    public void Solve(int number)
    //    {

    //    }
    //    public void Solve(int numberOne, int numberTwo)
    //    {

    //    }

    //    // Явная реализация
    //    void ICalculator.Solve(int number)
    //    {

    //    }

    //    void ICalculator.Solve(int numberOne, int numberTwo)
    //    {

    //    }
    //}
    #endregion
    #region 10.2.2 (явная реализация интерфейса)
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Writer writer = new Writer();

    //        ((IWriter)writer).Write();

    //        Console.ReadKey();
    //    }
    //}
    //public interface IWriter
    //{
    //    void Write();
    //}
    //public class Writer : IWriter
    //{
    //    void IWriter.Write()
    //    {

    //    }
    //}
    #endregion
    #region 10.2.3 (неявная реализация интерфейса)
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Worker worker = new Worker();

    //        worker.Build();

    //        Console.ReadKey();
    //    }
    //}
    //public interface IWorker
    //{
    //    public void Build();
    //}
    //public class Worker : IWorker
    //{
    //    public void Build()
    //    {

    //    }
    //}
    #endregion
    #region 10.2.4
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

            ((IWorker)worker).Build();

            Console.ReadKey();
        }
    }
    public interface IWorker
    {
        public void Build();
    }
    public class Worker : IWorker
    {
        void IWorker.Build()
        {

        }
    }
    #endregion
}
