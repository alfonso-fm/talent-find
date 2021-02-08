INSERT INTO CompanySizes (Id, Description)
VALUES (1, 'Pequeña'), (2, 'Mediana'), (3, 'Grande');

INSERT INTO CompanyTypes (Id, Description)
VALUES (1, 'Servicios'), (2, 'Productos'), (3, 'Hibrida');

INSERT INTO Companies (Id, Name, BusinessName, CompanyTypeId, CompanySizeId)
VALUES (1, 'Bimbo', 'Bimbo Services S.A de C.V', 3, 3);