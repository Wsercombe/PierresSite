using System.Collections.Generic;
using System.ComponentModel;

namespace PierresSite.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    [DisplayName("Treat Name")]
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}