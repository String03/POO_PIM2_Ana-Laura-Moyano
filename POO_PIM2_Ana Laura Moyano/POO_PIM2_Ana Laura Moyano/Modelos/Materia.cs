using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PIM2_Ana_Laura_Moyano.Modelos
{
    //  Clase abstracta para todas las materias que pueden haber. Implementa IClonable para crear instancias nuevas de las materias para agregarselas al alumno.
    public abstract class Materia : ICloneable
    {
        public Materia()
        {

        }

        public Materia(string codigo, string denominacion)
        {
            Codigo = codigo;
            Denominacion = denominacion;
        }

        protected int _nota;

        public string Codigo { get; set; }
        public string Denominacion { get; set; }
        public int Nota { get { return _nota; } }


        //  Método para aprobar la materia, puede ser sobreescrito por las subclases.
        public virtual void AprobarMateria(int aNota)
        {
            if (aNota < 1 || aNota > 10)
            {
                throw new Exception("Nota no válida.");
            }
            this._nota = aNota;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Recursar()
        {
            _nota = 0;
        }
    }
}
