SET IDENTITY_INSERT [dbo].[pizzas] ON
INSERT INTO [dbo].[pizzas] ([Id], [name], [ingredients], [photo], [price]) VALUES (1, N'Pizza Margherita', N'Pomodori pelati,Mozzarella di bufala,Basilico,Olio EVO', N'margherita.jpg', CAST(4.50 AS Decimal(5, 2)))
INSERT INTO [dbo].[pizzas] ([Id], [name], [ingredients], [photo], [price]) VALUES (3, N'Speck e Gorgonzola', N'Fior di latte d''Agerola,Speck IGP,Gorgonzola,Basilico,Olio EVO', N'speck.jpg', CAST(8.00 AS Decimal(5, 2)))
INSERT INTO [dbo].[pizzas] ([Id], [name], [ingredients], [photo], [price]) VALUES (4, N'Pizza Calabria', N'Pomodori pelati,Fior di latte d''Agerola,''Nduja di Spilinfa,Caciocavallo,Basilico,Olio EVO', N'calabria.jpg', CAST(6.50 AS Decimal(5, 2)))
INSERT INTO [dbo].[pizzas] ([Id], [name], [ingredients], [photo], [price]) VALUES (6, N'Pizza Sicilia', N'Pomodori pelati,Melanzane,Scaglie di ricotta,Basilico,Olio EVO', N'sicilia.jpg', CAST(7.50 AS Decimal(5, 2)))
INSERT INTO [dbo].[pizzas] ([Id], [name], [ingredients], [photo], [price]) VALUES (7, N'Pizza Puglia', N'Datterini  gialli,Capocollo di Martina Franca,Burrata pugliese,Olive,Tarallo sbriciolato,Basilico,Olio EVO', N'puglia.jpg', CAST(8.50 AS Decimal(5, 2)))
INSERT INTO [dbo].[pizzas] ([Id], [name], [ingredients], [photo], [price]) VALUES (8, N'Pizza Emilia', N'Fior di latte d''Agerola,Mortadella IGP,Granella di pistacchio,Basilico,Olio EVO', N'emilia.jpg', CAST(7.00 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[pizzas] OFF
