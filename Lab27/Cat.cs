using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork27.Models
{
    public record struct Cat(int Id, string Name, string Breed, string Color, int Age);
}
