DROP TABLE FAQ

CREATE TABLE FAQ (
	id int not null PRIMARY KEY IDENTITY(1,1),
	question varchar(100) not null,
	reponse varchar(100) not null
);

DROP TABLE users

CREATE TABLE users (
	id int not null PRIMARY KEY IDENTITY(1,1),
	nom varchar(100) not null,
	prenom varchar(100) not null,
	numeroStatut int not null,
	mail varchar(100) not null,
	mdp varchar(100) not null
);

DROP TABLE statut

CREATE TABLE statut (
	id int not null PRIMARY KEY IDENTITY(1,1),
	nom varchar(100) not null
);

DROP TABLE ressources

CREATE TABLE ressources (
	id int not null PRIMARY KEY IDENTITY(1,1),
	titre varchar(100) not null,
	categorie int not null,
	tags varchar(200) not null,
	[description] varchar(100) not null,
	images varchar(200) not null,
	contenu varchar(200) not null,
	trailerVideo varchar(200),
	nbEpisode int,
	nbSaison int
);

DROP TABLE images

CREATE TABLE images (
	id int not null PRIMARY KEY IDENTITY(1,1),
	[url] varchar(100) not null,
	type varchar(100) not null
);

DROP TABLE tags

CREATE TABLE tags (
	id int not null PRIMARY KEY IDENTITY(1,1),
	nom varchar(100) not null,
	[description] varchar(100) not null
);

DROP TABLE categorie

CREATE TABLE categorie (
	id int not null PRIMARY KEY IDENTITY(1,1),
	nom varchar(100) not null,
	[description] varchar(100) not null
);