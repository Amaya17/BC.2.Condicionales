using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicioneales3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida dos números y que muestre la suma, la resta, la multiplicación, la media, el máximo y el mínimo.

            int num1, num2, num3;

            Console.WriteLine("Introduzca un número");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su segundo número");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Suma = " + (num1+num2) );
            Console.WriteLine("Resta = " + (num1 - num2));
            Console.WriteLine("Multiplicación = " + (num1 * num2));
            Console.WriteLine("Media = " + ((num1 + num2)/2));
            
            if (num1 > num2)
            {
                Console.WriteLine("Máx = " + num1);
            }
            else
            {
                Console.WriteLine("Máx = " + num2);
            }

            

            if (num1 < num2)
            {
                Console.WriteLine("Min = " + num1);
            }
            else
            {
                Console.WriteLine("Min = " + num2);
            }

            Console.ReadLine();

            //Escribe un programa que pida al usuario 3 números. Si el resultado de la suma de los dos primeros es igual al tercer número, mostrarlo en pantalla, sino mostrar que el tercero no es la suma de los dos anteriores.

            Console.WriteLine("Introduzca un número");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su segundo número");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su tercer número");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1 + num2 == num3)
            {
                Console.WriteLine(num3);
            }
            else
            {
                Console.WriteLine(num3 + " no es igual a " + num1 + " + " + num2);
            }

            //Escribe un programa que convierta los segundos a horas, minutos y segundos.

            int tiempoS, segundos, minutos, horas;

            Console.WriteLine("Introduzca los segundos");
            tiempoS = Convert.ToInt32(Console.ReadLine());

            horas = tiempoS / 3600;
            minutos = (tiempoS - (horas * 3600)) / 60;
            segundos = tiempoS - (horas * 3600) - (minutos * 60);

            Console.WriteLine("Sus segundos son " + horas + " horas, " + minutos + " minutos y " + segundos + " segundos. ");


            //Escribe un programa que pida al usuario tres números y que diga si uno de ellos es 20 menos que uno de los otros.

            Console.WriteLine("Introduzca un número");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su segundo número");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su tercer número");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1+20 == num2)
            {
                Console.WriteLine(num1 +" es 20 menor que " + num2);
            }
            else if (num2+20 == num1)
            {
                Console.WriteLine(num2 + " es 20 menor que " + num1);
            }
            else if (num2+20 == num3)
            {
                Console.WriteLine(num2 + " es 20 menor que " + num3);
            }
            else if (num3+20 == num2)
            {
                Console.WriteLine(num3 + " es 20 menor que " + num2);
            }
            else if (num3+20 == num1)
            {
                Console.WriteLine(num3 + " es 20 menor que " + num1);
            }
            else if(num1+20 == num3)
            {
                Console.WriteLine(num1 + " es 20 menor que " + num3);
            }
            else
            {
                Console.WriteLine("No hay ningún numero 20 veces mayor que otro");
            }

            Console.ReadLine();
            //Escribe un programa que pida dos valores del usuario y 
            //Si los dos valores son iguales muestre 0
            //Si los dos valores tienen el mismo resto al dividir entre 6 mostrar el más pequeño
            //Si no que muestre el más grande de los dos


            Console.WriteLine("Introduzca un número");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su segundo número");
            num2 = Int32.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine(0);
            }
            else if (num1 % 6 == num2 % 6)
                if (num1 < num2)
                {
                    Console.WriteLine(num1);
                }
                else if (num2 < num1)
                {
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine("Tus números son iguales.");
                }
            else
            {
                if (num1 > num2)
             
                Console.WriteLine(num1);
                else
                {
                    Console.WriteLine(num2);
                }
                
            }
            Console.ReadLine();

            //Escribe un programa que pida dos números enteros entre 25 y 75 y que diga si hay un dígito en común entre los dos números.

            int decena1, decena2, unidad1, unidad2;

            Console.WriteLine("Introduzca un número entero entre 25 y 75");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ahora otro");
            num2 = Int32.Parse(Console.ReadLine());

            decena1 = num1 / 10;
            decena2 = num2 / 10;
            unidad1 = num1 - (decena1 * 10);
            unidad2 = num2 - (decena2 * 10);

            if (decena1 == decena2 ||decena1 == unidad2 ||unidad1 == decena2 || unidad1 == unidad2)
            {
                Console.WriteLine("Hay digitos en común");
            }

            Console.ReadLine();

            //Problema VIP

            string pago, entrada, deuda;
            double saldo;

            Console.WriteLine("Buenos días, ha pagado la entrada?");
            pago = Console.ReadLine();

            if (pago.ToLower() == "si" || pago.ToLower() == "sí")
            {
                Console.WriteLine("Bienvenido");
            }
            else
            {
                Console.WriteLine("Debes pagar la entrada");
            }

            Console.WriteLine("¿Qué entrada tiene?");
            entrada = Console.ReadLine();

            if (entrada.ToLower() == "vip")
            {
                Console.WriteLine("Que pase un buen día.");
                Console.ReadLine();
            }
            else
            {
                Console.ReadLine();
            }

            Console.WriteLine("¿Tiene deudas?");
            deuda = Console.ReadLine();

            if (deuda.ToLower() == "si")
            {
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Bienvenido");
            }


            //Solo damos la bienvenida en el caso de cliente vip y el saldo sea mayor que 0

            Console.WriteLine("Introduzca su saldo");
            saldo = Convert.ToDouble(Console.ReadLine());

            if (entrada.ToLower() == "vip" && saldo > 0 )
                Console.WriteLine("Bienvenido cliente VIP con saldo.");
            Console.ReadLine();

            //Resultado de carrera. Hacer varios programas en los que se le pregunta al usuario el puesto en el que acabó. Después:

            int puesto;

            Console.WriteLine("Introduzca su puesto en la carrera en números.");
            puesto = Convert.ToInt32(Console.ReadLine()); 

            switch (puesto)
            {
                case 1:
                    Console.WriteLine("!GANASTE!");
                    break;
                default:
                    Console.WriteLine("Lo importante es participar.");
                    break;

            }

            Console.ReadLine();

            Console.WriteLine("Introduzca su puesto en la carrera en números.");
            puesto = Convert.ToInt32(Console.ReadLine());

            switch (puesto)
            {
                case 1:
                    Console.WriteLine("Medalla de oro");
                    break;
                case 2:
                    Console.WriteLine("Medalla de plata");
                    break;
                case 3:
                    Console.WriteLine("Medalla de bronce");
                    break;

                default:
                    Console.WriteLine("Lo importante es participar.");
                    break;

                    Console.ReadLine();

                    //Si la edad es igual o inferior a 8 mostramos mensaje "Pasa al tobogán", si no mostramos "Eres demasiado mayor para usar el tobogán" 

                    int edad;

                    Console.WriteLine("Introduzca su edad");
                    edad = Convert.ToInt32(Console.ReadLine());

                    if (edad < 8 && edad>0)
                    {
                        Console.WriteLine("Pasa al tobogán");
                    }
                    else
                    {
                        Console.WriteLine("Es demasiado mayor para el tobogán");
                    }

                    //Comprobar un string que tenga el valor del día de la semana (lunes, martes, ...). Mostrar en pantalla el día que dice que es si es entre lunes y viernes (Por ejemplo "Hoy es lunes") y si es fin de semana mostrar "Es fin de semana" 

                    string dia;

                    Console.WriteLine("¿Qué día es?");
                    dia = Console.ReadLine();


                    switch (dia.ToLower())
                    {
                        case "sabado":
                            Console.WriteLine("¡HOY ES FINDE!");
                            break;

                        case "domingo":
                            Console.WriteLine("¡HOY ES FINDE!");
                            break;

                        case "lunes":
                            Console.WriteLine("Hoy es lunes");
                            break;

                        case "martes":
                            Console.WriteLine("Hoy es martes");
                            break;

                        case "miércoles":
                            Console.WriteLine("Hoy es miércoles");
                            break;

                        case "jueves":
                            Console.WriteLine("Hoy es jueves");
                            break;

                        case "viernes":
                            Console.WriteLine("Hoy es viernes");
                            break;

                        default:
                        Console.WriteLine("Eso no es un día de la semana");
                            break;
                    }

                    //A partir de un valor de número entero, mostrar el mensaje "El valor absoluto de -7 es 7". Si es menor que cero mostrar el valor en positivo, si es positivo o cero mostrar ese mismo valor. 

                    int valor;

                    Console.WriteLine("Dame un valor");
                    valor = Convert.ToInt32(Console.ReadLine());

                    if (valor < 0)
                    {
                        valor = valor * (-1);
                    }

                    Console.WriteLine("El valor absoluto de su número es " + valor);
                    Console.ReadLine();

                    //Decir el número de helados que queremos comprar. Cada helado vale 2 euros. Si compramos más de 10 helados, nos regalan uno gratis. Mostrar en pantalla el número de helados que nos dan y cuánto hemos pagado por ellos.

                    int numHelados, heladosG;

                    Console.WriteLine("Cuántos helados quieres?");
                    numHelados = Convert.ToInt32(Console.ReadLine());

                    heladosG = numHelados / 10;

                    Console.WriteLine("Debes pagar " + (numHelados * 2) + " . ");
                    Console.WriteLine("Te llevas " + (numHelados + heladosG) + " . ");

                    Console.ReadLine();

                    //Tenemos dos números, un numerador y un dividendo. Si el dividendo no es cero, mostramos el resultado de dividir el numerador por el dividendo. Si el dividendo es cero, mostramos el mensaje "No se puede dividir por cero"

                    int numerador, divisor, cociente;

                    Console.WriteLine("Introduzca numerador");
                    numerador = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduzca divisor");
                    divisor = Convert.ToInt32(Console.ReadLine());

                    if (numerador != 0)
                    {
                        Console.WriteLine("Su resultado es " + numerador/divisor);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero");
                    }

                    Console.ReadLine();

                    //Un año es bisiesto si se puede dividir por 4. Pero un año que se pueda dividir por 100 NO es bisiesto a no ser que se pueda dividir por 400. A partir de un año, mostrar en pantalla si es bisiesto o no.

                    int añoStart, añoConsulta;

                    Console.WriteLine("Intrduzca un año");
                    añoStart = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("¿Qué año quiere consultar?");
                    añoConsulta = Convert.ToInt32(Console.ReadLine());

                    if (añoConsulta % 400 == 0)
                    {
                        Console.WriteLine("Su año es bisiesto.");
                    }
                    

                    else
                    {
                        if (añoConsulta % 4 == 0 && añoConsulta % 100 != 0)

                        {
                            Console.WriteLine("Su año es bisiesto.");
                        }
                        else
                        {
                            Console.WriteLine("Su año no es bisiesto.");
                        }
                        
                    }
                    Console.ReadLine();

                    //Con if else if: Mostrar en pantalla un menú con varias opciones. Dependiendo de lo que el usuario elija, mostrar en pantalla la selección. Hacerlo tanto con if else como con switch





            }


        }
    }
}
