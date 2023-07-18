using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PruebaTecnica.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public int? UserId { get; set; }

    public int? ActivityId { get; set; }

    public DateTime? ReservationDate { get; set; }

    [JsonIgnore]
    public virtual Activity? Activity { get; set; }

    [JsonIgnore]
    public virtual User? User { get; set; }
}
