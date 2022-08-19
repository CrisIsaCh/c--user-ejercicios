using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_
{
    public class Cuenta
    {

        /// <summary>
        /// 
        /// </summary>
        public Cliente Cliente { get; set; }
        private decimal _saldo;

        public decimal Saldo
        {
            get
            {
                return _saldo;
            }
        }

        public void Depositar(decimal monto)
        {
            _saldo += monto;
        }

        public void Extraer(decimal monto)
        {
            if (_saldo >= monto)
                _saldo -= monto;

        }

        public override string ToString()
        {
            return $" Cliente: {Cliente.Apellido} {Cliente.Nombre} , Direccion:{Cliente.Direccion.DireccionCompleta}, Saldo:{Saldo}";
            // return $"Cliente: {Cliente.ApyNom}, Saldo: {Saldo} ";
        }

    }
}
