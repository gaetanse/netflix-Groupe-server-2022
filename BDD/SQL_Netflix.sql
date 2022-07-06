DROP TABLE FAQ

CREATE TABLE FAQ (
	id int not null PRIMARY KEY IDENTITY(1,1),
	question varchar(100) not null,
	response varchar(100) not null
);

DROP TABLE users

CREATE TABLE users (
	id int not null PRIMARY KEY IDENTITY(1,1),
	lastname varchar(100) not null,
	firstname varchar(100) not null,
	numberstatut int not null,
	mail varchar(100) not null,
	[password] varchar(100) not null
);

DROP TABLE statut

CREATE TABLE statut (
	id int not null PRIMARY KEY IDENTITY(1,1),
	[name] varchar(100) not null
);

DROP TABLE ressources

CREATE TABLE ressources (
	id int not null PRIMARY KEY IDENTITY(1,1),
	title varchar(100) not null,
	categorie int not null,
	tags varchar(200) not null,
	[description] varchar(100) not null,
	content varchar(200) not null,
	trailervideo varchar(200),
	nbepisode int,
	nbseason int
);

DROP TABLE images

CREATE TABLE images (
	id int not null PRIMARY KEY IDENTITY(1,1),
	[url] varchar(100) not null,
	[type] varchar(100) not null,
	ressourceId int not null
);

DROP TABLE tags

CREATE TABLE tags (
	id int not null PRIMARY KEY IDENTITY(1,1),
	[name] varchar(100) not null,
	[description] varchar(100) not null
);

DROP TABLE categorie

CREATE TABLE categorie (
	id int not null PRIMARY KEY IDENTITY(1,1),
	[name] varchar(100) not null,
	[description] varchar(100) not null
);