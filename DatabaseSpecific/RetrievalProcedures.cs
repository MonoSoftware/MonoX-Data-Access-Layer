///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace MonoSoftware.MonoX.DAL.DatabaseSpecific
{
	/// <summary>Class which contains the static logic to execute retrieval stored procedures in the database.</summary>
	public static partial class RetrievalProcedures
	{



		/// <summary>Calls stored procedure 'FriendSuggestion'.<br/><br/></summary>
		/// <param name="userId">Input parameter. </param>
		/// <param name="numberOfLevels">Input parameter. </param>
		/// <param name="pageNumber">Input parameter. </param>
		/// <param name="pageSize">Input parameter. </param>
		/// <param name="isRandom">Input parameter. </param>
		/// <param name="userName">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable FriendSuggestion(System.Guid userId, System.Int32 numberOfLevels, System.Int32 pageNumber, System.Int32 pageSize, System.Boolean isRandom, System.String userName)
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return FriendSuggestion(userId, numberOfLevels, pageNumber, pageSize, isRandom, userName, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'FriendSuggestion'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="userId">Input parameter. </param>
		/// <param name="numberOfLevels">Input parameter. </param>
		/// <param name="pageNumber">Input parameter. </param>
		/// <param name="pageSize">Input parameter. </param>
		/// <param name="isRandom">Input parameter. </param>
		/// <param name="userName">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable FriendSuggestion(System.Guid userId, System.Int32 numberOfLevels, System.Int32 pageNumber, System.Int32 pageSize, System.Boolean isRandom, System.String userName, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateFriendSuggestionCall(dataAccessProvider, userId, numberOfLevels, pageNumber, pageSize, isRandom, userName))
			{
				DataTable toReturn = call.FillDataTable();
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'FriendSuggestion'.</summary>
		/// <param name="userId">Input parameter of stored procedure</param>
		/// <param name="numberOfLevels">Input parameter of stored procedure</param>
		/// <param name="pageNumber">Input parameter of stored procedure</param>
		/// <param name="pageSize">Input parameter of stored procedure</param>
		/// <param name="isRandom">Input parameter of stored procedure</param>
		/// <param name="userName">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetFriendSuggestionCallAsQuery(System.Guid userId, System.Int32 numberOfLevels, System.Int32 pageNumber, System.Int32 pageSize, System.Boolean isRandom, System.String userName)
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return CreateFriendSuggestionCall(dataAccessProvider, userId, numberOfLevels, pageNumber, pageSize, isRandom, userName).ToRetrievalQuery();
			}
		}

		/// <summary>Creates the call object for the call 'FriendSuggestion' to stored procedure 'FriendSuggestion'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="userId">Input parameter</param>
		/// <param name="numberOfLevels">Input parameter</param>
		/// <param name="pageNumber">Input parameter</param>
		/// <param name="pageSize">Input parameter</param>
		/// <param name="isRandom">Input parameter</param>
		/// <param name="userName">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateFriendSuggestionCall(IDataAccessCore dataAccessProvider, System.Guid userId, System.Int32 numberOfLevels, System.Int32 pageNumber, System.Int32 pageSize, System.Boolean isRandom, System.String userName)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[MonoX2].[dbo].[FriendSuggestion]", "FriendSuggestion")
							.AddParameter("@UserId", "UniqueIdentifier", 0, ParameterDirection.Input, true, 0, 0, userId)
							.AddParameter("@NumberOfLevels", "Int", 0, ParameterDirection.Input, true, 10, 0, numberOfLevels)
							.AddParameter("@PageNumber", "Int", 0, ParameterDirection.Input, true, 10, 0, pageNumber)
							.AddParameter("@PageSize", "Int", 0, ParameterDirection.Input, true, 10, 0, pageSize)
							.AddParameter("@IsRandom", "Bit", 0, ParameterDirection.Input, true, 0, 0, isRandom)
							.AddParameter("@UserName", "NVarChar", 200, ParameterDirection.Input, true, 0, 0, userName);
		}


		#region Included Code

		#endregion
	}
}
