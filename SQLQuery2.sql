USE [MSTDCdb]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_insertUsers]
		@p_uname = N'shivani',
		@p_uemail = N's@gmail.com',
		@p_upassword = N'1234',
		@p_ugender = N'female',
		@p_udob = N'05/03/1997'

SELECT	@return_value as 'Return Value'

GO
