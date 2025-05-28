namespace TravelAgencyGuzik.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bookings
    {
        public int Id { get; set; }

        public int? ClientId { get; set; }

        public int? TourId { get; set; }

        public int? StaffId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BookingDate { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public decimal? PaymentAmount { get; set; }

        [StringLength(20)]
        public string PaymentStatus { get; set; }

        public byte[] ScannedDoc { get; set; }

        public virtual Clients Clients { get; set; }

        public virtual Tours Tours { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
