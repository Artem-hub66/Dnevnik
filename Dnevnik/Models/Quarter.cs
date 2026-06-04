using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Quarter
{
    public int Id { get; set; }

    public int AcademicYearId { get; set; }

    public int QuarterNumber { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public virtual AcademicYear AcademicYear { get; set; } = null!;

    public virtual ICollection<QuarterlyGrade> QuarterlyGrades { get; set; } = new List<QuarterlyGrade>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
