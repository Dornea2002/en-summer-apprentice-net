namespace TicketManagement.Models.Dto
{
    public class OrderPatchDto
    {
        public int Orderid { get; set; }

        public int? NumberOfTickets { get; set; }

        public int TicketCategoryid { get; set; }
    }
}
