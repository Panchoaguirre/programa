using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miclase2
{
   
    class Program
    {

        //los atributos

        //los metodos
        static void Main(string[] args)
        {

            //opciones 

            Console.WriteLine("  Bienvenido administrador !");
            int tv;          
            var listadp = new List<ClassDpto>();
            var listaper = new List<ClassPersonal>();
            int s1;
            do
            {
                Console.WriteLine(" Elige una opcion\n" +
                "\n1.- Agregar departamento" +
                "\n2.- Modificar departamentos" +
                "\n3.- Agregar personal" +
                "\n4.- Modificar personal" +
                "\n5.- Ver departamentos" +
                "\n6.- Ver personal" +               
                "\n7.- Salir");
                bool result = int.TryParse(Console.ReadLine(), out s1);

                switch (s1)
                {
                    case 1:

                        Console.WriteLine("Opcion agregar departamento");


                        Console.WriteLine("Ingrese la cantidad de departamentos a registrar:  ");
                        tv = int.Parse(Console.ReadLine());
                        ClassDpto[] vectorDpto = new ClassDpto[tv];

                        for (int i = 0; i < vectorDpto.Length; i++)
                        {
                            Console.Write("Ingrese los datos del departamento a continuacion>   ");
                            ClassDpto objDpto = new ClassDpto();
                            Console.Write("numero: ");
                            objDpto.numero = int.Parse(Console.ReadLine());
                            Console.Write("torre: ");
                            objDpto.torre = Console.ReadLine();
                            Console.Write("piezas: ");
                            objDpto.piezas = int.Parse(Console.ReadLine());
                            Console.Write("baños: ");
                            objDpto.baños = int.Parse(Console.ReadLine());                          
                            listadp.Add(objDpto);
                            objDpto = null;

                        }
                        Console.WriteLine("Departamentos agregados correctamente");
                        for (int j = 0; j < listadp.Count; j++)
                        {
                            Console.WriteLine("departamento ", j + 1);
                            Console.WriteLine("Numero: "+listadp[j].numero + "  " +"Torre: "+ listadp[j].torre + "  " + "Piezas: " + listadp[j].piezas + "  " + "Baños: " + listadp[j].baños);
                        }

                        
                        break;


                    case 2:

                        Console.WriteLine("Opcion Modificar departamento");
                        Console.WriteLine("Ingrese el numero de departamento que desea modificar:  ");
                        int depto, n, p, b;
                        string torr, t;
                        depto = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la torre del departamento que desea modificar:  ");
                        torr = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo numero:  ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la torre:  ");
                        t = Console.ReadLine();
                        Console.WriteLine("Ingrese la nueva cantidad de piezas:  ");
                        p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la nueva cantidad de baños:  ");
                        b = int.Parse(Console.ReadLine());
                        var listasuplente = new List<ClassDpto>();
                        foreach (var x in listadp)
                        {
                            if (x.numero == depto && x.torre == torr)
                            {
                                x.ModificarDpto(n, t, p, b);
                                listasuplente.Add(x);

                            }
                            else
                            {
                                listasuplente.Add(x);
                                
                            }
                            
                        }
                        listadp = listasuplente;

                      

                        break;
                    case 3:
                        Console.WriteLine("Opcion agregar personal: ");

                        Console.WriteLine("Ingrese la cantidad de personal a registrar:  ");
                        tv = int.Parse(Console.ReadLine());
                        ClassPersonal[] vectorPerso = new ClassPersonal[tv];
                        for (int i = 0; i < vectorPerso.Length; i++)
                        {
                            Console.Write("Ingrese los datos del personal a continuacion>   ");
                            ClassPersonal objPerso = new ClassPersonal();
                            Console.Write("Nombres: ");
                            objPerso.nombres = Console.ReadLine();
                            Console.Write("Apellidos: ");
                            objPerso.apellidos = Console.ReadLine();
                            Console.Write("Rut: ");
                            objPerso.rut = int.Parse(Console.ReadLine());
                            Console.Write("Edad: ");
                            objPerso.edad = int.Parse(Console.ReadLine());
                            Console.Write("Seleccione el cargo- Aseo 1 - Supervisor 2: ");
                            objPerso.cargo = int.Parse(Console.ReadLine());
                            listaper.Add(objPerso);
                            objPerso = null;
                        }
                        Console.WriteLine("Personal agregado correctamente");
                        for (int j = 0; j < listaper.Count; j++)
                        {
                            Console.WriteLine("Nombres: "+listaper[j].nombres + "  " +"Apellidos: "+ listaper[j].apellidos + "  " + "Rut: " + listaper[j].rut + "  " + "Edad: " + listaper[j].edad + "  " + "Cargo: " + listaper[j].cargo);

                        }

                        break;
                    case 4:
                        Console.WriteLine("Opcion modificar el personal:");             
                        Console.WriteLine("Ingrese el rut del personal que desea modificar:  ");
                        int rutt, r, e, c;
                        string nom, a;                     
                        rutt = int.Parse(Console.ReadLine());
                       
                        Console.WriteLine("Ingrese el nuevo nombre:  ");
                        nom = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo apellido:  ");
                        a = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo rut:  ");
                        r = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la nueva edad:  ");
                        e = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el cargo - Aseo 1 - Supervisor 2:  ");
                        c = int.Parse(Console.ReadLine());
                        var listasuplentep = new List<ClassPersonal>();
                        foreach (var y in listaper)
                        {
                            if (y.rut == rutt )
                            {
                                y.ModificarPerso(nom, a, r, e,c);
                                listasuplentep.Add(y);

                            }
                            else
                            {
                                listasuplentep.Add(y);

                            }

                        }
                        listaper = listasuplentep;
                        break;
                    case 5:
                        Console.WriteLine("Opcion listado de departamentos");
                        foreach(var x in listadp)
                        {
                            Console.WriteLine("numero:  "+x.numero + "  " + "torre:  "+x.torre + "  " + "piezas:  "+x.piezas + "  " + "baños:  "+x.baños);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Opcion listado del personal");
                        foreach (var y in listaper)
                        {
                            Console.WriteLine("nombres: "+y.nombres+"  " + "apellidos: "+y.apellidos+"  "+ "rut: " + y.rut + "  " + "edad: "+ y.edad + "  " + "cargo: " + y.cargo);
                        }
                        break;
                   
                    default:
                        Console.WriteLine("Seleccione una opcion valida");
                        break;

                }
                







            } while (s1 != 7);
        }
    }
}
