--	Realizar un script SQL para determinar cuántos puestos hay por empresa.
select t.puestos,t.empresa from 
(select COUNT(1) puestos, p.EmpresaID,e.Nombre empresa 
from TblPuestos p inner join TblEmpresas e on (p.EmpresaID = e.EmpresaID)  
group by p.EmpresaID, e.Nombre) t

--	Realizar una script SQL para modificar el nombre incorrecto de la empresa 01.
update TblEmpresas set Nombre = 'Empresa de Evaluaciones Modified' where EmpresaCodigo = '01';
select * from TblEmpresas;

--	Realizar un script SQL para determinar cuántos puestos están activos por empresa.
select COUNT(1) puestos_activos, EmpresaID
from TblPuestos 
where FechaDeBaja is not null
group by EmpresaID;

--	Realizar un script SQL para determinar el porcentaje de puestos con fecha de baja en relación con el total por empresa.
Select EmpresaID, CAST(Count(PuestoID)* 1000 / (Select Count(*) From TblPuestos where FechaDeBaja is not null)AS FLOAT )/10 as Score
From TblPuestos
where FechaDeBaja is not null
Group By EmpresaID;