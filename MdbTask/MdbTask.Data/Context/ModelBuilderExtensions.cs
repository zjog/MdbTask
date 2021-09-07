using MdbTask.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MdbTask.Data.Context
{
    public static class ModelBuilderExtensions
    {
        /// <summary>
        /// Seed DB data
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region cast
            modelBuilder.Entity<Cast>().HasData(
                new Cast { CastId = 1, Name = "Tim Robbins" },
                new Cast { CastId = 2, Name = "Morgan Freeman" },
                new Cast { CastId = 3, Name = "Bob Gunton" },
                new Cast { CastId = 4, Name = "William Sadler" },
                new Cast { CastId = 5, Name = "Clancy Brown" },
                new Cast { CastId = 6, Name = "Uma Thurman" },
                new Cast { CastId = 7, Name = "Rebecca Williams" },
                new Cast { CastId = 8, Name = "Sally Field" },
                new Cast { CastId = 9, Name = "Carrie-Anne Moss" },
                new Cast { CastId = 10, Name = "Gloria Foster" }
                );
            #endregion

            #region media
            modelBuilder.Entity<Media>().HasData(
                new Media { 
                    MediaId = 1,
                    Type = Enums.MediaType.Movie,
                    Title = "The Shawshank Redemption", 
                    Image= "76dc4726-424b-4b81-b6f4-f9ffa4bf1734.PNG", 
                    Descritpion = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", 
                    ReleaseDate = new DateTime(1994, 05, 25)
                },
                new Media
                {
                    MediaId = 2,
                    Type = Enums.MediaType.Movie,
                    Title = "The Godfather",
                    Image = "32ab2181-3042-4737-96e6-6d22d2099346.PNG",
                    Descritpion = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                    ReleaseDate = new DateTime(1972, 05, 25)
                },
                new Media
                {
                    MediaId = 3,
                    Type = Enums.MediaType.Movie,
                    Title = "The Godfather: Part II",
                    Image = "7e5bd243-8464-4e66-8209-067d09782b9e.PNG",
                    Descritpion = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                    ReleaseDate = new DateTime(1974, 05, 25)
                },
                new Media
                {
                    MediaId = 4,
                    Type = Enums.MediaType.Movie,
                    Title = "The Dark Knight",
                    Image = "acdbb57f-ea31-4796-bcca-19ee0859a95a.PNG",
                    Descritpion = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    ReleaseDate = new DateTime(2008, 05, 25)
                },
                new Media
                {
                    MediaId = 5,
                    Type = Enums.MediaType.Movie,
                    Title = "12 Angry Men",
                    Image = "d1b10603-f921-4958-add9-2cf24917e5c7.PNG",
                    Descritpion = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                    ReleaseDate = new DateTime(1957, 05, 25)
                },
                new Media
                {
                    MediaId = 6,
                    Type = Enums.MediaType.Movie,
                    Title = "Schindler's List",
                    Image = "2675bc9d-b461-4c80-aa58-eeaf1ea4351f.PNG",
                    Descritpion = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    ReleaseDate = new DateTime(1993, 05, 25)
                },
                new Media
                {
                    MediaId = 7,
                    Type = Enums.MediaType.Movie,
                    Title = "The Lord of the Rings: The Return of the King",
                    Image = "18f1125b-6306-48e4-8f9f-263d76018a79.PNG",
                    Descritpion = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                    ReleaseDate = new DateTime(2003, 05, 25)
                },
                new Media
                {
                    MediaId = 8,
                    Type = Enums.MediaType.Movie,
                    Title = "Pulp Fiction",
                    Image = "0d7b6135-16d4-4586-b417-6a48e5c7837c.PNG",
                    Descritpion = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    ReleaseDate = new DateTime(1994, 05, 25)
                },
                new Media
                {
                    MediaId = 9,
                    Type = Enums.MediaType.Movie,
                    Title = "The Good, the Bad and the Ugly",
                    Image = "886a7fcd-d44a-410a-bd43-c6499fc4ea3c.PNG",
                    Descritpion = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                    ReleaseDate = new DateTime(1966, 05, 25)
                },
                new Media
                {
                    MediaId = 10,
                    Type = Enums.MediaType.Movie,
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Image = "a5394d5f-cf3a-4f4a-a073-33f01537343e.PNG",
                    Descritpion = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                    ReleaseDate = new DateTime(2001, 05, 25)
                },
                new Media
                {
                    MediaId = 11,
                    Type = Enums.MediaType.Movie,
                    Title = "Fight Club",
                    Image = "b03ba6df-c0b3-473b-9054-c11b8e72172c.PNG",
                    Descritpion = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                    ReleaseDate = new DateTime(1999, 05, 25)
                },
                new Media
                {
                    MediaId = 12,
                    Type = Enums.MediaType.Movie,
                    Title = "Forrest Gump",
                    Image = "1c615d7a-4eb2-4df2-961b-ee495d56fcde.PNG",
                    Descritpion = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                    ReleaseDate = new DateTime(1994, 05, 25)
                },
                new Media
                {
                    MediaId = 13,
                    Type = Enums.MediaType.Movie,
                    Title = "Inception",
                    Image = "908728fd-3cde-4d75-b0fa-78e9e6eeddb4.PNG",
                    Descritpion = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                    ReleaseDate = new DateTime(2010, 05, 25)
                },
                new Media
                {
                    MediaId = 14,
                    Type = Enums.MediaType.Movie,
                    Title = "The Lord of the Rings: The Two Towers",
                    Image = "11fb7a34-bc30-4add-b6e4-ee69fb60e841.PNG",
                    Descritpion = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                    ReleaseDate = new DateTime(2002, 05, 25)
                },
                new Media
                {
                    MediaId = 15,
                    Type = Enums.MediaType.Movie,
                    Title = "The Matrix",
                    Image = "ea1cf8c2-cb50-4a3c-8454-b15f1e6b8417.PNG",
                    Descritpion = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
                    ReleaseDate = new DateTime(1999, 05, 25)
                },
                new Media
                {
                    MediaId = 16,
                    Type = Enums.MediaType.Movie,
                    Title = "Goodfellas",
                    Image = "524d78a2-cbcf-4d35-9700-0dc1e4dd14c1.PNG",
                    Descritpion = "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.",
                    ReleaseDate = new DateTime(1990, 05, 25)
                },
                new Media
                {
                    MediaId = 17,
                    Type = Enums.MediaType.Movie,
                    Title = "Seven Samurai",
                    Image = "35f15079-9c99-4c88-8040-6d4fca4f1fa5.PNG",
                    Descritpion = "A poor village under attack by bandits recruits seven unemployed samurai to help them defend themselves.",
                    ReleaseDate = new DateTime(1954, 05, 25)
                },
                new Media
                {
                    MediaId = 18,
                    Type = Enums.MediaType.Movie,
                    Title = "Se7en",
                    Image = "5ca1d05b-0c72-4686-860b-c6d2cb21ba95.PNG",
                    Descritpion = "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.",
                    ReleaseDate = new DateTime(1995, 05, 25)
                },
                new Media
                {
                    MediaId = 19,
                    Type = Enums.MediaType.Movie,
                    Title = "The Silence of the Lambs",
                    Image = "9100a14d-a3d1-4811-976e-575f619d01d4.PNG",
                    Descritpion = "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.",
                    ReleaseDate = new DateTime(1991, 05, 25)
                },
                new Media
                {
                    MediaId = 20,
                    Type = Enums.MediaType.Movie,
                    Title = "City of God",
                    Image = "27514c79-8c30-477a-8c0a-38e9078f7147.PNG",
                    Descritpion = "In the slums of Rio, two kids' paths diverge as one struggles to become a photographer and the other a kingpin.",
                    ReleaseDate = new DateTime(2002, 05, 25)
                },
                new Media
                {
                    MediaId = 21,
                    Type = Enums.MediaType.Show,
                    Title = "Planet Earth II",
                    Image = "bfd415ff-e78c-4b14-ace6-7bad9ae53f37.PNG",
                    Descritpion = "Wildlife documentary series with David Attenborough, beginning with a look at the remote islands which offer sanctuary to some of the planet's rarest creatures, to the beauty of cities, which are home to humans, and animals.",
                    ReleaseDate = new DateTime(2016, 05, 25)
                },
                new Media
                {
                    MediaId = 22,
                    Type = Enums.MediaType.Show,
                    Title = "Planet Earth",
                    Image = "740d3ede-41c0-43c6-a3cb-7cdb0082a6fa.PNG",
                    Descritpion = "Emmy Award-winning, 11 episodes, five years in the making, the most expensive nature documentary series ever commissioned by the BBC, and the first to be filmed in high definition.",
                    ReleaseDate = new DateTime(2006, 05, 25)
                },
                new Media
                {
                    MediaId = 23,
                    Type = Enums.MediaType.Show,
                    Title = "Breaking Bad",
                    Image = "2fb29410-c0dc-4d46-949c-4a1815d3b50f.PNG",
                    Descritpion = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                    ReleaseDate = new DateTime(2008, 05, 25)
                },
                new Media
                {
                    MediaId = 24,
                    Type = Enums.MediaType.Show,
                    Title = "Band of Brothers",
                    Image = "6e7edc1a-bc77-4253-aa96-ed5e91dc42b3.PNG",
                    Descritpion = "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.",
                    ReleaseDate = new DateTime(2001, 05, 25)
                },
                new Media
                {
                    MediaId = 25,
                    Type = Enums.MediaType.Show,
                    Title = "Chernobyl",
                    Image = "17513a86-fdc0-4598-bec4-52acd627cc36.PNG",
                    Descritpion = "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.",
                    ReleaseDate = new DateTime(2019, 05, 25)
                },
                new Media
                {
                    MediaId = 26,
                    Type = Enums.MediaType.Show,
                    Title = "The Wire",
                    Image = "6150136a-4ce7-4c9b-a49e-68ec6c9fe642.PNG",
                    Descritpion = "The Baltimore drug scene, as seen through the eyes of drug dealers and law enforcement.",
                    ReleaseDate = new DateTime(2000, 05, 25)
                },
                new Media
                {
                    MediaId = 27,
                    Type = Enums.MediaType.Show,
                    Title = "Avatar: The Last Airbender",
                    Image = "85dc2dbe-d959-417e-b403-e12a8fe8afb5.PNG",
                    Descritpion = "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.",
                    ReleaseDate = new DateTime(2005, 05, 25)
                },
                new Media
                {
                    MediaId = 28,
                    Type = Enums.MediaType.Show,
                    Title = "Game of Thrones",
                    Image = "6fad8c23-c2c8-45b3-8baf-47495dece884.PNG",
                    Descritpion = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                    ReleaseDate = new DateTime(2011, 05, 25)
                },
                new Media
                {
                    MediaId = 29,
                    Type = Enums.MediaType.Show,
                    Title = "The Sopranos",
                    Image = "6562d6af-f04d-4246-8304-2a62c0ac1945.PNG",
                    Descritpion = "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.",
                    ReleaseDate = new DateTime(1999, 05, 25)
                },
                new Media
                {
                    MediaId = 30,
                    Type = Enums.MediaType.Show,
                    Title = "Rick and Morty",
                    Image = "756a163a-adf9-45e3-bbbf-c00f9aed8b18.PNG",
                    Descritpion = "An animated series that follows the exploits of a super scientist and his not-so-bright grandson.",
                    ReleaseDate = new DateTime(2000, 05, 25)
                },
                new Media
                {
                    MediaId = 31,
                    Type = Enums.MediaType.Show,
                    Title = "The World at War",
                    Image = "b7c5c80e-4e4a-4072-919f-5b2b82aa2d1a.PNG",
                    Descritpion = "A groundbreaking 26-part documentary series narrated by the actor Laurence Olivier about the deadliest conflict in history, World War II.",
                    ReleaseDate = new DateTime(1973, 05, 25)
                },
                new Media
                {
                    MediaId = 32,
                    Type = Enums.MediaType.Show,
                    Title = "Sherlock",
                    Image = "8d758e36-b365-4ab7-8d47-e125b98c165e.PNG",
                    Descritpion = "A modern update finds the famous sleuth and his doctor partner solving crime in 21st century London.",
                    ReleaseDate = new DateTime(2010, 05, 25)
                },
                new Media
                {
                    MediaId = 33,
                    Type = Enums.MediaType.Show,
                    Title = "The Twilight Zone",
                    Image = "23c49b20-e975-4840-86a0-a18a5543faa8.PNG",
                    Descritpion = "Ordinary people find themselves in extraordinarily astounding situations, which they each try to solve in a remarkable manner.",
                    ReleaseDate = new DateTime(1959, 05, 25)
                },
                new Media
                {
                    MediaId = 34,
                    Type = Enums.MediaType.Show,
                    Title = "Firefly",
                    Image = "162c4579-c6b9-4eae-b773-8ae1e6ef69e5.PNG",
                    Descritpion = "Five hundred years in the future, a renegade crew aboard a small spacecraft tries to survive as they travel the unknown parts of the galaxy and evade warring factions as well as authority agents out to get them.",
                    ReleaseDate = new DateTime(2002, 05, 25)
                },
                new Media
                {
                    MediaId = 35,
                    Type = Enums.MediaType.Show,
                    Title = "Death Note",
                    Image = "a8f5c87c-6fad-477a-9a09-4c125ed37f69.PNG",
                    Descritpion = "An intelligent high school student goes on a secret crusade to eliminate criminals from the world after discovering a notebook capable of killing anyone whose name is written into it.",
                    ReleaseDate = new DateTime(2006, 05, 25)
                },
                new Media
                {
                    MediaId = 36,
                    Type = Enums.MediaType.Show,
                    Title = "True Detective",
                    Image = "31121abe-e86f-4843-9baa-711b33928fb4.PNG",
                    Descritpion = "Seasonal anthology series in which police investigations unearth the personal and professional secrets of those involved, both within and outside the law.",
                    ReleaseDate = new DateTime(2014, 05, 25)
                },
                new Media
                {
                    MediaId = 37,
                    Type = Enums.MediaType.Show,
                    Title = "Cowboy Bebop",
                    Image = "c1ad8f44-fc28-4f7d-8c99-59485b74cd06.PNG",
                    Descritpion = "The futuristic misadventures and tragedies of an easygoing bounty hunter and his partners.",
                    ReleaseDate = new DateTime(1998, 05, 25)
                },
                new Media
                {
                    MediaId = 38,
                    Type = Enums.MediaType.Show,
                    Title = "The Office",
                    Image = "f8279730-3905-4497-946d-5377e20ae4be.PNG",
                    Descritpion = "A mockumentary on a group of typical office workers, where the workday consists of ego clashes, inappropriate behavior, and tedium.",
                    ReleaseDate = new DateTime(2005, 05, 25)
                },
                new Media
                {
                    MediaId = 39,
                    Type = Enums.MediaType.Show,
                    Title = "Fargo",
                    Image = "526abfac-a3f1-40a8-b58c-1a8649088182.PNG",
                    Descritpion = "Various chronicles of deception, intrigue and murder in and around frozen Minnesota. Yet all of these tales mysteriously lead back one way or another to Fargo, North Dakota.",
                    ReleaseDate = new DateTime(2014, 05, 25)
                },
                new Media
                {
                    MediaId = 40,
                    Type = Enums.MediaType.Show,
                    Title = "Only Fools and Horses",
                    Image = "d5d7d230-f594-4783-9063-21176004a786.PNG",
                    Descritpion = "Comedy that follows two brothers from London's rough Peckham estate as they wheel and deal through a number of dodgy deals and search for the big score that'll make them millionaires.",
                    ReleaseDate = new DateTime(1981, 05, 25)
                }
                );
            #endregion

            #region media cast

            IList<object> mediaCastData = new List<object>();
            Random rnd = new Random();

            for (int i = 1; i <= 40; i++)
            {
                int nmbr = rnd.Next(1, 11);
                mediaCastData.Add(new { MediaId = i, CastId = nmbr });
                mediaCastData.Add(new { MediaId = i, CastId = nmbr > 1 ? nmbr -1 : nmbr + 1 });
            };

            modelBuilder.Entity<Media>().HasMany(m => m.Cast).WithMany(m => m.Media).UsingEntity(j => j.HasData(mediaCastData));
            #endregion

            #region media ratings
            IList<Rating> mediaRatingData = new List<Rating>();

            for(int i = 1; i <= 25; i++)
            {
                mediaRatingData.Add(new Rating { RatingId = i, UserRating = rnd.Next(1, 6), MediaId = rnd.Next(1, 41) });
            }

            modelBuilder.Entity<Rating>().HasData(mediaRatingData);
            #endregion

        }
    }
}
