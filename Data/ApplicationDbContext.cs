using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Concert400.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Place> Places { get; set; }

        public void ResetDatabase(bool delete = true)
        {
            if (delete) this.Database.EnsureDeleted();
            if (this.Database.EnsureCreated())
            {

                this.Places.Add(new()
                {
                    Name = "L'Olympia",
                    Description = "Salle de concert emblématique à Paris, accueillant des artistes internationaux.",
                    PhoneNumber = "+33 1 47 42 25 49",
                    Address1 = "28 Boulevard des Capucines",
                    Address2 = null,
                    Zip = "75009",
                    City = "Paris",
                    Country = "France"
                });

                this.Places.Add(new()
                {
                    Name = "Zénith Paris - La Villette",
                    Description = "Grande salle de spectacle pour concerts et événements divers.",
                    PhoneNumber = "+33 1 44 52 54 56",
                    Address1 = "211 Avenue Jean Jaurès",
                    Address2 = null,
                    Zip = "75019",
                    City = "Paris",
                    Country = "France"
                });

                this.Places.Add(new()
                {
                    Name = "Le Dôme de Marseille",
                    Description = "Salle polyvalente pour concerts et spectacles à Marseille.",
                    PhoneNumber = "+33 4 91 12 21 21",
                    Address1 = "48 Avenue de Saint-Just",
                    Address2 = null,
                    Zip = "13004",
                    City = "Marseille",
                    Country = "France"
                });

                this.Places.Add(new()
                {
                    Name = "La Cigale",
                    Description = "Salle de spectacle mythique située dans le quartier de Pigalle à Paris.",
                    PhoneNumber = "+33 1 49 25 89 99",
                    Address1 = "120 Boulevard de Rochechouart",
                    Address2 = null,
                    Zip = "75018",
                    City = "Paris",
                    Country = "France"
                });

                this.Places.Add(new()
                {
                    Name = "Le Bikini",
                    Description = "Salle de concert réputée à Toulouse pour son ambiance unique.",
                    PhoneNumber = "+33 5 62 24 09 50",
                    Address1 = "Rue Théodore Monod",
                    Address2 = "Parc Technologique du Canal",
                    Zip = "31520",
                    City = "Ramonville-Saint-Agne",
                    Country = "France"
                });


                this.Artists.Add(new()
                {
                    Name = "Édith Piaf",
                    Description = "Chanteuse emblématique de la chanson française, connue pour des titres comme 'La Vie en Rose'."
                });

                this.Artists.Add(new()
                {
                    Name = "Jean-Jacques Goldman",
                    Description = "Auteur-compositeur-interprète français très apprécié, célèbre pour ses chansons intemporelles."
                });

                this.Artists.Add(new()
                {
                    Name = "Daft Punk",
                    Description = "Duo électronique français ayant marqué la musique avec des titres comme 'Get Lucky'."
                });

                this.Artists.Add(new()
                {
                    Name = "David Guetta",
                    Description = "DJ et producteur français reconnu mondialement pour ses collaborations avec des artistes internationaux."
                });

                this.Artists.Add(new()
                {
                    Name = "Angèle",
                    Description = "Chanteuse belge d'expression française, populaire pour ses titres comme 'Balance Ton Quoi'."
                });

                this.Artists.Add(new()
                {
                    Name = "Adele",
                    Description = "Chanteuse britannique à la voix puissante, célèbre pour des hits comme 'Someone Like You'."
                });

                this.Artists.Add(new()
                {
                    Name = "Beyoncé",
                    Description = "Icône de la musique pop et R&B américaine, connue pour ses performances spectaculaires."
                });

                this.Artists.Add(new()
                {
                    Name = "Ed Sheeran",
                    Description = "Chanteur et compositeur britannique, connu pour ses ballades telles que 'Perfect'."
                });

                this.Artists.Add(new()
                {
                    Name = "Renaud",
                    Description = "Artiste français incontournable, auteur de chansons engagées et poétiques."
                });

                this.Artists.Add(new()
                {
                    Name = "Stromae",
                    Description = "Auteur-compositeur-interprète belge célèbre pour ses hits comme 'Alors on danse'."
                });

                this.SaveChanges();
                var artists = this.Artists.ToList();
                var places = this.Places.ToList();

                this.Concerts.Add(new()
                {
                    Name = "L'Étoile de Paris",
                    Description = "Un concert exceptionnel réunissant Édith Piaf et Jean-Jacques Goldman pour une soirée mémorable.",
                    Artists = new List<Artist>() { artists[0], artists[1] },
                    Place = places[0],
                    Date = new DateTime(2024, 12, 15, 20, 0, 0),
                    Price = 95.00m,
                    Picture = GetImageBytes("place-1.jpg")
                });

                this.Concerts.Add(new()
                {
                    Name = "Electro Night",
                    Description = "Daft Punk et David Guetta sur scène pour une nuit de musique électro incroyable.",
                    Artists = new List<Artist>() { artists[2], artists[3] },
                    Place = places[1],
                    Date = new DateTime(2025, 1, 20, 22, 0, 0),
                    Price = 75.50m,
                    Picture = GetImageBytes("place-2.jpg")
                });

                this.Concerts.Add(new()
                {
                    Name = "Chansons Intemporelles",
                    Description = "Un hommage à la chanson française avec Renaud et Angèle.",
                    Artists = new List<Artist>() { artists[4], artists[8] },
                    Place = places[2],
                    Date = new DateTime(2024, 11, 30, 19, 30, 0),
                    Price = 65.00m,
                    Picture = GetImageBytes("place-3.jpg")
                });

                this.Concerts.Add(new()
                {
                    Name = "Pop Divas Live",
                    Description = "Une soirée légendaire avec Beyoncé et Adele.",
                    Artists = new List<Artist>() { artists[6], artists[5] },
                    Place = places[3],
                    Date = new DateTime(2025, 2, 14, 20, 0, 0),
                    Price = 150.00m,
                    Picture = GetImageBytes("place-4.jpg")
                });

                this.Concerts.Add(new()
                {
                    Name = "Ambiance Festive",
                    Description = "Stromae et Ed Sheeran réunis pour un spectacle unique.",
                    Artists = new List<Artist>() { artists[9], artists[7] },
                    Place = places[4],
                    Date = new DateTime(2024, 12, 10, 21, 0, 0),
                    Price = 85.00m,
                    Picture = GetImageBytes("place-5.jpg")
                });

                this.SaveChanges();
            }
        }
        byte[] GetImageBytes(string filename) => File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", filename));
    }
}
