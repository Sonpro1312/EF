using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Gender { get; set; }

    public int Age { get; set; }

    public int DepartmentId { get; set; }

    public int CompanyId { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;
}
