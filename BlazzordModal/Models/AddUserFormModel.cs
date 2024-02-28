﻿using System.ComponentModel.DataAnnotations;

namespace BlazzordModal.Models
{
	public class AddUserFormModel
	{
		[Required(ErrorMessage = "Username is required")]
		public string? username { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string? password { get; set; }
	}
}
