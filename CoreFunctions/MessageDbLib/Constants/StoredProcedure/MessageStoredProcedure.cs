﻿namespace MessageDbLib.Constants.StoredProcedure.Constants
{
	public class MessageStoredProcedure
	{
		public const string GetAllMessages = @"[messagedbo].[GetMessages]";

		public const string GetMessagesBetweenSenderReceiver = @"messagedbo.GetMessagesBetweenSenderReceiver";
		public const string GetMessagesBetweenSenderReceiverParameters = @"@senderEmailAddress, @recieverEmailAddress, @messageIdLimit, @messageCount";
	}
}