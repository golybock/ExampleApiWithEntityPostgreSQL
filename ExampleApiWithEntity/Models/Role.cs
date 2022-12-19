﻿using System;
using System.Collections.Generic;

namespace ExampleApiWithEntity.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Worker> Workers { get; } = new List<Worker>();
}
