-- Users table
CREATE TABLE Users (
    user_id INT PRIMARY KEY IDENTITY,
    user_name VARCHAR(100),
    user_email VARCHAR(100),
    user_password VARCHAR(100)
);

-- Activities table
CREATE TABLE Activities (
    activity_id INT PRIMARY KEY IDENTITY,
    activity_title VARCHAR(100),
    activity_description VARCHAR(255),
    activity_category VARCHAR(100),
    activity_price REAL,
    activity_location VARCHAR(100)
);

-- Availability table
CREATE TABLE Availability (
    availability_id INT PRIMARY KEY IDENTITY,
    activity_id INT,
    availability_date DATE,
    FOREIGN KEY (activity_id) REFERENCES Activities(activity_id)
);

-- Comments table
CREATE TABLE Comments (
    comment_id INT PRIMARY KEY IDENTITY,
    user_id INT,
    activity_id INT,
    comment_content VARCHAR(255),
    comment_rating INT,
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (activity_id) REFERENCES Activities(activity_id)
);

-- Reservations table
CREATE TABLE Reservations (
    reservation_id INT PRIMARY KEY IDENTITY,
    user_id INT,
    activity_id INT,
    reservation_date DATE,
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (activity_id) REFERENCES Activities(activity_id)
);
