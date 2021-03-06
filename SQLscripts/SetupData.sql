USE [SittingOnTheFence]
GO

DECLARE @TransactionName varchar(20) = 'Transaction1';

--BEGIN TRAN @TransactionName




INSERT INTO [dbo].[Questions] ( [Question])
OUTPUT INSERTED.*

SELECT N'Should candy floss be compulsory in primary schools?'AS QUESTION
UNION
SELECT  N'Are you willing to support repainting parliament light purple?' AS QUESTION
UNION
SELECT N'If you could choose any mode of transport what would it be?' AS QUESTION
UNION
SELECT N'If you had to choose between saving a whale and saving a dolphin what would you choose?' AS QUESTION
UNION
SELECT 'If you had to choose one city in New Zealand to get transport funding from the National government, what city would that be?' AS QUESTION

EXCEPT 
SELECT QUESTION FROM QUESTIONS

--INSERT [dbo].[Party] ([PartyName]) VALUES (N'Wishy Washy Random Party')
--INSERT [dbo].[Party] ([PartyName]) VALUES (N'Grumpy Party')
--INSERT [dbo].[Party] ([PartyName]) VALUES (N'Unicorn Fart Party')
--INSERT [dbo].[Party] ([PartyName]) VALUES (N'The Beige Party')

INSERT INTO [dbo].[Answers] ([QuestionId], [Answer], [PartyId])
OUTPUT INSERTED.*

SELECT 1, N'Ohh.. We are not sure?!', 1
UNION
SELECT 1, N'No, children should not be indulged with treats', 2
UNION
SELECT 1, N'Only, when the stars are in alignment!', 3
UNION
SELECT 1, N'No, candy floss is bad for childrens teeth and a cost to the tax payer.', 4
UNION
SELECT 2, N'Maybe', 4
UNION
SELECT 2, N'Possibly, if it is a really nice shade', 1
UNION
SELECT 2, N'Definitely Not, that will only encourage those spineless politicians.', 2
UNION
SELECT 2, N'Yes, Unicorns love a light shade of purple.', 3
union

SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you could choose any mode of transport what would it be?'), N'Im not sure I guess I just end up places and usually Im not sure how I got there.', 1
UNION
SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you could choose any mode of transport what would it be?'), N'Why is everybody in such a hurry these days? What is wrong with just staying home!', 2
UNION
SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you could choose any mode of transport what would it be?'), N'A Rocket ship, no a flying Dragon! NO! I know I would drift on clouds.', 3
UNION
SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you could choose any mode of transport what would it be?'), N'A car.', 4
UNION
SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you had to choose between saving a whale and saving a dolphin what would you choose?'), N'Im not sure, whatever I saw being threatened first??', 1
UNION
SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you had to choose between saving a whale and saving a dolphin what would you choose?'), N'Neither, let the bastards die, they are taking too much oxygen away from me as it!', 2
UNION
SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you had to choose between saving a whale and saving a dolphin what would you choose?'), N'I would create a magic spell and save them both.', 3
UNION
SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you had to choose between saving a whale and saving a dolphin what would you choose?'), N' A whale.', 4
UNION
SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you had to choose one city in New Zealand to get transport funding from the National government, what city would that be?'), N'I guess whatever city needed it most?', 1
UNION
SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you had to choose one city in New Zealand to get transport funding from the National government, what city would that be?'), N'All cities are bloated with parasites, why would any of these places deserve transport funding.', 2
UNION
SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you had to choose one city in New Zealand to get transport funding from the National government, what city would that be?'), N'I would split the funding evenly between every city in New Zealand.', 3
UNION
SELECT (SELECT ID FROM QUESTIONS WHERE QUESTION = 'If you had to choose one city in New Zealand to get transport funding from the National government, what city would that be?'), N' Hamilton.', 4

EXCEPT 
SELECT  [QuestionId], [Answer], [PartyId] FROM ANSWERS

--ROLLBACK TRAN @TransactionName;