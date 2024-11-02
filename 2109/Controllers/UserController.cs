using _2109.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2109.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			// Создаем объект пользователя
			User user = new User
			{
				Id = Guid.NewGuid(),
				Name = "Иван Иванов",
				Email = "ivan.ivanov@example.com"
			};

			// Подход 1: Используем ViewBag
			ViewBag.UserName = user.Name;
			ViewBag.UserEmail = user.Email;

			// Подход 2: Используем ViewData
			ViewData["UserId"] = user.Id;

			// Подход 3: Используем модель
			return View(user); // Передаем объект User в представление
		}
	}
}
