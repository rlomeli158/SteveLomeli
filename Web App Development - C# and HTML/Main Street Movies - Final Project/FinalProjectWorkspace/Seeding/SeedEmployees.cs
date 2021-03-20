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
	public static class SeedEmployee
	{
		public static async Task SeedEmployees(IServiceProvider serviceProvider)
		//public static void SeedCustomers(AppDbContext db)
		{
			AppDbContext db = serviceProvider.GetRequiredService<AppDbContext>();
			UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
			RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();


			AppUser newUserEmp2 = db.Users.FirstOrDefault(u => u.Email == "t.jacobs@mainstreetmovies.com");

			if (newUserEmp2 == null)
			{
				newUserEmp2 = new AppUser();
				newUserEmp2.UserName = "t.jacobs@mainstreetmovies.com";
				newUserEmp2.Email = "t.jacobs@mainstreetmovies.com";
				newUserEmp2.FirstName = "Todd";
				newUserEmp2.LastName = "Jacobs";
				newUserEmp2.MiddleInitial = "L";
				newUserEmp2.Address = "4564 Elm St.";
				newUserEmp2.City = "Georgetown";
				newUserEmp2.State = "TX";
				newUserEmp2.Zip = "78628";
				newUserEmp2.PhoneNumber = "9074653365";
				newUserEmp2.Birthday = new DateTime(1958, 4, 25);



				var result = await _userManager.CreateAsync(newUserEmp2, "toddyboy");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp2 = db.Users.FirstOrDefault(u => u.UserName == "t.jacobs@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp2, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp2, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp3 = db.Users.FirstOrDefault(u => u.Email == "e.rice@mainstreetmovies.com");

			if (newUserEmp3 == null)
			{
				newUserEmp3 = new AppUser();
				newUserEmp3.UserName = "e.rice@mainstreetmovies.com";
				newUserEmp3.Email = "e.rice@mainstreetmovies.com";
				newUserEmp3.FirstName = "Eryn";
				newUserEmp3.LastName = "Rice";
				newUserEmp3.MiddleInitial = "M";
				newUserEmp3.Address = "3405 Rio Grande";
				newUserEmp3.City = "Austin";
				newUserEmp3.State = "TX";
				newUserEmp3.Zip = "78746";
				newUserEmp3.PhoneNumber = "9073876657";
				newUserEmp3.Birthday = new DateTime(1959, 7, 2);



				var result = await _userManager.CreateAsync(newUserEmp3, "ricearoni");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp3 = db.Users.FirstOrDefault(u => u.UserName == "e.rice@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp3, "Manager") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp3, "Manager");
			}
			db.SaveChanges();
			AppUser newUserEmp4 = db.Users.FirstOrDefault(u => u.Email == "a.taylor@mainstreetmovies.com");

			if (newUserEmp4 == null)
			{
				newUserEmp4 = new AppUser();
				newUserEmp4.UserName = "a.taylor@mainstreetmovies.com";
				newUserEmp4.Email = "a.taylor@mainstreetmovies.com";
				newUserEmp4.FirstName = "Allison";
				newUserEmp4.LastName = "Taylor";
				newUserEmp4.MiddleInitial = "R";
				newUserEmp4.Address = "467 Nueces St.";
				newUserEmp4.City = "Austin";
				newUserEmp4.State = "TX";
				newUserEmp4.Zip = "78727";
				newUserEmp4.PhoneNumber = "9074748452";
				newUserEmp4.Birthday = new DateTime(1964, 9, 2);



				var result = await _userManager.CreateAsync(newUserEmp4, "nostalgic");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp4 = db.Users.FirstOrDefault(u => u.UserName == "a.taylor@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp4, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp4, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp5 = db.Users.FirstOrDefault(u => u.Email == "g.martinez@mainstreetmovies.com");

			if (newUserEmp5 == null)
			{
				newUserEmp5 = new AppUser();
				newUserEmp5.UserName = "g.martinez@mainstreetmovies.com";
				newUserEmp5.Email = "g.martinez@mainstreetmovies.com";
				newUserEmp5.FirstName = "Gregory";
				newUserEmp5.LastName = "Martinez";
				newUserEmp5.MiddleInitial = "R";
				newUserEmp5.Address = "8295 Sunset Blvd.";
				newUserEmp5.City = "Austin";
				newUserEmp5.State = "TX";
				newUserEmp5.Zip = "78712";
				newUserEmp5.PhoneNumber = "9078746718";
				newUserEmp5.Birthday = new DateTime(1992, 3, 30);



				var result = await _userManager.CreateAsync(newUserEmp5, "fungus");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp5 = db.Users.FirstOrDefault(u => u.UserName == "g.martinez@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp5, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp5, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp6 = db.Users.FirstOrDefault(u => u.Email == "m.sheffield@mainstreetmovies.com");

			if (newUserEmp6 == null)
			{
				newUserEmp6 = new AppUser();
				newUserEmp6.UserName = "m.sheffield@mainstreetmovies.com";
				newUserEmp6.Email = "m.sheffield@mainstreetmovies.com";
				newUserEmp6.FirstName = "Martin";
				newUserEmp6.LastName = "Sheffield";
				newUserEmp6.MiddleInitial = "J";
				newUserEmp6.Address = "3886 Avenue A";
				newUserEmp6.City = "San Marcos";
				newUserEmp6.State = "TX";
				newUserEmp6.Zip = "78666";
				newUserEmp6.PhoneNumber = "9075479167";
				newUserEmp6.Birthday = new DateTime(1996, 12, 29);



				var result = await _userManager.CreateAsync(newUserEmp6, "longhorns");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp6 = db.Users.FirstOrDefault(u => u.UserName == "m.sheffield@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp6, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp6, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp7 = db.Users.FirstOrDefault(u => u.Email == "j.tanner@mainstreetmovies.com");

			if (newUserEmp7 == null)
			{
				newUserEmp7 = new AppUser();
				newUserEmp7.UserName = "j.tanner@mainstreetmovies.com";
				newUserEmp7.Email = "j.tanner@mainstreetmovies.com";
				newUserEmp7.FirstName = "Jeremy";
				newUserEmp7.LastName = "Tanner";
				newUserEmp7.MiddleInitial = "S";
				newUserEmp7.Address = "4347 Almstead";
				newUserEmp7.City = "Austin";
				newUserEmp7.State = "TX";
				newUserEmp7.Zip = "78712";
				newUserEmp7.PhoneNumber = "9074590929";
				newUserEmp7.Birthday = new DateTime(1970, 8, 12);



				var result = await _userManager.CreateAsync(newUserEmp7, "tanman");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp7 = db.Users.FirstOrDefault(u => u.UserName == "j.tanner@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp7, "Manager") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp7, "Manager");
			}
			db.SaveChanges();
			AppUser newUserEmp8 = db.Users.FirstOrDefault(u => u.Email == "m.rhodes@mainstreetmovies.com");

			if (newUserEmp8 == null)
			{
				newUserEmp8 = new AppUser();
				newUserEmp8.UserName = "m.rhodes@mainstreetmovies.com";
				newUserEmp8.Email = "m.rhodes@mainstreetmovies.com";
				newUserEmp8.FirstName = "Megan";
				newUserEmp8.LastName = "Rhodes";
				newUserEmp8.MiddleInitial = "C";
				newUserEmp8.Address = "4587 Enfield Rd.";
				newUserEmp8.City = "Austin";
				newUserEmp8.State = "TX";
				newUserEmp8.Zip = "78729";
				newUserEmp8.PhoneNumber = "9073744746";
				newUserEmp8.Birthday = new DateTime(1970, 12, 18);



				var result = await _userManager.CreateAsync(newUserEmp8, "countryrhodes");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp8 = db.Users.FirstOrDefault(u => u.UserName == "m.rhodes@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp8, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp8, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp9 = db.Users.FirstOrDefault(u => u.Email == "e.stuart@mainstreetmovies.com");

			if (newUserEmp9 == null)
			{
				newUserEmp9 = new AppUser();
				newUserEmp9.UserName = "e.stuart@mainstreetmovies.com";
				newUserEmp9.Email = "e.stuart@mainstreetmovies.com";
				newUserEmp9.FirstName = "Eric";
				newUserEmp9.LastName = "Stuart";
				newUserEmp9.MiddleInitial = "F";
				newUserEmp9.Address = "5576 Toro Ring";
				newUserEmp9.City = "San Antonio";
				newUserEmp9.State = "TX";
				newUserEmp9.Zip = "78758";
				newUserEmp9.PhoneNumber = "9078178335";
				newUserEmp9.Birthday = new DateTime(1971, 3, 11);



				var result = await _userManager.CreateAsync(newUserEmp9, "stewboy");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp9 = db.Users.FirstOrDefault(u => u.UserName == "e.stuart@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp9, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp9, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp10 = db.Users.FirstOrDefault(u => u.Email == "r.taylor@mainstreetmovies.com");

			if (newUserEmp10 == null)
			{
				newUserEmp10 = new AppUser();
				newUserEmp10.UserName = "r.taylor@mainstreetmovies.com";
				newUserEmp10.Email = "r.taylor@mainstreetmovies.com";
				newUserEmp10.FirstName = "Rachel";
				newUserEmp10.LastName = "Taylor";
				newUserEmp10.MiddleInitial = "O";
				newUserEmp10.Address = "345 Longview Dr.";
				newUserEmp10.City = "Austin";
				newUserEmp10.State = "TX";
				newUserEmp10.Zip = "78746";
				newUserEmp10.PhoneNumber = "9074512631";
				newUserEmp10.Birthday = new DateTime(1972, 12, 20);



				var result = await _userManager.CreateAsync(newUserEmp10, "swansong");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp10 = db.Users.FirstOrDefault(u => u.UserName == "r.taylor@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp10, "Manager") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp10, "Manager");
			}
			db.SaveChanges();
			AppUser newUserEmp11 = db.Users.FirstOrDefault(u => u.Email == "v.lawrence@mainstreetmovies.com");

			if (newUserEmp11 == null)
			{
				newUserEmp11 = new AppUser();
				newUserEmp11.UserName = "v.lawrence@mainstreetmovies.com";
				newUserEmp11.Email = "v.lawrence@mainstreetmovies.com";
				newUserEmp11.FirstName = "Tori";
				newUserEmp11.LastName = "Lawrence";
				newUserEmp11.MiddleInitial = "Y";
				newUserEmp11.Address = "6639 Butterfly Ln.";
				newUserEmp11.City = "Austin";
				newUserEmp11.State = "TX";
				newUserEmp11.Zip = "78712";
				newUserEmp11.PhoneNumber = "9079457399";
				newUserEmp11.Birthday = new DateTime(1973, 4, 28);



				var result = await _userManager.CreateAsync(newUserEmp11, "lottery");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp11 = db.Users.FirstOrDefault(u => u.UserName == "v.lawrence@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp11, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp11, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp12 = db.Users.FirstOrDefault(u => u.Email == "a.rogers@mainstreetmovies.com");

			if (newUserEmp12 == null)
			{
				newUserEmp12 = new AppUser();
				newUserEmp12.UserName = "a.rogers@mainstreetmovies.com";
				newUserEmp12.Email = "a.rogers@mainstreetmovies.com";
				newUserEmp12.FirstName = "Allen";
				newUserEmp12.LastName = "Alberts";
				newUserEmp12.MiddleInitial = "H";
				newUserEmp12.Address = "4965 Oak Hill";
				newUserEmp12.City = "Austin";
				newUserEmp12.State = "TX";
				newUserEmp12.Zip = "78705";
				newUserEmp12.PhoneNumber = "9078752943";
				newUserEmp12.Birthday = new DateTime(1978, 6, 21);



				var result = await _userManager.CreateAsync(newUserEmp12, "evanescent");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp12 = db.Users.FirstOrDefault(u => u.UserName == "a.rogers@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp12, "Manager") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp12, "Manager");
			}
			db.SaveChanges();
			AppUser newUserEmp13 = db.Users.FirstOrDefault(u => u.Email == "c.baker@mainstreetmovies.com");

			if (newUserEmp13 == null)
			{
				newUserEmp13 = new AppUser();
				newUserEmp13.UserName = "c.baker@mainstreetmovies.com";
				newUserEmp13.Email = "c.baker@mainstreetmovies.com";
				newUserEmp13.FirstName = "Christopher";
				newUserEmp13.LastName = "Baker";
				newUserEmp13.MiddleInitial = "E";
				newUserEmp13.Address = "1245 Lake Anchorage Blvd.";
				newUserEmp13.City = "Cedar Park";
				newUserEmp13.State = "TX";
				newUserEmp13.Zip = "78613";
				newUserEmp13.PhoneNumber = "9075571146";
				newUserEmp13.Birthday = new DateTime(1993, 3, 16);



				var result = await _userManager.CreateAsync(newUserEmp13, "hecktour");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp13 = db.Users.FirstOrDefault(u => u.UserName == "c.baker@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp13, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp13, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp14 = db.Users.FirstOrDefault(u => u.Email == "w.sewell@mainstreetmovies.com");

			if (newUserEmp14 == null)
			{
				newUserEmp14 = new AppUser();
				newUserEmp14.UserName = "w.sewell@mainstreetmovies.com";
				newUserEmp14.Email = "w.sewell@mainstreetmovies.com";
				newUserEmp14.FirstName = "William";
				newUserEmp14.LastName = "Sewell";
				newUserEmp14.MiddleInitial = "G";
				newUserEmp14.Address = "2365 51st St.";
				newUserEmp14.City = "Austin";
				newUserEmp14.State = "TX";
				newUserEmp14.Zip = "78755";
				newUserEmp14.PhoneNumber = "9074510084";
				newUserEmp14.Birthday = new DateTime(1986, 5, 25);



				var result = await _userManager.CreateAsync(newUserEmp14, "walkamile");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp14 = db.Users.FirstOrDefault(u => u.UserName == "w.sewell@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp14, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp14, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp15 = db.Users.FirstOrDefault(u => u.Email == "j.mason@mainstreetmovies.com");

			if (newUserEmp15 == null)
			{
				newUserEmp15 = new AppUser();
				newUserEmp15.UserName = "j.mason@mainstreetmovies.com";
				newUserEmp15.Email = "j.mason@mainstreetmovies.com";
				newUserEmp15.FirstName = "Jack";
				newUserEmp15.LastName = "Mason";
				newUserEmp15.MiddleInitial = "L";
				newUserEmp15.Address = "444 45th St";
				newUserEmp15.City = "Austin";
				newUserEmp15.State = "TX";
				newUserEmp15.Zip = "78701";
				newUserEmp15.PhoneNumber = "9018833432";
				newUserEmp15.Birthday = new DateTime(1986, 6, 6);



				var result = await _userManager.CreateAsync(newUserEmp15, "changalang");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp15 = db.Users.FirstOrDefault(u => u.UserName == "j.mason@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp15, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp15, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp16 = db.Users.FirstOrDefault(u => u.Email == "j.jackson@mainstreetmovies.com");

			if (newUserEmp16 == null)
			{
				newUserEmp16 = new AppUser();
				newUserEmp16.UserName = "j.jackson@mainstreetmovies.com";
				newUserEmp16.Email = "j.jackson@mainstreetmovies.com";
				newUserEmp16.FirstName = "Jack";
				newUserEmp16.LastName = "Jackson";
				newUserEmp16.MiddleInitial = "J";
				newUserEmp16.Address = "222 Main";
				newUserEmp16.City = "Austin";
				newUserEmp16.State = "TX";
				newUserEmp16.Zip = "78760";
				newUserEmp16.PhoneNumber = "9075554545";
				newUserEmp16.Birthday = new DateTime(1989, 10, 16);



				var result = await _userManager.CreateAsync(newUserEmp16, "offbeat");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp16 = db.Users.FirstOrDefault(u => u.UserName == "j.jackson@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp16, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp16, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp17 = db.Users.FirstOrDefault(u => u.Email == "m.nguyen@mainstreetmovies.com");

			if (newUserEmp17 == null)
			{
				newUserEmp17 = new AppUser();
				newUserEmp17.UserName = "m.nguyen@mainstreetmovies.com";
				newUserEmp17.Email = "m.nguyen@mainstreetmovies.com";
				newUserEmp17.FirstName = "Andy";
				newUserEmp17.LastName = "Nguyen";
				newUserEmp17.MiddleInitial = "M";
				newUserEmp17.Address = "465 N. Bear Cub";
				newUserEmp17.City = "Austin";
				newUserEmp17.State = "TX";
				newUserEmp17.Zip = "78734";
				newUserEmp17.PhoneNumber = "9075524141";
				newUserEmp17.Birthday = new DateTime(1988, 4, 5);



				var result = await _userManager.CreateAsync(newUserEmp17, "landus");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp17 = db.Users.FirstOrDefault(u => u.UserName == "m.nguyen@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp17, "Manager") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp17, "Manager");
			}
			db.SaveChanges();
			AppUser newUserEmp18 = db.Users.FirstOrDefault(u => u.Email == "s.barnes@mainstreetmovies.com");

			if (newUserEmp18 == null)
			{
				newUserEmp18 = new AppUser();
				newUserEmp18.UserName = "s.barnes@mainstreetmovies.com";
				newUserEmp18.Email = "s.barnes@mainstreetmovies.com";
				newUserEmp18.FirstName = "Susan";
				newUserEmp18.LastName = "Barnes";
				newUserEmp18.MiddleInitial = "M";
				newUserEmp18.Address = "888 S. Main";
				newUserEmp18.City = "Kyle";
				newUserEmp18.State = "TX";
				newUserEmp18.Zip = "78640";
				newUserEmp18.PhoneNumber = "9556662323";
				newUserEmp18.Birthday = new DateTime(1993, 2, 22);



				var result = await _userManager.CreateAsync(newUserEmp18, "rhythm");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp18 = db.Users.FirstOrDefault(u => u.UserName == "s.barnes@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp18, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp18, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp19 = db.Users.FirstOrDefault(u => u.Email == "l.jones@mainstreetmovies.com");

			if (newUserEmp19 == null)
			{
				newUserEmp19 = new AppUser();
				newUserEmp19.UserName = "l.jones@mainstreetmovies.com";
				newUserEmp19.Email = "l.jones@mainstreetmovies.com";
				newUserEmp19.FirstName = "Sarah";
				newUserEmp19.LastName = "Johns";
				newUserEmp19.MiddleInitial = "L";
				newUserEmp19.Address = "999 LeBlat";
				newUserEmp19.City = "Austin";
				newUserEmp19.State = "TX";
				newUserEmp19.Zip = "78747";
				newUserEmp19.PhoneNumber = "9886662222";
				newUserEmp19.Birthday = new DateTime(1996, 6, 29);



				var result = await _userManager.CreateAsync(newUserEmp19, "kindly");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp19 = db.Users.FirstOrDefault(u => u.UserName == "l.jones@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp19, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp19, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp20 = db.Users.FirstOrDefault(u => u.Email == "c.silva@mainstreetmovies.com");

			if (newUserEmp20 == null)
			{
				newUserEmp20 = new AppUser();
				newUserEmp20.UserName = "c.silva@mainstreetmovies.com";
				newUserEmp20.Email = "c.silva@mainstreetmovies.com";
				newUserEmp20.FirstName = "Cindy";
				newUserEmp20.LastName = "Silva";
				newUserEmp20.MiddleInitial = "S";
				newUserEmp20.Address = "900 4th St";
				newUserEmp20.City = "Austin";
				newUserEmp20.State = "TX";
				newUserEmp20.Zip = "78758";
				newUserEmp20.PhoneNumber = "9221113333";
				newUserEmp20.Birthday = new DateTime(1997, 12, 29);



				var result = await _userManager.CreateAsync(newUserEmp20, "arched");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp20 = db.Users.FirstOrDefault(u => u.UserName == "c.silva@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp20, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp20, "Employee");
			}
			db.SaveChanges();
			AppUser newUserEmp21 = db.Users.FirstOrDefault(u => u.Email == "s.rankin@mainstreetmovies.com");

			if (newUserEmp21 == null)
			{
				newUserEmp21 = new AppUser();
				newUserEmp21.UserName = "s.rankin@mainstreetmovies.com";
				newUserEmp21.Email = "s.rankin@mainstreetmovies.com";
				newUserEmp21.FirstName = "Suzie";
				newUserEmp21.LastName = "Rankin";
				newUserEmp21.MiddleInitial = "R";
				newUserEmp21.Address = "23 Polar Bear Road";
				newUserEmp21.City = "Buda";
				newUserEmp21.State = "TX";
				newUserEmp21.Zip = "78712";
				newUserEmp21.PhoneNumber = "9893336666";
				newUserEmp21.Birthday = new DateTime(1999, 12, 17);



				var result = await _userManager.CreateAsync(newUserEmp21, "decorate");
				if (result.Succeeded == false)
				{
					throw new Exception("This user can't be added - " + result.ToString());
				}
				db.SaveChanges();
				newUserEmp21 = db.Users.FirstOrDefault(u => u.UserName == "s.rankin@mainstreetmovies.com");
			}
			if (await _userManager.IsInRoleAsync(newUserEmp21, "Employee") == false)
			{
				await _userManager.AddToRoleAsync(newUserEmp21, "Employee");
			}
			db.SaveChanges();
		}
	}
}