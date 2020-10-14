using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Angular_Assignment.Model
{
    public class MenuItem
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = " ";
        public double Price { get; set; } = 0;

        public override string ToString() => JsonSerializer.Serialize<MenuItem>(this);
    }
}
