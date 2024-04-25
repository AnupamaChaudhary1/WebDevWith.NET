# Web Devlopment With.NET

1. WWW- early 1990's
1. ASP -MS, JSP -SUN 
1. .NET Framework -Early 2000's -Windows only, last version 4.8 
1. ASP.NET (Web Forms)
1. MVC - Model view Controller - 2006-7
1. ASP.NET -2008 

1. 2015/16 - .NET Core (Cross platform, opensource)
1. ASP.net core 
1. 2020 - .net 5, 2021 .net 6, 22 7, 23 8, 24 9

## SDLC
### Environments ( physical server and app urls)
collegemonitor - https://collegemonitor.com
1. Developer - local : dev environment (local host)
1. QA -code changes deployed, test environment (https://tst.collegemonitor.com)
1. INT - all code changes, Integration environment (https://int.collegemonitor.com)
1. UAT - PD/TPO/BA user acceptance testing (https://uat.collegemonitor.com)
1. PROD -production environment  (https://collegemonitor.com)

# College monitor requirements

## entities/tables/models
1. class - Id, title, start,duration,details
1. course - id, name,  textbook,credithours, syllabus 
1. student - id, name, address, email, program, semestar

> coures has multiple classes( one to many)
> student may enroll on multiple courses and a coures can be enrolled by multiple students(many to many)
