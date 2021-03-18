using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PIM2_Ana_Laura_Moyano.Modelos
{
    //  Clase que describe al alumno, implementa la interfaz IComparable para establecer el orden por apellido
    public class Alumno : IComparable<Alumno>
    {
        public Alumno()
        {

        }

        public Alumno(int legajo, string nombre, string apellido)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            _materia = new List<Materia>();
        }

        protected List<Materia> _materia;

        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Materia> Materias { get { return _materia; } }

        public int CompareTo(Alumno other)
        {
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido)
                || string.IsNullOrEmpty(other.Nombre) || string.IsNullOrEmpty(other.Apellido))
                return 0;
            else
            {
                return string.Compare(Apellido, other.Apellido);
            }
        }
    }
}
