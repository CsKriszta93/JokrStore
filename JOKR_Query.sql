DROP TABLE Games
CREATE TABLE Games
(id uniqueidentifier DEFAULT NEWID(),
GameName varchar(50) not null,
Developer varchar(50) not null,
CoverArt varchar(50),
[Description] varchar(MAX),
Rate float,
Price decimal not null,
Release DateTime,
DownloadLink varchar(50),
DemoLink varchar(50),
NumOfDownloads int not null,
MinSysReqId uniqueidentifier,
RecSysReqId uniqueidentifier)

INSERT INTO Games (Id, GameName, Developer, CoverArt, [Description], Rate, Price, Release, DownloadLink, DemoLink, NumOfDownloads, MinSysReqId, RecSysReqId) VALUES
(NEWID(), 'Far Cry', 'Ubisoft', 'images/far_cry.jpg', 'Welcome to Hope County, Montana, home to a fanatical doomsday cult known as Eden’s Gate. Stand up to cult leader Joseph Seed & his siblings, the Heralds, to spark the fires of resistance & liberate the besieged community.',
3.5, 8000, '2004-06-01', 'far_fry.exe', NULL, 0, NULL, NULL),
(NEWID(), 'Crysis', 'Crytek', 'images/crysis.jpg', 'Welcome to the spiritual sequel of Far Cry.', 4.5, 8000, '2007-11-01', 'crysis.exe', NULL, 0, NULL, NULL),
(NEWID(), 'Far Cry 2', 'Ubisoft', 'images/far_cry_2.jpg', 'Welcome to in Africa.', 4.0, 8000, '2008-11-01', 'far_cry2.exe', NULL, 0, NULL, NULL)

SELECT *
FROM Games

INSERT INTO [StoreUsers] (Id, UserName, [Password], Email, Facebook, Registration, BankAccount, isAdmin, lastLogin, ConfigId) VALUES
('CCA1ACA6-5ABB-46EC-9871-75AC57048294', 'asd123', '123456', 'asd123@freemail.hu', 'asd123', '2018-04-01', null, 0, '2018-04-03', NEWID()),
('47E56AD3-C80C-4C40-8C90-AF004A8A51D4','ghj123', 'starwars', 'ghj123@citromail.hu', 'ghj123', '2018-04-01', null, 0, '2018-04-04', NEWID()),
('2CF0065C-49C6-4B48-A093-CB617C09DC30','Pistike', 'qwertz', 'Pistike@gmail.com', 'Pistike.3', '2018-04-02', null, 0, '2018-04-03', NEWID())

Select *
from StoreUsers

INSERT INTO Comments (CommentId, Commenter, GameId, CommentDate, Contain) VALUES
(NEWID(), 'CCA1ACA6-5ABB-46EC-9871-75AC57048294', '7A477BCF-43AF-437A-875F-7E4C5E5096D4', '2018-04-02', 'Awesame game'),
(NEWID(), '47E56AD3-C80C-4C40-8C90-AF004A8A51D4', '7A477BCF-43AF-437A-875F-7E4C5E5096D4', '2018-04-02', 'Far Cry is my favorite game'),
(NEWID(), '2CF0065C-49C6-4B48-A093-CB617C09DC30', '7A477BCF-43AF-437A-875F-7E4C5E5096D4', '2018-04-03', 'Not working for me :(')

SELECT *
FROM Comments

INSERT INTO MEDIA VALUES
(NEWID(), 'afcb149d-7899-473c-8213-13de068675ab', 0, '1.jpg'),
(NEWID(), 'afcb149d-7899-473c-8213-13de068675ab', 0, '2.jpg'),
(NEWID(), 'afcb149d-7899-473c-8213-13de068675ab', 0, '3.jpg'),
(NEWID(), 'afcb149d-7899-473c-8213-13de068675ab', 0, '4.jpg'),
(NEWID(), 'afcb149d-7899-473c-8213-13de068675ab', 0, '5.jpg'),
(NEWID(), 'afcb149d-7899-473c-8213-13de068675ab', 0, '6.jpg')