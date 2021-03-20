using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProjectWorkspace.Seeding
{
	public static class SeedMovies
	{
		public static void SeedAllMovies(AppDbContext db)
		{
		//Create a new list for all of the Movie Information
		List<Movie> AllMovies = new List<Movie>();
		AllMovies.Add(new Movie
		{
			MovieNumber = 3001,
			Title = "Finding Nemo",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Animation"),
			Overview = "Nemo, an adventurous young clownfish, is unexpectedly taken from his Great Barrier Reef home to a dentist's office aquarium. It's up to his worrisome father Marlin and a friendly but forgetful fish Dory to bring Nemo home -- meeting vegetarian sharks, surfer dude turtles, hypnotic jellyfish, hungry seagulls, and more along the way.",
			Year = new DateTime(2003,5,30),
			Revenue = 940335536,
			Tagline = "There are 3.7 trillion fish in the ocean, they're looking for one.",
			RunTime = 100,
			MPAARating = MPAARatings.G,
			Actors = "Albert Brooks, Ellen DeGeneres",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3002,
			Title = "It Happened One Night",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "Ellie Andrews has just tied the knot with society aviator King Westley when she is whisked away to her father's yacht and out of King's clutches. Ellie jumps ship and eventually winds up on a bus headed back to her husband. Reluctantly she must accept the help of out-of- work reporter Peter Warne. Actually, Warne doesn't give her any choice: either she sticks with him until he gets her back to her husband, or he'll blow the whistle on Ellie to her father. Either way, Peter gets what he wants... a really juicy newspaper story!",
			Year = new DateTime(1934,2,22),
			Revenue = 4500000,
			Tagline = "TOGETHER... for the first time",
			RunTime = 105,
			MPAARating = MPAARatings.Unrated,
			Actors = "Clark Gable, Claudette Colbert, Walter Connolly, Roscoe Karns, Jameson Thomas, Alan Hale",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3003,
			Title = "Snow White and the Seven Dwarfs",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "A beautiful girl, Snow White, takes refuge in the forest in the house of seven dwarfs to hide from her stepmother, the wicked Queen. The Queen is jealous because she wants to be known as 'the fairest in the land,' and Snow White's beauty surpasses her own.",
			Year = new DateTime(1937,12,20),
			Revenue = 184925486,
			Tagline = "The Happiest, Dopiest, Grumpiest, Sneeziest movie of the year.",
			RunTime = 83,
			MPAARating = MPAARatings.G,
			Actors = "Adriana Caselotti, Lucille La Verne, Harry Stockwell, Roy Atwell, Pinto Colvig, Otis Harlan",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3004,
			Title = "The Wizard of Oz",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "Young Dorothy finds herself in a magical world where she makes friends with a lion, a scarecrow and a tin man as they make their way along the yellow brick road to talk with the Wizard and ask for the things they miss most in their lives. The Wicked Witch of the West is the only thing that could stop them.",
			Year = new DateTime(1939,8,15),
			Revenue = 33754967,
			Tagline = "We're off to see the Wizard, the wonderful Wizard of Oz!",
			RunTime = 102,
			MPAARating = MPAARatings.PG,
			Actors = "Judy Garland, Frank Morgan, Ray Bolger, Bert Lahr, Jack Haley, Billie Burke",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3005,
			Title = "Mr. Smith Goes to Washington",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "Naive and idealistic Jefferson Smith, leader of the Boy Rangers, is appointed on a lark by the spineless governor of his state. He is reunited with the state's senior senator--presidential hopeful and childhood hero, Senator Joseph Paine. In Washington, however, Smith discovers many of the shortcomings of the political process as his earnest goal of a national boys' camp leads to a conflict with the state political boss, Jim Taylor. Taylor first tries to corrupt Smith and then later attempts to destroy Smith through a scandal.",
			Year = new DateTime(1939,10,19),
			Revenue = 9600000,
			Tagline = "Romance, drama, laughter and heartbreak... created out of the very heart and soil of America!",
			RunTime = 129,
			MPAARating = MPAARatings.Unrated,
			Actors = "James Stewart, Jean Arthur, Claude Rains, Edward Arnold, Guy Kibbee, Thomas Mitchell",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3006,
			Title = "Gone with the Wind",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "An American classic in which a manipulative woman and a roguish man carry on a turbulent love affair in the American south during the Civil War and Reconstruction.",
			Year = new DateTime(1939,12,15),
			Revenue = 400176459,
			Tagline = "The greatest romance of all time!",
			RunTime = 238,
			MPAARating = MPAARatings.G,
			Actors = "Vivien Leigh, Clark Gable, Olivia de Havilland, Thomas Mitchell, Leslie Howard, Barbara O'Neil",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3007,
			Title = "Casablanca",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "In Casablanca, Morocco in December 1941, a cynical American expatriate meets a former lover, with unforeseen complications.",
			Year = new DateTime(1942,11,26),
			Revenue = 10462500,
			Tagline = "They had a date with fate in Casablanca!",
			RunTime = 102,
			MPAARating = MPAARatings.PG,
			Actors = "Humphrey Bogart, Ingrid Bergman, Paul Henreid, Claude Rains, Conrad Veidt, Sydney Greenstreet",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3008,
			Title = "Dr. No",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Action"),
			Overview = "In the film that launched the James Bond saga, Agent 007 battles mysterious Dr. No, a scientific genius bent on destroying the U.S. space program. As the countdown to disaster begins, Bond must go to Jamaica, where he encounters beautiful Honey Ryder, to confront a megalomaniacal villain in his massive island headquarters.",
			Year = new DateTime(1962,10,4),
			Revenue = 59600000,
			Tagline = "NOW meet the most extraordinary gentleman spy in all fiction!",
			RunTime = 110,
			MPAARating = MPAARatings.PG,
			Actors = "Sean Connery, Ursula Andress, Bernard Lee, Anthony Dawson",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3009,
			Title = "Lawrence of Arabia",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Adventure"),
			Overview = "An epic about British officer T.E. Lawrence's mission to aid the Arab tribes in their revolt against the Ottoman Empire during the First World War. Lawrence becomes a flamboyant, messianic figure in the cause of Arab unity but his psychological instability threatens to undermine his achievements.",
			Year = new DateTime(1962,12,10),
			Revenue = 69995385,
			Tagline = "A Mighty Motion Picture Of Action And Adventure!",
			RunTime = 216,
			MPAARating = MPAARatings.PG,
			Actors = "Peter O'Toole, Jack Hawkins, Omar Sharif, Claude Rains",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3010,
			Title = "A Streetcar Named Desire",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "Disturbed Blanche DuBois moves in with her sister in New Orleans and is tormented by her brutish brother-in-law while her reality crumbles around her.",
			Year = new DateTime(1951,9,18),
			Revenue = 8000000,
			Tagline = "...Blanche, who wanted so much to stay a lady...",
			RunTime = 125,
			MPAARating = MPAARatings.PG,
			Actors = "Vivien Leigh, Marlon Brando, Kim Hunter, Karl Malden, Rudy Bond, Nick Dennis",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3011,
			Title = "Singin' in the Rain",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Musical"),
			Overview = "In 1927 Hollywood, Don Lockwood and Lina Lamont are a famous on-screen romantic pair in silent movies, but Lina mistakes the on-screen romance for real love. When their latest film is transformed into a musical, Don has the perfect voice for the songs, but strident voice faces the studio to dub her voice. Aspiring actress, Kathy Selden is brought in and, while she is working on the movie, Don falls in love with her.",
			Year = new DateTime(1952,4,10),
			Revenue = 7200000,
			Tagline = "What a Glorious Feeling!",
			RunTime = 103,
			MPAARating = MPAARatings.G,
			Actors = "Gene Kelly, Donald O'Connor, Debbie Reynolds",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3012,
			Title = "Cat on a Hot Tin Roof",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "Brick, an alcoholic ex-football player, drinks his days away and resists the affections of his wife, Maggie. His reunion with his father, Big Daddy, who is dying of cancer, jogs a host of memories and revelations for both father and son.",
			Year = new DateTime(1958,2,17),
			Revenue = 17570324,
			Tagline = "Just one pillow on her bed ... and just one desire in her heart!",
			RunTime = 108,
			MPAARating = MPAARatings.Unrated,
			Actors = "Elizabeth Taylor, Paul Newman, Burl Ives, Judith Anderson, Jack Carson, Madeleine Sherwood",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3013,
			Title = "Some Like It Hot",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "Two musicians witness a mob hit and struggle to find a way out of the city before they are found by the gangsters. Their only opportunity is to join an all-girl band as they leave on a tour. To make their getaway they must first disguise themselves as women, then keep their identities secret and deal with the problems this brings - such as an attractive bandmate and a very determined suitor.",
			Year = new DateTime(1959,3,18),
			Revenue = 25000000,
			Tagline = "The movie too HOT for words!",
			RunTime = 122,
			MPAARating = MPAARatings.Unrated,
			Actors = "Marilyn Monroe, Tony Curtis",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3014,
			Title = "Four Weddings and a Funeral",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "Four Weddings And A Funeral is a British comedy about a British Man named Charles and an American Woman named Carrie who go through numerous weddings before they determine if they are right for one another.",
			Year = new DateTime(1994,3,9),
			Revenue = 254700832,
			Tagline = "Five good reasons to stay single.",
			RunTime = 117,
			MPAARating = MPAARatings.R,
			Actors = "Hugh Grant, Andie MacDowell",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3015,
			Title = "The Lion King",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Animation"),
			Overview = "A young lion cub named Simba can't wait to be king. But his uncle craves the title for himself and will stop at nothing to get it.",
			Year = new DateTime(1994,6,23),
			Revenue = 788241776,
			Tagline = "Life's greatest adventure is finding your place in the Circle of Life.",
			RunTime = 89,
			MPAARating = MPAARatings.G,
			Actors = "Jonathan Taylor Thomas, Matthew Broderick",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3016,
			Title = "Forrest Gump",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "A man with a low IQ has accomplished great things in his life and been present during significant historic events - in each case, far exceeding what anyone imagined he could do. Yet, despite all the things he has attained, his one true love eludes him. 'Forrest Gump' is the story of a man who rose above his challenges, and who proved that determination, courage, and love are more important than ability.",
			Year = new DateTime(1994,7,6),
			Revenue = 677945399,
			Tagline = "The world will never be the same, once you've seen it through the eyes of Forrest Gump.",
			RunTime = 142,
			MPAARating = MPAARatings.PG13,
			Actors = "Tom Hanks",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3017,
			Title = "The Shawshank Redemption",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "Framed in the 1940s for the double murder of his wife and her lover, upstanding banker Andy Dufresne begins a new life at the Shawshank prison, where he puts his accounting skills to work for an amoral warden. During his long stretch in prison, Dufresne comes to be admired by the other inmates -- including an older prisoner named Red -- for his integrity and unquenchable sense of hope.",
			Year = new DateTime(1994,9,23),
			Revenue = 28341469,
			Tagline = "Fear can hold you prisoner. Hope can set you free.",
			RunTime = 142,
			MPAARating = MPAARatings.R,
			Actors = "Tim Robbins, Morgan Freeman, Bob Gunton",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3018,
			Title = "Pulp Fiction",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Thriller"),
			Overview = "A burger-loving hit man, his philosophical partner, a drug-addled gangster's moll and a washed-up boxer converge in this sprawling, comedic crime caper. Their adventures unfurl in three stories that ingeniously trip back and forth in time.",
			Year = new DateTime(1994,10,8),
			Revenue = 213928762,
			Tagline = "Just because you are a character doesn't mean you have character.",
			RunTime = 154,
			MPAARating = MPAARatings.R,
			Actors = "John Travolta, Samuel L. Jackson",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3019,
			Title = "The Usual Suspects",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Crime"),
			Overview = "Held in an L.A. interrogation room, Verbal Kint attempts to convince the feds that a mythic crime lord, Keyser Soze, not only exists, but was also responsible for drawing him and his four partners into a multi-million dollar heist that ended with an explosion in San Pedro harbor ??? leaving few survivors. Verbal lures his interrogators with an incredible story of the crime lord's almost supernatural prowess.",
			Year = new DateTime(1995,7,19),
			Revenue = 23341568,
			Tagline = "Five Criminals. One Line Up. No Coincidence.",
			RunTime = 106,
			MPAARating = MPAARatings.R,
			Actors = "Stephen Baldwin, Gabriel Byrne, Chazz Palminteri, Kevin Pollak, Pete Postlethwaite, Kevin Spacey",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3020,
			Title = "Back to the Future Part II",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Adventure"),
			Overview = "Marty and Doc are at it again in this wacky sequel to the 1985 blockbuster as the time-traveling duo head to 2015 to nip some McFly family woes in the bud. But things go awry thanks to bully Biff Tannen and a pesky sports almanac. In a last-ditch attempt to set things straight, Marty finds himself bound for 1955 and face to face with his teenage parents -- again.",
			Year = new DateTime(1989,11,20),
			Revenue = 332000000,
			Tagline = "Roads? Where we're going, we don't need roads!",
			RunTime = 108,
			MPAARating = MPAARatings.PG,
			Actors = "Michael J. Fox, Christopher Lloyd, Lea Thompson",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3021,
			Title = "Back to the Future Part III",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Adventure"),
			Overview = "The final installment of the Back to the Future trilogy finds Marty digging the trusty DeLorean out of a mineshaft and looking up Doc in the Wild West of 1885. But when their time machine breaks down, the travelers are stranded in a land of spurs. More problems arise when Doc falls for pretty schoolteacher Clara Clayton, and Marty tangles with Buford Tannen.",
			Year = new DateTime(1990,5,25),
			Revenue = 244527583,
			Tagline = "They've saved the best trip for last... But this time they may have gone too far.",
			RunTime = 118,
			MPAARating = MPAARatings.PG,
			Actors = "Michael J. Fox, Christopher Lloyd, Lea Thompson, Elisabeth Shue",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3022,
			Title = "Rush Hour",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "The daughter of a Chinese Diplomat is kidnapped and an unlikely duo sets out to find her",
			Year = new DateTime(1998,9,18),
			Revenue = 72070731,
			Tagline = "War. What is it good for? Absolutely nothing!",
			RunTime = 98,
			MPAARating = MPAARatings.PG13,
			Actors = "Jackie Chan, Chris Tucker",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3023,
			Title = "The Sound of Music",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Musical"),
			Overview = "Film adaptation of a classic Rodgers and Hammerstein musical based on a nun who becomes a governess for an Austrian family.",
			Year = new DateTime(1965,3,2),
			Revenue = 286214286,
			Tagline = "The happiest sound in all the world!",
			RunTime = 174,
			MPAARating = MPAARatings.G,
			Actors = "Julie Andrews, Christopher Plummer, Richard Haydn, Peggy Wood, Charmian Carr",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3024,
			Title = "Butch Cassidy and the Sundance Kid",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Western"),
			Overview = "In late 1890s Wyoming, Butch Cassidy is the affable, clever and talkative leader of the outlaw Hole in the Wall Gang. His closest companion is the laconic dead-shot 'Sundance Kid'. As the west rapidly becomes civilized, the law finally catches up to Butch, Sundance and their gang.  Chased doggedly by a special posse, the two decide to make their way to South America in hopes of evading their pursuers once and for all.",
			Year = new DateTime(1969,9,23),
			Revenue = 102308889,
			Tagline = "Not that it matters, but most of it is true.",
			RunTime = 110,
			MPAARating = MPAARatings.PG,
			Actors = "Paul Newman, Robert Redford, Henry Jones, Jeff Corey",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3025,
			Title = "Catch-22",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "A bombardier in World War II tries desperately to escape the insanity of the war. However, sometimes insanity is the only sane way to cope with a crazy situation. Catch-22 is a parody of a 'military mentality' and of a bureaucratic society in general.",
			Year = new DateTime(1970,6,24),
			Revenue = 24911670,
			Tagline = "The anti-war satire of epic proportions.",
			RunTime = 121,
			MPAARating = MPAARatings.R,
			Actors = "Martin Balsam, Richard Benjamin, Art Garfunkel, Jack Gilford",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3026,
			Title = "Willy Wonka & the Chocolate Factory",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "Eccentric candy man Willy Wonka prompts a worldwide frenzy when he announces that golden tickets hidden inside five of his delicious candy bars will admit their lucky holders into his top-secret confectionary. But does Wonka have an agenda hidden amid a world of Oompa Loompas and chocolate rivers?",
			Year = new DateTime(1971,6,29),
			Revenue = 4000000,
			Tagline = "It's Scrumdiddlyumptious!",
			RunTime = 100,
			MPAARating = MPAARatings.G,
			Actors = "Gene Wilder, Jack Albertson, Leonard Stone",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3027,
			Title = "Fiddler on the Roof",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Musical"),
			Overview = "This lavishly produced and critically acclaimed screen adaptation of the international stage sensation tells the life-affirming story of Tevye (Topol), a poor milkman whose love, pride and faith help him face the oppression of turn-of-the-century Czarist Russia. Nominated for eight Academy Awards.",
			Year = new DateTime(1971,11,3),
			Revenue = 83304330,
			Tagline = "To Life!",
			RunTime = 181,
			MPAARating = MPAARatings.G,
			Actors = "Chaim Topol, Norma Crane, Leonard Frey, Molly Picon, Paul Mann, Rosalind Harris",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3028,
			Title = "Diamonds Are Forever",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Action"),
			Overview = "Diamonds are stolen only to be sold again in the international market. James Bond infiltrates a smuggling mission to find out who???s guilty. The mission takes him to Las Vegas where Bond meets his archenemy Blofeld.",
			Year = new DateTime(1971,12,13),
			Revenue = 116019547,
			Tagline = "The man who made 007 a household number",
			RunTime = 120,
			MPAARating = MPAARatings.PG,
			Actors = "Sean Connery, Jill St. John, Charles Gray, Lana Wood, Jimmy Dean, Bruce Cabot",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3029,
			Title = "American Graffiti",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "A couple of high school graduates spend one final night cruising the strip with their buddies before they go off to college.",
			Year = new DateTime(1973,8,1),
			Revenue = 140000000,
			Tagline = "Where were you in '62?",
			RunTime = 110,
			MPAARating = MPAARatings.PG,
			Actors = "Richard Dreyfuss, Ron Howard,Cindy Williams, Candy Clark",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3030,
			Title = "The Sting",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "Set in the 1930's this intricate caper deals with an ambitious small-time crook and a veteran con man who seek revenge on a vicious crime lord who murdered one of their gang.",
			Year = new DateTime(1973,12,25),
			Revenue = 159616327,
			Tagline = "...all it takes is a little confidence.",
			RunTime = 129,
			MPAARating = MPAARatings.PG,
			Actors = "Paul Newman, Robert Redford, Robert Shaw, Ray Walston, Eileen Brennan",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3031,
			Title = "The Exorcist",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Horror"),
			Overview = "12-year-old Regan MacNeil begins to adapt an explicit new personality as strange events befall the local area of Georgetown. Her mother becomes torn between science and superstition in a desperate bid to save her daughter, and ultimately turns to her last hope: Father Damien Karras, a troubled priest who is struggling with his own faith.",
			Year = new DateTime(1973,12,26),
			Revenue = 441306145,
			Tagline = "Something almost beyond comprehension is happening to a girl on this street, in this house... and a man has been sent for as a last resort. This man is The Exorcist.",
			RunTime = 122,
			MPAARating = MPAARatings.R,
			Actors = "Linda Blair, Max von Sydow, Ellen Burstyn, Jason Miller, Lee J. Cobb, Kitty Winn",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3032,
			Title = "Blazing Saddles",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "A town ??? where everyone seems to be named Johnson ??? is in the way of the railroad and, in order to grab their land, Hedley Lemar, a politically connected nasty person, sends in his henchmen to make the town unlivable. After the sheriff is killed, the town demands a new sheriff from the Governor, so Hedley convinces him to send the town the first black sheriff in the west.",
			Year = new DateTime(1974,2,7),
			Revenue = 119500000,
			Tagline = "Never give a saga an even break!",
			RunTime = 93,
			MPAARating = MPAARatings.R,
			Actors = "Cleavon Little, Gene Wilder, Harvey Korman, Mel Brooks",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3033,
			Title = "Monty Python and the Holy Grail",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "King Arthur, accompanied by his squire, recruits his Knights of the Round Table, including Sir Bedevere the Wise, Sir Lancelot the Brave, Sir Robin the Not-Quite-So-Brave-As-Sir-Lancelot and Sir Galahad the Pure. On the way, Arthur battles the Black Knight who, despite having had all his limbs chopped off, insists he can still fight. They reach Camelot, but Arthur decides not  to enter, as 'it is a silly place'.",
			Year = new DateTime(1975,3,13),
			Revenue = 5028948,
			Tagline = "And now! At Last! Another film completely different from some of the other films which aren't quite the same as this one is.",
			RunTime = 91,
			MPAARating = MPAARatings.PG,
			Actors = "Graham Chapman, John Cleese, Terry Gilliam, Eric Idle, Terry Jones, Michael Palin",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3034,
			Title = "The Color Purple",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "An epic tale spanning forty years in the life of Celie (Whoopi Goldberg), an African-American woman living in the South who survives incredible abuse and bigotry.  After Celie's abusive father marries her off to the equally debasing 'Mister' Albert Johnson (Danny Glover), things go from bad to worse, leaving Celie to find companionship anywhere she can.  She perseveres, holding on to her dream of one day being reunited with her sister in Africa.  Based on the novel by Alice Walker.",
			Year = new DateTime(1985,12,18),
			Revenue = 146292009,
			Tagline = "It's about life. It's about love. It's about us.",
			RunTime = 154,
			MPAARating = MPAARatings.PG13,
			Actors = "Whoopi Goldberg, Oprah Winfrey, Willard E. Pugh",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3035,
			Title = "Top Gun",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Action"),
			Overview = "For Lieutenant Pete 'Maverick' Mitchell and his friend and Co-Pilot Nick 'Goose' Bradshaw being accepted into an elite training school for fighter pilots is a dream come true.  A tragedy, as well as personal demons, threaten Pete's dreams of becoming an Ace pilot.",
			Year = new DateTime(1986,5,16),
			Revenue = 356830601,
			Tagline = "Up there with the best of the best.",
			RunTime = 110,
			MPAARating = MPAARatings.PG,
			Actors = "Tom Cruise, Kelly McGillis, Val Kilmer, Michael Ironside",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3036,
			Title = "Little Shop of Horrors",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Musical"),
			Overview = "Seymour Krelborn is a nerdy orphan working at Mushnik's, a flower shop in urban Skid Row. He harbors a crush on fellow co-worker Audrey Fulquard, and is berated by Mr. Mushnik daily. One day as Seymour is seeking a new mysterious plant, he finds a very mysterious unidentified plant which he calls Audrey II. The plant seems to have a craving for blood and soon begins to sing for his supper.",
			Year = new DateTime(1986,12,19),
			Revenue = 38748395,
			Tagline = "Don't feed the plants.",
			RunTime = 94,
			MPAARating = MPAARatings.PG13,
			Actors = "Rick Moranis, Ellen Greene, Vincent Gardenia, Steve Martin, Tisha Campbell-Martin, John Candy",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3037,
			Title = "Spaceballs",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "When the nefarious Dark Helmet hatches a plan to snatch Princess Vespa and steal her planet's air, space-bum-for-hire Lone Starr and his clueless sidekick fly to the rescue. Along the way, they meet Yogurt, who puts Lone Starr wise to the power of 'The Schwartz.' Can he master it in time to save the day?",
			Year = new DateTime(1987,6,24),
			Revenue = 38119483,
			Tagline = "May the schwartz be with you",
			RunTime = 96,
			MPAARating = MPAARatings.PG,
			Actors = "Mel Brooks, Rick Moranis, Bill Pullman, Daphne Zuniga, John Candy, George Wyner",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3038,
			Title = "The Princess Bride",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "In this enchantingly cracked fairy tale, the beautiful Princess Buttercup and the dashing Westley must overcome staggering odds to find happiness amid six-fingered swordsmen, murderous princes, Sicilians and rodents of unusual size. But even death can't stop these true lovebirds from triumphing.",
			Year = new DateTime(1987,9,18),
			Revenue = 30857814,
			Tagline = "It's as real as the feelings you feel.",
			RunTime = 98,
			MPAARating = MPAARatings.PG,
			Actors = "Cary Elwes, Robin Wright, Mandy Patinkin, Andre the Giant",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3039,
			Title = "Big",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "A young boy, Josh Baskin makes a wish at a carnival machine to be big. He wakes up the following morning to find that it has been granted and his body has grown older overnight. But he is still the same 13-year-old boy inside. Now he must learn how to cope with the unfamiliar world of grown-ups including getting a job and having his first romantic encounter with a woman. What will he find out about this strange world?",
			Year = new DateTime(1988,6,3),
			Revenue = 151668774,
			Tagline = "You're Only Young Once But For Josh It Might Just Last A Lifetime.",
			RunTime = 104,
			MPAARating = MPAARatings.PG,
			Actors = "Tom Hanks, Elizabeth Perkins, Jared Rushton, David Moscow",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3040,
			Title = "The Land Before Time",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "An orphaned brontosaurus named Littlefoot sets off in search of the legendary Great Valley. A land of lush vegetation where the dinosaurs can thrive and live in peace. Along the way he meets four other young dinosaurs, each one a different species, and they encounter several obstacles as they learn to work together in order to survive.",
			Year = new DateTime(1988,11,18),
			Revenue = 84460846,
			Tagline = "A new adventure is born.",
			RunTime = 69,
			MPAARating = MPAARatings.G,
			Actors = "Gabriel Damon, Candace Hutson, Judith Barsi, Will Ryan, Pat Hingle, Helen Shaver",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3041,
			Title = "Rain Man",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "Selfish yuppie Charlie Babbitt's father left a fortune to his savant brother Raymond and a pittance to Charlie; they travel cross-country.",
			Year = new DateTime(1988,12,11),
			Revenue = 412800000,
			Tagline = "A journey through understanding and fellowship.",
			RunTime = 133,
			MPAARating = MPAARatings.R,
			Actors = "Dustin Hoffman, Tom Cruise, Valeria Golino, Gerald R. Molen, Jack Murdock, Michael D. Roberts",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3042,
			Title = "Bill & Ted's Excellent Adventure",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "In the small town of San Dimas, a few miles away from Los Angeles, there are two nearly brain dead teenage boys going by the names of Bill S, Preston ESQ. and Ted Theodore Logan, they have a dream together of starting their own rock and roll band called the 'Wyld Stallyns. Unfortunately, they are still in high school and on the verge of failing out of their school as well, and if they do not pass their upcoming history report, they will be separated as a result of Ted's father sending him to military school. But, what Bill and Ted do not know is that they must stay together to save the future. So, a man from the future named Rufus came to help them pass their report. So, both Bill and Ted decided to gather up historical figures which they need for their report. They are hoping that this will help them pass their report so they can stay together.",
			Year = new DateTime(1989,2,17),
			Revenue = 40485039,
			Tagline = "History is about to be rewritten by two guys who can't spell.",
			RunTime = 90,
			MPAARating = MPAARatings.PG,
			Actors = "Keanu Reeves, Alex Winter,  Amy Stock-Poynton",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3043,
			Title = "Dead Poets Society",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "At an elite, old-fashioned boarding school in New England, a passionate English teacher inspires his students to rebel against convention and seize the potential of every day, courting the disdain of the stern headmaster.",
			Year = new DateTime(1989,6,2),
			Revenue = 235860116,
			Tagline = "He was their inspiration. He made their lives extraordinary.",
			RunTime = 129,
			MPAARating = MPAARatings.PG,
			Actors = "Robin Williams, Ethan Hawke, Robert Sean Leonard, Gale Hansen, Josh Charles, Dylan Kussman",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3044,
			Title = "When Harry Met Sally...",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "During their travels from Chicago to New York, Harry and Sally Will debate whether or not sex ruins a perfect relationship between a man and a woman. Eleven years and later, they're still no closer to finding the answer.",
			Year = new DateTime(1989,7,21),
			Revenue = 92823546,
			Tagline = "Can two friends sleep together and still love each other in the morning?",
			RunTime = 96,
			MPAARating = MPAARatings.R,
			Actors = "Meg Ryan, Billy Crystal, Carrie Fisher, Bruno Kirby, Steven Ford, Lisa Jane Persky",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3045,
			Title = "Animal House",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "At a 1962 College, Dean Vernon Wormer is determined to expel the entire Delta Tau Chi Fraternity, but those troublemakers have other plans for him.",
			Year = new DateTime(1978,7,27),
			Revenue = 141000000,
			Tagline = "It was the Deltas against the rules... the rules lost!",
			RunTime = 109,
			MPAARating = MPAARatings.R,
			Actors = "Verna Bloom, Tom Hulce, Cesare Danova, John Vernon",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3046,
			Title = "West Side Story",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Musical"),
			Overview = "In the slums of the upper West Side of Manhattan, New York, a gang of Polish-American teenagers called the Jets compete with a rival gang of recently immigrated Puerto Ricans, the Sharks, to 'own' the neighborhood streets. Tensions are high between the gangs but two kids, one from each rival gang, fall in love leading to tragedy.",
			Year = new DateTime(1961,10,18),
			Revenue = 43656822,
			Tagline = "The screen achieves one of the great entertainments in the history of motion pictures",
			RunTime = 152,
			MPAARating = MPAARatings.Unrated,
			Actors = "Natalie Wood, Richard Beymer, Russ Tamblyn, Rita Moreno, George Chakiris, Simon Oakland",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3047,
			Title = "The Man Who Shot Liberty Valance",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Western"),
			Overview = "A senator, who became famous for killing a notorious outlaw, returns for the funeral of an old friend and tells the truth about his deed.",
			Year = new DateTime(1962,4,22),
			Revenue = 8000000,
			Tagline = "Together For The First Time - James Stewart - John Wayne - in the masterpiece of four-time Academy Award winner John Ford",
			RunTime = 123,
			MPAARating = MPAARatings.Unrated,
			Actors = "John Wayne, James Stewart, Vera Miles, Lee Marvin, Edmond O'Brien, Ken Murray",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3048,
			Title = "Wayne's World",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "When a sleazy TV exec offers Wayne and Garth a fat contract to tape their late-night public access show at his network, they can't believe their good fortune. But they soon discover the road from basement to big-time is a gnarly one, fraught with danger, temptation and ragin' party opportunities.",
			Year = new DateTime(1992,2,14),
			Revenue = 121697323,
			Tagline = "You'll laugh. You'll cry. You'll hurl.",
			RunTime = 94,
			MPAARating = MPAARatings.PG13,
			Actors = "Mike Myers, Dana Carvey, Rob Lowe, Tia Carrere, Chris Farley",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3049,
			Title = "A League of Their Own",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "Small-town sisters Dottie and Kit join an all-female baseball league formed after World War II brings pro baseball to a standstill. When their team hits the road with its drunken coach, the siblings find troubles and triumphs on and off the field.",
			Year = new DateTime(1992,7,1),
			Revenue = 107458785,
			Tagline = "To achieve the incredible, you have to attempt the impossible.",
			RunTime = 128,
			MPAARating = MPAARatings.PG,
			Actors = "Tom Hanks, Geena Davis, Madonna, Lori Petty, Jon Lovitz, David Strathairn",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3050,
			Title = "The Last of the Mohicans",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Adventure"),
			Overview = "As the English and French soldiers battle for control of the American colonies in the 18th century, the settlers and native Americans are forced to take sides. Cora and her sister Alice unwittingly walk into trouble but are reluctantly saved by Hawkeye, an orphaned settler adopted by the last of the Mohicans.",
			Year = new DateTime(1992,9,25),
			Revenue = 75505856,
			Tagline = "The first American hero.",
			RunTime = 112,
			MPAARating = MPAARatings.R,
			Actors = "Daniel Day-Lewis",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3051,
			Title = "Aladdin",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "Princess Jasmine grows tired of being forced to remain in the palace and she sneaks out into the marketplace  in disguise where she meets street-urchin Aladdin and the two fall in love, although she may only marry a prince. After being thrown in jail, Aladdin and becomes embroiled in a plot to find a mysterious lamp with which the evil Jafar hopes to rule the land.",
			Year = new DateTime(1992,11,25),
			Revenue = 504050219,
			Tagline = "Wish granted!",
			RunTime = 90,
			MPAARating = MPAARatings.G,
			Actors = "Scott Weinger, Robin Williams,Frank Welker, Gilbert Gottfried",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3052,
			Title = "The Muppet Christmas Carol",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Musical"),
			Overview = "A retelling of the classic Dickens tale of Ebenezer Scrooge, miser extraordinaire. He is held accountable for his dastardly ways during night-time visitations by the Ghosts of Christmas Past, Present, and future.",
			Year = new DateTime(1992,12,10),
			Revenue = 27281507,
			Tagline = "",
			RunTime = 85,
			MPAARating = MPAARatings.G,
			Actors = "Michael Caine, Don Austen, Meredith Braun, Don Austen, Ed Sanders",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3053,
			Title = "A Few Good Men",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "When cocky military lawyer Lt. Daniel Kaffee and his co-counsel, Lt. Cmdr. JoAnne Galloway, are assigned to a murder case, they uncover a hazing ritual that could implicate high-ranking officials such as shady Col. Nathan Jessep.",
			Year = new DateTime(1992,12,11),
			Revenue = 243240178,
			Tagline = "You can't handle the truth!",
			RunTime = 138,
			MPAARating = MPAARatings.R,
			Actors = "Tom Cruise, Jack Nicholson, Demi Moore, James Marshall",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3054,
			Title = "Mary Poppins",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "The movie combines a diverting story, songs, color and sequences of live action blended with the movements of animated figures. Mary Poppins is a kind of Super-nanny who flies in with her umbrella in response to the request of the Banks children and proceeds to put things right with the aid of her rather extraordinary magical powers before flying off again.",
			Year = new DateTime(1964,8,27),
			Revenue = 102272727,
			Tagline = "It's supercalifragilisticexpialidocious!",
			RunTime = 139,
			MPAARating = MPAARatings.G,
			Actors = "Julie Andrews, Dick Van Dyke",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3055,
			Title = "Hocus Pocus",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "After 300 years of slumber, three sister witches are accidentally resurrected in Salem on Halloween night, and it us up to three kids and their newfound feline friend to put an end to the witches' reign of terror once and for all.",
			Year = new DateTime(1993,7,16),
			Revenue = 39514713,
			Tagline = "It's just a bunch of Hocus Pocus.",
			RunTime = 96,
			MPAARating = MPAARatings.PG,
			Actors = "Bette Midler, Sarah Jessica Parker",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3056,
			Title = "Dazed and Confused",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "The adventures of a group of Texas teens on their last day of school in 1976, centering on student Randall Floyd, who moves easily among stoners, jocks and geeks. Floyd is a star athlete, but he also likes smoking weed, which presents a conundrum when his football coach demands he sign a 'no drugs' pledge.",
			Year = new DateTime(1993,9,24),
			Revenue = 7993039,
			Tagline = "See it with a bud.",
			RunTime = 102,
			MPAARating = MPAARatings.R,
			Actors = "Jason London, Rory Cochrane",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3057,
			Title = "Back to the Future",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Adventure"),
			Overview = "Eighties teenager Marty McFly is accidentally sent back in time to 1955, inadvertently disrupting his parents' first meeting and attracting his mother's romantic interest. Marty must repair the damage to history by rekindling his parents' romance and - with the help of his eccentric inventor friend Doc Brown - return to 1985.",
			Year = new DateTime(1985,7,3),
			Revenue = 381109762,
			Tagline = "He's the only kid ever to get into trouble before he was born.",
			RunTime = 116,
			MPAARating = MPAARatings.PG,
			Actors = "Michael J. Fox, Christopher Lloyd, Lea Thompson",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3058,
			Title = "It's a Wonderful Life",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "George Bailey has spent his entire life giving of himself to the people of Bedford Falls. He has always longed to travel but never had the opportunity in order to prevent rich skinflint Mr. Potter from taking over the entire town. All that prevents him from doing so is George's modest building and loan company, which was founded by his generous father. But on Christmas Eve, George's Uncle Billy loses the business's $8,000 while intending to deposit it in the bank. Potter finds the misplaced money, hides it from Billy, and George's troubles begin.",
			Year = new DateTime(1946,12,20),
			Revenue = 9644124,
			Tagline = "It's a wonderful laugh! It's a wonderful love!",
			RunTime = 130,
			MPAARating = MPAARatings.PG,
			Actors = "James Stewart, Donna Reed, Lionel Barrymore, Thomas Mitchell, Henry Travers, Beulah Bondi",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3059,
			Title = "Annie Get Your Gun",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Musical"),
			Overview = "This film adaptation of Irving Berlin's classic musical stars Betty Hutton as gunslinger Annie Oakley, who romances fellow sharpshooter Frank Butler (Howard Keel) as they travel with Buffalo Bill's Wild West Show. Previously off target when it comes to love, Annie proves you can get a man with a gun in this battle-of-the-sexes extravaganza, which features timeless numbers like 'Anything You Can Do' and 'There's No Business Like Show Business.'",
			Year = new DateTime(1950,5,17),
			Revenue = 8000000,
			Tagline = "Biggest musical under the sun!",
			RunTime = 107,
			MPAARating = MPAARatings.Unrated,
			Actors = "Betty Hutton, Howard Keel, Louis Calhern, J. Carrol Naish, Edward Arnold, Keenan Wynn",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3060,
			Title = "To Kill a Mockingbird",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "In a small Alabama town in the 1930s, scrupulously honest and highly respected lawyer, Atticus Finch puts his career on the line when he agrees to represent Tom Robinson, a black man accused of rape. The trial and the events surrounding it are seen through the eyes of Finch's six-year-old daughter, Scout. While Robinson's trial gives the movie its momentum, there are plenty of anecdotal occurrences before and after the court date: Scout's ever-strengthening bond with older brother, Jem, her friendship with precocious young Dill Harris, her father's no-nonsense reactions to such life-and-death crises as a rampaging mad dog, and especially Scout's reactions to, and relationship with, Boo Radley, the reclusive 'village idiot' who turns out to be her salvation when she is attacked by a venomous bigot.",
			Year = new DateTime(1962,12,25),
			Revenue = 13129846,
			Tagline = "The most beloved Pulitzer Prize book now comes vividly alive on the screen!?",
			RunTime = 129,
			MPAARating = MPAARatings.Unrated,
			Actors = "Gregory Peck, Brock Peters, James Anderson, Mary Badham, Phillip Alford, John Megna",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3061,
			Title = "A Hard Day's Night",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Musical"),
			Overview = "Capturing John Lennon, Paul McCartney, George Harrison and Ringo Starr in their electrifying element, 'A Hard Day's Night' is a wildly irreverent journey through this pastiche of a day in the life of The Beatles during 1964. The band have to use all their guile and wit to avoid the pursuing fans and press to reach their scheduled television performance, in spite of Paul's troublemaking grandfather and Ringo's arrest.",
			Year = new DateTime(1964,7,6),
			Revenue = 12299668,
			Tagline = "The Beatles, starring in their first full-length, hilarious, action-packed film!",
			RunTime = 88,
			MPAARating = MPAARatings.G,
			Actors = "John Lennon, Paul McCartney, George Harrison, Ringo Starr, Wilfrid Brambell, Norman Rossington",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3062,
			Title = "The Spy Who Loved Me",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Action"),
			Overview = "Russian and British submarines with nuclear missiles on board both vanish from sight without a trace. England and Russia both blame each other as James Bond tries to solve the riddle of the disappearing ships. But the KGB also has an agent on the case.",
			Year = new DateTime(1977,7,7),
			Revenue = 185438673,
			Tagline = "It's the BIGGEST. It's the BEST. It's BOND. And B-E-Y-O-N-D.",
			RunTime = 125,
			MPAARating = MPAARatings.PG,
			Actors = "Roger Moore, Barbara Bach, Curd Joergens",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3063,
			Title = "Toy Story",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "Led by Woody, Andy's toys live happily in his room until Andy's birthday brings Buzz Lightyear onto the scene. Afraid of losing his place in Andy's heart, Woody plots against Buzz. But when circumstances separate Buzz and Woody from their owner, the duo eventually learns to put aside their differences.",
			Year = new DateTime(1995,10,30),
			Revenue = 373554033,
			Tagline = "Hang on for the comedy that goes to infinity and beyond!",
			RunTime = 81,
			MPAARating = MPAARatings.G,
			Actors = "Tom Hanks, Tim Allen, Don Rickles, Jim Varney, Wallace Shawn, John Ratzenberger",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3064,
			Title = "Sense and Sensibility",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Romance"),
			Overview = "Rich Mr. Dashwood dies, leaving his second wife and her daughters poor by the rules of inheritance. Two daughters are the titular opposites.",
			Year = new DateTime(1995,12,13),
			Revenue = 135000000,
			Tagline = "Lose your heart and come to your senses.",
			RunTime = 136,
			MPAARating = MPAARatings.PG,
			Actors = "Kate Winslet, Emma Thompson, Alan Rickman, Imogen Stubbs",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3065,
			Title = "Mission: Impossible",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Action"),
			Overview = "When Ethan Hunt, the leader of a crack espionage team whose perilous operation has gone awry with no explanation, discovers that a mole has penetrated the CIA, he's surprised to learn that he's the No. 1 suspect. To clear his name, Hunt now must ferret out the real double agent and, in the process, even the score.",
			Year = new DateTime(1996,5,22),
			Revenue = 457696359,
			Tagline = "Expect the Impossible.",
			RunTime = 110,
			MPAARating = MPAARatings.PG13,
			Actors = "Tom Cruise, Jon Voight, Emmanuelle Beart, Henry Czerny, Jean Reno, Ving Rhames",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3066,
			Title = "Independence Day",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Action"),
			Overview = "On July 2, a giant alien mothership enters orbit around Earth and deploys several dozen saucer-shaped 'destroyer' spacecraft that quickly lay waste to major cities around the planet. On July 3, the United States conducts a coordinated counterattack that fails. On July 4, a plan is devised to gain access to the interior of the alien mothership in space, in order to plant a nuclear missile.",
			Year = new DateTime(1996,6,25),
			Revenue = 816969268,
			Tagline = "Earth. Take a good look. It might be your last.",
			RunTime = 145,
			MPAARating = MPAARatings.PG13,
			Actors = "Will Smith, Bill Pullman, Jeff Goldblum, Mary McDonnell, Judd Hirsch, Robert Loggia",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3067,
			Title = "Austin Powers: International Man of Mystery",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "As a swingin' fashion photographer by day and a groovy British superagent by night, Austin Powers is the '60s' most shagadelic spy, baby! But can he stop megalomaniac Dr. Evil after the bald villain freezes himself and unthaws in the '90s? With the help of sexy sidekick Vanessa Kensington, he just might.",
			Year = new DateTime(1997,5,2),
			Revenue = 67683989,
			Tagline = "If he were any cooler, he'd still be frozen, baby!",
			RunTime = 94,
			MPAARating = MPAARatings.PG13,
			Actors = "Mike Myers, Elizabeth Hurley, Michael York, Mimi Rogers, Seth Green, Fabiana Udenio",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3068,
			Title = "Men in Black",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "Men in Black follows the exploits of agents Kay and Jay, members of a top-secret organization established to monitor and police alien activity on Earth. The two Men in Black find themselves in the middle of the deadly plot by an intergalactic terrorist who has arrived on Earth to assassinate two ambassadors from opposing galaxies. In order to prevent worlds from colliding, the MiB must track down the terrorist and prevent the destruction of Earth. It's just another typical day for the Men in Black.",
			Year = new DateTime(1997,7,2),
			Revenue = 589390539,
			Tagline = "Protecting the Earth from the scum of the universe.",
			RunTime = 98,
			MPAARating = MPAARatings.PG13,
			Actors = "Tommy Lee Jones, Will Smith, Linda Fiorentino, Vincent D'Onofrio, Rip Torn, Tony Shalhoub",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3069,
			Title = "Titanic",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "84 years later, a 101-year-old woman named Rose DeWitt Bukater tells the story to her granddaughter Lizzy Calvert, Brock Lovett, Lewis Bodine, Bobby Buell and Anatoly Mikailavich on the Keldysh about her life set in April 10th 1912, on a ship called Titanic when young Rose boards the departing ship with the upper-class passengers and her mother, Ruth DeWitt Bukater, and her fianc??, Caledon Hockley. Meanwhile, a drifter and artist named Jack Dawson and his best friend Fabrizio De Rossi win third-class tickets to the ship in a game. And she explains the whole story from departure until the death of Titanic on its first and last voyage April 15th, 1912 at 2:20 in the morning.",
			Year = new DateTime(1997,11,18),
			Revenue = 1845034188,
			Tagline = "Nothing on Earth could come between them.",
			RunTime = 194,
			MPAARating = MPAARatings.PG13,
			Actors = "Kate Winslet, Leonardo DiCaprio, Frances Fisher, Billy Zane, Kathy Bates, Gloria Stuart",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3070,
			Title = "Footloose",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "When teenager Ren and his family move from big-city Chicago to a small town in the West, he's in for a real case of culture shock.",
			Year = new DateTime(1984,2,17),
			Revenue = 80035402,
			Tagline = "He's a big-city kid in a small town. They said he'd never win. He knew he had to.",
			RunTime = 107,
			MPAARating = MPAARatings.PG,
			Actors = "Kevin Bacon, John Lithgow, Dianne Wiest, Chris Penn,  Sarah Jessica Parker",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3071,
			Title = "Shakespeare in Love",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Romance"),
			Overview = "Young Shakespeare is forced to stage his latest comedy, 'Romeo and Ethel, the Pirate's Daughter,' before it's even written. When a lovely noblewoman auditions for a role, they fall into forbidden love -- and his play finds a new life (and title). As their relationship progresses, Shakespeare's comedy soon transforms into tragedy.",
			Year = new DateTime(1998,12,11),
			Revenue = 289317794,
			Tagline = "Love is the only inspiration.",
			RunTime = 122,
			MPAARating = MPAARatings.R,
			Actors = "Joseph Fiennes, Gwyneth Paltrow",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3072,
			Title = "You've Got Mail",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Romance"),
			Overview = "Book superstore magnate, Joe Fox and independent book shop owner, Kathleen Kelly fall in love in the anonymity of the Internet ??? both blissfully unaware that he's putting her out of business.",
			Year = new DateTime(1998,12,17),
			Revenue = 250821495,
			Tagline = "Someone you pass on the street may already be the love of your life.",
			RunTime = 119,
			MPAARating = MPAARatings.PG,
			Actors = "Tom Hanks, Meg Ryan, Katie Sagona, Greg Kinnear, Parker Posey, Jean Stapleton",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3073,
			Title = "Office Space",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "Three office workers strike back at their evil employers by hatching a hapless attempt to embezzle money.",
			Year = new DateTime(1999,2,19),
			Revenue = 12827813,
			Tagline = "Work sucks.",
			RunTime = 89,
			MPAARating = MPAARatings.R,
			Actors = "Ron Livingston, Jennifer Aniston, David Herman, Ajay Naidu, Diedrich Bader, Stephen Root",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3074,
			Title = "Notting Hill",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Romance"),
			Overview = "The British comedy from director Roger Michell tells the love story between a famous actress and a simple book seller from London. A look into the attempt for famous people to have a personal and private life and the ramifications that follow. Nominated for three Golden Globes in 2000.",
			Year = new DateTime(1999,5,13),
			Revenue = 363889678,
			Tagline = "Can the most famous film star in the world fall for the man on the street?",
			RunTime = 124,
			MPAARating = MPAARatings.PG13,
			Actors = "Julia Roberts, Hugh Grant",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3075,
			Title = "Toy Story 2",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "Andy heads off to Cowboy Camp, leaving his toys to their own devices. Things shift into high gear when an obsessive toy collector named Al McWhiggen, owner of Al's Toy Barn kidnaps Woody. Andy's toys mount a daring rescue mission, Buzz Lightyear meets his match and Woody has to decide where he and his heart truly belong.",
			Year = new DateTime(1999,10,30),
			Revenue = 497366869,
			Tagline = "The toys are back!",
			RunTime = 92,
			MPAARating = MPAARatings.G,
			Actors = "Tom Hanks, Tim Allen, Joan Cusack, Kelsey Grammer, Don Rickles, Jim Varney",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3076,
			Title = "Jaws",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Adventure"),
			Overview = "An insatiable great white shark terrorizes the townspeople of Amity Island, The police chief, an oceanographer and a grizzled shark hunter seek to destroy the bloodthirsty beast.",
			Year = new DateTime(1975,6,18),
			Revenue = 470654000,
			Tagline = "Don't go in the water.",
			RunTime = 124,
			MPAARating = MPAARatings.PG,
			Actors = "Roy Scheider, Robert Shaw, Richard Dreyfuss, Lorraine Gary, Murray Hamilton, Carl Gottlieb",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3077,
			Title = "Star Wars",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Adventure"),
			Overview = "Princess Leia is captured and held hostage by the evil Imperial forces in their effort to take over the galactic Empire. Venturesome Luke Skywalker and dashing captain Han Solo team together with the loveable robot duo R2-D2 and C-3PO to rescue the beautiful princess and restore peace and justice in the Empire.",
			Year = new DateTime(1977,5,25),
			Revenue = 775398007,
			Tagline = "A long time ago in a galaxy far, far away...",
			RunTime = 121,
			MPAARating = MPAARatings.PG,
			Actors = "Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing, Alec Guinness, Anthony Daniels",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3078,
			Title = "Raiders of the Lost Ark",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Adventure"),
			Overview = "When Dr. Indiana Jones ??? the tweed-suited professor who just happens to be a celebrated archaeologist ??? is hired by the government to locate the legendary Ark of the Covenant, he finds himself up against the entire Nazi regime.",
			Year = new DateTime(1981,6,12),
			Revenue = 389925971,
			Tagline = "Indiana Jones - the new hero from the creators of JAWS and STAR WARS.",
			RunTime = 115,
			MPAARating = MPAARatings.PG,
			Actors = "Harrison Ford, Karen Allen, Paul Freeman, Ronald Lacey, John Rhys-Davies, Denholm Elliott",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3079,
			Title = "Close Encounters of the Third Kind",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Science Fiction"),
			Overview = "After an encounter with UFOs, a line worker feels undeniably drawn to an isolated area in the wilderness where something spectacular is about to happen.",
			Year = new DateTime(1977,11,16),
			Revenue = 303788635,
			Tagline = "We are not alone.",
			RunTime = 135,
			MPAARating = MPAARatings.PG,
			Actors = "Richard Dreyfuss, Francois Truffaut, Teri Garr, Melinda Dillon",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3080,
			Title = "Grease",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Musical"),
			Overview = "Australian good girl Sandy and greaser Danny fell in love over the summer. But when they unexpectedly discover they're now in the same high school, will they be able to rekindle their romance despite their eccentric friends?",
			Year = new DateTime(1978,7,7),
			Revenue = 181813770,
			Tagline = "Grease is the word",
			RunTime = 110,
			MPAARating = MPAARatings.PG13,
			Actors = "John Travolta",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3081,
			Title = "E.T. the Extra-Terrestrial",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "After a gentle alien becomes stranded on Earth, the being is discovered and befriended by a young boy named Elliott. Bringing the extraterrestrial into his suburban California house, Elliott introduces E.T., as the alien is dubbed, to his brother and his little sister, Gertie, and the children decide to keep its existence a secret. Soon, however, E.T. falls ill, resulting in government intervention and a dire situation for both Elliott and the alien.",
			Year = new DateTime(1982,4,3),
			Revenue = 792910554,
			Tagline = "He is afraid. He is alone. He is three million light years from home.",
			RunTime = 115,
			MPAARating = MPAARatings.PG,
			Actors = "Henry Thomas, Drew Barrymore, ",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3082,
			Title = "Fast Times at Ridgemont High",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "Follows a group of high school students growing up in southern California, based on the real-life adventures chronicled by Cameron Crowe. Stacy Hamilton and Mark Ratner are looking for a love interest, and are helped along by their older classmates, Linda Barrett and Mike Damone, respectively. The center of the film is held by Jeff Spicoli, a perpetually stoned surfer dude who faces off with the resolute Mr. Hand, who is convinced that everyone is on dope.",
			Year = new DateTime(1982,8,13),
			Revenue = 27092880,
			Tagline = "Fast Cars, Fast Girls, Fast Carrots...Fast Carrots?",
			RunTime = 90,
			MPAARating = MPAARatings.R,
			Actors = "Sean Penn, Jennifer Jason Leigh, Phoebe Cates, Brian Backer, Robert Romanus",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3083,
			Title = "Alien",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Horror"),
			Overview = "During its return to the earth, commercial spaceship Nostromo intercepts a distress signal from a distant planet. When a three-member team of the crew discovers a chamber containing thousands of eggs on the planet, a creature inside one of the eggs attacks an explorer. The entire crew is unaware of the impending nightmare set to descend upon them when the alien parasite planted inside its unfortunate host is birthed.",
			Year = new DateTime(1979,5,25),
			Revenue = 104931801,
			Tagline = "In space no one can hear you scream.",
			RunTime = 117,
			MPAARating = MPAARatings.R,
			Actors = "Tom Skerritt, Sigourney Weaver, Veronica Cartwright, Harry Dean Stanton, John Hurt, Ian Holm",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3084,
			Title = "The Muppet Movie",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "Kermit the Frog is persuaded by agent Dom DeLuise to pursue a career in Hollywood. Along the way, Kermit picks up Fozzie Bear, Miss Piggy, Gonzo, and a motley crew of other Muppets with similar aspirations. Meanwhile, Kermit must elude the grasp of a frog-leg restaurant magnate.",
			Year = new DateTime(1979,5,31),
			Revenue = 76657000,
			Tagline = "More entertaining than humanly possible.",
			RunTime = 97,
			MPAARating = MPAARatings.G,
			Actors = "Jim Henson, Frank Oz, Jerry Nelson, Richard Hunt, Dave Goelz, Charles Durning",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3085,
			Title = "Apocalypse Now",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "War"),
			Overview = "At the height of the Vietnam war, Captain Benjamin Willard is sent on a dangerous mission that, officially, 'does not exist, nor will it ever exist.' His goal is to locate - and eliminate - a mysterious Green Beret Colonel named Walter Kurtz, who has been leading his personal army on illegal guerrilla missions into enemy territory.",
			Year = new DateTime(1979,8,15),
			Revenue = 89460381,
			Tagline = "This is the end...",
			RunTime = 153,
			MPAARating = MPAARatings.R,
			Actors = "Martin Sheen, Marlon Brando, Robert Duvall",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3086,
			Title = "The Lego Movie",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "An ordinary Lego mini-figure, mistakenly thought to be the extraordinary MasterBuilder, is recruited to join a quest to stop an evil Lego tyrant from gluing the universe together.",
			Year = new DateTime(2014,2,6),
			Revenue = 469160692,
			Tagline = "The story of a nobody who saved everybody.",
			RunTime = 100,
			MPAARating = MPAARatings.PG,
			Actors = "Chris Pratt, Will Ferrell, Elizabeth Banks, Will Arnett, Nick Offerman, Alison Brie",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3087,
			Title = "The Shining",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Horror"),
			Overview = "Jack Torrance accepts a caretaker job at the Overlook Hotel, where he, along with his wife Wendy and their son Danny, must live isolated from the rest of the world for the winter. But they aren't prepared for the madness that lurks within.",
			Year = new DateTime(1980,5,22),
			Revenue = 44017374,
			Tagline = "A masterpiece of modern horror.",
			RunTime = 144,
			MPAARating = MPAARatings.R,
			Actors = "Jack Nicholson, Shelley Duvall, Danny Lloyd, Scatman Crothers, Barry Nelson, Philip Stone",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3088,
			Title = "Airplane!",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "Alcoholic pilot, Ted Striker has developed a fear of flying due to wartime trauma, but nevertheless boards a passenger jet in an attempt to woo back his stewardess girlfriend. Food poisoning decimates the passengers and crew, leaving it up to Striker to land the plane with the help of a glue-sniffing air traffic controller and Striker's vengeful former Air Force captain, who must both talk him down.",
			Year = new DateTime(1980,7,2),
			Revenue = 83453539,
			Tagline = "What's slower than a speeding bullet, and able to hit tall buildings at a single bound?",
			RunTime = 88,
			MPAARating = MPAARatings.PG,
			Actors = "Robert Hays, Julie Hagerty, Kareem Abdul-Jabbar, Lloyd Bridges, Peter Graves, Leslie Nielsen",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3089,
			Title = "Caddyshack",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "At an exclusive country club, an ambitious young caddy, Danny Noonan, eagerly pursues a caddy scholarship in hopes of attending college and, in turn, avoiding a job at the lumber yard. In order to succeed, he must first win the favour of the elitist Judge Smails, and then the caddy golf tournament which Smails sponsors.",
			Year = new DateTime(1980,7,25),
			Revenue = 39846344,
			Tagline = "The snobs against the slobs!",
			RunTime = 98,
			MPAARating = MPAARatings.R,
			Actors = "Chevy Chase, Rodney Dangerfield, Ted Knight, Michael O'Keefe, Bill Murray, Sarah Holcomb",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3090,
			Title = "Raging Bull",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Drama"),
			Overview = "When Jake LaMotta steps into a boxing ring and obliterates his opponent, he's a prizefighter. But when he treats his family and friends the same way, he's a ticking time bomb, ready to go off at any moment. Though LaMotta wants his family's love, something always seems to come between them. Perhaps it's his violent bouts of paranoia and jealousy. This kind of rage helped make him a champ, but in real life, he winds up in the ring alone.",
			Year = new DateTime(1980,11,14),
			Revenue = 23000000,
			Tagline = "",
			RunTime = 129,
			MPAARating = MPAARatings.R,
			Actors = "Robert De Niro, Joe Pesci, Cathy Moriarty, ",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3091,
			Title = "Halloween",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Horror"),
			Overview = "In John Carpenter's horror classic, a psychotic murderer, institutionalized since childhood for the murder of his sister, escapes and stalks a bookish teenage girl and her friends while his doctor chases him through the streets.",
			Year = new DateTime(1978,10,25),
			Revenue = 70000000,
			Tagline = "The Night He Came Home",
			RunTime = 91,
			MPAARating = MPAARatings.R,
			Actors = "Donald Pleasence, Jamie Lee Curtis",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3092,
			Title = "Robin Hood: Prince of Thieves",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Adventure"),
			Overview = "When the dastardly Sheriff of Nottingham murders Robin's father, the legendary archer vows vengeance. To accomplish his mission, Robin joins forces with a band of exiled villagers (and comely Maid Marian), and together they battle to end the evil sheriff's reign of terror.",
			Year = new DateTime(1991,6,14),
			Revenue = 390493908,
			Tagline = "For the good of all men, and the love of one woman, he fought to uphold justice by breaking the law.",
			RunTime = 143,
			MPAARating = MPAARatings.PG13,
			Actors = "Kevin Costner, Morgan Freeman, Alan Rickman, Geraldine McEwan",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3093,
			Title = "Trading Places",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "A snobbish investor and a wily street con-artist find their positions reversed as part of a bet by two callous millionaires.",
			Year = new DateTime(1983,6,7),
			Revenue = 90400000,
			Tagline = "Some very funny business.",
			RunTime = 116,
			MPAARating = MPAARatings.R,
			Actors = "Eddie Murphy, Dan Aykroyd, Jamie Lee Curtis, Jim Belushi",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3094,
			Title = "Return of the Jedi",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Adventure"),
			Overview = "As Rebel leaders map their strategy for an all-out attack on the Emperor's newer, bigger Death Star. Han Solo remains frozen in the cavernous desert fortress of Jabba the Hutt, the most loathsome outlaw in the universe, who is also keeping Princess Leia as a slave girl. Now a master of the Force, Luke Skywalker rescues his friends, but he cannot become a true Jedi Knight until he wages his own crucial battle against Darth Vader, who has sworn to win Luke over to the dark side of the Force.",
			Year = new DateTime(1983,5,23),
			Revenue = 572700000,
			Tagline = "The Empire Falls...",
			RunTime = 135,
			MPAARating = MPAARatings.PG,
			Actors = "Mark Hamill, Harrison Ford, Carrie Fisher, Billy Dee Williams, Anthony Daniels, David Prowse",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3095,
			Title = "WarGames",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Science Fiction"),
			Overview = "High School student David Lightman (Matthew Broderick) has a talent for hacking. But while trying to hack into a computer system to play unreleased video games, he unwittingly taps into the Defense Department's war computer and initiates a confrontation of global proportions! Together with his girlfriend (Ally Sheedy) and a wizardly computer genius (John Wood), David must race against time to outwit his opponent...and prevent a nuclear Armageddon.",
			Year = new DateTime(1983,6,3),
			Revenue = 79567667,
			Tagline = "Is it a game, or is it real?",
			RunTime = 114,
			MPAARating = MPAARatings.PG,
			Actors = "Matthew Broderick, Dabney Coleman, John Wood, Barry Corbin, Juanin Clay",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3096,
			Title = "A Christmas Story",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Family"),
			Overview = "The comic mishaps and adventures of a young boy named Ralph, trying to convince his parents, teachers, and Santa that a Red Ryder B.B. gun really is the perfect Christmas gift for the 1940s.",
			Year = new DateTime(1983,11,18),
			Revenue = 19294144,
			Tagline = "Peace, Harmony, Comfort and Joy... Maybe Next Year.",
			RunTime = 94,
			MPAARating = MPAARatings.PG,
			Actors = "Melinda Dillon,Jean Shepherd, Ian Petrella, Scott Schwartz",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3097,
			Title = "The Empire Strikes Back",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Adventure"),
			Overview = "The epic saga continues as Luke Skywalker, in hopes of defeating the evil Galactic Empire, learns the ways of the Jedi from aging master Yoda. But Darth Vader is more determined than ever to capture Luke. Meanwhile, rebel leader Princess Leia, cocky Han Solo, Chewbacca, and droids C-3PO and R2-D2 are thrown into various stages of capture, betrayal and despair.",
			Year = new DateTime(1980,5,17),
			Revenue = 538400000,
			Tagline = "The Adventure Continues...",
			RunTime = 124,
			MPAARating = MPAARatings.PG,
			Actors = "Mark Hamill, Harrison Ford, Carrie Fisher, ",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3098,
			Title = "Harry Potter and the Chamber of Secrets",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Fantasy"),
			Overview = "Ignoring threats to his life, Harry returns to Hogwarts to investigate ??? aided by Ron and Hermione ??? a mysterious series of attacks.",
			Year = new DateTime(2002,11,13),
			Revenue = 876688482,
			Tagline = "Hogwarts is back in session.",
			RunTime = 161,
			MPAARating = MPAARatings.PG,
			Actors = "Daniel Radcliffe, Rupert Grint, Emma Watson, Richard Harris, Alan Rickman, Tom Felton",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3099,
			Title = "Jurassic Park",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Science Fiction"),
			Overview = "A wealthy entrepreneur secretly creates a theme park featuring living dinosaurs drawn from prehistoric DNA. Before opening day, he invites a team of experts and his two eager grandchildren to experience the park and help calm anxious investors. However, the park is anything but amusing as the security systems go off-line and the dinosaurs escape.",
			Year = new DateTime(1993,6,11),
			Revenue = 920100000,
			Tagline = "An adventure 65 million years in the making.",
			RunTime = 127,
			MPAARating = MPAARatings.PG13,
			Actors = "Sam Neill, Laura Dern, Jeff Goldblum, Richard Attenborough, Bob Peck, Martin Ferrero",
		});
		AllMovies.Add(new Movie
		{
			MovieNumber = 3100,
			Title = "The Big Lebowski",
			Genre = db.Genres.FirstOrDefault(c => c.GenreName == "Comedy"),
			Overview = "Jeffrey 'The Dude' Lebowski, a Los Angeles slacker who only wants to bowl and drink white Russians, is mistaken for another Jeffrey Lebowski, a wheelchair-bound millionaire, and finds himself dragged into a strange series of events involving nihilists, adult film producers, ferrets, errant toes, and large sums of money.",
			Year = new DateTime(1998,3,6),
			Revenue = 46189568,
			Tagline = "Times like these call for a Big Lebowski.",
			RunTime = 117,
			MPAARating = MPAARatings.R,
			Actors = "Jeff Bridges, John Goodman, Julianne Moore, Steve Buscemi, Philip Seymour Hoffman, David Huddleston",
		});

		//create some counters to help debug problems
		Int32 intMovieID = 0;
		String strMovieTitle = "Start";

		//loop through the list to add or update the Movie Information
		try
		{
			foreach (Movie seedMovies in AllMovies)
			{
				//update the counters
				intMovieID = seedMovies.MovieNumber;
                    //db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Movies] ON");
					//see if the movie is already in the database using the IMDBID
					Movie dbSeedMovies = db.Movies.FirstOrDefault(f => f.MovieNumber == seedMovies.MovieNumber);

					//if Movie Information is null, MovieInformation is not in database
					if (dbSeedMovies == null)
					{
						//Add the MovieInformation to the database
						db.Movies.Add(seedMovies);
						db.SaveChanges();
					}
					else //the MovieInformation is in the database - reset all fields except ID and IMDBID
					{
						dbSeedMovies.Title = seedMovies.Title;
						dbSeedMovies.Genre = seedMovies.Genre;
						dbSeedMovies.Overview = seedMovies.Overview;
						dbSeedMovies.Year = seedMovies.Year;
						dbSeedMovies.Revenue = seedMovies.Revenue;
						dbSeedMovies.RunTime = seedMovies.RunTime;
						dbSeedMovies.Tagline = seedMovies.Tagline;
					}
				}
			}
			catch (Exception ex) //throw error if there is a problem in the database
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was a problem adding the MovieInformation with the ID: ");
				msg.Append(strMovieTitle);
				msg.Append(" (ID: ");
				msg.Append(intMovieID);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}
