<Query Kind="Statements" />

//this - доступ разрешен только в блоке конструктора экземпляра,
//метода экземпляра или кода доступа к экземпляру.

//Он имеет одно из следующих значений:

//1. Когда this используется в выражении внутри 
//конструктора экземпляра класса, оно классифицируется как значение.
//Типом этого значения будет тип экземпляра класса, 
//внутри которого оно используется, и это значение является
//ссылкой на сконструированный объект.

//2. Когда this используется в выражении внутри
//метода экземпляра или кода доступа к экземпляру класса, 
//оно классифицируется как значение. Типом значения будет 
//тип экземпляра класса, внутри которого 
//оно используется, и это значение является ссылкой на 
//объект, для которого вызывается метод или код доступа.

//3. Когда this используется в выражении внутри 
//конструктора экземпляра структуры, оно классифицируется 
//как переменная(!!!!).
//Типом переменной является тип экземпляра структуры, в которой 
//оно используется, и эта переменная представляет создаваемую 
//структуру. Переменная this конструктора экземпляра ведет
//себя в точности так же, как параметр out структурного типа
//— в частности, это означает, что переменная должна быть 
//определенно присвоена в каждом пути выполнения конструктора экземпляра.

//4. Когда this используется в выражении внутри метода 
//экземпляра или кода доступа к экземпляру структуры, оно 
//классифицируется как переменная.Типом переменной является тип 
//экземпляра структуры, внутри которой оно используется.

//􏰅 Если метод или код доступа не является итератором, переменная 
//this представляет структуру, для которой вызывается метод или 
//код доступа, и ведет себя в точности так же, как параметр 
//ref структурного типа.

//􏰅 Если метод или код доступа является итератором, переменная 
//this представляет копию структуры, для которой вызывается метод 
//или код доступа, и ее поведение в точности такое же, как у 
//параметра-значения структурного типа.