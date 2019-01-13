using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControlAsistencia
{
    class cPersona
    {
        //--------------- ATRIBUTOS -------------
        private string aNombres;
        private string aAP;
        private string aAM;
        private string aDNI;
        private string aDireccion;
        private string aTelefono;

        //---------------- METODOS ---------------
        //--------------- Constructores -----------
        public cPersona()
        {
            aNombres = "";
            aAP = "";
            aAM = "";
            aDNI = "";
            aDireccion = "";
            aTelefono = "";
        }
        public cPersona(string pNombres, string pAP, string pAM, string pDNI, string pDireccion, string pTelefono)
        {
            this.aNombres = pNombres;
            this.aAP = pAP;
            this.aAM = pAM;
            this.aDNI = pDNI;
            this.aDireccion = pDireccion;
            this.aTelefono = pTelefono;
        }
        //------------- Propiedades ---------------
        public string Nombres
        {
            get { return aNombres; }
            set { aNombres = value; }
        }

        public string AP
        {
            get { return aAP; }
            set { aAP = value; }
        }

        public string AM
        {
            get { return aAM; }
            set { aAM = value; }
        }
        public string DNI
        {
            get { return aDNI; }
            set { aDNI = value; }
        }
        public string Direccion
        {
            get { return aDireccion; }
            set { aDireccion = value; }
        }
        public string Telefono
        {
            get { return aTelefono; }
            set { aTelefono = value; }
        }
    }
}
