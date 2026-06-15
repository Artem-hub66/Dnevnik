using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Student
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ClassId { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? ParentFullName { get; set; }

    public string? ParentPhone { get; set; }

    public string? Address { get; set; }

    public DateOnly? EnrollmentDate { get; set; }

    public virtual ICollection<AnnualGrade> AnnualGrades { get; set; } = new List<AnnualGrade>();

    public virtual Class Class { get; set; } = null!;

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual ICollection<QuarterlyGrade> QuarterlyGrades { get; set; } = new List<QuarterlyGrade>();

    public virtual User User { get; set; } = null!;

    internal IEnumerable<object> List()
    {
        throw new NotImplementedException();
    }
}
