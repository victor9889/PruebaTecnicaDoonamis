using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PruebaTecnica.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public int? UserId { get; set; }

    public int? ActivityId { get; set; }

    public string? CommentContent { get; set; }

    public int? CommentRating { get; set; }

    [JsonIgnore]
    public virtual Activity? Activity { get; set; }

    [JsonIgnore]
    public virtual User? User { get; set; }
}
