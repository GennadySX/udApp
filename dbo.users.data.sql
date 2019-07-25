SET IDENTITY_INSERT [dbo].[users] ON
INSERT INTO [dbo].[users] ([id], [name], [surname], [email], [birth_date], [login], [password], [secret_code], [role], [image]) VALUES (12, N'Gennady', N'admin', N'admin', N'1999-09-04', N'admin', N'admin', N'hola', 0, NULL)
SET IDENTITY_INSERT [dbo].[users] OFF
