using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class QuarterlyGrade
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int TeacherSubjectClassId { get; set; }

    public int QuarterId { get; set; }

    public int? GradeValue { get; set; }

    public DateTime? CalculatedAt { get; set; }

    public virtual Quarter Quarter { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual TeacherSubjectClass TeacherSubjectClass { get; set; } = null!;
}
