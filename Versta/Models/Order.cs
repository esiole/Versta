using System;
using System.ComponentModel.DataAnnotations;

namespace Versta.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Не указан город отправителя")]
        [Display(Name = "Город отправителя")]
        public string SenderCity { get; set; }

        [Required(ErrorMessage = "Не указан адрес отправителя")]
        [Display(Name = "Адрес отправителя")]
        public string SenderAddress { get; set; }

        [Required(ErrorMessage = "Не указан город получателя")]
        [Display(Name = "Город получателя")]
        public string RecipientCity { get; set; }

        [Required(ErrorMessage = "Не указан адрес получателя")]
        [Display(Name = "Адрес получателя")]
        public string RecipientAddress { get; set; }

        [Required(ErrorMessage = "Не указан вес груза")]
        [Display(Name = "Вес груза в кг")]
        [Range(0.001, double.MaxValue, ErrorMessage = "Вес груза не может быть отрицательным или нулевым")]
        public double WeightInKg { get; set; }

        [Required(ErrorMessage = "Не указана дата забора груза")]
        [Display(Name = "Дата забора груза")]
        [DataType(DataType.Date)]
        public DateTime DateOfReceiving { get; set; }
    }
}
