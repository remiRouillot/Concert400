using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Aumerial.EntityFrameworkCore;
using System.Data.Common;

namespace Concert400.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Unicode] public string? FirstName { get; set; } = "";
        [Unicode] public string? LastName { get; set; } = "";
        [Unicode] public string? Address1 { get; set; } = "";
        [Unicode] public string? Address2 { get; set; } = "";
        [Unicode] public string? Zip { get; set; } = "";
        [Unicode] public string? City { get; set; } = "";
        [Unicode] public string? Country { get; set; } = "";
        public IEnumerable<Ticket>? Tickets { get; set; }
        [Column(TypeName = "BLOB(3M)")] public byte[]? Picture { get; set; }

        public string GetUserName()
        {
            if (!string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(FirstName)) return String.Format("{0} {1}", FirstName, LastName);
            else if (!string.IsNullOrWhiteSpace(FirstName) ) return FirstName;
            else return UserName ?? "User";
        }
        public string GetAvatarName()
        {
            if (!string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName)) return String.Format("{0}{1}", FirstName[0], LastName[0]);
            else if (!string.IsNullOrWhiteSpace(FirstName) ) return String.Format("{0}",FirstName[0]);
            else if (!string.IsNullOrWhiteSpace(UserName) ) return String.Format("{0}",UserName[0]);
            else return "U";
        }
    }

    public class Concert
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Unicode] public string? Name { get; set; } = "";
        [Unicode] public string? Description { get; set; } = "";
        public IEnumerable<Artist>? Artists { get; set; }
        public Place? Place { get; set; }
        public DateTime? Date { get; set; } = DateTime.Now;
        [Column(TypeName = "BLOB(3M)")] public byte[]? Picture { get; set; }
        public decimal? Price {  get; set; }
    }

    public class Place
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Unicode] public string? Name { get; set; } = "";
        [Unicode] public string? Description { get; set; } = "";
        public string? PhoneNumber { get; set; } = "";
        [Unicode] public string? Address1 { get; set; } = "";
        [Unicode] public string? Address2 { get; set; } = "";
        [Unicode] public string? Zip { get; set; } = "";
        [Unicode] public string? City { get; set; } = "";
        [Unicode] public string? Country { get; set; } = "";
        [Column(TypeName = "BLOB(3M)")] public byte[]? Picture { get; set; }
    }

    public class Artist
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Unicode] public string? Name { get; set; } = "";
        [Unicode] public string? Description { get; set; } = "";
        public IEnumerable<Concert>? Concerts { get; set; }
        [Column(TypeName = "BLOB(3M)")] public byte[]? Picture { get; set; }
    }

    public class Ticket
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal? Price { get; set; }
        public bool Checked { get; set; } = false;
        public DateTime? CheckedOn { get; set; }
        [Unicode] public string? FirstName { get; set; } = "";
        [Unicode] public string? LastName { get; set; } = "";
        public Concert? Concert { get; set; }
        public ApplicationUser User { get; set; }
    }
}
