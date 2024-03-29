# Windows Forms

C# + .NET Framework

## [Mouse events](/HW01/)

Створіть додаток за поданим зразком
![Examle](/HW01/Winforms_Example.png)

При наведенні миші на кнопку «Да» кнопка змінює своє місце розташування в межах видимої частини вікна. Користувач не повинен мати змогу натиснути на її. При зміні розмірів вікна кнопки повинні бути в межах вікна. При натисканні на кнопку «Нет», вивести повідомлення «Дякую за співпрацю»

## Результат:
![Result](/HW01/Winforms_Result.png)

-----

## [Label, Button, Edit](/HW02/)

Завдання "Анкета". Завдання користувача ввести свої дані в форму.
При натисканні на кнопку дані з форми та дата заповнення анкети 
записуються до файлу та відображаються у блокноті (У файлі мають 
зберігатись всі анкети). 

Зовнішній вигляд програми:
![Example](/HW02/Winforms_Example.png)

## Результат:
![Result](/HW02/Winforms_Result.png)

-----

## [MonthCalendar, DateTimePicker](/HW03/)

Завдання №1.
Написати програму, яка обчислює скільки залишилося часу до зазначеної дати. 
Передбачити можливість видачі результату в роках, місяцях, днях, хвилинах, секундах. 
Для перемикання між варіантами використайте перемикач RadioButton.
Завдання №2.
Підрахуйте кількість днів між обраними датами за допомогою DateTimePicker і 
виведіть результат на форму з використання елемента Label

## Результат:
![Result](/HW03/Winforms_Result.png)

-----

## [LIST](/HW04/)

Задание 1:
Разработать программу «Обработка строк», которая должна выполнять следующие задачи:
- по щелчку на кнопке «Добавить в список» записывать в «Список 
студентов» строку из «Поля ввода», содержащую фамилию и инициалы студента. 20 фамилий можно записать с помощью «Редактора коллекции строк»;
- по щелчку на кнопке «Вставить в список» вставлять перед выделенной строкой в «Списке студентов» строку из «Поля ввода»;
- по щелчку на кнопке «Изменить строку» изменять содержимое выделенной строки в «Списке студентов» на содержимое из «Поля ввода»;
- по щелчку на кнопке «У далить из списка» удалять строку из «Списка студентов»;
- по щелчку на кнопке «Определить строку» определять самую длинную и короткую строку и содержание этих строк вывести в соответствующие поля.
При разработке интерфейса приложения использовать компоненты 
Label, Button, TextBox, Panel и ListBox (один из вариантов интерфейса 
представлен на рисунке)
![Example](/HW04/Winforms_Example1.png)

## Результат:
![Result](/HW04/Winforms_Result1.png)

Задание 2:
Разработать программу вычисления значений функции
![Function](/HW04/Winforms_Function.png)

