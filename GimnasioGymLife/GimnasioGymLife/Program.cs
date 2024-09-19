using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenidos al programa de gestion de membresias del Gimnasio Fit Life");
        Console.WriteLine("Seleccione el tipo de membresia que desea");
        Console.WriteLine("1.La membresía Básica $30/Mes (Acceso a zona de pesas) ");
        Console.WriteLine("2.La membresía Premium $50/Mes (acceso a zona de pesas, piscina y clases grupales) ");
        Console.WriteLine("3.La membresía VIP 80/Mes (Incluye todos los servicios disponibles y acceso al spa) ");


        //Leer la opcion de membresia elegida
        int opcionMembresia = int.Parse(Console.ReadLine());
        double costoMembresia = 0;
        double descuentoClases = 0;

        //Asignamos Costos y Descuentos a cada opcion

        switch (opcionMembresia)
        {
            case 1:
                costoMembresia = 30; //BASICA
                break;

            case 2:
                costoMembresia = 50; //PREMIUM
                descuentoClases = 0.10;
                break;

            case 3:
                costoMembresia = 80; //VIP
                descuentoClases = 0.20;
                break;
           
            default:
                Console.WriteLine("Opcion de membresia no valida");
                Main(); //LLAMADA RECURSIVA.    Se llama al metodo main para volver a ejecutar el programa 
                break;
        }

        //Mostrar opciones de clases adicionales

        Console.WriteLine("Seleccione las clases Adicionales a las que desea participar");
        Console.WriteLine("1.Clase de yoga: $15/Mes");
        Console.WriteLine("2.Clase de pilates: $20/Mes");
        Console.WriteLine("3.Entrenamiento personal: $40/Mes");
        Console.WriteLine("Elegir cuantas clases se quiera separadas con comas por ejemplo: 1,2 ETC");

        //Leer la entrada del usuario
        string[] clasesSeleccionadas = Console.ReadLine().Split(',');

        double costoTotalClases = 0;

        //Calcular el costo total de las clases ingresada

        foreach (string clase in clasesSeleccionadas) //Con el foreach agregamos el valor de la clase seleccionada a la variable costoTotalClases
        {
            switch (clase.Trim()) //se utiliza el .Trim para eliminar espacios en blanco asegurando una comparacion correcta en cada uno de los casos
            {
                case "1":
                    costoTotalClases += 15;
                    break;

                case "2":
                    costoTotalClases += 20;
                    break;

                case "3":
                    costoTotalClases += 40;
                    break;

                case "": //No se selecciona ninguna clase (Ignoramos)
                    break;

                default:
                    Console.WriteLine("Clase adicional no valida: " + clase);
                    break;
            }
        }

        double descuentoAplicado = costoTotalClases * descuentoClases; //Calculamos el descuento
        double costoFinalClases = costoTotalClases - descuentoAplicado; //Aplicamos el descuento al monto total de las clases
       

        double costoTotalMensual = costoFinalClases + costoMembresia; //Calculamos el coste total mensual

        //Mostrar un resumen de los costes

        Console.WriteLine("RESUMEN DEL COSTO MENSUAL: ");
        Console.WriteLine("Costo de la membresia: $" + costoMembresia);
        Console.WriteLine("Costo de las clases: $" + costoTotalClases);
        Console.WriteLine("Descuento aplicado a las clases: -$" + descuentoAplicado);
        Console.WriteLine("Costo final de las clases adicionales: $" + costoFinalClases);
        Console.WriteLine("Costo total mensual: $" + costoTotalMensual);



    }
}
    