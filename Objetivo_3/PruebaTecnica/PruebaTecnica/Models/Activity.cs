using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PruebaTecnica.Models;

public partial class Activity
{
    public int ActivityId { get; set; }

    public string? ActivityTitle { get; set; }

    public string? ActivityDescription { get; set; }

    public string? ActivityCategory { get; set; }

    public float? ActivityPrice { get; set; }

    public string? ActivityLocation { get; set; }

    [JsonIgnore]
    public virtual ICollection<Availability> Availabilities { get; set; } = new List<Availability>();
    [JsonIgnore]
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    [JsonIgnore]
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
