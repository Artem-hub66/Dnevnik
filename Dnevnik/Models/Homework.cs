using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Homework
{
    public int Id { get; set; }

    public int TeacherSubjectClassId { get; set; }

    public int ClassId { get; set; }

    public DateOnly DueDate { get; set; }

    public string Description { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual TeacherSubjectClass TeacherSubjectClass { get; set; } = null!;
}
