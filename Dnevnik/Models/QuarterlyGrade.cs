using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class QuarterlyGrade
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int SubjectId { get; set; }

    public int ClassId { get; set; }

    public int AcademicYearId { get; set; }

    public int Quarter { get; set; }

    public int? GradeValue { get; set; }

    public DateTime? CalculatedAt { get; set; }

    public virtual AcademicYear AcademicYear { get; set; } = null!;

    public virtual Class Class { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
