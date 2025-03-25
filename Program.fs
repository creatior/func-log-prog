open System
open HelloWorld
open SumDigits
open Fibonacci
open CylinderVolume
open Traverse
open FavProgLang
open Coprimes
open NumericMethods

let task6 bool =
    match bool with
        | true -> sumDigits
        | false -> fibonacciUp

let task20 num arg =
    match num with
        | 1 -> countEvenNotCoprime arg
        | 2 -> maxDigitNotDiv3 arg
        | 3 -> computeProduct arg
        | _ -> 
            Console.WriteLine("Неверный номер задачи")
            0


[<EntryPoint>]
let main args =
    Console.WriteLine("Введите номер задачи и аргумент: ")
    let task = Console.ReadLine() |> int
    let arg = Console.ReadLine() |> int
    Console.WriteLine(task20 task arg)

    System.Console.ReadKey() |> ignore
    0

