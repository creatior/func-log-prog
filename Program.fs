open System
open HelloWorld
open QuadraticEquation

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
    printHelloWorld

    let result = solve 4. 2. -1.

    match result with 
        None -> printf "Корней нет\n\n"
        | Linear(x) -> printf "Линейное уравнение, корень: x = %f\n\n" x
        | Quadratic(x1, x2) when x1=x2 -> printf "Квадратное уравнение, 1 корень: x = %f\n\n" x1
        | Quadratic(x1, x2) -> printf "Квадратное уравнение, 2 корня: x1 = %f x2 = %f\n\n" x1 x2

    System.Console.Write("Введите радиус: ")
    let r = System.Console.ReadLine() |> float
    System.Console.Write("Введите высоту: ")
    let h = System.Console.ReadLine() |> float

    let volume = cylinderVolume r h

    System.Console.WriteLine("Объем (каррирование): " + volume.ToString())

    let volume2 = cylinderVolumeSuperPos r h

    System.Console.WriteLine("Объем: (суперпозиция): " + volume2.ToString() + "\n")

    System.Console.ReadKey() |> ignore
    0

