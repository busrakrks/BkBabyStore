using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BkBabyStore.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50), Display(Name = "Kategori Adı")]
        public string Name { get; set; }
        [Display(Name = "Kategori Açıklaması")]
        public string? Description { get; set; }
        [StringLength(150), Display(Name = "Kategori Resmi")]
        public string? Image { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? CreateDate { get; set; } = DateTime.Now; // eğer bu alan boş geçilirse eklenme zamanını sistemden otomatik al
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        public virtual ICollection<Product>? Products { get; set; } //Category ile ürünler arasında 1 e çok ilişki kurduk
    }
}
