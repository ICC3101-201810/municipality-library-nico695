using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> p = new List<Person>();
            List<Address> ad = new List<Address>();
            List<Car> cars = new List<Car>();
            
            while (true)
            {
                Console.WriteLine("(1) Inscribir persona\n(2) Inscribir Propiedades\n(3) Inscribir Automoviles\n(4) \nIngrese opcion");
                string a = Console.ReadLine();
                if (a == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("Ingrese nombre");
                        string nm = Console.ReadLine();
                        Console.WriteLine("Ingrese apellido");
                        string ap = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento");
                        string fn = Console.ReadLine();
                        DateTime fnn = DateTime.Parse(fn);
                        Console.WriteLine("Ingrese rut");
                        string rut = Console.ReadLine();

                        Person aps = new Person(nm, ap, fnn,null,rut,null,null);
                        p.Add(aps);
                    }
                    

                }
                else if (a == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("Ingrese calle");
                        string ca = Console.ReadLine();
                        Console.WriteLine("Ingrese numero");
                        string num = Console.ReadLine();
                        int num1 = Int32.Parse(num);
                        Console.WriteLine("Ingrese comuna");
                        string fn1 = Console.ReadLine();
                        Console.WriteLine("Ingrese ciudad");
                        string ciu = Console.ReadLine();


                        Console.WriteLine("Ingrese año de construccion");
                        string con = Console.ReadLine();
                        int c1 = Int32.Parse(con);
                        Console.WriteLine("Ingrese cantidad de piezas");
                        string pa = Console.ReadLine();
                        int p1 = Int32.Parse(pa);
                        Console.WriteLine("Ingrese cantidad de baños");
                        string ba = Console.ReadLine();
                        int b1 = Int32.Parse(ba);
                        bool patiox = false;
                        while (true)
                        {
                            Console.WriteLine("(1)Si tiene patio\n(2) En caso contrario");
                            string patio = Console.ReadLine();
                            if (patio == "1")
                            {
                                patiox = true;
                                break;
                            }
                            else if (patio == "2")
                            {
                                patiox = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese 1 o 2");
                            }
                        }
                        bool piscina = false;
                        while (true)
                        {
                            Console.WriteLine("(1)Si tiene piscina\n(2) En caso contrario");
                            string pis = Console.ReadLine();
                            if (pis == "1")
                            {
                                piscina = true;
                                break;
                            }
                            else if (pis == "2")
                            {
                                piscina = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese 1 o 2");
                            }
                        }
                        Address ads = new Address(ca,num1,fn1,ciu,null,c1,p1,b1,patiox,piscina);
                        ad.Add(ads);
                    }
                }
                else if (a == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("Ingrese marca");
                        string ma = Console.ReadLine();
                        Console.WriteLine("Ingrese modelo");
                        string mod = Console.ReadLine();
                        Console.WriteLine("Ingrese año");
                        string an = Console.ReadLine();
                        int an1 = Int32.Parse(an);
                        Console.WriteLine("Ingrese matricula del automovil");
                        string matr = Console.ReadLine();
                        Console.WriteLine("Ingrese cantidad de cinturones");
                        string cint = Console.ReadLine();
                        int c1 = Int32.Parse(cint);
                        bool diesel = false;
                        while (true)
                        {
                            Console.WriteLine("(1)Si es diesel\n(2) En caso contrario");
                            string d1 = Console.ReadLine();
                            if (d1 == "1")
                            {
                                diesel = true;
                                break;
                            }
                            else if (d1 == "2")
                            {
                                diesel = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese 1 o 2");
                            }
                        }
                        Car cr = new Car(ma,mod,an1,null,matr,c1,diesel);
                        cars.Add(cr);



                    }
                }
            }

        }
    }
}
