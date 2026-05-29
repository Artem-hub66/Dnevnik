using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class TeacherSubjectClass
{
    public int Id { get; set; }

    public int TeacherId { get; set; }

    public int SubjectId { get; set; }

    public int ClassId { get; set; }

    public int AcademicYearId { get; set; }

    public int? HoursPerWeek { get; set; }

    public virtual AcademicYear AcademicYear { get; set; } = null!;

    public virtual Class Class { get; set; } = null!;

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual ICollection<Homework> Homeworks { get; set; } = new List<Homework>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    public virtual Subject Subject { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
