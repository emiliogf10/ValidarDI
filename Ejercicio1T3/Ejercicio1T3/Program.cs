using System.Collections;

namespace Ejercicio1T3
{
    internal class Program
    {
        public static bool ComprobarIp(String ip)
        {
            bool bien = true;
            ip.Split(".");

            if (ip.Split(".").Length != 4)
            {
                return bien = false;
            }

            foreach (String ip2 in ip.Split("."))
            {
                if (ip2.Length > 3 || ip2.Length < 1 || int.Parse(ip2) < 0 || int.Parse(ip2) > 255)
                {
                    return bien = false;
                }
            }

            return bien;
        }



        static void Main(string[] args)
        {
            Hashtable computadoras = new Hashtable();

            computadoras.Add("192.168.100.167", 16);
            computadoras.Add("8.8.4.4", 32);
            computadoras.Add("8.8.8.8", 16);


            int opcMenu;

            try
            {
                do
                {
                    Console.WriteLine("\n MENU DE OPCIONES\n" +
                        "1.- Introducir datos\n" +
                        "2.- Eliminar un dato\n" +
                        "3.- Mostrar la colección entera\n" +
                        "4.- Mostrar un elemento de la colección\n" +
                        "5.- Salir\n");
                    opcMenu = int.Parse(Console.ReadLine());

                    switch (opcMenu)
                    {
                        case 1:
                            string agregarIp;
                            int memoriaRam;

                            try
                            {
                                Console.Write("Dime una direccion IP: ");
                                agregarIp = Console.ReadLine();

                                while (!ComprobarIp(agregarIp))
                                {
                                    Console.WriteLine("Esa IP no es correcta, introduce una IP valida");
                                    Console.Write("Dime la dreiccion IP: ");
                                    agregarIp = Console.ReadLine();
                                }

                                Console.Write("Cantidad de memoria: ");
                                memoriaRam = int.Parse(Console.ReadLine());

                                if (memoriaRam < 0 || memoriaRam % 1 != 0)
                                {
                                    Console.WriteLine("Solo se admiten números enteros");
                                    Console.Write("Dame la cantidad de memoria: ");
                                    memoriaRam = int.Parse(Console.ReadLine());
                                }

                                computadoras.Add(agregarIp, memoriaRam);

                            }
                            catch (ArgumentException)
                            {
                                Console.WriteLine("Esa IP ya esta agregada\n");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("El valor introducido no es correcto\n");
                            }
                            break;

                        case 2:
                            string eliminarIp;

                            try
                            {
                                Console.Write("Dame la IP que deseas eliminar: ");
                                eliminarIp = Console.ReadLine();

                                while (!ComprobarIp(eliminarIp))
                                {
                                    Console.WriteLine("Ese número de IP no es correcto, intentalo de nuevo");
                                    Console.Write("Dame la dirección IP: ");
                                    eliminarIp = Console.ReadLine();
                                }

                                if (computadoras.Contains(eliminarIp))
                                {
                                    computadoras.Remove(eliminarIp);
                                    Console.WriteLine("La IP ha sido borrada");
                                }
                                else
                                {
                                    Console.WriteLine("Esa IP no se encuentra en la lista");

                                }
                            }
                            catch (NotSupportedException)
                            {
                                Console.WriteLine("Ha ocurrido un error, intentelo de nuevo");
                            }

                            break;

                        case 3:
                            if (computadoras.Count != 0)
                            {
                                int contIp = 1;
                                Console.WriteLine("Lista de direcciones IP's");
                                foreach (DictionaryEntry item in computadoras)
                                {
                                    Console.WriteLine("{0} IP: {1,-20} Memoria: {2} GB", contIp, item.Key, item.Value);
                                    contIp++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay elementos en la lista");
                            }
                            break;

                        case 4:
                            string muestraIp;

                            try
                            {
                                Console.WriteLine("¿Qué IP deseas mostrar?");
                                muestraIp = Console.ReadLine();

                                while (!ComprobarIp(muestraIp))
                                {
                                    Console.WriteLine("Esa IP no es correcta, intentalo de nuevo");
                                    Console.Write("Dime la dirección IP: ");
                                    muestraIp = Console.ReadLine();

                                }

                                if (computadoras.Contains(muestraIp))
                                {
                                    Console.WriteLine("Direccion IP: {0, -20} Cantidad de memoria: {1} GB", muestraIp, computadoras[muestraIp]);
                                }
                                else
                                {
                                    Console.WriteLine("Esa IP no se encunetra en la lista");
                                }

                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Ha ocurrido un error, intentalo de nuevo");
                            }
                            break;

                        case 5:
                            break;
                    }
                } while (opcMenu != 5);

            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ocurrido un error, intentalo de nuevo");
            }
        }

    }
}