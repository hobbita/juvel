namespace JuvekSoft.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InsertStore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsertStore()
        {
            Products = new HashSet<Product>();
        }

        public int id { get; set; }

        [Column(TypeName = "image")]
        [DisplayName("����")]
        public byte[] Photo { get; set; }
        [DisplayName("�������� �������")]
        public int InsMat { get; set; }
        [DisplayName("����� �������")]
        public int FacType { get; set; }
        [DisplayName("������")]
        public decimal Size1 { get; set; }
        [DisplayName("������")]
        public decimal? Size2 { get; set; }
        [DisplayName("������")]
        public decimal? Size3 { get; set; }
        [DisplayName("�������")]
        public int SizeUnits { get; set; }
        [DisplayName("����������")]
        public int Quantity { get; set; }
        [DisplayName("�������")]
        public int QuantityUnits { get; set; }
        [DisplayName("����")]
        [Column(TypeName = "money")]
        public decimal Cost { get; set; }
        [DisplayName("�������")]
        public int CostUnits { get; set; }
        [DisplayName("��������������� ����������")]
        [StringLength(50)]
        public string OtherInfo { get; set; }

        public bool InUse { get; set; }
        [DisplayName("����� �������")]
        public virtual FacetingType FacetingType { get; set; }
        [DisplayName("�������� �������")]
        public virtual InsertMaterial InsertMaterial { get; set; }
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
