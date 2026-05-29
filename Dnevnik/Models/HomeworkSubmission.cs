using System;
using System.Collections.Generic;

namespace Dnevnik.Models;

public partial class HomeworkSubmission
{
    public int Id { get; set; }

    public int HomeworkId { get; set; }

    public int StudentId { get; set; }

    public string? SubmissionText { get; set; }

    public string? AttachmentPath { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public string? Status { get; set; }

    public int? Grade { get; set; }

    public string? TeacherComment { get; set; }

    public virtual Homework Homework { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
