using IndiceDeMasaCorporal.CalculadoraImc;

Console.WriteLine("Aplicación que calcula el índice de masa corporal de una persona. \n");

try
{
    decimal peso = ReadDecimal("Proprcione el peso en kilogramos de la persona: ");
    decimal estatura = ReadDecimal("Proporcione la estatura en metros de la persona: ");

    decimal imc = CalculadoraDeIndiceDeMasaCorporal.IndiceDeMasaCorporal(peso, estatura);
    Console.WriteLine($"El incice de masa corporal de la persona es {imc:F4}");
    Console.WriteLine($"El estado nutricional de la persona es {CalculadoraDeIndiceDeMasaCorporal.EstadoNutricional(imc)}");
}
catch(FormatException)
{
    Console.Error.WriteLine("El número proporcionado no tiene el formato correcto");
    //throw;
}
//catch(OverflowException)
//{ 
//Console.Error.WriteLine("El número proporcionado es muy grande");
//throw;
//}
catch(Exception exc)
{
    Console.Error.WriteLine(exc.Message);
    Console.Error.WriteLine(exc.StackTrace);
    //throw;
}

decimal ReadDecimal(string s)
{
    //decimal value;
    //bool huboExito = false;

    Console.Write(s);
    string entrada = Console.ReadLine();
    //huboExito = decimal.TryParse(entrada, out value);
    //if (huboExito)
    //{
    //return value;
    //}
    //else
    //{ 
    //throw new exception ("El valor proporcionado no es un número");
    //}
    return Convert.ToDecimal(entrada);

}