using System;
using Core.Entities.Abstract;
using NpgsqlTypes;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; } = DateTime.Today.Date;
        public DateTime ReturnDate { get; set; }
    }
}