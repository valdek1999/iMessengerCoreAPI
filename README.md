# iMessengerCoreAPI

iMessengerCoreAPI - это web-api сервис в котором реализован метод API поиска диалога с теми идентификаторами клиентов, которые были переданы в метод.


Метод - HTTP GET: /api/dialogs/dialogID принимает список идентфикаторов клиентов типа GUID для которых необходимо найти диалог.
После находит такой диалог, в котором есть все переданные клиенты. 
Если такого диалога нет, то возвращается пустой GUID.


Cписок всех методов web-api сервиса.
![image](https://user-images.githubusercontent.com/17438672/126802564-e8d9067f-a258-4a26-8d32-50c499ecf732.png)
