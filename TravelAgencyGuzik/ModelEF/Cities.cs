namespace TravelAgencyGuzik.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cities()
        {
            Hotels = new HashSet<Hotels>();
        }

        public int Id { get; set; }

        public int? CountryId { get; set; }

        [StringLength(100)]
        public string CityName { get; set; }

        public virtual Countries Countries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hotels> Hotels { get; set; }
    }
}
