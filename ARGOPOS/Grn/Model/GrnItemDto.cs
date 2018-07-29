
namespace ARGOPOS.Grn.Model
{
   public class GrnItemDto
    {
        public int id { get; set; }
        public int itemid { get; set; }
        public decimal itemquntity { get; set; }
        public decimal itemcost { get; set; }
        public int grnid { get; set; }

        public string itemname { get; set; }
    }
}
