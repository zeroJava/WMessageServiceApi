﻿using MessageDbLib.Logging;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using WMessageServiceApi.Authentication;
using WMessageServiceApi.Exceptions.Datacontacts;
using WMessageServiceApi.Messaging.DataContracts.MessageContracts;
using WMessageServiceApi.Messaging.ServiceBusinessLogics;
using WMessageServiceApi.Messaging.ServiceInterfaces;

namespace WMessageServiceApi.Messaging.Services
{
    public class RetrieveMessageService : IRetrieveMessageService
    {
        public List<MessageDispatchInfoContract> GetMessagesSentToUser(IRetrieveMessageRequest messageRequest)
        {
            try
            {
                RetrieveMessageServiceBl retrieveMessageBL = new RetrieveMessageServiceBl();
                return retrieveMessageBL.GetMessagesSentToUser(messageRequest);
            }
            catch (TokenValidationException exception)
            {
                WriteErrorLog("Encontered a token validation error getting messages set to user.", exception);
                ErrorContract error = new ErrorContract(exception.Message, StatusList.VALIDATION_ERROR);
                throw new FaultException<ErrorContract>(error);
            }
            catch (Exception exception)
            {
                WriteErrorLog("Error encountered when getting messages-sent-to-user.", exception);
                ErrorContract error = new ErrorContract(exception.Message, StatusList.PROCESS_ERROR);
                throw new FaultException<ErrorContract>(error);
            }
        }

        public List<MessageDispatchInfoContract> GetMessageDipatchesBetweenSenderReceiver(IRetrieveMessageRequest messageRequest)
        {
            try
            {
                RetrieveMessageServiceBl retrieveMessageBL = new RetrieveMessageServiceBl();
                return retrieveMessageBL.GetMsgDispatchesBetweenSenderReceiver(messageRequest);
            }
            catch (TokenValidationException exception)
            {
                WriteErrorLog("Encontered a token validation error getting messages between sender and receiver.", exception);
                ErrorContract error = new ErrorContract(exception.Message, StatusList.VALIDATION_ERROR);
                throw new FaultException<ErrorContract>(error);
            }
            catch (Exception exception)
            {
                WriteErrorLog("Error encountered when Getting-Message-Dispatches-Between-Sender-Receiver.", exception);
                ErrorContract error = new ErrorContract(exception.Message, StatusList.PROCESS_ERROR);
                throw new FaultException<ErrorContract>(error);
            }
        }

        private void WriteErrorLog(string message, Exception exception)
        {
            LogFile.WriteErrorLog(message, exception);
        }

        private void WriteInfoLog(string message)
        {
            LogFile.WriteInfoLog(message);
        }
    }
}