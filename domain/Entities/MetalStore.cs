namespace JuvekSoft.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MetalStore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MetalStore()
        {
            Products = new HashSet<Product>();
        }

        public int id { get; set; }

        [Column(TypeName = "image")]
        [DisplayName("����")]
        public byte[] Photo { get; set; }
        [DisplayName("��� �������")]
        public int MetType { get; set; }
        [DisplayName("��� �������")]
        public int MetName { get; set; }
        [DisplayName("������1")]
        public decimal Size1 { get; set; }
        [DisplayName("������2")]
        public decimal? Size2 { get; set; }
        [DisplayName("������3")]
        public decimal? Size3 { get; set; }
        [DisplayName("������� ��������")]
        public int SizeUnits { get; set; }
        [DisplayName("����������")]
        public decimal Quantity { get; set; }
        [DisplayName("������� ��������� ���-��")]
        public int QuantityUnits { get; set; }
        [DisplayName("����")]
        [Column(TypeName = "money")]
        public decimal Cost { get; set; }
        [DisplayName("������")]
        public int CostUnits { get; set; }

        [StringLength(50)]
        [DisplayName("�������������� ����������")]
        public string OtherInfo { get; set; }

        public bool InUse { get; set; }
        [DisplayName("��� �������")]
        public virtual MetalName MetalName { get; set; }
        [DisplayName("��� �������")]
        public virtual MetalType MetalType { get; set; }
        [DisplayName("�������")]
        public virtual Unit Unit { get; set; }
        [DisplayName("�������")]
        public virtual Unit Unit1 { get; set; }
        [DisplayName("�������")]
        public virtual Unit Unit2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
