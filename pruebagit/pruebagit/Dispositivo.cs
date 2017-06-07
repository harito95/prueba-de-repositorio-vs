using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebagit
{
    class Dispositivo
    {
        protected string _Marca;
        protected string _Modelo;
        protected float _Pulgadas;

        public Dispositivo(string Marca,  string Modelo, float Pulgadas)
        {
            this._Marca = Marca;
            this._Modelo = Modelo;
            this._Pulgadas = Pulgadas;
        }
        public string getMarca()
        {
            return _Marca;
        }
        public string getModelo()
        {
            return _Modelo;
        }
        public float getPulgadas()
        {
            return _Pulgadas;
        }
    }
}
