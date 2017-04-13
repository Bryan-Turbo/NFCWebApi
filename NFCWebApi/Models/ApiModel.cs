using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NFCWebApi.Models
{
    public class ApiModel
    {
        [Required]
        public string SerialId { get; set; }
    }
}
