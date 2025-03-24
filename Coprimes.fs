module Coprimes

let rec gcd a b =
     match b with
     | 0 -> a
     | _ -> gcd b (a % b)
 
let coprimeTraversal number (func :int->int->int) initial =
     let rec traversal number (func :int->int->int) acc candidate =
         if candidate <= 0 then acc
         else
             let newAcc = if gcd number candidate = 1 then (func acc candidate) else acc
             traversal number func newAcc (candidate-1)
     traversal number func initial number