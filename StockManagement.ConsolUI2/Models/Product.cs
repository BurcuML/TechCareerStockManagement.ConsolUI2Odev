using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.ConsolUI2.Models
{
    public record Product(
    int Id,
    string Name,
    double Price,
    int Stock);
}
