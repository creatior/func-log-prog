open System

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

let circleArea radius = 
    let area = Math.PI * radius * radius
    area

let cylinderVolume radius height =
    let area = circleArea radius
    area * height

let multipleAreaHeight area h = area * h

let cylinderVolumeSuperPos = (circleArea >> multipleAreaHeight)

[<EntryPoint>]
let main args = 
    //printfn "Hello, world!"
    //System.Console.WriteLine("Hello, world!")
    let result = solve 4. 2. -1.

    match result with 
        None -> printf "Корней нет\n"
        | Linear(x) -> printf "Линейное уравнение, корень: %f\n" x
        | Quadratic(x1, x2) when x1=x2 -> printf "Квадратное уравнение, 1 корень: %f\n" x1
        | Quadratic(x1, x2) -> printf "Квадратное уравнение, 2 корня: %f %f\n" x1 x2

    System.Console.Write("Введите радиус: ")
    let r = System.Console.ReadLine() |> float
    System.Console.Write("Введите высоту: ")
    let h = System.Console.ReadLine() |> float

    let volume = cylinderVolume r h

    System.Console.WriteLine("Объем (каррирование): " + volume.ToString())

    let volume2 = cylinderVolumeSuperPos r h

    System.Console.WriteLine("Объем: (суперпозиция): " + volume2.ToString())

    System.Console.ReadKey() |> ignore
    0

