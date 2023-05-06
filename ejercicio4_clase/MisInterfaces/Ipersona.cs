using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4_clase.MisInterfaces
{
    internal interface Ipersona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
       public void DecirMinombre();
        public void cumplirAños();
    }
}

public void DecirMinombre();
string nom;
{
    Console.Write("Escriba su nombre");
        nom = Console.ReadLine();
    Console.WriteLine("Su nombre es "+nom);
}
static void cumplirAños()
string umplirAños;
double dia, mes, ano, edad=0;
{
    Console.Write("Ingrese su dia de nacimiento")
        dia = Convert.Toint32(Console.ReadLine());
    Console.Write("Ingrese su mes de nacimiento")
        mes = Convert.Toint32(Console.ReadLine());
    Console.Write("Ingrese su ano de nacimiento")
        ano = (Console.ReadLine());

    edad = DateTime.UtcNow.AddDays(1);

    Console.WriteLine("Su edad es:"+edad);

}



