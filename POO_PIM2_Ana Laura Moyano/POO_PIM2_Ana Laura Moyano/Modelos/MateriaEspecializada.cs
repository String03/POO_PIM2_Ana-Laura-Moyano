using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PIM2_Ana_Laura_Moyano.Modelos
{

    // Las materias de especialización sobreescriben el método aprobarmateria.
    public class MateriaEspecializada : Materia
    {

        public MateriaEspecializada(string codigo, string denominacion) : base(codigo, denominacion)
        {

        }

        public override void AprobarMateria(int aNota)
        {
            if (aNota < 1 || aNota > 10)
            {
                throw new Exception("Nota no válida.");
            }
            if (aNota <= 9 && aNota >= 6)
            {
                _nota = aNota + 1;
            }
            else
            {
                _nota = aNota;
            }
        }
    }

}
