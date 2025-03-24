module Fibonacci

open System

let rec fibonacciUp num = 
    match num with
        | 0 | 1 -> 1
        | _ -> (fibonacciUp (num - 1)) + (fibonacciUp (num - 2))

let fibonacciDown num = 
    let rec fibonacci x acc y =
        match y with
        | 0 | 1 -> acc
        | _ -> fibonacci acc (acc + x) (y - 1)
    fibonacci 0 1 num