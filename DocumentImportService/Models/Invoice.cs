using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentImportService.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public DateTime ImportedDate { get; set; }

        public string ImportedUserName { get; set; }

        public int ImportedUserId { get; set; }

        public string InvoicePath { get; set; }
    }
}
