if not exists(select * from sys.databases where name = 'QuizResult') create database QuizResult;

use QuizResult;

create table Results (
	id bigint NOT NULL IDENTITY(1, 1),
	course_title nvarchar(512),
	completed BIT DEFAULT 0,
	student_email nvarchar(255),
	student_name nvarchar(255),
	start_time datetime,
	end_time datetime,
	attempt_number int default 0,
	quiz_result text,
	PRIMARY KEY (id)
);