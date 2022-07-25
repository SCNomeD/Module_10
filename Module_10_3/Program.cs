using System;

namespace Module_10_3
{
    #region ScreenCast (множественная реализация)
    //class Program
    //{
    //    static void Main()
    //    {
    //        IFile file = new FileInfo();
    //        IBinaryFile binaryFile = new FileInfo();
    //        FileInfo fileInfo = new FileInfo();

    //        file.ReadFile();

    //        binaryFile.ReadFile();
    //        binaryFile.OpenBinaryFile();

    //        fileInfo.Search("Строка для поиска");

    //        Console.ReadKey();
    //    }
    //}
    //public interface IFile
    //{
    //    void ReadFile();
    //}
    //public interface IBinaryFile
    //{
    //    void ReadFile();
    //    void OpenBinaryFile();
    //}
    //public class FileInfo : IFile, IBinaryFile
    //{
    //    void IBinaryFile.OpenBinaryFile()
    //    {
    //        Console.WriteLine("Открываем бинарный файл...");
    //    }

    //    void IFile.ReadFile()
    //    {
    //        Console.WriteLine("Читаем текстовый файл...");
    //    }

    //    void IBinaryFile.ReadFile()
    //    {
    //        Console.WriteLine("Читаем бинарный файл...");
    //    }
    //    public void Search(string text)
    //    {
    //        Console.WriteLine("Начался поиск текста в файле...");
    //    }
    //}
    #endregion
    #region 10.3.1
    //public interface IWriter
    //{
    //    void Write();
    //}

    //public interface IReader
    //{
    //    void Read();
    //}

    //public interface IMailer
    //{
    //    void SendEmail();
    //}
    //public class FileManager : IWriter, IReader, IMailer
    //{
    //    public void Read()
    //    {

    //    }

    //    public void SendEmail()
    //    {

    //    }

    //    public void Write()
    //    {

    //    }
    //}
    #endregion
    #region 10.3.2 (множественная неявная реализация)
    //public interface ICreatable
    //{
    //    void Create();
    //}

    //public interface IDeletable
    //{
    //    void Delete();
    //}

    //public interface IUpdatable
    //{
    //    void Update();
    //}
    //public class Entity : ICreatable, IDeletable, IUpdatable
    //{
    //    public void Create()
    //    {

    //    }

    //    public void Delete()
    //    {

    //    }

    //    public void Update()
    //    {

    //    }
    //}
    #endregion
    #region 10.3.3 (множественная явная реализация)
    public interface IBook
    {
        void Read();
    }

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }
    public class ElectronicBook : IBook, IDevice
    {
        void IBook.Read()
        {
            
        }

        void IDevice.TurnOff()
        {
            
        }

        void IDevice.TurnOn()
        {
            
        }
    }
    #endregion
}
