# Итоговая проверочная работа 
## Формулировка задачи

 * Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



## Алгоритм программы
Поскольку по условию задачи нет жёстких требований к заданию массива, инициализируем его в самом начале. Затем весь алгоритм будет разделён на пять частей:

Инициализируем вспомогательную переменную count = 0, в которую запишем количество строк, длина которых 3 символа и меньше.

Вычисляем количество строк, длинна которых меньше либо равна 3 символа.

В цикле проходим по каждой строке массива. На каждой итерации сверяем длину строки - если длина меньше или равна трём инкрементируем ранее инициализируемую переменную count и инкрементируем счётчик цикла. Если длина больше трёх инкрементируем только счётчик цикла.

Инициализируем массив результатов размером *_count._*

Формируем массив с результатами.

Снова в цикле проходим по каждой строке и также сравниваем на каждой итерации длину строки. Однако, теперь если длина меньше или равна трём, мы в текущий массив добавляем данную строку, декрементируем count и инкрементируем счётчик цикла, иначе только инкрементируем счётчик цикла. Декрементировать счётчик количества строк count необходимо для правильного заполнения массива: мы из размера массива вычитаем текущее значение данного счётчика.

Выводим массив результатов в консоль
В данном алгоритме пункты 2, 4 и 5 можно выполнить в виде отдельных функций.

[Файл с блок-схемой](https://github.com/VadimProkopiev/FinalTask1/blob/main/Task.drawio.png)

### Примеры массивов и результаты выводов
~~~
["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
~~~
[Файл с кодом](https://github.com/VadimProkopiev/FinalTask1/blob/main/Program.cs)