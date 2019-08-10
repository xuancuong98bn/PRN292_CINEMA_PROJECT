USE [cinema_database]
GO
SET IDENTITY_INSERT [dbo].[Films] ON 

INSERT [dbo].[Films] ([ID], [Code], [Title], [Author], [Actor], [PublicationDate], [ContentFilm], [Image], [IsEnable]) VALUES (1, N'F01', N'Toy Story 3', N'xxx', N'lion', CAST(N'2019-08-17 00:00:00.000' AS DateTime), N'Egetnunc nunc mattitor curabiturpiscipis nec ac hac pellus sem intesque sociis. Metusmetuer hendimentesque diam at orbi sempor.', N'1page-img2.jpg', 1)
INSERT [dbo].[Films] ([ID], [Code], [Title], [Author], [Actor], [PublicationDate], [ContentFilm], [Image], [IsEnable]) VALUES (2, N'F02', N'Prince of Percia: Sands of Time', N'xxx', N'xxx', CAST(N'2019-01-07 00:00:00.000' AS DateTime), N'Dolorem malesuada anterdum quis vitae. Cursustellentesque enim justo vestasse vitae trices phasellus leo sociis leo magnisl. Malestibulusnatis.', N'1page-img3.jpg', 1)
INSERT [dbo].[Films] ([ID], [Code], [Title], [Author], [Actor], [PublicationDate], [ContentFilm], [Image], [IsEnable]) VALUES (3, N'F03', N'The Twilight Saga: Eclipse', N'xxx', N'xxx', CAST(N'2019-07-15 00:00:00.000' AS DateTime), N'Quisque felit odio ut nunc convallis semper sente ris feugiat. Odionam leo phasellentum id vitantesque nunc tor quisque a maecenatibus pellus.', N'1page-img4.jpg', 1)
INSERT [dbo].[Films] ([ID], [Code], [Title], [Author], [Actor], [PublicationDate], [ContentFilm], [Image], [IsEnable]) VALUES (5, N'F04', N'xxx', N'xxx', N'xxx', CAST(N'2017-01-01 00:00:00.000' AS DateTime), N'xxx', N'1page-img2.jpg', 1)
INSERT [dbo].[Films] ([ID], [Code], [Title], [Author], [Actor], [PublicationDate], [ContentFilm], [Image], [IsEnable]) VALUES (6, N'F05', N'xxx', N'xxx', N'xxx', CAST(N'2017-01-01 00:00:00.000' AS DateTime), N'xxx', N'1page-img2.jpg', 1)
INSERT [dbo].[Films] ([ID], [Code], [Title], [Author], [Actor], [PublicationDate], [ContentFilm], [Image], [IsEnable]) VALUES (7, N'F06', N'xxx', N'xxx', N'xxx', CAST(N'2017-01-01 00:00:00.000' AS DateTime), N'xxx', N'1page-img2.jpg', 1)
INSERT [dbo].[Films] ([ID], [Code], [Title], [Author], [Actor], [PublicationDate], [ContentFilm], [Image], [IsEnable]) VALUES (8, N'F07', N'Hello', N'hihi', N'haahaa', CAST(N'2019-07-10 00:00:00.000' AS DateTime), N'a cute lion ......', N'1page-img2.jpg', 1)
INSERT [dbo].[Films] ([ID], [Code], [Title], [Author], [Actor], [PublicationDate], [ContentFilm], [Image], [IsEnable]) VALUES (9, N'F08', N'Tien', N'Thay Tien', N'Thay Tien', CAST(N'2019-07-16 00:00:00.000' AS DateTime), N'a cute lion ......', N'1page-img2.jpg', 1)
SET IDENTITY_INSERT [dbo].[Films] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([ID], [Code], [Name], [IsEnable]) VALUES (1, N'Admin', N'Admin', 1)
INSERT [dbo].[Roles] ([ID], [Code], [Name], [IsEnable]) VALUES (2, N'Customer', N'Customer', 1)
INSERT [dbo].[Roles] ([ID], [Code], [Name], [IsEnable]) VALUES (3, N'Manager', N'Manger', 1)
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Rooms] ON 

