create database CampusHealthService;
use CampusHealthService;

create table patients
(
Patient_ID int auto_increment primary key,
StudentORStaff_Number varchar(10),
Full_Name varchar(100),
Contact_Number varchar(20),
PasswordCode varchar(20),
Email varchar(100)
);

create table appointment_slots
(
Slot_ID int primary key auto_increment,
Slot_date date,
Services varchar(50),
Start_Time time,
End_Time time,
Is_Available varchar(3),
Created_by varchar(50)
);


create table appointments
(
Appointment_ID int primary key auto_increment,
Patient_ID int not null,
foreign key(Patient_ID) references patients(Patient_ID),
Slot_ID int not null,
foreign key(Slot_ID) references appointment_slots(Slot_ID),
Appointment_Type varchar(50),
Appointment_Status varchar(50),
Date_Created datetime DEFAULT CURRENT_TIMESTAMP
);


create table reschedules
(
Change_ID int primary key auto_increment,
Appointment_ID int not null,
foreign key(Appointment_ID) references appointments(Appointment_ID),
Change_Type varchar(50),
Original_Slot_ID int not null,
foreign key(Original_Slot_ID) references appointment_slots(Slot_ID),
New_Slot_ID int null,
foreign key(New_Slot_ID) references appointment_slots(Slot_ID),
Change_Date datetime DEFAULT CURRENT_TIMESTAMP
);

create table emergency
(
Emergency_ID int auto_increment primary key,
Appointment_ID int not null,
foreign key(Appointment_ID)references appointments(Appointment_ID),
Urgent_Classification varchar(50),
Recorded_By varchar(50),
Date_recorded datetime default current_timestamp
);

create table followUp
(
Followup_ID int auto_increment primary key,
Appointment_ID int not null,
foreign key (Appointment_ID) references appointments(Appointment_ID),
Followup_Date date,
Note_Instructions Text,
Recorded_By varchar(50)
);

create table report_log
(
Report_ID int auto_increment primary key,
Report_Type varchar(50) not null,
Date_Generated datetime default current_timestamp,
Generated_By varchar(50) not null
);

create table backup_log
(
Backup_ID int auto_increment primary key,
Backup_DateTime datetime default current_timestamp,
Backup_Location varchar(200) not null,
Backup_Status varchar(50) not null
);

INSERT INTO patients
(
    StudentORStaff_Number,
    Full_Name,
    Contact_Number,
    PasswordCode,
    Email
)
VALUES
(
    '12345678',
    'John Doe',
    '0712345678',
    '1234',
    'john@gmail.com'
);