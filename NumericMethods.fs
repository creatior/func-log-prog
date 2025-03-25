module NumericMethods
open Coprimes
open Traverse

let countEvenNotCoprime number =
    let totalEven = number / 2
    let evenCoprime = coprimeTraversalWithPredicate number (fun acc _ -> acc + 1) (fun x -> x % 2 = 0) 0
    totalEven - evenCoprime

let maxDigitNotDiv3 number =
    let result = traverseWithPredicate number max (fun a -> a % 3 <> 0) 
    result

let smallestDivisor n =
    let rec check i =
        if i * i > n then n
        elif n % i = 0 then i
        else check (i + (if i = 2 then 1 else 2))
    if n % 2 = 0 then 2 else check 3

let computeProduct number =
    let sd = smallestDivisor number

    let maxNonCoprimeNotDivBySd =
        let isNotCoprime x = gcd number x > 1
        let doesNotDivideSd x = x % sd <> 0
        let predicate x = isNotCoprime x && doesNotDivideSd x
        let rec findMax candidate =
            if candidate = 0 then 0 
            elif predicate candidate then candidate
            else findMax (candidate - 1)
        findMax number

    let sumDigitsLessThan5 =
        let isLessThan5 x = x < 5
        traverseWithPredicate number (+) isLessThan5

    maxNonCoprimeNotDivBySd * sumDigitsLessThan5