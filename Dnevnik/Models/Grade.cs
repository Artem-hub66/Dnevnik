using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Grade
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int ScheduleId { get; set; }

    public int GradeValue { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Schedule Schedule { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
