﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AuthorisationServer.Validation
{
	public class UserCredential
	{
		public string Username { get; set; }
		public string Password { get; set; }
	}
}