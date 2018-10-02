using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pedir dos números y decir si son iguales o no

            int num1, num2;

            Console.WriteLine("Introduzca un número");            
            num1 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Introduce otro número");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Sus números son iguales.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sus números son distintos.");
            }


            //Introduce un número e indica si par o impar

            double num3, num4;

            Console.WriteLine("Introduzca un número");
            num3 = Convert.ToInt32(Console.ReadLine());            

            if (num3 % 2 == 0)
            {
                Console.WriteLine("Su número es par");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Su número es impar");
                Console.ReadLine();
            }

            //Pedir un número del 1 al  y decir que dia de la semena es.

            int dia;

            Console.WriteLine("Introduzca un número del 1 al 7");
            dia = Convert.ToInt32(Console.ReadLine());

            if (dia == 1)
            {
                Console.WriteLine("Lunes");           
            }
            else if (dia == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (dia == 3)
            {
                Console.WriteLine("Miércoles");
            }
            else if (dia == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (dia == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (dia == 6)
            {
                Console.WriteLine("Sábado");
            }
            else if (dia == 7)
            {
                Console.WriteLine("Domingo");
            }
            else
            {
                Console.WriteLine("Ese número no corresponde con un día de la semana");
                Console.ReadLine();
            }

            //Pedir por teclado el peso y la altura e indicar según su imc cual es su clasificación en la OMS.

            int mes;

            Console.WriteLine("Introduzca un numero entre el 1 y el 12");

            mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");                 
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");               
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("EL número introducido no es correcto.");
                    break;

            }

            //Notas

            double nota;

            Console.WriteLine("Introduzca su nota");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota > 0 && nota < 5)
            {
                Console.WriteLine("Suspenso");
            }
            else if (nota >= 5 && nota < 6)
            {
                Console.WriteLine("Aprobado");
            }
            else if (nota >= 6 && nota < 7)
            {
                Console.WriteLine("Bien");
            }
            else if (nota >= 7 && nota < 8.5)
            {
                Console.WriteLine("Notable");
            }
            else if (nota >= 8.5 && nota < 10)
                Console.WriteLine("Sobresaliente");
            else
            {
                Console.WriteLine("Ese nota no existe");
            }
                Console.ReadLine();

            // Calcula el índice de masa corporal

            double peso, altura, IMC;

            Console.WriteLine("Introduce tu peso en kg");
            peso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce tu altura en metros (decimales con ,)");
            altura = Convert.ToDouble(Console.ReadLine());


            IMC = peso / Math.Pow(altura,2);

            Console.WriteLine("Su IMC es " + IMC + ".");

            if (IMC < 16)
            {
                Console.WriteLine("Infrapeso severo");
            }
            else if (IMC >= 16 && IMC < 17)
            {
                Console.WriteLine("Infrapeso moderado");
            }
            else if (IMC >= 17 && IMC < 18.5)
            {
                Console.WriteLine("Infrapeso aceptable");
            }
            else if (IMC >= 18.5 && IMC < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (IMC >= 25 && IMC < 30)
            {
                Console.WriteLine("Sobrepeso");
            }

            else if (IMC >= 30 && IMC < 35)
            {
                    Console.WriteLine("Obeso I");
            }
            
            else if (IMC>= 35 && IMC <=40)
            {
                Console.WriteLine("Obeso II");
            }
            else if (IMC > 40)
            {
                Console.WriteLine("Obeso III");
            }
            else
            {
                Console.WriteLine("Compruebe sus datos");                
            }

            Console.ReadLine();
            


        }
    }
}
