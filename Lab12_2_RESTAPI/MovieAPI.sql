create database lotsofmovies;

use lotsofmovies;

create table movie (
id int not null auto_increment,
title varchar(50) not null,
actor varchar(50) not null,
category varchar(20) not null,
director varchar(50) not null,
primary key(id)
);

insert into movie (title, actor, category, director) values ('The Rock','Nicolas Cage','Action','Michael Bay');
insert into movie (title, actor, category, director) values ('A Quiet Place','Emily Blunt','Horror','Michael Bay');
insert into movie (title, actor, category, director) values ('Songbird', 'KJ Apa', 'Thriller','Michael Bay');
insert into movie (title, actor, category, director) values ('Con Air','Nicolas Cage','Action','Simon West');
insert into movie (title, actor, category, director) values ('I Am Number Four','Alex Pettyfer','Scifi','Michael Bay');
insert into movie (title, actor, category, director) values ('Seven Samari','Toshiro Mifune','Drama','Akira Kurosawa');
insert into movie (title, actor, category, director) values ('The Magnificent Seven','Yul Brenner','Western','John Sturges');
insert into movie (title, actor, category, director) values ('The Magnificent Seven','Denzel Washington','Western','Antoine Fuqua');

select * from movie where category = 'Action';

select * from movie;