using MachineParkApp.Shared.Domain;

namespace MachineParkApp.Client.Components
{
    public partial class Machines
    {
        public List<Machine> MachineList { get; set; } = new List<Machine>();
        protected override void OnInitialized()
        {
            base.OnInitialized();
            MachineList.Add(new Machine() 
            { MachineID = Guid.NewGuid(), 
              Location = Location.Skövde,
              Date = new DateTime(),
              MachineType = "MachineType1", 
              Status = Status.online 
            });

            MachineList.Add(new Machine()
            {
                MachineID = Guid.NewGuid(),
                Location = Location.Göteborg,
                Date = new DateTime(),
                MachineType = "MachineType2",
                Status = Status.offline
            });

            //Föreläsning 1 dag 1: 58:24
        }
    }
}
