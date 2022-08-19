namespace Ejerc_
{
    public class Direccion
    {
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Piso { get; set; }
        public string Deparatamento { get; set; }
        public string Manzana { get; set; }
        public string Lote { get; set; }


        public string DireccionCompleta
        {
            get
            {
                string direccion = $"{Calle} Nro: {Numero.ToString()}";
                if (!string.IsNullOrEmpty((Piso)))
                {
                    direccion += $"Piso: {Piso}";
                }
                if (!string.IsNullOrEmpty((Deparatamento)))
                {
                    direccion += $"Dpto: {Deparatamento}";
                }
                if (!string.IsNullOrEmpty((Manzana)))
                {
                    direccion += $"Mza: {Manzana}";
                }
                if (!string.IsNullOrEmpty((Lote)))
                {
                    direccion += $"Lote: {Lote}";
                }

                return direccion;
            }
        }


    }
}