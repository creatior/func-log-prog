type SolveResult =
  | None
  | Linear of float
  | Quadratic of float * float

let solve a b c = 
    let D = b*b - 4.*a*c
    if a = 0. then 
        if b = 0. then None
        else Linear(-c/b)
    else
        if D<0. then None
        else Quadratic(((-b+sqrt(D))/2.*a),(-b-sqrt(D)) / (2.*a))

[<EntryPoint>]
let main args = 
    //printfn "Hello, world!"
    //System.Console.WriteLine("Hello, world!")
    let result = solve 4. 2. -1.

    match result with 
        None -> printf "Корней нет"
        | Linear(x) -> printf "Линейное уравнение, корень: %f" x
        | Quadratic(x1, x2) when x1=x2 -> printf "Квадратное уравнение, 1 корень: %f" x1
        | Quadratic(x1, x2) -> printf "Квадратное уравнение, 2 корня: %f %f" x1 x2

    System.Console.ReadKey() |> ignore
    0

