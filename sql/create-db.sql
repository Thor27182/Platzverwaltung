CREATE DATABASE platzverwaltung;

CREATE TABLE rolls(
  roll VARCHAR(255),
  PRIMARY KEY (roll)
);

CREATE TABLE users(
  username VARCHAR(255),
  roll VARCHAR(255),
  password VARCHAR(255) NOT NULL,
  first_name VARCHAR(255),
  middle_names VARCHAR(255),
  last_name VARCHAR(255),
  date_of_birth DATE,
  country VARCHAR(255),
  street VARCHAR(255),
  street_number int,
  postal_code VARCHAR(5),
  city VARCHAR(255),
  iban VARCHAR(22),
  PRIMARY KEY (username),
  FOREIGN KEY (roll) REFERENCES rolls(roll)
);
  

CREATE TABLE tennis_courts(
  court_number int,
  court_description VARCHAR(1000),
  PRIMARY KEY (court_number)
);