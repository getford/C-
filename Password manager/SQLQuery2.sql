-- вставить открытие ключа перед insert, select ...
open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$'

-- проверяем, открыт ли ключ
select * from [sys].[openkeys]
