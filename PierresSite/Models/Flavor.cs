using System.Collections.Generic;
using System.ComponentModel;
namespace PierresSite.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }

    [DisplayName("Flavor Name")]
    public string Description { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<FlavorTreat> JoinEntities { get;}
  }
}