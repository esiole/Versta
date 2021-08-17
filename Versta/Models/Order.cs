using System;

namespace Versta.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string SenderCity { get; set; }
        public string SenderAddress { get; set; }
        public string RecipientCity { get; set; }
        public string RecipientAddress { get; set; }
        public double WeightInKg { get; set; }
        public DateTime DateOfReceiving { get; set; }
    }
}
