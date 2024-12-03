using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octagram.Application.DTOs
{
    public class CreateTourDto
    {
        public IFormFile ImageFile { get; set; }
        public string Caption { get; set; }
        public List<string> Hashtags { get; set; }
    }
}
