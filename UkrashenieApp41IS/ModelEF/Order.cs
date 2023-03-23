namespace UkrashenieApp41IS.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public int OrderID { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        public DateTime OrderDeliveryDate { get; set; }

        public int OrderPickupPoint { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        public string OrderFullName { get; set; }

        public int OrderReceiptCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }

        public virtual PickupPoint PickupPoint { get; set; }
    }
}
