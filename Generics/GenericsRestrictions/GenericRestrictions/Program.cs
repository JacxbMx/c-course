using System;

namespace GenericRestrictions
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> directores = new AlmacenEmpleados<Director>(4);
            directores.SetElemento(new Director(12134));
        }
    }

    //Declaracion de una clase generica con una restriccion dada por una interfaz
    class AlmacenEmpleados<T> where T: IParaEmpleados
    {
        private int i = 0;
        private T[] datosEmpleado;

        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }

        public void SetElemento(T obj)
        {
            datosEmpleado[i] = obj;
            i++;
        }

        public T GetElemento(int i)
        {
            return datosEmpleado[i];
        }
    }

    class Director : IParaEmpleados
    {
        private double salario;

        public Director(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }
    class Secretaria : IParaEmpleados
    {
        private double salario;

        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }
    class Electricista : IParaEmpleados
    {
        private double salario;

        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }
    class Estudiante
    {

    }
    interface IParaEmpleados
    {
        double GetSalario();
    }
}
