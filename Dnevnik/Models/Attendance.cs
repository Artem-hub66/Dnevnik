using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Attendance
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int ScheduleId { get; set; }

    public DateOnly AttendanceDate { get; set; }

    public bool? IsPresent { get; set; }

    public bool? IsExcused { get; set; }

    public string? Reason { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
