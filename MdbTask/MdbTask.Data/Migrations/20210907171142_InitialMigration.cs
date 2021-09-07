using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MdbTask.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cast",
                columns: table => new
                {
                    CastId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cast", x => x.CastId);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    MediaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Descritpion = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.MediaId);
                });

            migrationBuilder.CreateTable(
                name: "CastMedia",
                columns: table => new
                {
                    CastId = table.Column<int>(type: "INTEGER", nullable: false),
                    MediaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastMedia", x => new { x.CastId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_CastMedia_Cast_CastId",
                        column: x => x.CastId,
                        principalTable: "Cast",
                        principalColumn: "CastId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastMedia_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "MediaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserRating = table.Column<int>(type: "INTEGER", nullable: false),
                    MediaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "MediaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "CastId", "Name" },
                values: new object[] { 1, "Tim Robbins" });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "CastId", "Name" },
                values: new object[] { 10, "Gloria Foster" });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "CastId", "Name" },
                values: new object[] { 8, "Sally Field" });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "CastId", "Name" },
                values: new object[] { 7, "Rebecca Williams" });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "CastId", "Name" },
                values: new object[] { 6, "Uma Thurman" });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "CastId", "Name" },
                values: new object[] { 9, "Carrie-Anne Moss" });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "CastId", "Name" },
                values: new object[] { 4, "William Sadler" });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "CastId", "Name" },
                values: new object[] { 3, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "CastId", "Name" },
                values: new object[] { 2, "Morgan Freeman" });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "CastId", "Name" },
                values: new object[] { 5, "Clancy Brown" });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 28, "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.", "6fad8c23-c2c8-45b3-8baf-47495dece884.PNG", new DateTime(2011, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game of Thrones", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 22, "Emmy Award-winning, 11 episodes, five years in the making, the most expensive nature documentary series ever commissioned by the BBC, and the first to be filmed in high definition.", "740d3ede-41c0-43c6-a3cb-7cdb0082a6fa.PNG", new DateTime(2006, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planet Earth", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 23, "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", "2fb29410-c0dc-4d46-949c-4a1815d3b50f.PNG", new DateTime(2008, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking Bad", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 24, "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.", "6e7edc1a-bc77-4253-aa96-ed5e91dc42b3.PNG", new DateTime(2001, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Band of Brothers", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 25, "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.", "17513a86-fdc0-4598-bec4-52acd627cc36.PNG", new DateTime(2019, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chernobyl", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 26, "The Baltimore drug scene, as seen through the eyes of drug dealers and law enforcement.", "6150136a-4ce7-4c9b-a49e-68ec6c9fe642.PNG", new DateTime(2000, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wire", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 27, "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.", "85dc2dbe-d959-417e-b403-e12a8fe8afb5.PNG", new DateTime(2005, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar: The Last Airbender", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 29, "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.", "6562d6af-f04d-4246-8304-2a62c0ac1945.PNG", new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sopranos", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 34, "Five hundred years in the future, a renegade crew aboard a small spacecraft tries to survive as they travel the unknown parts of the galaxy and evade warring factions as well as authority agents out to get them.", "162c4579-c6b9-4eae-b773-8ae1e6ef69e5.PNG", new DateTime(2002, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Firefly", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 31, "A groundbreaking 26-part documentary series narrated by the actor Laurence Olivier about the deadliest conflict in history, World War II.", "b7c5c80e-4e4a-4072-919f-5b2b82aa2d1a.PNG", new DateTime(1973, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The World at War", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 32, "A modern update finds the famous sleuth and his doctor partner solving crime in 21st century London.", "8d758e36-b365-4ab7-8d47-e125b98c165e.PNG", new DateTime(2010, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sherlock", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 33, "Ordinary people find themselves in extraordinarily astounding situations, which they each try to solve in a remarkable manner.", "23c49b20-e975-4840-86a0-a18a5543faa8.PNG", new DateTime(1959, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Twilight Zone", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 21, "Wildlife documentary series with David Attenborough, beginning with a look at the remote islands which offer sanctuary to some of the planet's rarest creatures, to the beauty of cities, which are home to humans, and animals.", "bfd415ff-e78c-4b14-ace6-7bad9ae53f37.PNG", new DateTime(2016, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planet Earth II", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 35, "An intelligent high school student goes on a secret crusade to eliminate criminals from the world after discovering a notebook capable of killing anyone whose name is written into it.", "a8f5c87c-6fad-477a-9a09-4c125ed37f69.PNG", new DateTime(2006, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Note", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 36, "Seasonal anthology series in which police investigations unearth the personal and professional secrets of those involved, both within and outside the law.", "31121abe-e86f-4843-9baa-711b33928fb4.PNG", new DateTime(2014, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "True Detective", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 37, "The futuristic misadventures and tragedies of an easygoing bounty hunter and his partners.", "c1ad8f44-fc28-4f7d-8c99-59485b74cd06.PNG", new DateTime(1998, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cowboy Bebop", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 38, "A mockumentary on a group of typical office workers, where the workday consists of ego clashes, inappropriate behavior, and tedium.", "f8279730-3905-4497-946d-5377e20ae4be.PNG", new DateTime(2005, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Office", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 30, "An animated series that follows the exploits of a super scientist and his not-so-bright grandson.", "756a163a-adf9-45e3-bbbf-c00f9aed8b18.PNG", new DateTime(2000, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rick and Morty", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 20, "In the slums of Rio, two kids' paths diverge as one struggles to become a photographer and the other a kingpin.", "27514c79-8c30-477a-8c0a-38e9078f7147.PNG", new DateTime(2002, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "City of God", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 15, "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", "ea1cf8c2-cb50-4a3c-8454-b15f1e6b8417.PNG", new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 18, "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.", "5ca1d05b-0c72-4686-860b-c6d2cb21ba95.PNG", new DateTime(1995, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Se7en", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 1, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "76dc4726-424b-4b81-b6f4-f9ffa4bf1734.PNG", new DateTime(1994, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 2, "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", "32ab2181-3042-4737-96e6-6d22d2099346.PNG", new DateTime(1972, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 3, "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "7e5bd243-8464-4e66-8209-067d09782b9e.PNG", new DateTime(1974, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather: Part II", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 4, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "acdbb57f-ea31-4796-bcca-19ee0859a95a.PNG", new DateTime(2008, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 5, "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", "d1b10603-f921-4958-add9-2cf24917e5c7.PNG", new DateTime(1957, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Angry Men", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 6, "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "2675bc9d-b461-4c80-aa58-eeaf1ea4351f.PNG", new DateTime(1993, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 7, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "18f1125b-6306-48e4-8f9f-263d76018a79.PNG", new DateTime(2003, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Return of the King", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 8, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "0d7b6135-16d4-4586-b417-6a48e5c7837c.PNG", new DateTime(1994, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 9, "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", "886a7fcd-d44a-410a-bd43-c6499fc4ea3c.PNG", new DateTime(1966, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Good, the Bad and the Ugly", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 10, "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "a5394d5f-cf3a-4f4a-a073-33f01537343e.PNG", new DateTime(2001, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Fellowship of the Ring", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 11, "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "b03ba6df-c0b3-473b-9054-c11b8e72172c.PNG", new DateTime(1999, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 12, "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "1c615d7a-4eb2-4df2-961b-ee495d56fcde.PNG", new DateTime(1994, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 13, "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "908728fd-3cde-4d75-b0fa-78e9e6eeddb4.PNG", new DateTime(2010, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 14, "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.", "11fb7a34-bc30-4add-b6e4-ee69fb60e841.PNG", new DateTime(2002, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings: The Two Towers", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 39, "Various chronicles of deception, intrigue and murder in and around frozen Minnesota. Yet all of these tales mysteriously lead back one way or another to Fargo, North Dakota.", "526abfac-a3f1-40a8-b58c-1a8649088182.PNG", new DateTime(2014, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fargo", 0 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 16, "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.", "524d78a2-cbcf-4d35-9700-0dc1e4dd14c1.PNG", new DateTime(1990, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Goodfellas", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 17, "A poor village under attack by bandits recruits seven unemployed samurai to help them defend themselves.", "35f15079-9c99-4c88-8040-6d4fca4f1fa5.PNG", new DateTime(1954, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seven Samurai", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 19, "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.", "9100a14d-a3d1-4811-976e-575f619d01d4.PNG", new DateTime(1991, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Silence of the Lambs", 1 });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "MediaId", "Descritpion", "Image", "ReleaseDate", "Title", "Type" },
                values: new object[] { 40, "Comedy that follows two brothers from London's rough Peckham estate as they wheel and deal through a number of dodgy deals and search for the big score that'll make them millionaires.", "d5d7d230-f594-4783-9063-21176004a786.PNG", new DateTime(1981, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Only Fools and Horses", 0 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 6, 1 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 10, 28 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 27 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 6, 27 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 8, 26 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 9, 26 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 3, 25 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 4, 25 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 1, 24 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 2, 24 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 2, 23 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 1, 23 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 4, 22 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 22 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 2, 21 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 1, 40 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 1, 20 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 2, 20 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 8, 19 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 9, 19 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 9, 28 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 7, 18 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 4, 29 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 9, 30 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 39 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 6, 39 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 8, 38 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 9, 38 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 3, 37 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 4, 37 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 4, 36 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 36 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 35 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 6, 35 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 3, 34 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 4, 34 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 33 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 6, 33 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 2, 32 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 1, 32 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 7, 31 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 8, 31 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 8, 30 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 3, 29 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 8, 18 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 1, 21 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 9, 17 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 6, 10 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 6, 9 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 7, 9 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 8, 8 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 9, 8 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 4, 7 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 7 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 6 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 10 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 6, 6 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 6, 5 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 2, 4 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 4, 3 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 1 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 3, 11 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 2, 40 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 10, 14 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 10, 15 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 2, 11 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 1, 16 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 9, 14 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 2, 16 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 1, 13 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 2, 13 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 9, 15 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 5, 12 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 6, 12 });

            migrationBuilder.InsertData(
                table: "CastMedia",
                columns: new[] { "CastId", "MediaId" },
                values: new object[] { 10, 17 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 19, 16, 4 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 11, 21, 1 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 1, 19, 3 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 22, 1, 2 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 16, 1, 4 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 7, 15, 3 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 12, 35, 3 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 5, 15, 4 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 4, 37, 2 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 21, 25, 3 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 15, 22, 2 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 17, 33, 2 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 8, 6, 1 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 18, 22, 4 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 20, 31, 4 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 14, 31, 1 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 9, 7, 2 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 24, 7, 3 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 25, 17, 2 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 6, 28, 2 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 3, 24, 3 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 2, 27, 5 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 13, 10, 4 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 23, 5, 3 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MediaId", "UserRating" },
                values: new object[] { 10, 28, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_CastMedia_MediaId",
                table: "CastMedia",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MediaId",
                table: "Ratings",
                column: "MediaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CastMedia");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Cast");

            migrationBuilder.DropTable(
                name: "Media");
        }
    }
}
