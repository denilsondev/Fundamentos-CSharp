namespace Modulo14
{
    public class TrabalhandoComLinq
    {
        public void AulaWhere()
        {
            var numeros = new int[] { 10, 6, 4, 15, 20, 1 };
            var resultado = numeros.Where(p => p >= 10);

            foreach (var numero in resultado)
            {
                System.Console.WriteLine(numero);
            }
        }

        public void AulaOrderBy()
        {
            var numeros = new int[] { 10, 6, 4, 15, 20, 1 };
            var resultado = numeros.OrderBy(p => p);

            foreach (var numero in resultado)
            {
                System.Console.WriteLine(numero);
            }
        }

        public void AulaTake()
        {
            var numeros = new int[] { 10, 6, 4, 15, 20, 1 };
            var resultado = numeros.Take(3);

            foreach (var numero in resultado)
            {
                System.Console.WriteLine(numero);
            }
        }

        public void AulaCount()
        {
            var numeros = new int[] { 10, 6, 4, 15, 20, 1 };
            var resultado = numeros.Count(c => c > 5);


            System.Console.WriteLine(resultado);
        }

            public void AulaFirstEFirstOrDefault()
        {
            var numeros = new int[] { 10, 6, 4, 15, 20, 1 };
            // var resultado = numeros.First(c => c > 5);
            var resultado = numeros.FirstOrDefault(p => p > 10, -99);


            System.Console.WriteLine(resultado);
        }







    }

}