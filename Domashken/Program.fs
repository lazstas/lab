#light
//module MyNamespace.MyModule
open System
//функция для упрощения ввода числа с клавиатуры
let rec read() =
    match System.Double.TryParse(System.Console.ReadLine()) with
    | false, _ -> printfn "?"; read()
    | _, x -> x
//ввод с клавиатуры коэффициентов уравнения
printfn "Квадратное уравнение имеет вид Ax^2+Bx+C=0"
printfn "Введите А"
let a = read();
printfn "Введите В"
let b = read();
printfn "Введите С"
let c = read();
//тип - для нормального вывод результата
type ResultOfSolve=
 None
    |Function of float*float
//зададим формулу решения квадратого уравнения в общем виде
let solve = fun (a,b,c) ->
    let D = b*b-4.0*a*c
    if a=0.0 then
        if b=0.0 then None else Function((-c/b),(-c/b))
    else
        if D<0.0 then None else Function(((-b+sqrt(D))/(2.0*a),(-b-sqrt(D))/(2.0*a)))
//решение уравнения
let res = solve(a,b,c);
//вывод результата
match res with
    None -> printf "Нет решений"
    |Function(x1,x2) -> printf "Уравнение имеет корни %f %f " x1 x2
System.Console.Read();