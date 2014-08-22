USE [SittingOnTheFence]
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([Id], [Question]) VALUES (1, N'Should candy floss be compulsory in primary schools?')
INSERT [dbo].[Questions] ([Id], [Question]) VALUES (2, N'Are you willing to support repainting parliament light purple?')
SET IDENTITY_INSERT [dbo].[Questions] OFF
SET IDENTITY_INSERT [dbo].[Party] ON 

INSERT [dbo].[Party] ([Id], [PartyName]) VALUES (1, N'Wishy Washy Random Party')
INSERT [dbo].[Party] ([Id], [PartyName]) VALUES (2, N'Grumpy Party')
INSERT [dbo].[Party] ([Id], [PartyName]) VALUES (3, N'Unicorn Fart Party')
INSERT [dbo].[Party] ([Id], [PartyName]) VALUES (4, N'The Beige Party')
SET IDENTITY_INSERT [dbo].[Party] OFF
SET IDENTITY_INSERT [dbo].[Answers] ON 

INSERT [dbo].[Answers] ([QuestionId], [Answer], [PartyId], [Id]) VALUES (1, N'Ohh.. We are not sure?!', 1, 1)
INSERT [dbo].[Answers] ([QuestionId], [Answer], [PartyId], [Id]) VALUES (1, N'No, children should not be indulged with treats', 2, 2)
INSERT [dbo].[Answers] ([QuestionId], [Answer], [PartyId], [Id]) VALUES (1, N'Only, when the stars are in alignment!', 3, 3)
INSERT [dbo].[Answers] ([QuestionId], [Answer], [PartyId], [Id]) VALUES (1, N'No, candy floss is bad for childrens teeth and a cost to the tax payer.', 4, 4)
INSERT [dbo].[Answers] ([QuestionId], [Answer], [PartyId], [Id]) VALUES (2, N'Maybe', 4, 5)
INSERT [dbo].[Answers] ([QuestionId], [Answer], [PartyId], [Id]) VALUES (2, N'Possibly, if it is a really nice shade', 1, 6)
INSERT [dbo].[Answers] ([QuestionId], [Answer], [PartyId], [Id]) VALUES (2, N'Definitely Not, that will only encourage those spineless politicians.', 2, 7)
INSERT [dbo].[Answers] ([QuestionId], [Answer], [PartyId], [Id]) VALUES (2, N'Yes, Unicorns love a light shade of purple.', 3, 8)
SET IDENTITY_INSERT [dbo].[Answers] OFF
