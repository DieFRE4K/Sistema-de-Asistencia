using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControlAsistencia
{
    class cAsistencia
    {
        private string Cod_Alumno;
        private bool Pte;
        private bool Tarde;
        private bool Falta;

        public void CAsistencia(string Cod)
        {
            Pte = false;
            Tarde = false;
            Falta = false;
        }
    }
}
