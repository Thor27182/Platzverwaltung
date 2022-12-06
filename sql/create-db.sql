CREATE DATABASE platzverwaltung;

CREATE TABLE rights(
	rights VARCHAR(255),
  	PRIMARY KEY (rights)
);

CREATE TABLE roles(
  role VARCHAR(255),
  PRIMARY KEY (role)
);

CREATE TABLE users(
  username VARCHAR(255),
  role VARCHAR(255) NOT NULL,
  password VARCHAR(64) NOT NULL,
  first_name VARCHAR(255)NOT NULL,
  middle_names VARCHAR(255),
  last_name VARCHAR(255)NOT NULL,
  date_of_birth DATE NOT NULL,
  country VARCHAR(255)NOT NULL,
  street VARCHAR(255) NOT NULL,
  street_number int NOT NULL,
  postal_code VARCHAR(5) NOT NULL,
  city VARCHAR(255) NOT NULL,
  iban VARCHAR(22) NOT NULL,
  PRIMARY KEY (username),
  FOREIGN KEY (role) REFERENCES roles(role)
);
  
CREATE TABLE rights_roles(
  rights VARCHAR(255),
  role VARCHAR(255),
  PRIMARY KEY (rights, role),
  FOREIGN KEY (rights) REFERENCES rights(rights),
  FOREIGN KEY (role) REFERENCES roles(role)
);

CREATE TABLE users_roles(
  username VARCHAR(255),
  role VARCHAR(255),
  PRIMARY KEY (username, role),
  FOREIGN KEY (username) REFERENCES users(username),
  FOREIGN KEY (role) REFERENCES roles(role)
);

CREATE TABLE tennis_courts(
  court_number INT AUTO_INCREMENT,
  court_description VARCHAR(1000),
  PRIMARY KEY (court_number)
);

CREATE TABLE bills(
  bill_id INT AUTO_INCREMENT,
  username VARCHAR(255) NOT NULL,
  amount DECIMAL NOT NULL,
  PRIMARY KEY (bill_id),
  FOREIGN KEY (username) REFERENCES users(username)
);  
  
CREATE TABLE bookings(
  booking_id INT AUTO_INCREMENT,
  bill_id INT,
  username VARCHAR(255) NOT NULL,
  court_number INT NOT NULL,
  date_start DATE NOT NULL,
  date_end DATE NOT NULL,
  PRIMARY KEY (booking_id),
  FOREIGN KEY (bill_id) REFERENCES bills(bill_id),
  FOREIGN KEY (username) REFERENCES users(username)
);
