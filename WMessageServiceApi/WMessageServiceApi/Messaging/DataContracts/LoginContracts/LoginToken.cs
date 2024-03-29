﻿using System.Runtime.Serialization;

namespace WMessageServiceApi.Messaging.DataContracts.LoginContracts
{
	[DataContract]
	public class LoginToken : ILoginToken
	{
		[DataMember]
		public bool LoginSuccessful { get; set; }

		[DataMember]
		public string UserName { get; set; }

		[DataMember]
		public string UserEmailAddress { get; set; }
		//[DataMember]
		//public User User { get; set; }
	}
}