using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class Asociado
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public List<Aporte> Aportes { get; set; }
        public List<Aporte> getAportes { get { return Aportes; } }
        public List<Ahorro> Ahorros { get; set; }
        public List<Ahorro> getAhorros { get { return Ahorros; } }
        public List<Credito> Creditos { get; set; }
        public List<Credito> getCreditos { get { return Creditos; } }

        public Asociado()
        {
            Aportes = new List<Aporte>();
            Ahorros = new List<Ahorro>();
            Creditos = new List<Credito>();
        }

        public Asociado(int cedula, string nombre, string primer_apellido, string segundo_apellido, DateTime fecha_nacimiento)
        {
            Cedula = cedula;
            Nombre = nombre;
            Primer_Apellido = primer_apellido;
            Segundo_Apellido = segundo_apellido;
            Fecha_Nacimiento = fecha_nacimiento;
            Aportes = new List<Aporte>();
            Ahorros = new List<Ahorro>();
            Creditos = new List<Credito>();
        }
    }
}
