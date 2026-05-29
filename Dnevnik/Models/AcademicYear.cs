using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class AcademicYear
{
    public int Id { get; set; }

    public string YearName { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public bool? IsCurrent { get; set; }

    public virtual ICollection<AnnualGrade> AnnualGrades { get; set; } = new List<AnnualGrade>();

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual ICollection<QuarterlyGrade> QuarterlyGrades { get; set; } = new List<QuarterlyGrade>();

    public virtual ICollection<TeacherSubjectClass> TeacherSubjectClasses { get; set; } = new List<TeacherSubjectClass>();
}
