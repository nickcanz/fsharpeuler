//find sum of even terms in fibonacci sequence which do not exceed four million

let rec fibonacci m n =
  match n with
  | x when x>= 4000000 -> 0 
  | x when x%2=0 -> n + fibonacci n (n+m)
  | x -> 0 + fibonacci n (n+m)

let v = fibonacci 0 1 

printfn "%d" v

