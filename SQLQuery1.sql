
ALTER TABLE Emleados
ALTER COLUMN Cedula varchar(50)




CREATE TABLE  Stok(
 ID INT PRIMARY KEY IDENTITY(1,1),
 FechadefACTURA varchar(200),
 Descrip varchar(5000)
)

    select * from Stok

   UPDATE Stok set FechadefACTURA  = '7&78', Descrip = '' where ID = 2



