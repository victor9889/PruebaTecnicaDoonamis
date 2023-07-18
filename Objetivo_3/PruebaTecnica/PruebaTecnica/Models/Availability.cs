using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PruebaTecnica.Models;

public partial class Availability
{
    public int AvailabilityId { get; set; }

    public int? ActivityId { get; set; }

    public DateTime? AvailabilityDate { get; set; }
    [JsonIgnore]
    public virtual Activity? Activity { get; set; }
}
