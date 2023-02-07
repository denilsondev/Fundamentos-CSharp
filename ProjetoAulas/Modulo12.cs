namespace Modulo12
{
    public class TraabalhandoComExcecoes
    {

        public void AulaGerandoException()
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine("Indorme um numero ");
                    var numero = Console.ReadLine();
                    var resultado = 500 / int.Parse(numero);
                    System.Console.WriteLine("Resultado: " + resultado);
                }
                catch (DivideByZeroException ex)
                {
                    System.Console.WriteLine("erro de divisao" + ex.Message);
                    System.Console.WriteLine("stack" + ex.StackTrace);

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("erro" + ex.Message);
                    System.Console.WriteLine("stack" + ex.StackTrace);
                }
            }


        }


    }
}