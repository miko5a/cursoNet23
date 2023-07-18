namespace Entidades
{
    public class Vehiculos
    {
        public string Matricula { get; set; }
        private double ValorBase { get; set; }
        private double PorcentajeEtiqueta { get; set; }
        public DateTime FechaMatriculacion { get; set; } = DateTime.Now;

        public enum Etiqueta
        {
            sinEtiqueta,
            etiquetaB,
            etiquetaC,
            etiquetaECO,
            etiquetaCERO
        }
        private Etiqueta _etiqueta;

        public Vehiculos(string matricula, DateTime fechaMatriculacion, Etiqueta etiqueta)
        {
            Matricula = matricula;
            FechaMatriculacion = fechaMatriculacion;
            _etiqueta = etiqueta;
            ValorBase = 1000;
        }

        public void FijarEtiqueta(Etiqueta etiqueta)
        {
            this._etiqueta = etiqueta;
        }

        public void CalcularImpuesto()
        {
            switch (_etiqueta)
            {
                case Etiqueta.sinEtiqueta:
                    PorcentajeEtiqueta = 25;
                    break;
                case Etiqueta.etiquetaB:
                    PorcentajeEtiqueta = 15;
                    break;
                case Etiqueta.etiquetaC:
                    PorcentajeEtiqueta = 10;
                    break;
                case Etiqueta.etiquetaCERO:
                    PorcentajeEtiqueta = 0;
                    break;
                case Etiqueta.etiquetaECO:
                    PorcentajeEtiqueta = 5;
                    break;
            }

            var añoAntiguedad = DateTime.Now.Year - FechaMatriculacion.Year;

            var sumaPorcentajes = añoAntiguedad + PorcentajeEtiqueta;

            var cantidadImpuesto = ((sumaPorcentajes / 100) * ValorBase) + ValorBase; 

            Console.WriteLine($"El vehículo con matrícula: {Matricula} {_etiqueta} tiene que pagar como impuesto {cantidadImpuesto} Euros");

            //throw new NotImplementedException();
        }
    }
}
