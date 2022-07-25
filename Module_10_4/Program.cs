using System;

namespace Module_10_4
{
    #region Start
    //// Создадим обобщенный интерфейс IMessenger, который при вызове функции DeviceInfo, будет возвращать объект T:
    //public interface IMessenger<T>
    //{
    //    T DeviceInfo(); // В качестве параметра T будет выступать либо класс, либо параметр, который мы укажем при реализации. 
    //}

    //// Далее мы создаём два класса: Phone и Computer.
    //public class Phone
    //{

    //}
    //public class Computer
    //{

    //}

    //// А теперь реализуем наш интерфейс IMessenger<T> через класс Phone:
    //public class Viber : IMessenger<Phone> // Обобщенный интерфейс IMessenger реализован через класс Phone
    //{
    //    public Phone DeviceInfo() // И при вызове функции DeviceInfo возвращает объект Phone, который указан в качестве параметра T.
    //    {
    //        return null;
    //    }
    //}
    #endregion
    #region Proceed (ключевое слово "out" - ковариантность)
    //// Изменим наш интерфейс IMessenger следующим образом:
    //public interface IMessenger<out T> // Слово out указывает, что интерфейс IMessenger теперь является ковариантным.
    //{
    //    T DeviceInfo();
    //}

    //// Для начала создаём класс Phone и IPhone. IPhone наследуем от класса Phone:
    //public class Phone
    //{

    //}
    //public class IPhone : Phone
    //{

    //}

    //// Далее необходимо сделать класс Viber обобщённым и определить его следующим образом:
    //public class Viber<T> : IMessenger<T> where T : Phone, new()
    //{
    //    public T DeviceInfo()
    //    {
    //        T device = new T();
    //        Console.WriteLine(device);
    //        return new T();
    //    }
    //}

    //// Далее переходим в класс Main и выполняем реализацию обобщенного интерфейса IMessenger двух типов: Phone и IPhone.
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IMessenger<Phone> viberInPhone = new Viber<Phone>();
    //        IMessenger<IPhone> viberInIPhone = new Viber<IPhone>();
    //        // И вот теперь можем посмотреть на ковариацию.
    //        // Объект интерфейса более универсального типа Phone мы можем привести к объекту интерфейса более конкретного типа IPhone следующей строкой:
    //        IMessenger<Phone> viberInIphone = new Viber<IPhone>();

    //        viberInPhone.DeviceInfo();
    //        viberInIPhone.DeviceInfo();
    //        // Ковариация
    //        viberInIphone.DeviceInfo();

    //        Console.Read();

    //        // Для проверки удаляем слово out перед интерфейсом и видим, что наш код больше не работает!
    //        // Обобщённый интерфейс с параметром out реализовал нашу ковариацию.
    //    }
    //}
    #endregion
    #region Proceed (ключевое слово "in" - контрвариантность)
    //// Для демонстрации контравариации воспользуемся тем же самым кодом и изменим наш интерфейс IMessenger следующим образом:
    //public interface IMessenger<in T>
    //{
    //    void DeviceInfo(T device);
    //}

    //public class Phone
    //{

    //}
    //public class IPhone : Phone
    //{

    //}

    //public class Viber<T> : IMessenger<T> where T : Phone, new()
    //{
    //    public void DeviceInfo(T device)
    //    {
    //        Console.WriteLine(device);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IMessenger<Phone> viberInPhone = new Viber<Phone>();
    //        viberInPhone.DeviceInfo(new Phone());

    //        IMessenger<IPhone> viberInIPhone = new Viber<IPhone>();
    //        viberInIPhone.DeviceInfo(new IPhone());

    //        // И снова магия контравариции. Данной строкой мы выполняем приведение объекта интерфейса более универсального типа Phone к объекту интерфейса более конкретного типа IPhone.
    //        IMessenger<IPhone> viberInIphone = new Viber<Phone>();
    //        viberInIphone.DeviceInfo(new IPhone());

    //        Console.Read();
    //    }
    //}
    #endregion
    #region ScreenCast
    //class Program
    //{
    //    void Main()
    //    {
    //        IGarageManager<Car, Garage> garageManager1 = new GarageManagerBase();
    //        IGarageManager<Bike, Garage> garageManager2 = new GarageManagerBase();
    //        IGarageManager<Bike, House> garageManager3 = new GarageManagerBase();
    //    }
    //}
    //public class Car
    //{

    //}

    //public class Bike : Car
    //{

    //}
    //public class House
    //{

    //}

    //public class Garage : House
    //{

    //}
    //public interface IGarageManager<in T, out Z>
    //{
    //    void Add(T car);
    //    Z GetGarageInfo();
    //}
    //public class GarageManagerBase : IGarageManager<Car, Garage>
    //{
    //    public void Add(Car car)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public Garage GetGarageInfo()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    #endregion
    #region 10.4.4
    class Program
    {
        void Main()
        {
            var user = new User();
            var account = new Account();

            IUpdater<Account> updater = new UserService();

            var userService = new UserService();
            userService.Update(user);

            // IUpdater<User> updater1 = new UserService();
            // updater1.Update(user);
        }
    }
    public class User
    {

    }

    public class Account : User
    {

    }
    public interface IUpdater<in T>
    {
        void Update(T entity);
    }
    public class UserService : IUpdater<User>
    {
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
