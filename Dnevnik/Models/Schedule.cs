using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Schedule
{
    public int Id { get; set; }

    public int ClassId { get; set; }

    public int TeacherSubjectClassId { get; set; }

    public int DayOfWeek { get; set; }

    public int LessonNumber { get; set; }

    public string? Classroom { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public bool? IsOddWeek { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Class Class { get; set; } = null!;

    public virtual TeacherSubjectClass TeacherSubjectClass { get; set; } = null!;
}
