using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ASP.NETCoreIdentityCustom.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public ApplicationUser()
    {
        Tickets = new HashSet<Ticket>();
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public  ICollection<Ticket> Tickets { get; set; }
}

public class ApplicationRole : IdentityRole
{

}
