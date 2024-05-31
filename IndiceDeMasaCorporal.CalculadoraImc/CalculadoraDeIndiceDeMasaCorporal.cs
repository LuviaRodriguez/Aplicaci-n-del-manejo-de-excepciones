using System.ComponentModel.Design;

namespace IndiceDeMasaCorporal.CalculadoraImc
{
    public class CalculadoraDeIndiceDeMasaCorporal
    {
        public static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura)
        { 
           return peso / (estatura * estatura);
        }

        public static string EstadoNutricional(decimal imc)
        {
            if (imc < 18.5M)
            {
                return "Peso bajo";
            }
            else if (imc < 25.0M)
            {
                return "Peso normal";
            }
            else if (imc < 30.0M)
            {
                return "Sobrepeso";
            }
            else if (imc < 40.0M)
            {
                return "Obesidad";
            }
            else
            {
                return "Obsecidad extrema";
            }
        }
    }
}
