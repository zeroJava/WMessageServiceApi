﻿using System;
using System.ServiceModel;
using WMessageServiceApi.Exceptions.Datacontacts;
using WMessageServiceApi.Messaging.DataContracts.UserContracts;
using WMessageServiceApi.Messaging.ServiceBusinessLogics;
using WMessageServiceApi.Messaging.ServiceInterfaces;

namespace WMessageServiceApi.Messaging.Services
{
	public class CreateUserService : ICreateUserService
	{
		public void CreateNewAdvancedUser(NewAdvancedUserDataContract advanceUserContract)
		{
			try
			{
				CreateUserServiceFacade createUserBL = new CreateUserServiceFacade();
				createUserBL.CreateNewAdvancedUser(advanceUserContract);
			}
			catch (InvalidOperationException exception)
			{
				ThrowUserExistErrorMessage(exception.Message);
			}
			catch (Exception exception)
			{
				ThrowErrorMessage(exception.Message, StatusList.PROCESS_ERROR);
			}
		}

		public void CreateNewUser(NewUserDataContract userContract)
		{
			try
			{
				CreateUserServiceFacade createUserBL = new CreateUserServiceFacade();
				createUserBL.CreateNewUser(userContract);
			}
			catch (InvalidOperationException exception)
			{
				ThrowUserExistErrorMessage(exception.Message);
			}
			catch (Exception exception)
			{
				ThrowErrorMessage(exception.Message, StatusList.PROCESS_ERROR);
			}
		}

		private void ThrowErrorMessage(string message, int status)
		{
			ErrorContract error = new ErrorContract(message, status);
			throw new FaultException<ErrorContract>(error);
		}

		private void ThrowUserExistErrorMessage(string message)
		{
			UserExistErrorContract error = new UserExistErrorContract
			{
				Message = message
			};
			throw new FaultException<UserExistErrorContract>(error);
		}
	}
}

/*var advanceUser = new AdvancedUser()
{
	USERNAME = user.USERNAME,
	Password = user.Password,
	DOB = user.DOB,
	ADVANCEENDDATETIME = DateTime.Now.AddDays(50d),
	ADVANCESTARTDATETIME = DateTime.Now
};*/
