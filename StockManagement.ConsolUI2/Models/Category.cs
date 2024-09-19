using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.ConsolUI2.Models
{
    public record Category(
        int Id,
        string Name,
        string Description
        );
}
