internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculador IMC\n\nDigite o peso em kg: ");
        float Peso = float.Parse( Console.ReadLine());
        Console.WriteLine("\nDigite a altura em metros: ");
        float Altura = float.Parse(Console.ReadLine());
        float IMC = CalcularIMC(Peso, Altura);
        Console.WriteLine("Seu IMC é: " + CalcularIMC(Peso, Altura));
        IMC = CalcularIMC(Peso, Altura);
        ClassificarIMC(IMC);
    }
    static float CalcularIMC(float peso,float altura)
    {
        return peso / altura * altura;
    }
    static void ClassificarIMC(float imc)
    {
        if (imc < 18.5)
        {
            Console.WriteLine("Você está abaixo do peso ideal!\n");
        }
        else if (imc < 24.5)
        {
            Console.WriteLine("Você está dentro do peso ideal!\n");
        }
        else if(imc < 29.9)
        {
            Console.WriteLine("Você está em sobrepeso!\n");
        }
        else if (imc < 34.9)
        {
            Console.WriteLine("Você está com obesidade grau I!\n");
        }
        else if((imc < 39.9))
        {
            Console.WriteLine("Você está com obesidade grau II!\n");
        }
        else
        {
            Console.WriteLine("Você está com obesidade grau III!\n");
        }
    }
}