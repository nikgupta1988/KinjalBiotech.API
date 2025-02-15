namespace KinjalBiotech.Model
{
    public class SalesDetail
    {
        public int SellID { get; set; }
        public int ProdID { get; set; }
        public int CatID { get; set; }
        public int Quantity { get; set; }
        public DateTime SellDate { get; set; }
        public int CustID { get; set; }
        public decimal SellPrise { get; set; }
    }
}
