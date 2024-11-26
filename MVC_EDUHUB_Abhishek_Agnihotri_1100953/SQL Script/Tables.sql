use Eduhubbb;


create table users (
userId int primary key identity(1,1),
username varchar(40) unique not null,
FullName varchar(40),
password varchar(20) not null,
role varchar(20) not null,
email varchar(100) unique not null,
mobile_number varchar(20),
profileImage varchar(200)
)

create table Enrollments(
enrollmentId int primary key identity(1,1),
userId int,
courseId int,
enrollmentDate datetime,
status varchar(70)
);

CREATE TABLE Materials (
    materialId INT PRIMARY KEY identity(1,1),
    courseId INT,
    title VARCHAR(255),
    description VARCHAR(300),
    URL VARCHAR(255),
    uploadDate DATE,
    contentType VARCHAR(50),
);

CREATE TABLE Enquiries (
    enquiryId INT PRIMARY KEY identity(1,1),
    userId INT,
    courseId INT NULL,
    subject VARCHAR(255),
    message VARCHAR(200),
    enquiryDate DATETIME,
    status VARCHAR(50),
    response VARCHAR(200) NULL,
);

CREATE TABLE Feedbacks (
    feedbackId INT PRIMARY KEY identity(1,1),
    userId INT,
    feedback TEXT,
    date DATE,
);


create table courses(
courseId int primary key identity(1,1),
title varchar(50),
description varchar(250),
courseStartDate datetime,
courseEndDate datetime,
userId int,
category varchar(50),
level varchar(40),
);


insert into users(username,password,role,email,mobile_number) values
('abhi_agni','xyz','admin','abhishek2@gmail.com','9098080785'),
('utkar23','xyz','user','abhis23k@gmail.com','9098080785'),
('abih123','xyz','user','abhihek@gmail.com','9098080785'),
('atuuul','xyz','user','abhi12ek@gmail.com','9098080785'),
('atul23','xyz','user','ab12hiek@gmail.com','9098080785'),
('atuuuul00','xyz','user','abhis213k@gmail.com','9098080785'),
('atuuuuuul','xyz','user','abhi123@gmail.com','9098080785'),
('adsfbhi','xyz','user','abhishek323@gmail.com','9098080785'),
('989abhi','xyz','user','abh345ik@gmail.com','9098080785'),
('babycoder','xyz','user','abhishek12@gmail.com','9098080785'),
('codercoding','xyz','user','a4ishe6k@gmail.com','9098080785');

--insert into courses(title,description,courseStartDate,courseEndDate,userId,category,level) values()

INSERT INTO Courses (title, description, courseStartDate, courseEndDate, userId, category, level)
VALUES 
('Introduction to Python', 'Learn Python basics', '2024-09-01', '2024-12-15', 2, 'Programming', 'Beginner'),
('Advanced Machine Learning', 'Deep dive into ML', '2024-09-15', '2025-01-30', 4, 'Data Science', 'Advanced'),
('Web Development Fundamentals', 'HTML, CSS, and JavaScript', '2024-10-01', '2024-12-31', 2, 'Web Development', 'Beginner'),
('Data Structures and Algorithms', 'Core CS concepts', '2024-09-15', '2025-02-28', 4, 'Computer Science', 'Intermediate'),
('Digital Marketing Basics', 'Introduction to digital marketing', '2024-09-01', '2024-11-30', 6, 'Marketing', 'Beginner'),
('Artificial Intelligence Ethics', 'Ethical considerations in AI', '2024-10-15', '2025-01-15', 8, 'Ethics', 'Intermediate'),
('Mobile App Development', 'Build apps for iOS and Android', '2024-11-01', '2025-03-31', 10, 'Mobile Development', 'Intermediate'),
('Cybersecurity Fundamentals', 'Basic principles of information security', '2024-09-15', '2024-12-15', 6, 'Cybersecurity', 'Beginner'),
('Cloud Computing Essentials', 'Introduction to cloud technologies', '2024-10-01', '2025-01-31', 8, 'Cloud Computing', 'Intermediate'),
('Blockchain Technology', 'Understanding blockchain and cryptocurrencies', '2024-11-15', '2025-03-15', 10, 'Blockchain', 'Advanced');

INSERT INTO Enrollments (userId, courseId, enrollmentDate, status)
VALUES 
    (1, 1, '2024-01-15 09:30:00', 'Active'),
    (2, 2, '2024-01-20 14:45:00', 'Active'),
    (3, 3, '2024-02-01 10:00:00', 'Completed'),
    (4, 4, '2024-02-10 16:30:00', 'Active'),
    (5, 5, '2024-03-01 11:15:00', 'On Hold'),
    (6, 1, '2024-03-15 13:00:00', 'Active'),
    (7, 2, '2024-04-01 09:45:00', 'Withdrawn'),
    (8, 3, '2024-04-10 15:30:00', 'Active'),
    (9, 4, '2024-05-01 10:30:00', 'Completed'),
    (10, 5, '2024-05-15 14:00:00', 'Active');

