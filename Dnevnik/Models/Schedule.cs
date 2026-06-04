using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Schedule
{
    public int Id { get; set; }

    public int TeacherSubjectClassId { get; set; }

    public int ClassId { get; set; }

    public DateOnly LessonDate { get; set; }

    public string? LessonTopic { get; set; }

    public string? Classroom { get; set; }

    public int QuarterId { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual Quarter Quarter { get; set; } = null!;

    public virtual TeacherSubjectClass TeacherSubjectClass { get; set; } = null!;
}
