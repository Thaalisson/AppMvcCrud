using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvcCrud.Models
{
    public class Product : Entity
    {
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "Field {0} is required")]
        [StringLength(200, ErrorMessage = "Field {0} must be between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Field {0} is required")]
        [StringLength(1000, ErrorMessage = "Field {0} must be between {2} and {1} characters", MinimumLength = 2)]
        public string Description { get; set; }

        [DisplayName("Imagem do Product")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Field {0} is required")]
        public decimal Value { get; set; }

        public DateTime DateRegister { get; set; }

        [DisplayName("Status")]
        public bool Status { get; set; }

        /* EF Relations */
        public Supplier Supplier { get; set; }
    }
}
