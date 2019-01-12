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
        private string aAP;
        private string aAM;
        private string aNombres;
        //METODOS
        public cEstudiante(string Cod,string AP,string AM,string Nombres)
        {
            this.Cod_Estudiante = Cod;
            this.aNombres = Nombres;
            this.aAP = AP;
            this.aAM = AM;
        }

        public string Cod{
        	get{return Cod_Estudiante;}
        	set{Cod_Estudiante=value;}
        }

        public string Nombres{
        	get{return aNombres;}
        	set{aNombres=value;}
        }

        public string AP{
        	get{return aAP;}
        	set{aAP=value;}
        }

        public string AM{
        	get{return aAM;}
        	set{aAM=value;}
        }

    }
}
