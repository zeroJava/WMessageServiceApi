﻿using WMessageServiceApi.Messaging.DataEnumerations;

namespace WMessageServiceApi.Messaging.DataContracts.MessageContracts
{
	public interface IMessageRequestToken
	{
		long MessageId { get; set; }
		string Message { get; set; }
		MessageReceivedState MessageRecievedState { get; set; }
	}
}
