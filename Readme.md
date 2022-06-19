## Итоговая проверочная работа
### Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

### Решение:

#### Основная программа:
Исходный массив array вводится с клавиатуры. Далее в основном коде программы создаётся массив resultArray, ему сразу присваивается значение результата работы метода GetLenSelectedArray, в качестве аргументов передаются исходный массив array и число символов в строке 3 (по условию задачи). Для проверки работы программы вызывается метод Console.WriteLine, который ввыводит на печать получившийся массив через string.Join.

#### Метод GetLenSelectedArray:
Внутри метода объявляется новый массив result, число элементов - число элементов исходного массива, отвечающих требованиям по длине; объявляется переменная count = 0. После этого циклом foreach программа обходит элементы исходного массива array: если элемент соответствует требованиям по длине, его значение записывается в элемент массива result с индексом count, индекс count увеличивается на 1. В результате выполнения GetLenSelectedArray возвращается массив из элементов исходного массива, отвечающих требованиям по длине.