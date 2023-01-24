namespace Modulo10
{
    public class TrabalhandoComStrings
    {
        
        public void ConverterParaLetrasMinusculas()
        {
            System.Console.WriteLine("Favor digitar alguma informação: ");
            var linha = Console.ReadLine();
            System.Console.WriteLine(linha?.ToLower());
        }

         public void ConverterParaLetrasMaiusculas()
        {
            System.Console.WriteLine("Favor digitar alguma informação: ");
            var linha = Console.ReadLine();
            System.Console.WriteLine(linha?.ToUpper());
        }

          public void AulaSubstring()
        {
            System.Console.WriteLine("Favor digitar alguma informação: ");
            var linha = Console.ReadLine();
            System.Console.WriteLine(linha?.Substring(0,6));
        }

        public void AulaRange()
        {
            string nomeArquivo = "2022_12_01_backup.bak";
            var ano = nomeArquivo[..4];
            System.Console.WriteLine(ano);
            var extensao = nomeArquivo[^3..];
            Console.WriteLine(extensao);
            string nome = nomeArquivo[11..^4];
            System.Console.WriteLine(nome);
        }

        public void AulaContains()
        {
           string nomeArquivo = "2022_12_01_backup.bak";
           System.Console.WriteLine($"Contem nome: {nomeArquivo.Contains("backup")}");

        }

        public void AulaTrim()
        {
            string teste = "**Denilson Carvalho**";

            System.Console.WriteLine($"Trim {teste.Trim('*')}");
            System.Console.WriteLine($"Trim {teste.TrimStart('*')}");
            System.Console.WriteLine($"Trim {teste.TrimEnd('*')}");
        }

          public void AulaReplace()
        {
            string teste = "Curso Csharp";

            Console.WriteLine(teste.Replace("Csharp", "C#"));
        }





    }
}