using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
	internal class User
	{
		public string UserName;
		public Holst MyHolst;

		public User() {
			UserName = "";
			MyHolst = new Holst();
		}

		public void login() {
			Console.Write("введите имя : ");
			UserName = Console.ReadLine();
			Console.Write("Приветствую Вас, "+UserName);
		}
		public void logout() {
			Console.WriteLine("Пользователь "+UserName+" вышел");
			UserName = "";
			MyHolst.clearHolst();
		}
		public void Relog() {
			logout();
			login();
		}
	}
}
