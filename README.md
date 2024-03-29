Лабораторная работа 8. «Дерево объектов, подписка»
Тип приложения: GUI; язык: без ограничений.
Развитие приложения из Л.Р.7:
•	Добавить на форму приложения объект TreeView для отображения текущего содержания хранилища 
•	Реализовать синхронизацию объекта TreeView с хранилищем с помощью паттерна Observer, при этом должна выполняться синхронизация в обоих направлениях: при выборе объекта в дереве он должен выбираться в рабочей области и наоборот, при выборе объекта в рабочей области он должен выбираться в дереве.
•	Реализовать с помощью паттерна Observer новый вид объекта: однонаправленная стрелка, явно создаваемая пользователем и соединяющая объект А с объектом Б таким образом, что при перемещении объекта А перемещается и объект Б.
•	Факультативно: сделать стрелку двунаправленной.

Объект TreeView должен уметь полностью перестраивать свое содержимое исходя из текущего содержимого хранилища, в котором могут в произвольных комбинациях встречаться отдельные объекты и группы объектов. Как один из вариантов, это может быть реализовано рекурсивной функцией processNode(TreeNode tn, StorageObject o), алгоритм работы которой в общих чертах выглядит так:

processNode(TreeNode tn, StorageObject o)
{
	Создай у узла дерева tn новый дочерний узел t;
	Если объект o является группой, то:
		Для всех объектов oo из группы o:
			processNode(t, oo);
}

Объект TreeView должен автоматически узнавать, когда в хранилище происходят изменения. Для этого в рамках паттерна Observer, объект TreeView должен «подписаться» на объект Storage и, получая уведомления, перестраивать свое содержимое при любых изменениях в объекте Storage. Выделенные объекты в дереве должны становиться выделенными объектами в хранилище и на рабочем поле и наоборот.

Факультативно:
•	Переработать приложение для того, чтобы все действия с объектами выполнялись только через команды (в том числе удаление и создание, в том числе и команды, реализуемые с помощью мыши), с реализацией undo и отображением истории команд.
•	Реализовать окно свойств, позволяющее отображать и изменять свойства любого выбранного объекта, путём реализации механизмов рефлексии и интроспекции.
