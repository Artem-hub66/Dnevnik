using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class Homework
{
    public int Id { get; set; }

    public int TeacherSubjectClassId { get; set; }

    public int ClassId { get; set; }

    public DateOnly AssignmentDate { get; set; }

    public DateOnly? DueDate { get; set; }

    public string Description { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; } = new List<HomeworkSubmission>();

    public virtual TeacherSubjectClass TeacherSubjectClass { get; set; } = null!;
}
