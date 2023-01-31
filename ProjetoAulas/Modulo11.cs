namespace Modulo11
{
    public class TrabalhandoComDatas
    {

        public void AulaDateTime()
        {
            var date1 = new DateTime(2012, 12, 02, 19, 22, 13);
            var date2 = DateTime.Parse("2022/12/22 19:25:23");
            var date3 = DateTime.Now;
            var date4 = DateTime.Today;

            System.Console.WriteLine(date1);
            System.Console.WriteLine(date2);
            System.Console.WriteLine(date3);
            System.Console.WriteLine(date4);
        }

        public void AulaSubtraindoDatas()
        {
            var date1 = DateTime.Now;
            var date2 = DateTime.Parse("2022-01-01");

            // var diff = date1 - date2;
            var diff = date1.Subtract(date2);
            System.Console.WriteLine((int)diff.TotalDays);
            System.Console.WriteLine(diff.TotalHours);
        }

           public void AulaAdicionandoDiasMEsEAno()
        {
            var date1 = DateTime.Now;
            
            System.Console.WriteLine(date1.AddDays(3));
            System.Console.WriteLine(date1.AddMonths(3));
            System.Console.WriteLine(date1.AddYears(3));
        }

         
    }
}