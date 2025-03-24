module SumDigits

let rec sumDigitsUp num =
    if num = 0 then 0
    else (num % 10) + (sumDigitsUp (num / 10))

let sumDigits n = 
    let rec sumDigitsDown n acc =
        if n = 0 then acc
        else sumDigitsDown (n / 10) (acc + n % 10)
    sumDigitsDown n 0