INSERT [dbo].[Rooms] ([ID], [Code], [Name], [RowQuantity], [ColumnQuantity], [IsEnable]) VALUES (1, N'R01', N'Conan', 5, 5, 1)
INSERT [dbo].[Rooms] ([ID], [Code], [Name], [RowQuantity], [ColumnQuantity], [IsEnable]) VALUES (2, N'R02', N'Naruto', 5, 5, 1)
INSERT [dbo].[Rooms] ([ID], [Code], [Name], [RowQuantity], [ColumnQuantity], [IsEnable]) VALUES (3, N'R03', N'Saitama', 5, 5, 1)
SET IDENTITY_INSERT [dbo].[Rooms] OFF
SET IDENTITY_INSERT [dbo].[Seats] ON 

INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (1, 1, 1, 1, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (2, 1, 1, 2, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (3, 1, 1, 3, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (4, 1, 1, 4, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (5, 1, 1, 5, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (6, 1, 2, 1, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (7, 1, 2, 2, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (8, 1, 2, 3, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (9, 1, 2, 4, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (10, 1, 2, 5, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (11, 1, 3, 1, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (12, 1, 3, 2, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (13, 1, 3, 3, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (14, 1, 3, 4, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (15, 1, 3, 5, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (16, 1, 4, 1, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (17, 1, 4, 2, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (18, 1, 4, 3, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (19, 1, 4, 4, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (20, 1, 4, 5, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (21, 1, 5, 1, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (22, 1, 5, 2, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (23, 1, 5, 3, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (24, 1, 5, 4, 1, 1)
INSERT [dbo].[Seats] ([ID], [RoomID], [Rowth], [Columnth], [IsEnable], [SeattypeID]) VALUES (25, 1, 5, 5, 1, 1)
SET IDENTITY_INSERT [dbo].[Seats] OFF
SET IDENTITY_INSERT [dbo].[Seattypes] ON 

INSERT [dbo].[Seattypes] ([ID], [Code], [Name], [IsEnable], [PlusPrice]) VALUES (1, N'STD', N'Standard', 1, 0)
INSERT [dbo].[Seattypes] ([ID], [Code], [Name], [IsEnable], [PlusPrice]) VALUES (2, N'VIP', N'VIP', 1, 50000)
INSERT [dbo].[Seattypes] ([ID], [Code], [Name], [IsEnable], [PlusPrice]) VALUES (3, N'SPE', N'Special', 1, 100000)
SET IDENTITY_INSERT [dbo].[Seattypes] OFF
SET IDENTITY_INSERT [dbo].[Showtimes] ON 

INSERT [dbo].[Showtimes] ([ID], [FilmID], [SlotID], [IsEnable], [OriginPrice]) VALUES (1, 1, 1, 1, 120000)
INSERT [dbo].[Showtimes] ([ID], [FilmID], [SlotID], [IsEnable], [OriginPrice]) VALUES (2, 2, 2, 1, 100000)
INSERT [dbo].[Showtimes] ([ID], [FilmID], [SlotID], [IsEnable], [OriginPrice]) VALUES (4, 3, 3, 1, 150000)
INSERT [dbo].[Showtimes] ([ID], [FilmID], [SlotID], [IsEnable], [OriginPrice]) VALUES (5, 1, 4, 1, 120000)
INSERT [dbo].[Showtimes] ([ID], [FilmID], [SlotID], [IsEnable], [OriginPrice]) VALUES (6, 2, 5, 1, 100000)
INSERT [dbo].[Showtimes] ([ID], [FilmID], [SlotID], [IsEnable], [OriginPrice]) VALUES (7, 3, 6, 1, 150000)
INSERT [dbo].[Showtimes] ([ID], [FilmID], [SlotID], [IsEnable], [OriginPrice]) VALUES (8, 2, 7, 1, 100000)
INSERT [dbo].[Showtimes] ([ID], [FilmID], [SlotID], [IsEnable], [OriginPrice]) VALUES (9, 3, 8, 1, 150000)
SET IDENTITY_INSERT [dbo].[Showtimes] OFF
SET IDENTITY_INSERT [dbo].[Slots] ON 

INSERT [dbo].[Slots] ([ID], [RoomID], [TimeslotID], [IsEnable], [Description]) VALUES (1, 1, 1, 1, NULL)
INSERT [dbo].[Slots] ([ID], [RoomID], [TimeslotID], [IsEnable], [Description]) VALUES (3, 1, 2, 1, NULL)
INSERT [dbo].[Slots] ([ID], [RoomID], [TimeslotID], [IsEnable], [Description]) VALUES (4, 1, 3, 1, NULL)
INSERT [dbo].[Slots] ([ID], [RoomID], [TimeslotID], [IsEnable], [Description]) VALUES (5, 1, 5, 1, NULL)
INSERT [dbo].[Slots] ([ID], [RoomID], [TimeslotID], [IsEnable], [Description]) VALUES (6, 2, 3, 1, NULL)
INSERT [dbo].[Slots] ([ID], [RoomID], [TimeslotID], [IsEnable], [Description]) VALUES (7, 2, 4, 1, NULL)
INSERT [dbo].[Slots] ([ID], [RoomID], [TimeslotID], [IsEnable], [Description]) VALUES (8, 3, 5, 1, NULL)
SET IDENTITY_INSERT [dbo].[Slots] OFF
SET IDENTITY_INSERT [dbo].[Tickets] ON 

INSERT [dbo].[Tickets] ([ID], [ShowtimeID], [SeatID], [Status], [Price]) VALUES (1, 1, 10, 1, 120000)
INSERT [dbo].[Tickets] ([ID], [ShowtimeID], [SeatID], [Status], [Price]) VALUES (2, 1, 19, 1, 120000)
INSERT [dbo].[Tickets] ([ID], [ShowtimeID], [SeatID], [Status], [Price]) VALUES (3, 1, 18, 1, 120000)
INSERT [dbo].[Tickets] ([ID], [ShowtimeID], [SeatID], [Status], [Price]) VALUES (4, 1, 8, 1, 120000)
INSERT [dbo].[Tickets] ([ID], [ShowtimeID], [SeatID], [Status], [Price]) VALUES (5, 1, 23, 1, 120000)
INSERT [dbo].[Tickets] ([ID], [ShowtimeID], [SeatID], [Status], [Price]) VALUES (6, 1, 11, 1, 120000)
INSERT [dbo].[Tickets] ([ID], [ShowtimeID], [SeatID], [Status], [Price]) VALUES (7, 1, 17, 1, 120000)
INSERT [dbo].[Tickets] ([ID], [ShowtimeID], [SeatID], [Status], [Price]) VALUES (8, 1, 16, 1, 120000)
INSERT [dbo].[Tickets] ([ID], [ShowtimeID], [SeatID], [Status], [Price]) VALUES (9, 1, 15, 1, 120000)
INSERT [dbo].[Tickets] ([ID], [ShowtimeID], [SeatID], [Status], [Price]) VALUES (10, 1, 12, 1, 120000)
INSERT [dbo].[Tickets] ([ID], [ShowtimeID], [SeatID], [Status], [Price]) VALUES (11, 1, 13, 1, 120000)
SET IDENTITY_INSERT [dbo].[Tickets] OFF
SET IDENTITY_INSERT [dbo].[Timeslots] ON 

INSERT [dbo].[Timeslots] ([ID], [BeginTime], [EndTime], [IsEnable]) VALUES (1, CAST(N'2019-07-24 07:00:00.000' AS DateTime), CAST(N'2019-07-24 09:00:00.000' AS DateTime), 1)
INSERT [dbo].[Timeslots] ([ID], [BeginTime], [EndTime], [IsEnable]) VALUES (2, CAST(N'2019-07-24 10:00:00.000' AS DateTime), CAST(N'2019-07-24 12:00:00.000' AS DateTime), 1)
INSERT [dbo].[Timeslots] ([ID], [BeginTime], [EndTime], [IsEnable]) VALUES (3, CAST(N'2019-07-24 13:00:00.000' AS DateTime), CAST(N'2019-07-24 15:00:00.000' AS DateTime), 1)
INSERT [dbo].[Timeslots] ([ID], [BeginTime], [EndTime], [IsEnable]) VALUES (4, CAST(N'2019-07-24 16:00:00.000' AS DateTime), CAST(N'2019-07-24 18:00:00.000' AS DateTime), 1)
INSERT [dbo].[Timeslots] ([ID], [BeginTime], [EndTime], [IsEnable]) VALUES (5, CAST(N'2019-07-24 19:00:00.000' AS DateTime), CAST(N'2019-07-24 21:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Timeslots] OFF
SET IDENTITY_INSERT [dbo].[User_Ticket] ON 

INSERT [dbo].[User_Ticket] ([ID], [UserID], [TicketID], [Booktime], [IsEnable]) VALUES (1, 2, 1, CAST(N'2019-07-24 15:32:12.797' AS DateTime), 1)
INSERT [dbo].[User_Ticket] ([ID], [UserID], [TicketID], [Booktime], [IsEnable]) VALUES (2, 2, 2, CAST(N'2019-07-24 15:39:05.507' AS DateTime), 1)
INSERT [dbo].[User_Ticket] ([ID], [UserID], [TicketID], [Booktime], [IsEnable]) VALUES (3, 2, 3, CAST(N'2019-07-24 15:41:51.357' AS DateTime), 1)
INSERT [dbo].[User_Ticket] ([ID], [UserID], [TicketID], [Booktime], [IsEnable]) VALUES (4, 2, 4, CAST(N'2019-07-24 17:01:00.547' AS DateTime), 1)
INSERT [dbo].[User_Ticket] ([ID], [UserID], [TicketID], [Booktime], [IsEnable]) VALUES (5, 2, 5, CAST(N'2019-07-24 17:15:11.947' AS DateTime), 1)
INSERT [dbo].[User_Ticket] ([ID], [UserID], [TicketID], [Booktime], [IsEnable]) VALUES (6, 2, 6, CAST(N'2019-07-24 17:19:20.573' AS DateTime), 1)
INSERT [dbo].[User_Ticket] ([ID], [UserID], [TicketID], [Booktime], [IsEnable]) VALUES (7, 2, 7, CAST(N'2019-07-24 17:20:37.617' AS DateTime), 1)
INSERT [dbo].[User_Ticket] ([ID], [UserID], [TicketID], [Booktime], [IsEnable]) VALUES (8, 2, 8, CAST(N'2019-07-24 17:20:52.893' AS DateTime), 1)
INSERT [dbo].[User_Ticket] ([ID], [UserID], [TicketID], [Booktime], [IsEnable]) VALUES (9, 3, 9, CAST(N'2019-07-26 12:44:10.573' AS DateTime), 1)
INSERT [dbo].[User_Ticket] ([ID], [UserID], [TicketID], [Booktime], [IsEnable]) VALUES (10, 3, 10, CAST(N'2019-07-26 16:24:06.883' AS DateTime), 1)
INSERT [dbo].[User_Ticket] ([ID], [UserID], [TicketID], [Booktime], [IsEnable]) VALUES (11, 3, 11, CAST(N'2019-07-26 16:54:22.230' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[User_Ticket] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Username], [Password], [Fullname], [Gender], [Birthdate], [Phone], [RoleID], [IsEnable]) VALUES (1, N'admin', N'admin123', N'admin', 0, CAST(N'1999-01-01 00:00:00.000' AS DateTime), N'0123456789', 1, 1)
INSERT [dbo].[Users] ([ID], [Username], [Password], [Fullname], [Gender], [Birthdate], [Phone], [RoleID], [IsEnable]) VALUES (2, N'user', N'123456', N'customer', 1, CAST(N'1998-01-01 00:00:00.000' AS DateTime), N'0987654321', 2, 1)
INSERT [dbo].[Users] ([ID], [Username], [Password], [Fullname], [Gender], [Birthdate], [Phone], [RoleID], [IsEnable]) VALUES (3, N'user2', N'123456', N'customer2', 0, CAST(N'1997-01-01 00:00:00.000' AS DateTime), N'0132459876', 2, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
