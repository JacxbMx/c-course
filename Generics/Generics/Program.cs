using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cuando instanciamos una clase generica debemos especificar en la instanciacion el tipo de dato que utilizaremos
            StoreObjects<string> storeNames = new StoreObjects<string>(4);
            storeNames.SetObject("Juan");
            storeNames.SetObject("Pedro");
            storeNames.SetObject("Jafet");
            storeNames.SetObject("Luis");

         

            StoreObjects<int> storeAges = new StoreObjects<int>(4);
            storeAges.SetObject(24);
            storeAges.SetObject(24);
            storeAges.SetObject(25);
            storeAges.SetObject(26);

            StoreObjects<Car> storeCars = new StoreObjects<Car>(4);
            storeCars.SetObject(new Car("Avanza"));
            storeCars.SetObject(new Car("i10"));
            storeCars.SetObject(new Car("Jetta"));
            storeCars.SetObject(new Car("Honda"));

            string name = storeNames.GetObject(2);
            int age = storeAges.GetObject(2);
            Car car = storeCars.GetObject(2);
            Console.WriteLine($"{name}  {age}  {car.GetCar()}");


        }
    }


    //Para crear una clase generico solo neceistamos especificar a continuacion del nombre de la clase entre <> un generico.
    //Un generico se indica simplemente  con una letra que por convencion en c# suele ser una T
   
    class StoreObjects<T>
    {
        private int i = 0;
        public T [] objectsArray;

        public StoreObjects(int z)
        {
            objectsArray = new T[z];
        }

        public void SetObject(T obj)
        {
            objectsArray[i] = obj;
            i++;
        }

        public T GetObject(int i)
        {
            return objectsArray[i];
        }
    }

    // Clases genericas con restricciones
    // las restricciones en las clases genericas surgen para solucionar un error
    // le podemos decir a unda clase generica que solo maneje objetos que tenga una determinada restriccion o caracteristica
    class Car {
        public string carModel;
         public Car(string carModel)
         {
            this.carModel = carModel;
         }
        
        public string GetCar()
        {
            return carModel;
        }
    }
}
