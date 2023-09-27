using System;
using System.Collections.Generic;

namespace Lesson06_test_code_first.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public float Price { get; set; }

    public float SalePrice { get; set; }

    public byte Status { get; set; }

    public int CategoryId { get; set; }

    public DateTime CreateDate { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public virtual Category Category { get; set; } = null!;
}
