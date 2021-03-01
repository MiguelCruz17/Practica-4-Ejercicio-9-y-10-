using System;

namespace Practica_4_Ejercicio_9_y_10_
{
  //Ejercicio 9
        
        #region 

        //Crear una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de multiplicar de dicho valor. Finalizar el programa al ingresar el -1.
        
        #endregion

    /*class Tabla
    {
        
        private int num;

        public void Ingresar()
        {
            Console.WriteLine("\nSi desea salir del programa pulse -1\n");
            Console.WriteLine("\nIngrese un número");
            num = int.Parse(Console.ReadLine());


        }
        public void Imprimir()
        {


            int i = 0, result;

            do
            {
                if (num == -1)
                {
                    Environment.Exit(0);

                }
                i++;
                result = i * num;
                Console.WriteLine("{0} X {1} = {2}", num, i, result);


            } while (i <= 9 && num != -1);

        }

 static void Main(string[] args)
        {
            

            Tabla resultado = new Tabla();
            resultado.Ingresar();
            resultado.Imprimir();
            resultado.Ingresar();
            resultado.Imprimir();
            resultado.Ingresar();
            resultado.Imprimir();
            resultado.Ingresar();
            resultado.Imprimir();
            resultado.Ingresar();
            resultado.Imprimir();
            resultado.Ingresar();
            resultado.Imprimir();
            resultado.Ingresar();
            resultado.Imprimir();

        }

    }*/

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //Ejercicio 10

    #region 

    //Confeccionar una clase que permita carga el nombre y la edad de una persona. Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18).

    #endregion
    /*class Persona
    {
        private string nombre;
        private int edad;

        public void InicioMetodo()
        {
            Console.WriteLine("\nIntroduzca su nombre");
            nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca su edad");
            edad = int.Parse(Console.ReadLine());

        }
        public void ImprimirDatos()
        {

            Console.WriteLine("\nSu nombre es: {0}", nombre);
            Console.WriteLine("Su edad es: {0}", edad);

            if (edad >= 18)
            {
                Console.WriteLine("\nUsted es mayor de edad\n");
            }
            else
            {
                Console.WriteLine("\nUsted es menor de edad\n");
            }
            Environment.Exit(0);
        }


        static void Main(string[] args)
        {
            Persona resultado = new Persona();
            resultado.InicioMetodo();
            resultado.ImprimirDatos();

        }
    }*/
}
