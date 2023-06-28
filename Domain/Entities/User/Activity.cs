using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.User
{
    public class Activity
    {
        public Guid Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        [MaxLength(500)]
        public string Discription { get; set; }

        [MaxLength(100)]
        public string Category { get; set; }

        [MaxLength(100)]
        public string City { get; set; }
    }
}
