namespace Lesson5_Restful
{
    public class Order
    {
        public int IdOrder { get; set; }
        public int CountProdact { get; set; }
        public Product  Product { get; set; }
        public DateTime DateOrder { get; set; }

    }

}
