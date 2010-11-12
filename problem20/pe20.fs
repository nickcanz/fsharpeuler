open System

let rec factorial (total:bigint) (n:bigint) =
    if n = 1I then
        total
    else
        factorial (total*n) (n-1I) 

let rec sumdigits (sum:bigint) (divisor:bigint) (num:bigint) =
    let digitToAdd = num % divisor
    let newSum = sum + digitToAdd/(divisor/10I)

    if num / divisor < 1I then
        newSum
    else
        sumdigits newSum (divisor*10I) (num-digitToAdd)

let answer = 
    100I |> factorial 1I |> sumdigits 0I 10I

Console.WriteLine(answer)

ignore (Console.Read())
