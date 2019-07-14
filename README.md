# ExamenFinalADSMario

 
Pegunta 1.  
Optimizar :



SELECT *
FROM Students c1
join (select c2.student_id from students c2  
WHERE  SUBSTRING(email, 0, CHARINDEX('@', email, 0)) = 'JPerez')
as c3 on c1.student_id = c3.student_id



Pregunta 2

Respuestas:

Database migrations: 

Sirve para migrar y crear tablas dinamicamente apartir de un Query.

Continuous integration, deployment and delivery:

Integracion Continua sirve para compilar y desplegar en automatico.
deployment and delivery: Generalmente se realiza en produccion, no es un pase automatico, es manual, para el despliegue en produccion.

Clean and scalable architecture:
Arquitectura limpia , codigo optimizado, y scalable de manera horizontal o vertical  un incoveniente, 
un ejemplo:
-Base de Datos.
-Informacion en Cache.
-Servidores.


Pregunta 3.
WEB API
