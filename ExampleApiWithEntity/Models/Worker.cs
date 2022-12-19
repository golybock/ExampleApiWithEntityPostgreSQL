using System;
using System.Collections.Generic;

namespace ExampleApiWithEntity.Models;

public partial class Worker
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int RoleId { get; set; }

    public virtual Role Role { get; set; } = null!;
}
