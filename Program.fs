open System
open HelloWorld
open QuadraticEquation
open SumDigits
open Fibonacci
open CylinderVolume
open Traverse
open FavProgLang
open Coprimes

let task6 bool =
    match bool with
        | true -> sumDigits
        | false -> fibonacciUp



[<EntryPoint>]
let main args =     
    printHelloWorld

    let result = solve 4. 2. -1.

    match result with 
        None -> printf "Корней нет\n\n"
        | Linear(x) -> printf "Линейное уравнение, корень: x = %f\n\n" x
        | Quadratic(x1, x2) when x1=x2 -> printf "Квадратное уравнение, 1 корень: x = %f\n\n" x1
        | Quadratic(x1, x2) -> printf "Квадратное уравнение, 2 корня: x1 = %f x2 = %f\n\n" x1 x2

    System.Console.Write("Введите радиус: ")
    //let r = System.Console.ReadLine() |> float
    System.Console.Write("Введите высоту: ")
    //let h = System.Console.ReadLine() |> float

    //let volume = cylinderVolume r h

    //System.Console.WriteLine("Объем (каррирование): " + volume.ToString())

    //let volume2 = cylinderVolumeSuperPos r h

    //System.Console.WriteLine("Объем: (суперпозиция): " + volume2.ToString() + "\n")

    //System.Console.Write("Сумма цифр\nВведите число: ")
    //let n = System.Console.ReadLine() |> int

    //let sum1 = sumDigitsUp n
    //System.Console.WriteLine("Сумма цифр (рекурсия вверх): " + sum1.ToString())

    //let sum2 = sumDigits n
    //System.Console.WriteLine("Сумма цифр (рекурсия вниз): " + sum2.ToString())

    let result1 = fibonacciUp 19
    System.Console.WriteLine(result1.ToString())
    let result2 = fibonacciUp 19
    System.Console.WriteLine(result2.ToString())
    let resultTask6 = task6 false 14
    System.Console.WriteLine(resultTask6.ToString())

    let num = 756766
    let result7 = traverse num (fun a b -> (a + b))
    System.Console.WriteLine(result7.ToString())

    let result8 = traverse num (fun a b -> max a b)
    System.Console.WriteLine(result8.ToString())

    let result9 = traverseWithPredicate num (fun a b -> (a + b)) (fun a -> (a % 2 = 1))
    System.Console.WriteLine(result9.ToString())

    let result10 = traverseWithPredicate num (fun a b -> max a b) (fun a -> (a % 2 = 1))
    System.Console.WriteLine(result10.ToString())
    
    //let language = System.Console.ReadLine() |> string
    //favouriteProgrammingLanguage language

    //favLangSuperPos ()
    //favLangCarry ()

    let number = 25

    let result11 = coprimeTraversal number (+) 0
    System.Console.WriteLine(result11.ToString())

    let result12 = coprimeTraversal number (fun a b -> a + 1) 0
    System.Console.WriteLine(result12.ToString())

    let result13 = coprimeTraversal number (fun a b -> max a b) 0
    System.Console.WriteLine(result13.ToString())

    let result14 = coprimeTraversal number (fun a b -> min a b) number
    System.Console.WriteLine(result14.ToString())

    let result15 = eulerFunction number
    System.Console.WriteLine(result15.ToString())

    let result16 = coprimeTraversalWithPredicate number (+) (fun x -> (x%2)=0) 0
    Console.WriteLine(result16)

    System.Console.ReadKey() |> ignore
    0

