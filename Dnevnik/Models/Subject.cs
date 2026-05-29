using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string SubjectName { get; set; } = null!;

    public string? ShortName { get; set; }

    public virtual ICollection<AnnualGrade> AnnualGrades { get; set; } = new List<AnnualGrade>();

    public virtual ICollection<QuarterlyGrade> QuarterlyGrades { get; set; } = new List<QuarterlyGrade>();

    public virtual ICollection<TeacherSubjectClass> TeacherSubjectClasses { get; set; } = new List<TeacherSubjectClass>();
}
