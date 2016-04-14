-- Создадим главный ключ DMK и зашифруем ЕГО(ключ) с помощью пароля
create master key encryption by password = '%(wbwgoo$'
--Создание асимметричного ключа, зашифрованного парольной фразой: %(wbwgoo$
create asymmetric key ASYMMETRIC_KEY with algorithm = RSA_2048 encryption by password = '%(wbwgoo$'
-- Создание симметричного ключа, зашифрованного асимметричным ключом.
create symmetric key SYMMETRIC_KEY with algorithm = AES_256 encryption by asymmetric key ASYMMETRIC_KEY


----------------------------- ПРИСТУПАЕМ К ШИФРОВАНИЮ ДАННЫХ -------------------------

/*
	Cначала открываем симметричный ключ, 
	Указываем имя симметричного ключа. 
	Указываем, что нужно расшифровать его с использованием заданного асимметричного ключа. 
*/

-- вставить открытие ключа перед insert, select ...
open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$'

-- проверяем, открыт ли ключ
select * from [sys].[openkeys]

