using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Grade
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int TeacherSubjectClassId { get; set; }

    public int GradeValue { get; set; }

    public int? GradeWeight { get; set; }

    public DateOnly GradeDate { get; set; }

    public string? LessonTopic { get; set; }

    public int? Quarter { get; set; }

    public int? Semester { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual TeacherSubjectClass TeacherSubjectClass { get; set; } = null!;
}
