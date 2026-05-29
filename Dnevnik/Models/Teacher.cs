using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? Qualification { get; set; }

    public DateOnly? HireDate { get; set; }

    public virtual ICollection<TeacherSubjectClass> TeacherSubjectClasses { get; set; } = new List<TeacherSubjectClass>();

    public virtual User User { get; set; } = null!;
}
