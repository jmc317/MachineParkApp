using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineParkApp.Shared.Domain
{
    public enum Status
    {
        online,
        offline
    }

    public enum Location
    {
        Skövde,
        Göteborg,
        Stockholm
    }

    public class Machine
    {
        public Guid MachineID { get; set; }
        public Location Location { get; set; }
        public DateTime Date { get; set; }
        public string MachineType { get; set; } = string.Empty;

        public Status Status { get; set; }
    }

}
