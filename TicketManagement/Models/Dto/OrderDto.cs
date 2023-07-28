namespace TicketManagement.Models.Dto
{
    public class OrderDto
    {
        public int Orderid { get; set; }

        public int? NumberOfTickets { get; set; }

        public DateTime? OrderedAt { get; set; }

        public double? TotalPrice { get; set; }

    }
}
