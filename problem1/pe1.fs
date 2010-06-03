//sum of all multiples of 3 or 5 below 1000

let sumMultiples n =
  [1..n]
  |> List.filter (fun i -> (i%3 = 0 || i%5 = 0))
  |> List.sum

let out = sumMultiples 999 

printfn "%d" out
