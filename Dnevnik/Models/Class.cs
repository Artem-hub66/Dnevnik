using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Class
{
    public int Id { get; set; }

    public string ClassName { get; set; } = null!;

    public int AcademicYearId { get; set; }

    public int? ClassTeacherId { get; set; }

    public virtual AcademicYear AcademicYear { get; set; } = null!;

    public virtual User? ClassTeacher { get; set; }

    public virtual ICollection<Homework> Homeworks { get; set; } = new List<Homework>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<TeacherSubjectClass> TeacherSubjectClasses { get; set; } = new List<TeacherSubjectClass>();
}
