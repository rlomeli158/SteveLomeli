using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;


namespace FinalProjectWorkspace.Seeding
{
	public static class SeedMovieSchedule
	{
		public static void SeedShowings(AppDbContext db)
		{
			List<Showing> Showings = new List<Showing>();

			Showing s1 = new Showing();
			{
				s1.Movie = db.Movies.FirstOrDefault(c => c.Title == "Footloose");
				s1.StartTime = new DateTime(2020, 12, 4, 9, 5, 0);
				s1.EndTime = s1.StartTime.AddMinutes(s1.Movie.RunTime);
				s1.Theatre = Theatre.Theatre1;
				s1.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s1);
			};
			Showing s2 = new Showing();
			{
				s2.Movie = db.Movies.FirstOrDefault(c => c.Title == "WarGames");
				s2.StartTime = new DateTime(2020, 12, 4, 11, 30, 0);
				s2.EndTime = s2.StartTime.AddMinutes(s2.Movie.RunTime);
				s2.Theatre = Theatre.Theatre1;
				s2.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s2);
			};
			Showing s3 = new Showing();
			{
				s3.Movie = db.Movies.FirstOrDefault(c => c.Title == "Office Space");
				s3.StartTime = new DateTime(2020, 12, 4, 14, 0, 0);
				s3.EndTime = s3.StartTime.AddMinutes(s3.Movie.RunTime);
				s3.Theatre = Theatre.Theatre1;
				s3.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s3);
			};
			Showing s4 = new Showing();
			{
				s4.Movie = db.Movies.FirstOrDefault(c => c.Title == "Diamonds are Forever");
				s4.StartTime = new DateTime(2020, 12, 4, 15, 55, 0);
				s4.EndTime = s4.StartTime.AddMinutes(s4.Movie.RunTime);
				s4.Theatre = Theatre.Theatre1;
				s4.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s4);
			};
			Showing s5 = new Showing();
			{
				s5.Movie = db.Movies.FirstOrDefault(c => c.Title == "West Side Story");
				s5.StartTime = new DateTime(2020, 12, 4, 18, 40, 0);
				s5.EndTime = s5.StartTime.AddMinutes(s5.Movie.RunTime);
				s5.Theatre = Theatre.Theatre1;
				s5.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s5);
			};
			Showing s6 = new Showing();
			{
				s6.Movie = db.Movies.FirstOrDefault(c => c.Title == "Forrest Gump");
				s6.StartTime = new DateTime(2020, 12, 4, 21, 37, 0);
				s6.EndTime = s6.StartTime.AddMinutes(s6.Movie.RunTime);
				s6.Theatre = Theatre.Theatre1;
				s6.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s6);
			};
			Showing s7 = new Showing();
			{
				s7.Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story");
				s7.StartTime = new DateTime(2020, 12, 4, 9, 0, 0);
				s7.EndTime = s7.StartTime.AddMinutes(s7.Movie.RunTime);
				s7.Theatre = Theatre.Theatre2;
				s7.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s7);
			};
			Showing s8 = new Showing();
			{
				s8.Movie = db.Movies.FirstOrDefault(c => c.Title == "Dazed and Confused");
				s8.StartTime = new DateTime(2020, 12, 4, 10, 50, 0);
				s8.EndTime = s8.StartTime.AddMinutes(s8.Movie.RunTime);
				s8.Theatre = Theatre.Theatre2;
				s8.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s8);
			};
			Showing s9 = new Showing();
			{
				s9.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Lego Movie");
				s9.StartTime = new DateTime(2020, 12, 4, 13, 0, 0);
				s9.EndTime = s9.StartTime.AddMinutes(s9.Movie.RunTime);
				s9.Theatre = Theatre.Theatre2;
				s9.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s9);
			};
			Showing s10 = new Showing();
			{
				s10.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Princess Bride");
				s10.StartTime = new DateTime(2020, 12, 4, 15, 20, 0);
				s10.EndTime = s10.StartTime.AddMinutes(s10.Movie.RunTime);
				s10.Theatre = Theatre.Theatre2;
				s10.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s10);
			};
			Showing s11 = new Showing();
			{
				s11.Movie = db.Movies.FirstOrDefault(c => c.Title == "Finding Nemo");
				s11.StartTime = new DateTime(2020, 12, 4, 17, 25, 0);
				s11.EndTime = s11.StartTime.AddMinutes(s11.Movie.RunTime);
				s11.Theatre = Theatre.Theatre2;
				s11.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s11);
			};
			Showing s12 = new Showing();
			{
				s12.Movie = db.Movies.FirstOrDefault(c => c.Title == "Harry Potter and the Chamber of Secrets");
				s12.StartTime = new DateTime(2020, 12, 4, 19, 30, 0);
				s12.EndTime = s12.StartTime.AddMinutes(s12.Movie.RunTime);
				s12.Theatre = Theatre.Theatre2;
				s12.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s12);
			};
			Showing s13 = new Showing();
			{
				s13.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Land Before Time");
				s13.StartTime = new DateTime(2020, 12, 4, 22, 40, 0);
				s13.EndTime = s13.StartTime.AddMinutes(s13.Movie.RunTime);
				s13.Theatre = Theatre.Theatre2;
				s13.ShowingDate = new DateTime(2020, 12, 4);
				Showings.Add(s13);
			};
			Showing s14 = new Showing();
			{
				s14.Movie = db.Movies.FirstOrDefault(c => c.Title == "Footloose");
				s14.StartTime = new DateTime(2020, 12, 5, 9, 5, 0);
				s14.EndTime = s14.StartTime.AddMinutes(s14.Movie.RunTime);
				s14.Theatre = Theatre.Theatre1;
				s14.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s14);
			};
			Showing s15 = new Showing();
			{
				s15.Movie = db.Movies.FirstOrDefault(c => c.Title == "WarGames");
				s15.StartTime = new DateTime(2020, 12, 5, 11, 30, 0);
				s15.EndTime = s15.StartTime.AddMinutes(s15.Movie.RunTime);
				s15.Theatre = Theatre.Theatre1;
				s15.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s15);
			};
			Showing s16 = new Showing();
			{
				s16.Movie = db.Movies.FirstOrDefault(c => c.Title == "Office Space");
				s16.StartTime = new DateTime(2020, 12, 5, 14, 0, 0);
				s16.EndTime = s16.StartTime.AddMinutes(s16.Movie.RunTime);
				s16.Theatre = Theatre.Theatre1;
				s16.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s16);
			};
			Showing s17 = new Showing();
			{
				s17.Movie = db.Movies.FirstOrDefault(c => c.Title == "Diamonds are Forever");
				s17.StartTime = new DateTime(2020, 12, 5, 15, 55, 0);
				s17.EndTime = s17.StartTime.AddMinutes(s17.Movie.RunTime);
				s17.Theatre = Theatre.Theatre1;
				s17.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s17);
			};
			Showing s18 = new Showing();
			{
				s18.Movie = db.Movies.FirstOrDefault(c => c.Title == "West Side Story");
				s18.StartTime = new DateTime(2020, 12, 5, 18, 40, 0);
				s18.EndTime = s18.StartTime.AddMinutes(s18.Movie.RunTime);
				s18.Theatre = Theatre.Theatre1;
				s18.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s18);
			};
			Showing s19 = new Showing();
			{
				s19.Movie = db.Movies.FirstOrDefault(c => c.Title == "Forrest Gump");
				s19.StartTime = new DateTime(2020, 12, 5, 21, 37, 0);
				s19.EndTime = s19.StartTime.AddMinutes(s19.Movie.RunTime);
				s19.Theatre = Theatre.Theatre1;
				s19.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s19);
			};
			Showing s20 = new Showing();
			{
				s20.Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story");
				s20.StartTime = new DateTime(2020, 12, 5, 9, 0, 0);
				s20.EndTime = s20.StartTime.AddMinutes(s20.Movie.RunTime);
				s20.Theatre = Theatre.Theatre2;
				s20.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s20);
			};
			Showing s21 = new Showing();
			{
				s21.Movie = db.Movies.FirstOrDefault(c => c.Title == "Dazed and Confused");
				s21.StartTime = new DateTime(2020, 12, 5, 10, 50, 0);
				s21.EndTime = s21.StartTime.AddMinutes(s21.Movie.RunTime);
				s21.Theatre = Theatre.Theatre2;
				s21.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s21);
			};
			Showing s22 = new Showing();
			{
				s22.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Lego Movie");
				s22.StartTime = new DateTime(2020, 12, 5, 13, 0, 0);
				s22.EndTime = s22.StartTime.AddMinutes(s22.Movie.RunTime);
				s22.Theatre = Theatre.Theatre2;
				s22.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s22);
			};
			Showing s23 = new Showing();
			{
				s23.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Princess Bride");
				s23.StartTime = new DateTime(2020, 12, 5, 15, 20, 0);
				s23.EndTime = s23.StartTime.AddMinutes(s23.Movie.RunTime);
				s23.Theatre = Theatre.Theatre2;
				s23.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s23);
			};
			Showing s24 = new Showing();
			{
				s24.Movie = db.Movies.FirstOrDefault(c => c.Title == "Finding Nemo");
				s24.StartTime = new DateTime(2020, 12, 5, 17, 25, 0);
				s24.EndTime = s24.StartTime.AddMinutes(s24.Movie.RunTime);
				s24.Theatre = Theatre.Theatre2;
				s24.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s24);
			};
			Showing s25 = new Showing();
			{
				s25.Movie = db.Movies.FirstOrDefault(c => c.Title == "Harry Potter and the Chamber of Secrets");
				s25.StartTime = new DateTime(2020, 12, 5, 19, 30, 0);
				s25.EndTime = s25.StartTime.AddMinutes(s25.Movie.RunTime);
				s25.Theatre = Theatre.Theatre2;
				s25.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s25);
			};
			Showing s26 = new Showing();
			{
				s26.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Land Before Time");
				s26.StartTime = new DateTime(2020, 12, 5, 22, 40, 0);
				s26.EndTime = s26.StartTime.AddMinutes(s26.Movie.RunTime);
				s26.Theatre = Theatre.Theatre2;
				s26.ShowingDate = new DateTime(2020, 12, 5);
				Showings.Add(s26);
			};
			Showing s27 = new Showing();
			{
				s27.Movie = db.Movies.FirstOrDefault(c => c.Title == "Footloose");
				s27.StartTime = new DateTime(2020, 12, 6, 9, 5, 0);
				s27.EndTime = s27.StartTime.AddMinutes(s27.Movie.RunTime);
				s27.Theatre = Theatre.Theatre1;
				s27.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s27);
			};
			Showing s28 = new Showing();
			{
				s28.Movie = db.Movies.FirstOrDefault(c => c.Title == "WarGames");
				s28.StartTime = new DateTime(2020, 12, 6, 11, 30, 0);
				s28.EndTime = s28.StartTime.AddMinutes(s28.Movie.RunTime);
				s28.Theatre = Theatre.Theatre1;
				s28.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s28);
			};
			Showing s29 = new Showing();
			{
				s29.Movie = db.Movies.FirstOrDefault(c => c.Title == "Office Space");
				s29.StartTime = new DateTime(2020, 12, 6, 14, 0, 0);
				s29.EndTime = s29.StartTime.AddMinutes(s29.Movie.RunTime);
				s29.Theatre = Theatre.Theatre1;
				s29.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s29);
			};
			Showing s30 = new Showing();
			{
				s30.Movie = db.Movies.FirstOrDefault(c => c.Title == "Diamonds are Forever");
				s30.StartTime = new DateTime(2020, 12, 6, 15, 55, 0);
				s30.EndTime = s30.StartTime.AddMinutes(s30.Movie.RunTime);
				s30.Theatre = Theatre.Theatre1;
				s30.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s30);
			};
			Showing s31 = new Showing();
			{
				s31.Movie = db.Movies.FirstOrDefault(c => c.Title == "West Side Story");
				s31.StartTime = new DateTime(2020, 12, 6, 18, 40, 0);
				s31.EndTime = s31.StartTime.AddMinutes(s31.Movie.RunTime);
				s31.Theatre = Theatre.Theatre1;
				s31.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s31);
			};
			Showing s32 = new Showing();
			{
				s32.Movie = db.Movies.FirstOrDefault(c => c.Title == "Forrest Gump");
				s32.StartTime = new DateTime(2020, 12, 6, 21, 37, 0);
				s32.EndTime = s32.StartTime.AddMinutes(s32.Movie.RunTime);
				s32.Theatre = Theatre.Theatre1;
				s32.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s32);
			};
			Showing s33 = new Showing();
			{
				s33.Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story");
				s33.StartTime = new DateTime(2020, 12, 6, 9, 0, 0);
				s33.EndTime = s33.StartTime.AddMinutes(s33.Movie.RunTime);
				s33.Theatre = Theatre.Theatre2;
				s33.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s33);
			};
			Showing s34 = new Showing();
			{
				s34.Movie = db.Movies.FirstOrDefault(c => c.Title == "Dazed and Confused");
				s34.StartTime = new DateTime(2020, 12, 6, 10, 50, 0);
				s34.EndTime = s34.StartTime.AddMinutes(s34.Movie.RunTime);
				s34.Theatre = Theatre.Theatre2;
				s34.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s34);
			};
			Showing s35 = new Showing();
			{
				s35.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Lego Movie");
				s35.StartTime = new DateTime(2020, 12, 6, 13, 0, 0);
				s35.EndTime = s35.StartTime.AddMinutes(s35.Movie.RunTime);
				s35.Theatre = Theatre.Theatre2;
				s35.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s35);
			};
			Showing s36 = new Showing();
			{
				s36.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Princess Bride");
				s36.StartTime = new DateTime(2020, 12, 6, 15, 20, 0);
				s36.EndTime = s36.StartTime.AddMinutes(s36.Movie.RunTime);
				s36.Theatre = Theatre.Theatre2;
				s36.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s36);
			};
			Showing s37 = new Showing();
			{
				s37.Movie = db.Movies.FirstOrDefault(c => c.Title == "Finding Nemo");
				s37.StartTime = new DateTime(2020, 12, 6, 17, 25, 0);
				s37.EndTime = s37.StartTime.AddMinutes(s37.Movie.RunTime);
				s37.Theatre = Theatre.Theatre2;
				s37.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s37);
			};
			Showing s38 = new Showing();
			{
				s38.Movie = db.Movies.FirstOrDefault(c => c.Title == "Harry Potter and the Chamber of Secrets");
				s38.StartTime = new DateTime(2020, 12, 6, 19, 30, 0);
				s38.EndTime = s38.StartTime.AddMinutes(s38.Movie.RunTime);
				s38.Theatre = Theatre.Theatre2;
				s38.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s38);
			};
			Showing s39 = new Showing();
			{
				s39.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Land Before Time");
				s39.StartTime = new DateTime(2020, 12, 6, 22, 40, 0);
				s39.EndTime = s39.StartTime.AddMinutes(s39.Movie.RunTime);
				s39.Theatre = Theatre.Theatre2;
				s39.ShowingDate = new DateTime(2020, 12, 6);
				Showings.Add(s39);
			};
			Showing s40 = new Showing();
			{
				s40.Movie = db.Movies.FirstOrDefault(c => c.Title == "Footloose");
				s40.StartTime = new DateTime(2020, 12, 7, 9, 5, 0);
				s40.EndTime = s40.StartTime.AddMinutes(s40.Movie.RunTime);
				s40.Theatre = Theatre.Theatre1;
				s40.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s40);
			};
			Showing s41 = new Showing();
			{
				s41.Movie = db.Movies.FirstOrDefault(c => c.Title == "WarGames");
				s41.StartTime = new DateTime(2020, 12, 7, 11, 30, 0);
				s41.EndTime = s41.StartTime.AddMinutes(s41.Movie.RunTime);
				s41.Theatre = Theatre.Theatre1;
				s41.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s41);
			};
			Showing s42 = new Showing();
			{
				s42.Movie = db.Movies.FirstOrDefault(c => c.Title == "Office Space");
				s42.StartTime = new DateTime(2020, 12, 7, 14, 0, 0);
				s42.EndTime = s42.StartTime.AddMinutes(s42.Movie.RunTime);
				s42.Theatre = Theatre.Theatre1;
				s42.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s42);
			};
			Showing s43 = new Showing();
			{
				s43.Movie = db.Movies.FirstOrDefault(c => c.Title == "Diamonds are Forever");
				s43.StartTime = new DateTime(2020, 12, 7, 15, 55, 0);
				s43.EndTime = s43.StartTime.AddMinutes(s43.Movie.RunTime);
				s43.Theatre = Theatre.Theatre1;
				s43.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s43);
			};
			Showing s44 = new Showing();
			{
				s44.Movie = db.Movies.FirstOrDefault(c => c.Title == "West Side Story");
				s44.StartTime = new DateTime(2020, 12, 7, 18, 40, 0);
				s44.EndTime = s44.StartTime.AddMinutes(s44.Movie.RunTime);
				s44.Theatre = Theatre.Theatre1;
				s44.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s44);
			};
			Showing s45 = new Showing();
			{
				s45.Movie = db.Movies.FirstOrDefault(c => c.Title == "Forrest Gump");
				s45.StartTime = new DateTime(2020, 12, 7, 21, 37, 0);
				s45.EndTime = s45.StartTime.AddMinutes(s45.Movie.RunTime);
				s45.Theatre = Theatre.Theatre1;
				s45.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s45);
			};
			Showing s46 = new Showing();
			{
				s46.Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story");
				s46.StartTime = new DateTime(2020, 12, 7, 9, 0, 0);
				s46.EndTime = s46.StartTime.AddMinutes(s46.Movie.RunTime);
				s46.Theatre = Theatre.Theatre2;
				s46.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s46);
			};
			Showing s47 = new Showing();
			{
				s47.Movie = db.Movies.FirstOrDefault(c => c.Title == "Dazed and Confused");
				s47.StartTime = new DateTime(2020, 12, 7, 10, 50, 0);
				s47.EndTime = s47.StartTime.AddMinutes(s47.Movie.RunTime);
				s47.Theatre = Theatre.Theatre2;
				s47.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s47);
			};
			Showing s48 = new Showing();
			{
				s48.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Lego Movie");
				s48.StartTime = new DateTime(2020, 12, 7, 13, 0, 0);
				s48.EndTime = s48.StartTime.AddMinutes(s48.Movie.RunTime);
				s48.Theatre = Theatre.Theatre2;
				s48.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s48);
			};
			Showing s49 = new Showing();
			{
				s49.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Princess Bride");
				s49.StartTime = new DateTime(2020, 12, 7, 15, 20, 0);
				s49.EndTime = s49.StartTime.AddMinutes(s49.Movie.RunTime);
				s49.Theatre = Theatre.Theatre2;
				s49.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s49);
			};
			Showing s50 = new Showing();
			{
				s50.Movie = db.Movies.FirstOrDefault(c => c.Title == "Finding Nemo");
				s50.StartTime = new DateTime(2020, 12, 7, 17, 25, 0);
				s50.EndTime = s50.StartTime.AddMinutes(s50.Movie.RunTime);
				s50.Theatre = Theatre.Theatre2;
				s50.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s50);
			};
			Showing s51 = new Showing();
			{
				s51.Movie = db.Movies.FirstOrDefault(c => c.Title == "Harry Potter and the Chamber of Secrets");
				s51.StartTime = new DateTime(2020, 12, 7, 19, 30, 0);
				s51.EndTime = s51.StartTime.AddMinutes(s51.Movie.RunTime);
				s51.Theatre = Theatre.Theatre2;
				s51.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s51);
			};
			Showing s52 = new Showing();
			{
				s52.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Land Before Time");
				s52.StartTime = new DateTime(2020, 12, 7, 22, 40, 0);
				s52.EndTime = s52.StartTime.AddMinutes(s52.Movie.RunTime);
				s52.Theatre = Theatre.Theatre2;
				s52.ShowingDate = new DateTime(2020, 12, 7);
				Showings.Add(s52);
			};
			Showing s53 = new Showing();
			{
				s53.Movie = db.Movies.FirstOrDefault(c => c.Title == "Footloose");
				s53.StartTime = new DateTime(2020, 12, 8, 9, 5, 0);
				s53.EndTime = s53.StartTime.AddMinutes(s53.Movie.RunTime);
				s53.Theatre = Theatre.Theatre1;
				s53.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s53);
			};
			Showing s54 = new Showing();
			{
				s54.Movie = db.Movies.FirstOrDefault(c => c.Title == "WarGames");
				s54.StartTime = new DateTime(2020, 12, 8, 11, 30, 0);
				s54.EndTime = s54.StartTime.AddMinutes(s54.Movie.RunTime);
				s54.Theatre = Theatre.Theatre1;
				s54.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s54);
			};
			Showing s55 = new Showing();
			{
				s55.Movie = db.Movies.FirstOrDefault(c => c.Title == "Office Space");
				s55.StartTime = new DateTime(2020, 12, 8, 14, 0, 0);
				s55.EndTime = s55.StartTime.AddMinutes(s55.Movie.RunTime);
				s55.Theatre = Theatre.Theatre1;
				s55.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s55);
			};
			Showing s56 = new Showing();
			{
				s56.Movie = db.Movies.FirstOrDefault(c => c.Title == "Diamonds are Forever");
				s56.StartTime = new DateTime(2020, 12, 8, 15, 55, 0);
				s56.EndTime = s56.StartTime.AddMinutes(s56.Movie.RunTime);
				s56.Theatre = Theatre.Theatre1;
				s56.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s56);
			};
			Showing s57 = new Showing();
			{
				s57.Movie = db.Movies.FirstOrDefault(c => c.Title == "West Side Story");
				s57.StartTime = new DateTime(2020, 12, 8, 18, 40, 0);
				s57.EndTime = s57.StartTime.AddMinutes(s57.Movie.RunTime);
				s57.Theatre = Theatre.Theatre1;
				s57.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s57);
			};
			Showing s58 = new Showing();
			{
				s58.Movie = db.Movies.FirstOrDefault(c => c.Title == "Forrest Gump");
				s58.StartTime = new DateTime(2020, 12, 8, 21, 37, 0);
				s58.EndTime = s58.StartTime.AddMinutes(s58.Movie.RunTime);
				s58.Theatre = Theatre.Theatre1;
				s58.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s58);
			};
			Showing s59 = new Showing();
			{
				s59.Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story");
				s59.StartTime = new DateTime(2020, 12, 8, 9, 0, 0);
				s59.EndTime = s59.StartTime.AddMinutes(s59.Movie.RunTime);
				s59.Theatre = Theatre.Theatre2;
				s59.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s59);
			};
			Showing s60 = new Showing();
			{
				s60.Movie = db.Movies.FirstOrDefault(c => c.Title == "Dazed and Confused");
				s60.StartTime = new DateTime(2020, 12, 8, 10, 50, 0);
				s60.EndTime = s60.StartTime.AddMinutes(s60.Movie.RunTime);
				s60.Theatre = Theatre.Theatre2;
				s60.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s60);
			};
			Showing s61 = new Showing();
			{
				s61.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Lego Movie");
				s61.StartTime = new DateTime(2020, 12, 8, 13, 0, 0);
				s61.EndTime = s61.StartTime.AddMinutes(s61.Movie.RunTime);
				s61.Theatre = Theatre.Theatre2;
				s61.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s61);
			};
			Showing s62 = new Showing();
			{
				s62.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Princess Bride");
				s62.StartTime = new DateTime(2020, 12, 8, 15, 20, 0);
				s62.EndTime = s62.StartTime.AddMinutes(s62.Movie.RunTime);
				s62.Theatre = Theatre.Theatre2;
				s62.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s62);
			};
			Showing s63 = new Showing();
			{
				s63.Movie = db.Movies.FirstOrDefault(c => c.Title == "Finding Nemo");
				s63.StartTime = new DateTime(2020, 12, 8, 17, 25, 0);
				s63.EndTime = s63.StartTime.AddMinutes(s63.Movie.RunTime);
				s63.Theatre = Theatre.Theatre2;
				s63.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s63);
			};
			Showing s64 = new Showing();
			{
				s64.Movie = db.Movies.FirstOrDefault(c => c.Title == "Harry Potter and the Chamber of Secrets");
				s64.StartTime = new DateTime(2020, 12, 8, 19, 30, 0);
				s64.EndTime = s64.StartTime.AddMinutes(s64.Movie.RunTime);
				s64.Theatre = Theatre.Theatre2;
				s64.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s64);
			};
			Showing s65 = new Showing();
			{
				s65.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Land Before Time");
				s65.StartTime = new DateTime(2020, 12, 8, 22, 40, 0);
				s65.EndTime = s65.StartTime.AddMinutes(s65.Movie.RunTime);
				s65.Theatre = Theatre.Theatre2;
				s65.ShowingDate = new DateTime(2020, 12, 8);
				Showings.Add(s65);
			};
			Showing s66 = new Showing();
			{
				s66.Movie = db.Movies.FirstOrDefault(c => c.Title == "Footloose");
				s66.StartTime = new DateTime(2020, 12, 9, 9, 5, 0);
				s66.EndTime = s66.StartTime.AddMinutes(s66.Movie.RunTime);
				s66.Theatre = Theatre.Theatre1;
				s66.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s66);
			};
			Showing s67 = new Showing();
			{
				s67.Movie = db.Movies.FirstOrDefault(c => c.Title == "WarGames");
				s67.StartTime = new DateTime(2020, 12, 9, 11, 30, 0);
				s67.EndTime = s67.StartTime.AddMinutes(s67.Movie.RunTime);
				s67.Theatre = Theatre.Theatre1;
				s67.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s67);
			};
			Showing s68 = new Showing();
			{
				s68.Movie = db.Movies.FirstOrDefault(c => c.Title == "Office Space");
				s68.StartTime = new DateTime(2020, 12, 9, 14, 0, 0);
				s68.EndTime = s68.StartTime.AddMinutes(s68.Movie.RunTime);
				s68.Theatre = Theatre.Theatre1;
				s68.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s68);
			};
			Showing s69 = new Showing();
			{
				s69.Movie = db.Movies.FirstOrDefault(c => c.Title == "Diamonds are Forever");
				s69.StartTime = new DateTime(2020, 12, 9, 15, 55, 0);
				s69.EndTime = s69.StartTime.AddMinutes(s69.Movie.RunTime);
				s69.Theatre = Theatre.Theatre1;
				s69.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s69);
			};
			Showing s70 = new Showing();
			{
				s70.Movie = db.Movies.FirstOrDefault(c => c.Title == "West Side Story");
				s70.StartTime = new DateTime(2020, 12, 9, 18, 40, 0);
				s70.EndTime = s70.StartTime.AddMinutes(s70.Movie.RunTime);
				s70.Theatre = Theatre.Theatre1;
				s70.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s70);
			};
			Showing s71 = new Showing();
			{
				s71.Movie = db.Movies.FirstOrDefault(c => c.Title == "Forrest Gump");
				s71.StartTime = new DateTime(2020, 12, 9, 21, 37, 0);
				s71.EndTime = s71.StartTime.AddMinutes(s71.Movie.RunTime);
				s71.Theatre = Theatre.Theatre1;
				s71.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s71);
			};
			Showing s72 = new Showing();
			{
				s72.Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story");
				s72.StartTime = new DateTime(2020, 12, 9, 9, 0, 0);
				s72.EndTime = s72.StartTime.AddMinutes(s72.Movie.RunTime);
				s72.Theatre = Theatre.Theatre2;
				s72.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s72);
			};
			Showing s73 = new Showing();
			{
				s73.Movie = db.Movies.FirstOrDefault(c => c.Title == "Dazed and Confused");
				s73.StartTime = new DateTime(2020, 12, 9, 10, 50, 0);
				s73.EndTime = s73.StartTime.AddMinutes(s73.Movie.RunTime);
				s73.Theatre = Theatre.Theatre2;
				s73.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s73);
			};
			Showing s74 = new Showing();
			{
				s74.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Lego Movie");
				s74.StartTime = new DateTime(2020, 12, 9, 13, 0, 0);
				s74.EndTime = s74.StartTime.AddMinutes(s74.Movie.RunTime);
				s74.Theatre = Theatre.Theatre2;
				s74.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s74);
			};
			Showing s75 = new Showing();
			{
				s75.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Princess Bride");
				s75.StartTime = new DateTime(2020, 12, 9, 15, 20, 0);
				s75.EndTime = s75.StartTime.AddMinutes(s75.Movie.RunTime);
				s75.Theatre = Theatre.Theatre2;
				s75.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s75);
			};
			Showing s76 = new Showing();
			{
				s76.Movie = db.Movies.FirstOrDefault(c => c.Title == "Finding Nemo");
				s76.StartTime = new DateTime(2020, 12, 9, 17, 25, 0);
				s76.EndTime = s76.StartTime.AddMinutes(s76.Movie.RunTime);
				s76.Theatre = Theatre.Theatre2;
				s76.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s76);
			};
			Showing s77 = new Showing();
			{
				s77.Movie = db.Movies.FirstOrDefault(c => c.Title == "Harry Potter and the Chamber of Secrets");
				s77.StartTime = new DateTime(2020, 12, 9, 19, 30, 0);
				s77.EndTime = s77.StartTime.AddMinutes(s77.Movie.RunTime);
				s77.Theatre = Theatre.Theatre2;
				s77.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s77);
			};
			Showing s78 = new Showing();
			{
				s78.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Land Before Time");
				s78.StartTime = new DateTime(2020, 12, 9, 22, 40, 0);
				s78.EndTime = s78.StartTime.AddMinutes(s78.Movie.RunTime);
				s78.Theatre = Theatre.Theatre2;
				s78.ShowingDate = new DateTime(2020, 12, 9);
				Showings.Add(s78);
			};
			Showing s79 = new Showing();
			{
				s79.Movie = db.Movies.FirstOrDefault(c => c.Title == "Footloose");
				s79.StartTime = new DateTime(2020, 12, 10, 9, 5, 0);
				s79.EndTime = s79.StartTime.AddMinutes(s79.Movie.RunTime);
				s79.Theatre = Theatre.Theatre1;
				s79.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s79);
			};
			Showing s80 = new Showing();
			{
				s80.Movie = db.Movies.FirstOrDefault(c => c.Title == "WarGames");
				s80.StartTime = new DateTime(2020, 12, 10, 11, 30, 0);
				s80.EndTime = s80.StartTime.AddMinutes(s80.Movie.RunTime);
				s80.Theatre = Theatre.Theatre1;
				s80.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s80);
			};
			Showing s81 = new Showing();
			{
				s81.Movie = db.Movies.FirstOrDefault(c => c.Title == "Office Space");
				s81.StartTime = new DateTime(2020, 12, 10, 14, 0, 0);
				s81.EndTime = s81.StartTime.AddMinutes(s81.Movie.RunTime);
				s81.Theatre = Theatre.Theatre1;
				s81.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s81);
			};
			Showing s82 = new Showing();
			{
				s82.Movie = db.Movies.FirstOrDefault(c => c.Title == "Diamonds are Forever");
				s82.StartTime = new DateTime(2020, 12, 10, 15, 55, 0);
				s82.EndTime = s82.StartTime.AddMinutes(s82.Movie.RunTime);
				s82.Theatre = Theatre.Theatre1;
				s82.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s82);
			};
			Showing s83 = new Showing();
			{
				s83.Movie = db.Movies.FirstOrDefault(c => c.Title == "West Side Story");
				s83.StartTime = new DateTime(2020, 12, 10, 18, 40, 0);
				s83.EndTime = s83.StartTime.AddMinutes(s83.Movie.RunTime);
				s83.Theatre = Theatre.Theatre1;
				s83.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s83);
			};
			Showing s84 = new Showing();
			{
				s84.Movie = db.Movies.FirstOrDefault(c => c.Title == "Forrest Gump");
				s84.StartTime = new DateTime(2020, 12, 10, 21, 37, 0);
				s84.EndTime = s84.StartTime.AddMinutes(s84.Movie.RunTime);
				s84.Theatre = Theatre.Theatre1;
				s84.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s84);
			};
			Showing s85 = new Showing();
			{
				s85.Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story");
				s85.StartTime = new DateTime(2020, 12, 10, 9, 0, 0);
				s85.EndTime = s85.StartTime.AddMinutes(s85.Movie.RunTime);
				s85.Theatre = Theatre.Theatre2;
				s85.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s85);
			};
			Showing s86 = new Showing();
			{
				s86.Movie = db.Movies.FirstOrDefault(c => c.Title == "Dazed and Confused");
				s86.StartTime = new DateTime(2020, 12, 10, 10, 50, 0);
				s86.EndTime = s86.StartTime.AddMinutes(s86.Movie.RunTime);
				s86.Theatre = Theatre.Theatre2;
				s86.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s86);
			};
			Showing s87 = new Showing();
			{
				s87.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Lego Movie");
				s87.StartTime = new DateTime(2020, 12, 10, 13, 0, 0);
				s87.EndTime = s87.StartTime.AddMinutes(s87.Movie.RunTime);
				s87.Theatre = Theatre.Theatre2;
				s87.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s87);
			};
			Showing s88 = new Showing();
			{
				s88.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Princess Bride");
				s88.StartTime = new DateTime(2020, 12, 10, 15, 20, 0);
				s88.EndTime = s88.StartTime.AddMinutes(s88.Movie.RunTime);
				s88.Theatre = Theatre.Theatre2;
				s88.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s88);
			};
			Showing s89 = new Showing();
			{
				s89.Movie = db.Movies.FirstOrDefault(c => c.Title == "Finding Nemo");
				s89.StartTime = new DateTime(2020, 12, 10, 17, 25, 0);
				s89.EndTime = s89.StartTime.AddMinutes(s89.Movie.RunTime);
				s89.Theatre = Theatre.Theatre2;
				s89.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s89);
			};
			Showing s90 = new Showing();
			{
				s90.Movie = db.Movies.FirstOrDefault(c => c.Title == "Harry Potter and the Chamber of Secrets");
				s90.StartTime = new DateTime(2020, 12, 10, 19, 30, 0);
				s90.EndTime = s90.StartTime.AddMinutes(s90.Movie.RunTime);
				s90.Theatre = Theatre.Theatre2;
				s90.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s90);
			};
			Showing s91 = new Showing();
			{
				s91.Movie = db.Movies.FirstOrDefault(c => c.Title == "The Land Before Time");
				s91.StartTime = new DateTime(2020, 12, 10, 22, 40, 0);
				s91.EndTime = s91.StartTime.AddMinutes(s91.Movie.RunTime);
				s91.Theatre = Theatre.Theatre2;
				s91.ShowingDate = new DateTime(2020, 12, 10);
				Showings.Add(s91);
			};


			//create some counters to help debug problems
			Int32 intMovieSchedule = 0;
			String strMovieSchedule = "Start";

			//loop through the list to add or update the Movie Schedule
			try
			{
				foreach (Showing seedShowing in Showings)
				{
					//update the counters
					intMovieSchedule = seedShowing.ShowingID;
					//see if the movie is already in the database using the IMDBID
					Showing dbMovieSchedule = db.Showings.FirstOrDefault(f => f.ShowingID == seedShowing.ShowingID);


					//if Movie Schedule is null, MovieSchedule is not in database
					if (dbMovieSchedule == null)
					{
						seedShowing.Status = "Published";
						seedShowing.SpecialEvent = false;
						//Add the MovieSchedule to the database
						db.Showings.Add(seedShowing);
						db.SaveChanges();
					}
					else //the MovieSchedule is in the database - reset all fields except ID and IMDBID
					{
						dbMovieSchedule.StartTime = seedShowing.StartTime;
						dbMovieSchedule.EndTime = seedShowing.EndTime;
						dbMovieSchedule.Movie = seedShowing.Movie;
						dbMovieSchedule.Theatre = seedShowing.Theatre;
						dbMovieSchedule.ShowingDate = seedShowing.ShowingDate;
						dbMovieSchedule.Status = "Published";
					}
				}
			}
			catch (Exception ex) //throw error if there is a problem in the database
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was a problem adding the MovieSchedule with the Movie: ");
				msg.Append(strMovieSchedule);
				msg.Append(" (ID: ");
				msg.Append(intMovieSchedule);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}
