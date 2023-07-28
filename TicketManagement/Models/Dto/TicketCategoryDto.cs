namespace TicketManagement.Models.Dto
{
    public class TicketCategoryDto
    {
        public int TicketCategoryid { get; set; }

        public string? Description { get; set; }

        public double? Price { get; set; }

        public int? Eventid { get; set; }
    }
}
