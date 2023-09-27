using System;
using System.Collections.Generic;

namespace Lesson06_test_code_first.Models;

public partial class Banner
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte Status { get; set; }

    public int Prioty { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }
}
