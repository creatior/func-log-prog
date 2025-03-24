module Traverse

let traverse num (f:(int -> int -> int)) =  
    let rec traverseDown n (f:(int -> int -> int)) acc =
        match n with
            | 0 -> acc
            | n -> traverseDown (n / 10) f (f acc (n % 10))
    traverseDown num f 0

let traverseWithPredicate num (f:(int -> int -> int)) (p:(int -> bool)) =  
    let rec traverseDown n (f:(int -> int -> int)) acc =
        match n with
            | 0 -> acc
            | n ->
                let newAcc = if p (n % 10) then f acc (n % 10) else acc
                traverseDown (n / 10) f newAcc
    traverseDown num f 0