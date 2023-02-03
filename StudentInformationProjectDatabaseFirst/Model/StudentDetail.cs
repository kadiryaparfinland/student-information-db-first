using System;
using System.Collections.Generic;

namespace StudentInformationProjectDatabaseFirst.Model;

public partial class StudentDetail
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }
}
