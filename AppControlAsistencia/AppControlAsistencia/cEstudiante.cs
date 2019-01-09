using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControlAsistencia
{
    class cEstudiante
    {
        //atributos
        private string Cod_Estudiante;
        private string AP;
        private string AM;
        private string Nombres;
        //METODOS
        public cEstudiante(string Cod,string AP,string AM,string Nombres)
        {
            this.Cod_Estudiante = Cod;
            this.Nombres = Nombres;
            this.AP = AP;
            this.AM = AM;
        }

    }
}
