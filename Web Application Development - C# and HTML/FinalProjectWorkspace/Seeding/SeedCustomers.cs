using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;

// THIS SEEDS THE ROLES & ADDS THE FIRST MANAGEER!

namespace FinalProjectWorkspace.Seeding
{
	public static class SeedCustomer
	{
		public static async Task SeedCustomers(IServiceProvider serviceProvider)
		//public static void SeedCustomers(AppDbContext db)
		{
			AppDbContext db = serviceProvider.GetRequiredService<AppDbContext>();
			UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
			RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
			//Get instances of the services needed to add a user & add a user to a role

			AppUser newCustUser2 = db.Users.FirstOrDefault(u => u.Email == "cbaker@puppy.com");

			if (newCustUser2 == null)
			{
				newCustUser2 = new AppUser();
				newCustUser2.UserName = "cbaker@puppy.com";
				newCustUser2.Email = "cbaker@puppy.com";
				newCustUser2.Id = "5001";
				newCustUser2.FirstName = "Christopher";
				newCustUser2.LastName = "Baker";
				newCustUser2.MiddleInitial = "L";
				newCustUser2.Birthday = new DateTime(1949, 11, 23);
				newCustUser2.Address = "1245 Lake Anchorage Blvd.";
				newCustUser2.City = "Austin";
				newCustUser2.State = "TX";
				newCustUser2.Zip = "37705";
				newCustUser2.PhoneNumber = "5125551132";
				newCustUser2.PCPBalance = 90;

				var result = await _userManager.CreateAsync(newCustUser2, "hello1");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser2 = db.Users.FirstOrDefault(u => u.UserName == "cbaker@puppy.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser2, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser2, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser3 = db.Users.FirstOrDefault(u => u.Email == "banker@longhorn.net");

			if (newCustUser3 == null)
			{
				newCustUser3 = new AppUser();
				newCustUser3.UserName = "banker@longhorn.net";
				newCustUser3.Email = "banker@longhorn.net";
				newCustUser3.Id = "5002";
				newCustUser3.FirstName = "Martin";
				newCustUser3.LastName = "Banks";
				newCustUser3.MiddleInitial = "T";
				newCustUser3.Birthday = new DateTime(1962, 11, 27);
				newCustUser3.Address = "6700 Small Pine Lane";
				newCustUser3.City = "Austin";
				newCustUser3.State = "TX";
				newCustUser3.Zip = "37712";
				newCustUser3.PhoneNumber = "5125552243";
				newCustUser3.PCPBalance = 80;

				var result = await _userManager.CreateAsync(newCustUser3, "snowing");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser3 = db.Users.FirstOrDefault(u => u.UserName == "banker@longhorn.net");
			}
			if (await _userManager.IsInRoleAsync(newCustUser3, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser3, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser4 = db.Users.FirstOrDefault(u => u.Email == "franco@puppy.com");

			if (newCustUser4 == null)
			{
				newCustUser4 = new AppUser();
				newCustUser4.UserName = "franco@puppy.com";
				newCustUser4.Email = "franco@puppy.com";
				newCustUser4.Id = "5003";
				newCustUser4.FirstName = "Franco";
				newCustUser4.LastName = "Broccolo";
				newCustUser4.MiddleInitial = "V";
				newCustUser4.Birthday = new DateTime(1992, 10, 11);
				newCustUser4.Address = "562 Sad Road";
				newCustUser4.City = "Austin";
				newCustUser4.State = "TX";
				newCustUser4.Zip = "37704";
				newCustUser4.PhoneNumber = "5125555546";
				newCustUser4.PCPBalance = 10;

				var result = await _userManager.CreateAsync(newCustUser4, "skating");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser4 = db.Users.FirstOrDefault(u => u.UserName == "franco@puppy.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser4, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser4, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser5 = db.Users.FirstOrDefault(u => u.Email == "wchang@puppy.com");

			if (newCustUser5 == null)
			{
				newCustUser5 = new AppUser();
				newCustUser5.UserName = "wchang@puppy.com";
				newCustUser5.Email = "wchang@puppy.com";
				newCustUser5.Id = "5004";
				newCustUser5.FirstName = "Wiseman";
				newCustUser5.LastName = "Chang";
				newCustUser5.MiddleInitial = "L";
				newCustUser5.Birthday = new DateTime(1997, 5, 16);
				newCustUser5.Address = "7202 Big Hall";
				newCustUser5.City = "Round Rock";
				newCustUser5.State = "TX";
				newCustUser5.Zip = "37681";
				newCustUser5.PhoneNumber = "5125553376";
				newCustUser5.PCPBalance = 20;

				var result = await _userManager.CreateAsync(newCustUser5, "Fighter");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser5 = db.Users.FirstOrDefault(u => u.UserName == "wchang@puppy.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser5, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser5, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser6 = db.Users.FirstOrDefault(u => u.Email == "limchou@gogle.com");

			if (newCustUser6 == null)
			{
				newCustUser6 = new AppUser();
				newCustUser6.UserName = "limchou@gogle.com";
				newCustUser6.Email = "limchou@gogle.com";
				newCustUser6.Id = "5005";
				newCustUser6.FirstName = "Lim";
				newCustUser6.LastName = "Chou";
				newCustUser6.MiddleInitial = "C";
				newCustUser6.Birthday = new DateTime(1970, 4, 6);
				newCustUser6.Address = "8600 Cherry Lane";
				newCustUser6.City = "Austin";
				newCustUser6.State = "TX";
				newCustUser6.Zip = "37705";
				newCustUser6.PhoneNumber = "5125555379";
				newCustUser6.PCPBalance = 70;

				var result = await _userManager.CreateAsync(newCustUser6, "Dallas63");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser6 = db.Users.FirstOrDefault(u => u.UserName == "limchou@gogle.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser6, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser6, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser7 = db.Users.FirstOrDefault(u => u.Email == "shdixon@aoll.com");

			if (newCustUser7 == null)
			{
				newCustUser7 = new AppUser();
				newCustUser7.UserName = "shdixon@aoll.com";
				newCustUser7.Email = "shdixon@aoll.com";
				newCustUser7.Id = "5006";
				newCustUser7.FirstName = "Shaman";
				newCustUser7.LastName = "Dixon";
				newCustUser7.MiddleInitial = "D";
				newCustUser7.Birthday = new DateTime(1984, 1, 12);
				newCustUser7.Address = "8234 Puppy Circle";
				newCustUser7.City = "Austin";
				newCustUser7.State = "TX";
				newCustUser7.Zip = "37712";
				newCustUser7.PhoneNumber = "5125556607";
				newCustUser7.PCPBalance = 10;

				var result = await _userManager.CreateAsync(newCustUser7, "peppero");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser7 = db.Users.FirstOrDefault(u => u.UserName == "shdixon@aoll.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser7, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser7, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser8 = db.Users.FirstOrDefault(u => u.Email == "j.b.evans@aheca.org");

			if (newCustUser8 == null)
			{
				newCustUser8 = new AppUser();
				newCustUser8.UserName = "j.b.evans@aheca.org";
				newCustUser8.Email = "j.b.evans@aheca.org";
				newCustUser8.Id = "5007";
				newCustUser8.FirstName = "Jim Bob";
				newCustUser8.LastName = "Evans";
				newCustUser8.MiddleInitial = "C";
				newCustUser8.Birthday = new DateTime(1959, 9, 9);
				newCustUser8.Address = "9506 Kitten Circle";
				newCustUser8.City = "Georgetown";
				newCustUser8.State = "TX";
				newCustUser8.Zip = "37628";
				newCustUser8.PhoneNumber = "5125552289";
				newCustUser8.PCPBalance = 0;

				var result = await _userManager.CreateAsync(newCustUser8, "longhorn");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser8 = db.Users.FirstOrDefault(u => u.UserName == "j.b.evans@aheca.org");
			}
			if (await _userManager.IsInRoleAsync(newCustUser8, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser8, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser9 = db.Users.FirstOrDefault(u => u.Email == "feeley@penguin.org");

			if (newCustUser9 == null)
			{
				newCustUser9 = new AppUser();
				newCustUser9.UserName = "feeley@penguin.org";
				newCustUser9.Email = "feeley@penguin.org";
				newCustUser9.Id = "5008";
				newCustUser9.FirstName = "Lou Ann";
				newCustUser9.LastName = "Feeley";
				newCustUser9.MiddleInitial = "K";
				newCustUser9.Birthday = new DateTime(2001, 1, 12);
				newCustUser9.Address = "7600 N 7th Street W";
				newCustUser9.City = "Austin";
				newCustUser9.State = "TX";
				newCustUser9.Zip = "37746";
				newCustUser9.PhoneNumber = "5125559999";
				newCustUser9.PCPBalance = 200;

				var result = await _userManager.CreateAsync(newCustUser9, "aggiesuck");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser9 = db.Users.FirstOrDefault(u => u.UserName == "feeley@penguin.org");
			}
			if (await _userManager.IsInRoleAsync(newCustUser9, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser9, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser10 = db.Users.FirstOrDefault(u => u.Email == "tfreeley@minnetonka.ci.us");

			if (newCustUser10 == null)
			{
				newCustUser10 = new AppUser();
				newCustUser10.UserName = "tfreeley@minnetonka.ci.us";
				newCustUser10.Email = "tfreeley@minnetonka.ci.us";
				newCustUser10.Id = "5009";
				newCustUser10.FirstName = "Teresa";
				newCustUser10.LastName = "Freeley";
				newCustUser10.MiddleInitial = "P";
				newCustUser10.Birthday = new DateTime(1991, 2, 4);
				newCustUser10.Address = "5448 Clearview Ave.";
				newCustUser10.City = "Horseshoe Bay";
				newCustUser10.State = "TX";
				newCustUser10.Zip = "37657";
				newCustUser10.PhoneNumber = "5125558827";
				newCustUser10.PCPBalance = 250;

				var result = await _userManager.CreateAsync(newCustUser10, "raiders75");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser10 = db.Users.FirstOrDefault(u => u.UserName == "tfreeley@minnetonka.ci.us");
			}
			if (await _userManager.IsInRoleAsync(newCustUser10, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser10, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser11 = db.Users.FirstOrDefault(u => u.Email == "mgarcia@gogle.com");

			if (newCustUser11 == null)
			{
				newCustUser11 = new AppUser();
				newCustUser11.UserName = "mgarcia@gogle.com";
				newCustUser11.Email = "mgarcia@gogle.com";
				newCustUser11.Id = "5010";
				newCustUser11.FirstName = "Mikaela";
				newCustUser11.LastName = "Garcia";
				newCustUser11.MiddleInitial = "L";
				newCustUser11.Birthday = new DateTime(1991, 10, 2);
				newCustUser11.Address = "3594 Cowview";
				newCustUser11.City = "Austin";
				newCustUser11.State = "TX";
				newCustUser11.Zip = "37727";
				newCustUser11.PhoneNumber = "5125550002";
				newCustUser11.PCPBalance = 40;

				var result = await _userManager.CreateAsync(newCustUser11, "mustang54");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser11 = db.Users.FirstOrDefault(u => u.UserName == "mgarcia@gogle.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser11, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser11, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser12 = db.Users.FirstOrDefault(u => u.Email == "chaley@mug.com");

			if (newCustUser12 == null)
			{
				newCustUser12 = new AppUser();
				newCustUser12.UserName = "chaley@mug.com";
				newCustUser12.Email = "chaley@mug.com";
				newCustUser12.Id = "5011";
				newCustUser12.FirstName = "Charmander";
				newCustUser12.LastName = "Haley";
				newCustUser12.MiddleInitial = "E";
				newCustUser12.Birthday = new DateTime(1974, 7, 10);
				newCustUser12.Address = "43 One Pigboy Pkwy";
				newCustUser12.City = "Austin";
				newCustUser12.State = "TX";
				newCustUser12.Zip = "37712";
				newCustUser12.PhoneNumber = "5125550198";
				newCustUser12.PCPBalance = 30;

				var result = await _userManager.CreateAsync(newCustUser12, "onetime76");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser12 = db.Users.FirstOrDefault(u => u.UserName == "chaley@mug.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser12, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser12, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser13 = db.Users.FirstOrDefault(u => u.Email == "jeffh@mario.com");

			if (newCustUser13 == null)
			{
				newCustUser13 = new AppUser();
				newCustUser13.UserName = "jeffh@mario.com";
				newCustUser13.Email = "jeffh@mario.com";
				newCustUser13.Id = "5012";
				newCustUser13.FirstName = "Jeff";
				newCustUser13.LastName = "Hampton";
				newCustUser13.MiddleInitial = "T";
				newCustUser13.Birthday = new DateTime(2004, 3, 10);
				newCustUser13.Address = "7337 67th St.";
				newCustUser13.City = "San Marcos";
				newCustUser13.State = "TX";
				newCustUser13.Zip = "37666";
				newCustUser13.PhoneNumber = "5125552134";
				newCustUser13.PCPBalance = 50;

				var result = await _userManager.CreateAsync(newCustUser13, "hampton98");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser13 = db.Users.FirstOrDefault(u => u.UserName == "jeffh@mario.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser13, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser13, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser14 = db.Users.FirstOrDefault(u => u.Email == "wjhearniii@umich.org");

			if (newCustUser14 == null)
			{
				newCustUser14 = new AppUser();
				newCustUser14.UserName = "wjhearniii@umich.org";
				newCustUser14.Email = "wjhearniii@umich.org";
				newCustUser14.Id = "5013";
				newCustUser14.FirstName = "John";
				newCustUser14.LastName = "Hearn";
				newCustUser14.MiddleInitial = "B";
				newCustUser14.Birthday = new DateTime(1950, 8, 5);
				newCustUser14.Address = "8225 South First";
				newCustUser14.City = "Plano";
				newCustUser14.State = "TX";
				newCustUser14.Zip = "37705";
				newCustUser14.PhoneNumber = "5125559729";
				newCustUser14.PCPBalance = 60;

				var result = await _userManager.CreateAsync(newCustUser14, "jhearn99");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser14 = db.Users.FirstOrDefault(u => u.UserName == "wjhearniii@umich.org");
			}
			if (await _userManager.IsInRoleAsync(newCustUser14, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser14, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser15 = db.Users.FirstOrDefault(u => u.Email == "ahick@yaho.com");

			if (newCustUser15 == null)
			{
				newCustUser15 = new AppUser();
				newCustUser15.UserName = "ahick@yaho.com";
				newCustUser15.Email = "ahick@yaho.com";
				newCustUser15.Id = "5014";
				newCustUser15.FirstName = "Abadon";
				newCustUser15.LastName = "Hicks";
				newCustUser15.MiddleInitial = "J";
				newCustUser15.Birthday = new DateTime(2004, 12, 8);
				newCustUser15.Address = "632 NE Dog Ln., Ste 910";
				newCustUser15.City = "Austin";
				newCustUser15.State = "TX";
				newCustUser15.Zip = "37712";
				newCustUser15.PhoneNumber = "5125553967";
				newCustUser15.PCPBalance = 60;

				var result = await _userManager.CreateAsync(newCustUser15, "hickemon");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser15 = db.Users.FirstOrDefault(u => u.UserName == "ahick@yaho.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser15, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser15, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser16 = db.Users.FirstOrDefault(u => u.Email == "ingram@jack.com");

			if (newCustUser16 == null)
			{
				newCustUser16 = new AppUser();
				newCustUser16.UserName = "ingram@jack.com";
				newCustUser16.Email = "ingram@jack.com";
				newCustUser16.Id = "5015";
				newCustUser16.FirstName = "Brock";
				newCustUser16.LastName = "Ingram";
				newCustUser16.MiddleInitial = "S";
				newCustUser16.Birthday = new DateTime(2001, 9, 5);
				newCustUser16.Address = "9548 El Perro Ct.";
				newCustUser16.City = "New York";
				newCustUser16.State = "NY";
				newCustUser16.Zip = "10101";
				newCustUser16.PhoneNumber = "5125552142";
				newCustUser16.PCPBalance = 90;

				var result = await _userManager.CreateAsync(newCustUser16, "ingram2098");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser16 = db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser16, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser16, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser17 = db.Users.FirstOrDefault(u => u.Email == "toddj@yourmom.com");

			if (newCustUser17 == null)
			{
				newCustUser17 = new AppUser();
				newCustUser17.UserName = "toddj@yourmom.com";
				newCustUser17.Email = "toddj@yourmom.com";
				newCustUser17.Id = "5016";
				newCustUser17.FirstName = "Todd";
				newCustUser17.LastName = "Jack";
				newCustUser17.MiddleInitial = "L";
				newCustUser17.Birthday = new DateTime(1999, 1, 20);
				newCustUser17.Address = "2564 Tree St.";
				newCustUser17.City = "Austin";
				newCustUser17.State = "TX";
				newCustUser17.Zip = "37729";
				newCustUser17.PhoneNumber = "5125555557";
				newCustUser17.PCPBalance = 140;

				var result = await _userManager.CreateAsync(newCustUser17, "toddy53");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser17 = db.Users.FirstOrDefault(u => u.UserName == "toddj@yourmom.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser17, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser17, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser18 = db.Users.FirstOrDefault(u => u.Email == "thequeen@aska.net");

			if (newCustUser18 == null)
			{
				newCustUser18 = new AppUser();
				newCustUser18.UserName = "thequeen@aska.net";
				newCustUser18.Email = "thequeen@aska.net";
				newCustUser18.Id = "5017";
				newCustUser18.FirstName = "Vic";
				newCustUser18.LastName = "Lancer";
				newCustUser18.MiddleInitial = "M";
				newCustUser18.Birthday = new DateTime(2000, 4, 14);
				newCustUser18.Address = "1639 Butter Ln.";
				newCustUser18.City = "Beverly Hills";
				newCustUser18.State = "CA";
				newCustUser18.Zip = "90210";
				newCustUser18.PhoneNumber = "5125550156";
				newCustUser18.PCPBalance = 110;

				var result = await _userManager.CreateAsync(newCustUser18, "nothing34");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser18 = db.Users.FirstOrDefault(u => u.UserName == "thequeen@aska.net");
			}
			if (await _userManager.IsInRoleAsync(newCustUser18, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser18, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser19 = db.Users.FirstOrDefault(u => u.Email == "linebacker@gogle.com");

			if (newCustUser19 == null)
			{
				newCustUser19 = new AppUser();
				newCustUser19.UserName = "linebacker@gogle.com";
				newCustUser19.Email = "linebacker@gogle.com";
				newCustUser19.Id = "5018";
				newCustUser19.FirstName = "Sweeney";
				newCustUser19.LastName = "Lineback";
				newCustUser19.MiddleInitial = "W";
				newCustUser19.Birthday = new DateTime(2003, 12, 2);
				newCustUser19.Address = "1700 Land St";
				newCustUser19.City = "Austin";
				newCustUser19.State = "TX";
				newCustUser19.Zip = "37758";
				newCustUser19.PhoneNumber = "5125550168";
				newCustUser19.PCPBalance = 50;

				var result = await _userManager.CreateAsync(newCustUser19, "Password5");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser19 = db.Users.FirstOrDefault(u => u.UserName == "linebacker@gogle.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser19, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser19, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser20 = db.Users.FirstOrDefault(u => u.Email == "elowe@scare.net");

			if (newCustUser20 == null)
			{
				newCustUser20 = new AppUser();
				newCustUser20.UserName = "elowe@scare.net";
				newCustUser20.Email = "elowe@scare.net";
				newCustUser20.Id = "5019";
				newCustUser20.FirstName = "Ernesto";
				newCustUser20.LastName = "Lowe";
				newCustUser20.MiddleInitial = "S";
				newCustUser20.Birthday = new DateTime(1977, 12, 7);
				newCustUser20.Address = "2301 Snail Drive";
				newCustUser20.City = "New Braunfels";
				newCustUser20.State = "TX";
				newCustUser20.Zip = "37130";
				newCustUser20.PhoneNumber = "5125556959";
				newCustUser20.PCPBalance = 40;

				var result = await _userManager.CreateAsync(newCustUser20, "aclfest2076");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser20 = db.Users.FirstOrDefault(u => u.UserName == "elowe@scare.net");
			}
			if (await _userManager.IsInRoleAsync(newCustUser20, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser20, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser21 = db.Users.FirstOrDefault(u => u.Email == "cluce@gogle.com");

			if (newCustUser21 == null)
			{
				newCustUser21 = new AppUser();
				newCustUser21.UserName = "cluce@gogle.com";
				newCustUser21.Email = "cluce@gogle.com";
				newCustUser21.Id = "5020";
				newCustUser21.FirstName = "Charles";
				newCustUser21.LastName = "Luce";
				newCustUser21.MiddleInitial = "B";
				newCustUser21.Birthday = new DateTime(1949, 3, 16);
				newCustUser21.Address = "7945 Small Clouds";
				newCustUser21.City = "Cactus";
				newCustUser21.State = "TX";
				newCustUser21.Zip = "79013";
				newCustUser21.PhoneNumber = "5125556919";
				newCustUser21.PCPBalance = 160;

				var result = await _userManager.CreateAsync(newCustUser21, "nothinggreat");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser21 = db.Users.FirstOrDefault(u => u.UserName == "cluce@gogle.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser21, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser21, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser22 = db.Users.FirstOrDefault(u => u.Email == "mackcloud@george.com");

			if (newCustUser22 == null)
			{
				newCustUser22 = new AppUser();
				newCustUser22.UserName = "mackcloud@george.com";
				newCustUser22.Email = "mackcloud@george.com";
				newCustUser22.Id = "5021";
				newCustUser22.FirstName = "Jackson";
				newCustUser22.LastName = "MacLeod";
				newCustUser22.MiddleInitial = "D";
				newCustUser22.Birthday = new DateTime(1947, 2, 21);
				newCustUser22.Address = "2804 Near West Blvd.";
				newCustUser22.City = "Plano";
				newCustUser22.State = "TX";
				newCustUser22.Zip = "37654";
				newCustUser22.PhoneNumber = "5125553223";
				newCustUser22.PCPBalance = 130;

				var result = await _userManager.CreateAsync(newCustUser22, "However");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser22 = db.Users.FirstOrDefault(u => u.UserName == "mackcloud@george.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser22, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser22, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser23 = db.Users.FirstOrDefault(u => u.Email == "cmartin@beets.com");

			if (newCustUser23 == null)
			{
				newCustUser23 = new AppUser();
				newCustUser23.UserName = "cmartin@beets.com";
				newCustUser23.Email = "cmartin@beets.com";
				newCustUser23.Id = "5022";
				newCustUser23.FirstName = "Candice";
				newCustUser23.LastName = "Markham";
				newCustUser23.MiddleInitial = "P";
				newCustUser23.Birthday = new DateTime(1972, 3, 20);
				newCustUser23.Address = "9761 Bike Chase";
				newCustUser23.City = "Kissimmee";
				newCustUser23.State = "FL";
				newCustUser23.Zip = "34741";
				newCustUser23.PhoneNumber = "5125554445";
				newCustUser23.PCPBalance = 200;

				var result = await _userManager.CreateAsync(newCustUser23, "nobodycares");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser23 = db.Users.FirstOrDefault(u => u.UserName == "cmartin@beets.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser23, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser23, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser24 = db.Users.FirstOrDefault(u => u.Email == "clarence@yoho.com");

			if (newCustUser24 == null)
			{
				newCustUser24 = new AppUser();
				newCustUser24.UserName = "clarence@yoho.com";
				newCustUser24.Email = "clarence@yoho.com";
				newCustUser24.Id = "5023";
				newCustUser24.FirstName = "Clarence";
				newCustUser24.LastName = "Martin";
				newCustUser24.MiddleInitial = "A";
				newCustUser24.Birthday = new DateTime(1992, 7, 19);
				newCustUser24.Address = "387 Alcedo St.";
				newCustUser24.City = "Austin";
				newCustUser24.State = "TX";
				newCustUser24.Zip = "37709";
				newCustUser24.PhoneNumber = "5125554447";
				newCustUser24.PCPBalance = 230;

				var result = await _userManager.CreateAsync(newCustUser24, "eggsellent");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser24 = db.Users.FirstOrDefault(u => u.UserName == "clarence@yoho.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser24, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser24, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser25 = db.Users.FirstOrDefault(u => u.Email == "gregmartinez@drdre.com");

			if (newCustUser25 == null)
			{
				newCustUser25 = new AppUser();
				newCustUser25.UserName = "gregmartinez@drdre.com";
				newCustUser25.Email = "gregmartinez@drdre.com";
				newCustUser25.Id = "5024";
				newCustUser25.FirstName = "Greg";
				newCustUser25.LastName = "Martinez";
				newCustUser25.MiddleInitial = "R";
				newCustUser25.Birthday = new DateTime(1947, 5, 28);
				newCustUser25.Address = "2495 Sunrise Blvd.";
				newCustUser25.City = "Red Rock";
				newCustUser25.State = "TX";
				newCustUser25.Zip = "37662";
				newCustUser25.PhoneNumber = "5125556666";
				newCustUser25.PCPBalance = 70;

				var result = await _userManager.CreateAsync(newCustUser25, "rainrain");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser25 = db.Users.FirstOrDefault(u => u.UserName == "gregmartinez@drdre.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser25, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser25, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser26 = db.Users.FirstOrDefault(u => u.Email == "cmiller@bob.com");

			if (newCustUser26 == null)
			{
				newCustUser26 = new AppUser();
				newCustUser26.UserName = "cmiller@bob.com";
				newCustUser26.Email = "cmiller@bob.com";
				newCustUser26.Id = "5025";
				newCustUser26.FirstName = "Charles";
				newCustUser26.LastName = "Miller";
				newCustUser26.MiddleInitial = "R";
				newCustUser26.Birthday = new DateTime(1990, 10, 15);
				newCustUser26.Address = "897762 Main St.";
				newCustUser26.City = "South Padre Island";
				newCustUser26.State = "TX";
				newCustUser26.Zip = "37597";
				newCustUser26.PhoneNumber = "5125555923";
				newCustUser26.PCPBalance = 0;

				var result = await _userManager.CreateAsync(newCustUser26, "mypuppyspot");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser26 = db.Users.FirstOrDefault(u => u.UserName == "cmiller@bob.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser26, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser26, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser27 = db.Users.FirstOrDefault(u => u.Email == "knelson@aoll.com");

			if (newCustUser27 == null)
			{
				newCustUser27 = new AppUser();
				newCustUser27.UserName = "knelson@aoll.com";
				newCustUser27.Email = "knelson@aoll.com";
				newCustUser27.Id = "5026";
				newCustUser27.FirstName = "Kelly";
				newCustUser27.LastName = "Nelson";
				newCustUser27.MiddleInitial = "T";
				newCustUser27.Birthday = new DateTime(1971, 7, 13);
				newCustUser27.Address = "5601 Blue River";
				newCustUser27.City = "Disney";
				newCustUser27.State = "OK";
				newCustUser27.Zip = "74340";
				newCustUser27.PhoneNumber = "5125557213";
				newCustUser27.PCPBalance = 10;

				var result = await _userManager.CreateAsync(newCustUser27, "spotmycat");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser27 = db.Users.FirstOrDefault(u => u.UserName == "knelson@aoll.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser27, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser27, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser28 = db.Users.FirstOrDefault(u => u.Email == "joewin@xfactor.com");

			if (newCustUser28 == null)
			{
				newCustUser28 = new AppUser();
				newCustUser28.UserName = "joewin@xfactor.com";
				newCustUser28.Email = "joewin@xfactor.com";
				newCustUser28.Id = "5027";
				newCustUser28.FirstName = "Joe";
				newCustUser28.LastName = "Nguyen";
				newCustUser28.MiddleInitial = "C";
				newCustUser28.Birthday = new DateTime(1984, 3, 17);
				newCustUser28.Address = "8249 54th SW St.";
				newCustUser28.City = "Del Rio";
				newCustUser28.State = "TX";
				newCustUser28.Zip = "37841";
				newCustUser28.PhoneNumber = "5125557774";
				newCustUser28.PCPBalance = 30;

				var result = await _userManager.CreateAsync(newCustUser28, "joejoebob");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser28 = db.Users.FirstOrDefault(u => u.UserName == "joewin@xfactor.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser28, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser28, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser29 = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnews.cnn");

			if (newCustUser29 == null)
			{
				newCustUser29 = new AppUser();
				newCustUser29.UserName = "orielly@foxnews.cnn";
				newCustUser29.Email = "orielly@foxnews.cnn";
				newCustUser29.Id = "5028";
				newCustUser29.FirstName = "Bill";
				newCustUser29.LastName = "O'Reilly";
				newCustUser29.MiddleInitial = "T";
				newCustUser29.Birthday = new DateTime(1959, 7, 8);
				newCustUser29.Address = "9870 Gato Drive";
				newCustUser29.City = "Fort Worth";
				newCustUser29.State = "TX";
				newCustUser29.Zip = "37746";
				newCustUser29.PhoneNumber = "5125551111";
				newCustUser29.PCPBalance = 120;

				var result = await _userManager.CreateAsync(newCustUser29, "bobbyboy");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser29 = db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnews.cnn");
			}
			if (await _userManager.IsInRoleAsync(newCustUser29, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser29, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser30 = db.Users.FirstOrDefault(u => u.Email == "ankaisrad@gogle.com");

			if (newCustUser30 == null)
			{
				newCustUser30 = new AppUser();
				newCustUser30.UserName = "ankaisrad@gogle.com";
				newCustUser30.Email = "ankaisrad@gogle.com";
				newCustUser30.Id = "5029";
				newCustUser30.FirstName = "Anka";
				newCustUser30.LastName = "Radkovich";
				newCustUser30.MiddleInitial = "L";
				newCustUser30.Birthday = new DateTime(1966, 5, 19);
				newCustUser30.Address = "7900 Mark Pl";
				newCustUser30.City = "Plano";
				newCustUser30.State = "TX";
				newCustUser30.Zip = "37712";
				newCustUser30.PhoneNumber = "5125555631";
				newCustUser30.PCPBalance = 150;

				var result = await _userManager.CreateAsync(newCustUser30, "chadgirl");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser30 = db.Users.FirstOrDefault(u => u.UserName == "ankaisrad@gogle.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser30, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser30, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser31 = db.Users.FirstOrDefault(u => u.Email == "megrhodes@freserve.co.uk");

			if (newCustUser31 == null)
			{
				newCustUser31 = new AppUser();
				newCustUser31.UserName = "megrhodes@freserve.co.uk";
				newCustUser31.Email = "megrhodes@freserve.co.uk";
				newCustUser31.Id = "5030";
				newCustUser31.FirstName = "Megan";
				newCustUser31.LastName = "Rhodes";
				newCustUser31.MiddleInitial = "C";
				newCustUser31.Birthday = new DateTime(1965, 3, 12);
				newCustUser31.Address = "1187 Carpet Rd.";
				newCustUser31.City = "Austin";
				newCustUser31.State = "TX";
				newCustUser31.Zip = "37705";
				newCustUser31.PhoneNumber = "5125557700";
				newCustUser31.PCPBalance = 50;

				var result = await _userManager.CreateAsync(newCustUser31, "megan55");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser31 = db.Users.FirstOrDefault(u => u.UserName == "megrhodes@freserve.co.uk");
			}
			if (await _userManager.IsInRoleAsync(newCustUser31, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser31, "Customer");
			}
			db.SaveChanges();


			AppUser newCustUser32 = db.Users.FirstOrDefault(u => u.Email == "erynrice@aoll.com");

			if (newCustUser32 == null)
			{
				newCustUser32 = new AppUser();
				newCustUser32.UserName = "erynrice@aoll.com";
				newCustUser32.Email = "erynrice@aoll.com";
				newCustUser32.Id = "5031";
				newCustUser32.FirstName = "Eryn";
				newCustUser32.LastName = "Rice";
				newCustUser32.MiddleInitial = "M";
				newCustUser32.Birthday = new DateTime(1975, 4, 28);
				newCustUser32.Address = "2205 Rio Pequeno";
				newCustUser32.City = "Austin";
				newCustUser32.State = "TX";
				newCustUser32.Zip = "37375";
				newCustUser32.PhoneNumber = "5125550006";
				newCustUser32.PCPBalance = 70;

				var result = await _userManager.CreateAsync(newCustUser32, "ricearoni");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newCustUser32 = db.Users.FirstOrDefault(u => u.UserName == "erynrice@aoll.com");
			}
			if (await _userManager.IsInRoleAsync(newCustUser32, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustUser32, "Customer");
			}
			db.SaveChanges();
		}
	}
}
