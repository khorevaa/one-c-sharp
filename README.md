# 1C#
1C# - это платформа для разработки серверных приложений. 1С:Предприятие 8.х является частным случаем платформы 1C#. Другими словами 1C# умеет работать с 1С на уровне структур хранения данных 1С напрямую без использования платформы 1С как таковой.

1C# состоит из трёх основных подсистем:

**1. Метаданные.**

Метаданные используются для моделирования прикладных объектов и их структур хранения данных в стиле конфигуратора 1С.

* Shell - графическая консоль управления на WPF
* orm - небольшой ORM для работы с объектами метаданных
* Metadata.UI - графические элементы управления метаданных (WPF)
* Metadata.Model - объектная модель метаданных
* Metadata.Module - подключаемый к оболочке Shell модуль Metadata (Microsoft Prism 5)
* Metadata.Services - вспомогательные классы для получения данных (service layer)

**2. Дизайнер запросов.**

Дизайнер запросов в стиле редактора кода SQL. Этот дизайнер обеспечивает визуальное редактирование запроса в терминах объектов метаданных, а не названий таблиц СУБД. Результатом работы дизайнера является построение синтаксического дерева запроса, которое можно сохранить в дереве метаданных. Запрос, как объект метаданных, может быть вызван web сервисом 1C# для выполнения и получения результата.

* Hermes.UI - графические элементы управления для дерева запроса (WPF)
* Hermes.Model - объектная модель запроса
* Hermes.Module - подключаемый к оболочке Shell модуль Hermes (Microsoft Prism 5)
* Hermes.Services - вспомогательные классы для получения данных (service layer)

**3. Web сервер для выполнения запросов через web.**

.NET Core middleware для получения доступа к запросам 1C# через web.
Полученный результат запроса сериализуется и отдайтся клиенту как JSON.

* Metadata.Server - хост приложение для Kestrel + middleware (.NET Core 2.2)

# Установка

Потребуется установка .NET Framework 4.7.2 + .NET Core 2.2

Актуальный билд проекта находится в папке debug. Для установки и запуска проекта достаточно просто скопировать этот какталог к себе и запустить файл z.exe.
Перед этим необходимо создать базу данных на Microsoft SQL Server для хранения метаданных. Подробности в папке docs.

Для запуска Kestrel используется команда типа: dotnet Zhichkin.Metadata.Server.dll
В текущей версии Kestrel работает по адресу: http://localhost:5000

Конфигурационный файл приложения App.config находится в папках Metadata.Server и debug или Shell.
Первый нужен для работы через сервер Kestrel, а второй - для работы через обычный UI, который запускается при помощи z.exe (см. выше).

# Контакты

dima_zhichkin@mail.ru
