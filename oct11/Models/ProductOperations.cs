namespace oct11.Models
{
    public class ProductOperations : ITransientInterface
    {
        int no;
        public ProductOperations()
        {
            Random r = new Random();
            no = r.Next(1200);
        }

        public int GenerateRandomNumber()
        {
            return no;
        }

      
    }
}
