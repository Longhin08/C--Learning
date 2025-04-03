using System;


namespace IMC_Calc
{
    public class calculo
    {
        static void Main(string[] args)
        {
            Console.Write("Digite Sua Altura: ");
            var initial = Console.ReadLine();

            double altura = 0;
            
            if (double.TryParse(initial, out altura)){
                return;
            }
            else {
                Console.WriteLine("Digite sua altura corretamente!\n(Exemplo: 1.73)");
            };

            var peso = Convert.ToInt32(Console.ReadLine());

            double imc = peso / (altura * altura);

            var result = imc * 10000;

            if (result <= 18.6)
            {
                Console.Write("Seu IMC é: " + result);
                Console.Write(" Seu peso está Abaixo do normal.");
            }
            else if (result <= 24.9 || result <= 18.6)
            {
                Console.Write("Seu IMC é: " + result);
                Console.Write(" Seu peso está normal.");
            }
            else if (result >= 25)
            {
                Console.Write("Seu IMC é: " + result);
                Console.WriteLine(" Você está Obeso");
            }
            ;

            Console.ReadKey();
            


        }
    }
}