в диапазоне изменения аргумента х от хн до хк с шагом dx, 
В форме предусмотреть ввода значения параметра а, хн, хк, dx. 
Ввод исходных данных осуществляется с клавиатуры или путем выбора 
данных из списка. 
Результат решения оформить в виде списка. Если результат решения 
отсутствует (например, из некорректных исходных данных), то в списке 
решений должно выдаваться соответствующее сообщение.
При разработке интерфейса приложения использовать компоненты 
Label, ListBox, Button, Panel и ComboBox (один из вариантов интерфейса 
представлен на рисунке.
![Example](/HW04/Winforms_Example2.png)

## Результат:
![Result](/HW04/Winforms_Result2.png)

-----

## [Label, Button, Timer](/HW05/)

Завдання 1:
Написати програму годинник. Програма повинна розміщуватись поверх всіх 
вікон.
![Example](/HW05/Winforms_Example1.png)

## Результат:
![Result](/HW05/Winforms_Result1.png)

Завдання 2:
Власник автозаправки «BestOil» замовив наступну програму.
Коли автозаправка тільки починає свою діяльність, власник зазвичай хоче отримувати максимально великий дохід, який планує збільшити за рахунок додаткових послуг. Тому на автозаправці буде діяти невелике кафе. Але, в той же час він може найняти тільки одного працівника на посаду касира, а тому призначення програми - облік продажів бензину і асортименту товарів в мінікафе.
![Example](/HW05/Winforms_Example2.png)

Вимоги до поставленого завдання:
Для зручності вікно розділене на три частини: перша для здійснення обчислень, що стосуються безпосередньо заправки автомобілів паливом; друга - покупки в міні-кафе; третя частина для обчислення суми оплати.
Отже, перша група елементів Автозаправка.

ComboBox - список, що випадає з переліком наявного пального. За 
замовчуванням, відразу при запуску програми повинен бути обраний певний вид 
пального і в TextBox (або наприклад Label) повинна відображатися ціна на даний вид 
продукту. При кожній зміні вибору бензину, ціна в даному полі буде відповідно 
змінюватися.

Далі, дається можливість вибору: купити пальне, вказавши необхідну кількість 
літрів або вказавши, на яку суму клієнт буде заправлятися. При цьому, після вибору 
одного з двох варіантів надання послуги, непотрібне поле стає заблокованим. У разі 
введення суми грошей, група «До оплати» змінить назву на «До видачі»; замість суми 
слід виводити кількість літрів, відповідно змінюються одиниці виміру з «грн.» на «л».

Друга група Міні-кафе.
Для зручності, всі можливі товари виведені відразу в даній частині. Для кожного 
продукту передбачені CheckBox з назвою товару, поруч виводиться ціна (неактивний 
TextBox). При отриманні замовлення для можливості введення кількості замовлених 
одиниць товару, слід поставити «галочку» в CheckBox навпроти відповідного товару.
Остання - «До оплати».

Містить кнопку, яка відповідає за здійснення обчислення і виведення сум у 
відповідних полях. 

Після того, як виведена сума, через (наприклад) 10 секунд повинен з'явитися 
запит на очистку форми, тобто при появі наступного клієнт: так - все поля приймають 
значення за замовчуванням, немає - незмінне стан залишається ще на 10 секунд. При 
виході з програми (закінчився робочий день) повинно з'явитися вікно з 
повідомленням, якою є загальна сума виручки за даний день. Або цю суму можна 
відразу виводити в самій формі і змінювати після кожної вправи розрахунку з 
клієнтом.

Крім цього, надайте формі естетичний вигляд (кольору, шрифти, малюнки ...). 
При обґрунтованої необхідності і цікавому рішенні функціональності програми 
дозволяється вносити зміни в зовнішній вигляд форми або набір елементів.

## Результат:
![Result](/HW05/Winforms_Result2.png)

-----

## [VScrollBar, HScrollBar](/HW06/)

Завдання 1:
Створити програму з використанням класів VScrollBar, HScrollBar, що 
дозволяє переглядати зображення великого розміру. Приклад:
![Example](/HW06/Winforms_Example1.png)

## Результат:
![Result](/HW06/Winforms_Result1.png)

Завдання 2:
Створити програму за поданим зразком:
![Example](/HW06/Winforms_Example2.png)

## Результат:
![Result](/HW06/Winforms_Result2.png)

Завдання 3:
Зміна кольору форми:
![Example](/HW06/Winforms_Example3.png)

## Результат:
![Result](/HW06/Winforms_Result3.png)

-----

## [Additional forms](/HW07/)
Створити програму за зразком :
![Example](/HW07/Winforms_Example.png)

Список повинен містити перелік студентів. Кожен студент містить такі поля: ПІБ, дата народження, середній бал.
При натисканні на кнопку Додати відкривається вікно для введення інформації про нового студента.
При натисканні на кнопку Редагувати відкривається вікно із заповненими полями для редагування.
Всі зміни в списку студентів повинні зберігатись у файл. 
При завантаженні програма повинна завантажити список студентів.

## Результат:
![Result](/HW07/Winforms_Result.png)

-----

## [Addtional forms](/HW08/)

Задание 1:
Разработайте программу, которая позволяет пользователю осуществлять поиск файлов по заданному критерию. Приложение состоит из двух форм – главное окно и окно поиска. Пользователь может 
открыть сколько угодно окон для поиска. Окно поиска запускается немодально. В окне поиска пользователь выбирает папку, в которой будет идти поиск и вводит маску поиска, например «*.doc». Найденные файлы отображаются в списке.

## Результат:
![Result](/HW08/Winforms_Result1.png)

Задание 2
Фирма продает составляющие компьютера. Первая форма отвечает за учет продаж, вторая за добавление и редактирование составляющих.

Первая форма:
Список, выпадающий список, текстовое поле, кнопка вызова второй формы. В выпадающем списке появляются наименования всех товаров, которые в наличие в магазине. Пользователь выбирает товар, в текстовом окне, которое нельзя редактировать, появляется цена. Пользователь нажимает «добавить» и товар добавляется в список продаж. Также должно быть окошко, которое выводит 
общую стоимость.

Вторая форма:
Информация о комплектующих (наименование, характеристика, описание и цена) вводится в текстовые поля; в список добавляется текстовая строка, содержащая информацию о товаре, кроме цены, цена в списке не видна, но содержится; также комплектующие можно редактировать.

## Результат:
![Result](/HW08/WinForms_Result2.png)

Задание 3
Разработайте приложение, которое состоит из двух форм. Первая форма содержит TextBox доступный только для чтения и две кнопки «загрузить файл» и «редактировать». Кнопка «редактировать» изначально неактивна. При нажатии на первую кнопку, открывается диалог и пользователю предлагают выбрать текстовый файл. Выбранный файл загружается в TextBox и кнопка «редактировать» становится активной. При нажатии на вторую кнопку открывается вторая форма 
(не модально), которая содержит TextBox доступный для редактирования и две кнопки «Сохранить» и «Отменить». При нажатии на первую кнопку изменения отображаются в TextBox первой формы.

## Результат:
![Result](/HW08/Winforms_Result3.png)

-----

## [Menu. Toolbar. Status bar](/HW09/)

В програму БЛОКНОТ (попередня домашня робота) добавити меню, панель з кнопками, рядок стану. Кнопки мають виконувати стандартні функції. В рядок стану потрібно добавити: позицію курсора в документі, в рядку, поточний рядок, кількість рядків. Добавити додаткову форму для  виведення статистики по тексту: кількість символів, кількість слів, слова, які повторюються більше двох раз (у порядку спадання їх повторень). 
Для зручності додайте Панель вкладок TabControl.
Для прикладу можна брати Notepad++
![Example](/HW09/WinForms_Example.png)

## Результат:
![Result](/HW09/Winforms_Result.png)

-----

## [Trees and lists](/HW10/)

Создать приложение, отображающее информацию о файлах и директориях с использованием элементов управления ListView и TreeView: отображение файлов и папок всех логических дисков с 
помощью TreeView, при выборе файла или папки в ListView отображаются все свойства (дата создания, размер, тип, количество файлов для папки, атрибуты и т.д.)
Приложение должно позволять:
■ при двойном клике на файле – открывать его стандартными средствами;
■ при двойном клике на папке – отображать ее содержимое;
■ переименовать файл;
■ переименовать папку;
■ удалять файл;
■ удалять папку.

## Результат:
![Result](/HW10/Winforms_Result.png)

-----

## [Dictionaries app](/HW11/)

Создать приложение «Словари». 
Основная задача проекта: хранить словари на разных языках и разрешать пользователю находить перевод нужного слова или фразы. 
Интерфейс приложения должен предоставлять такие возможности:
■ Создавать словарь. При создании нужно указать тип словаря. Например, 
англо-русский или русско-английский.
■ Добавлять слово и его перевод в уже существующий словарь. Так как у слова может быть несколько переводов, необходимо поддерживать возможность создания нескольких вариантов перевода.
■ Заменять слово или его перевод в словаре.
■ Удалять слово или перевод. Если удаляется слово, все его переводы удаляются вместе с ним. Нельзя удалить перевод слова, если это последний вариант перевода.
■ Искать перевод слова.
■ Словари должны храниться в файлах.
■ Слово и варианты его переводов можно экспортировать в отдельный файл результата.
■ При старте программы необходимо показывать меню для работы с программой. Если выбор пункта меню открывает подменю, то тогда в нем требуется предусмотреть возможность возврата в предыдущее меню.

## Результат:
![Result](/HW11/Winforms_Result.png)

-----

## [ToDo List](/HW11/)

Создать приложение «Список дел».
Основная задача приложения: предоставить пользователю функциональность для создания и ведения списка дел. 
Интерфейс приложения должен предоставлять такие возможности:
■ создание конкретного дела;
■ при создании дела можно указать: дату выполнения, время выполнения, 
приоритет (высокий, средний, низкий), теги, текстовый комментарий, прикрепленный файл;
■ отображение списка дел на день, неделю, месяц;
■ поиск дел по различным критериям поиска;
■ сохранение списка дел в файл pdf-формата;
■ создание проекта. Проект содержит набор дел;
■ приложение должно поддерживать механизм Drag-and-Drop для переноса дел из одного проекта в другой.

## Результат:
![Result](/HW12/Winforms_Result1.png)
![Result](/HW12/Winforms_Result2.png)

-----