INSERT INTO Materials (courseId, title, description, URL, uploadDate, contentType)
VALUES 
(1, 'Introduction to SQL', 'Basic SQL concepts', 'https://example.com/sql-intro', '2024-01-15', 'Video'),
(1, 'Advanced SQL Queries', 'Complex SQL queries explained', 'https://example.com/advanced-sql', '2024-01-20', 'PDF'),
(2, 'Python Basics', 'Getting started with Python', 'https://example.com/python-basics', '2024-02-01', 'Interactive'),
(2, 'Python Data Structures', 'Lists, tuples, and dictionaries', 'https://example.com/python-data-structures', '2024-02-10', 'Video'),
(3, 'Machine Learning Fundamentals', 'Introduction to ML concepts', 'https://example.com/ml-fundamentals', '2024-03-01', 'PDF'),
(3, 'Neural Networks', 'Deep dive into neural networks', 'https://example.com/neural-networks', '2024-03-15', 'Interactive'),
(4, 'Web Development Basics', 'HTML, CSS, and JavaScript', 'https://example.com/web-dev-basics', '2024-04-01', 'Video'),
(4, 'Responsive Design', 'Creating responsive websites', 'https://example.com/responsive-design', '2024-04-10', 'PDF'),
(5, 'Data Visualization', 'Techniques for effective data viz', 'https://example.com/data-viz', '2024-05-01', 'Interactive'),
(5, 'Dashboard Design', 'Creating impactful dashboards', 'https://example.com/dashboard-design', '2024-05-15', 'Video');

-- Insert 10 records into the Enquiry table
INSERT INTO Enquiries (userId, courseId, subject, message, enquiryDate, status, response)
VALUES 
(1, 1, 'SQL Course Question', 'Is prior programming experience needed?', '2024-01-16 10:30:00', 'Answered', 'No prior experience needed.'),
(2, 2, 'Python Course Difficulty', 'How challenging is the Python course?', '2024-02-05 14:45:00', 'Pending', NULL),
(3, 3, 'ML Prerequisites', 'What math knowledge is required for ML?', '2024-03-10 09:15:00', 'Answered', 'Basic calculus and linear algebra recommended.'),
(4, 4, 'Web Dev Tools', 'Which IDE do you recommend for web development?', '2024-04-05 16:20:00', 'Answered', 'We recommend Visual Studio Code.'),
(5, 5, 'Data Viz Software', 'Do we need to purchase any software?', '2024-05-05 11:00:00', 'Pending', NULL),
(6, NULL, 'Course Recommendations', 'Which course is best for a beginner?', '2024-06-01 13:30:00', 'Answered', 'We suggest starting with Python Basics.'),
(7, 1, 'SQL Course Duration', 'How long does it take to complete the SQL course?', '2024-06-15 10:00:00', 'Pending', NULL),
(8, 2, 'Python Project Help', 'Can I get help with my Python project?', '2024-07-01 15:45:00', 'Answered', 'Yes, we offer project support.'),
(9, 3, 'Machine Learning Job Prospects', 'What are the job opportunities after this course?', '2024-07-10 09:30:00', 'Pending', NULL),
(10, 4, 'Web Dev Course Update', 'When will the course content be updated?', '2024-08-01 14:00:00', 'Answered', 'The course will be updated next month.');

-- Insert 10 records into the Feedback table
INSERT INTO Feedbacks (userId, feedback, date)
VALUES 
(1, 'The SQL course was very informative and well-structured.', '2024-02-01'),
(2, 'I found the Python basics easy to follow. Great for beginners!', '2024-03-15'),
(3, 'The Machine Learning course was challenging but rewarding.', '2024-04-20'),
(4, 'Web Development basics helped me kickstart my project.', '2024-05-10'),
(5, 'Data Visualization techniques were eye-opening. Loved the course!', '2024-06-05'),
(6, 'The SQL advanced queries section could use more examples.', '2024-06-20'),
(7, 'Python Data Structures course was comprehensive. Highly recommend!', '2024-07-15'),
(8, 'Neural Networks module was a bit too fast-paced for me.', '2024-08-01'),
(9, 'Responsive Design course gave me skills I use daily now.', '2024-08-15'),
(10, 'Dashboard Design course was practical and immediately useful.', '2024-09-01');