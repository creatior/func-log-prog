module FavProgLang
open System

let favouriteProgrammingLanguage lang =
     match lang with
     | "F#" | "Prologue" -> Console.WriteLine("Подлиза")
     | "Ruby" -> Console.WriteLine("Это должно было произойти")
     | "Python" -> Console.WriteLine("Нуу такооое...")
     | _ -> Console.WriteLine("Не знаю такого")

let favLangSuperPos () =
    Console.WriteLine("Какой ваш любимый язык программирования?")
    (Console.ReadLine>>favouriteProgrammingLanguage>>Console.WriteLine)()

    
let favLangCarry () =
    Console.WriteLine("Какой ваш любимый язык программирования?")
    let func read transform write = write(transform(read()))
    func Console.ReadLine favouriteProgrammingLanguage Console.WriteLine