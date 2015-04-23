using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCupi2
{
    class emp
    {
        private string p1;
        private string p2;
        private char sexo;
        private string fechanac;
        private string fechaing;
        private float p3;

        public emp(string p1, string p2, char sexo, string fechanac, string fechaing, float p3)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.sexo = sexo;
            this.fechanac = fechanac;
            this.fechaing = fechaing;
            this.p3 = p3;
        }

        public string P1
        {
            get { return p1; }
            set { p1 = value; }
        }
        public string P2
        {
            get { return p2; }
            set { p2 = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Fechanac
        {
            get { return fechanac; }
            set { fechanac = value; }
        }
        public string Fechaing
        {
            get { return fechaing; }
            set { fechaing = value; }
        }
        public float P3
        {
            get { return p3; }
            set { p3 = value; }
        }
    }
}
