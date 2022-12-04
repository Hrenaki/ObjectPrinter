# ObjectPrinting

Библиотека для сериализации (преобразования) любого объекта в строку, перечисляя значения публичных свойств и полей объекта.

Реализованы следующие фичи:
1. Исключение из сериализации свойства/поля определенного типа
2. Альтернативный способ сериализации для определенного типа
3. Для всех типов, имеющих культуру, есть возможность ее указать
4. Настройка сериализации конкретного свойства/поля
5. Возможность обрезания строк
6. Исключение из сериализации конкретного свойства/поля
7. Корректная обработка циклических ссылок между объектами (не приводит к `StackOverflowException`, ставится метка)
8. Сериализация коллекций; как минимум решение работает с:
	- массивами
	- списками
	- словарями
9. Тесты