using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PruebaTecnica.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPassword { get; set; }

    [JsonIgnore]
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    [JsonIgnore]
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
