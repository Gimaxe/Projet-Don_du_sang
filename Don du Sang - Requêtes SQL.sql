--CREATE TABLE Donneur(
--   Id_Donneur INT IDENTITY,
--   Prenom VARCHAR(50) NOT NULL,
--   Nom VARCHAR(50) NOT NULL,
--   AdresseMail VARCHAR(50) NOT NULL,
--   DateDeNaissance DATE NOT NULL,
--   MotDePasse VARCHAR(100) NOT NULL,
--   EstDAccord VARCHAR(50) NOT NULL,
--   PRIMARY KEY(Id_Donneur)
--);

--CREATE TABLE Question(
--   Id_Question INT IDENTITY,
--   Numero VARCHAR(50) NOT NULL,
--   Categorie VARCHAR(50) NOT NULL,
--   Enonce VARCHAR(50) NOT NULL,
--   EstEliminatoire BIT,
--   PRIMARY KEY(Id_Question)
--);

--CREATE TABLE Reponse(
--   Id_Reponse INT IDENTITY,
--   Reponse BIT NOT NULL,
--   PrecisionPourMedecin VARCHAR(max),
--   Id_Donneur INT NOT NULL,
--   Id_Question INT NOT NULL,
--   PRIMARY KEY(Id_Reponse),
--   FOREIGN KEY(Id_Donneur) REFERENCES Donneur(Id_Donneur),
--   FOREIGN KEY(Id_Question) REFERENCES Question(Id_Question)
--);

INSERT INTO Question (Numero, Categorie, Enonce, EstElimanatoire) VALUES
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','Vous sentez-vous en forme pour donner votre sang ?','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');
('1','ÉTAT DE SANTÉ POUR POUVOIR DONNER DU SANG','','');