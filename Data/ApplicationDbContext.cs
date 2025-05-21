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
                    Description = "Salle de concert embl�matique � Paris, accueillant des artistes internationaux.",
                    PhoneNumber = "+33 1 47 42 25 49",
                    Address1 = "28 Boulevard des Capucines",
                    Address2 = null,
                    Zip = "75009",
                    City = "Paris",
                    Country = "France"
                });

                this.Places.Add(new()
                {
                    Name = "Z�nith Paris - La Villette",
                    Description = "Grande salle de spectacle pour concerts et �v�nements divers.",
                    PhoneNumber = "+33 1 44 52 54 56",
                    Address1 = "211 Avenue Jean Jaur�s",
                    Address2 = null,
                    Zip = "75019",
                    City = "Paris",
                    Country = "France"
                });

                this.Places.Add(new()
                {
                    Name = "Le D�me de Marseille",
                    Description = "Salle polyvalente pour concerts et spectacles � Marseille.",
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
                    Description = "Salle de spectacle mythique situ�e dans le quartier de Pigalle � Paris.",
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
                    Description = "Salle de concert r�put�e � Toulouse pour son ambiance unique.",
                    PhoneNumber = "+33 5 62 24 09 50",
                    Address1 = "Rue Th�odore Monod",
                    Address2 = "Parc Technologique du Canal",
                    Zip = "31520",
                    City = "Ramonville-Saint-Agne",
                    Country = "France"
                });


                this.Artists.Add(new()
                {
                    Name = "�dith Piaf",
                    Description = "Chanteuse embl�matique de la chanson fran�aise, connue pour des titres comme 'La Vie en Rose'."
                });

                this.Artists.Add(new()
                {
                    Name = "Jean-Jacques Goldman",
                    Description = "Auteur-compositeur-interpr�te fran�ais tr�s appr�ci�, c�l�bre pour ses chansons intemporelles."
                });

                this.Artists.Add(new()
                {
                    Name = "Daft Punk",
                    Description = "Duo �lectronique fran�ais ayant marqu� la musique avec des titres comme 'Get Lucky'."
                });

                this.Artists.Add(new()
                {
                    Name = "David Guetta",
                    Description = "DJ et producteur fran�ais reconnu mondialement pour ses collaborations avec des artistes internationaux."
                });

                this.Artists.Add(new()
                {
                    Name = "Ang�le",
                    Description = "Chanteuse belge d'expression fran�aise, populaire pour ses titres comme 'Balance Ton Quoi'."
                });

                this.Artists.Add(new()
                {
                    Name = "Adele",
                    Description = "Chanteuse britannique � la voix puissante, c�l�bre pour des hits comme 'Someone Like You'."
                });

                this.Artists.Add(new()
                {
                    Name = "Beyonc�",
                    Description = "Ic�ne de la musique pop et R&B am�ricaine, connue pour ses performances spectaculaires."
                });

                this.Artists.Add(new()
                {
                    Name = "Ed Sheeran",
                    Description = "Chanteur et compositeur britannique, connu pour ses ballades telles que 'Perfect'."
                });

                this.Artists.Add(new()
                {
                    Name = "Renaud",
                    Description = "Artiste fran�ais incontournable, auteur de chansons engag�es et po�tiques."
                });

                this.Artists.Add(new()
                {
                    Name = "Stromae",
                    Description = "Auteur-compositeur-interpr�te belge c�l�bre pour ses hits comme 'Alors on danse'."
                });

                this.SaveChanges();
                var artists = this.Artists.ToList();
                var places = this.Places.ToList();

                this.Concerts.Add(new()
                {
                    Name = "L'�toile de Paris",
                    Description = "Un concert exceptionnel r�unissant �dith Piaf et Jean-Jacques Goldman pour une soir�e m�morable.",
                    Artists = new List<Artist>() { artists[0], artists[1] },
                    Place = places[0],
                    Date = new DateTime(2024, 12, 15, 20, 0, 0),
                    Price = 95.00m,
                    Picture = GetImageBytes("place-1.jpg")
                });

                this.Concerts.Add(new()
                {
                    Name = "Electro Night",
                    Description = "Daft Punk et David Guetta sur sc�ne pour une nuit de musique �lectro incroyable.",
                    Artists = new List<Artist>() { artists[2], artists[3] },
                    Place = places[1],
                    Date = new DateTime(2025, 1, 20, 22, 0, 0),
                    Price = 75.50m,
                    Picture = GetImageBytes("place-2.jpg")
                });

                this.Concerts.Add(new()
                {
                    Name = "Chansons Intemporelles",
                    Description = "Un hommage � la chanson fran�aise avec Renaud et Ang�le.",
                    Artists = new List<Artist>() { artists[4], artists[8] },
                    Place = places[2],
                    Date = new DateTime(2024, 11, 30, 19, 30, 0),
                    Price = 65.00m,
                    Picture = GetImageBytes("place-3.jpg")
                });

                this.Concerts.Add(new()
                {
                    Name = "Pop Divas Live",
                    Description = "Une soir�e l�gendaire avec Beyonc� et Adele.",
                    Artists = new List<Artist>() { artists[6], artists[5] },
                    Place = places[3],
                    Date = new DateTime(2025, 2, 14, 20, 0, 0),
                    Price = 150.00m,
                    Picture = GetImageBytes("place-4.jpg")
                });

                this.Concerts.Add(new()
                {
                    Name = "Ambiance Festive",
                    Description = "Stromae et Ed Sheeran r�unis pour un spectacle unique.",
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
