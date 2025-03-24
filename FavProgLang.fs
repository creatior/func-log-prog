module FavProgLang
open System

let favouriteProgrammingLanguage lang =
     match lang with
     | "F#" | "Prologue" -> Console.WriteLine("Подлиза")
     | "Ruby" -> Console.WriteLine("Это должно было произойти")
     | "Python" -> Console.WriteLine("Нуу такооое...")
     | _ -> Console.WriteLine("Не знаю такого")
