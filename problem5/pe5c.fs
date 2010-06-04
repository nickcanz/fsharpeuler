let range = [2..10]

let primeTest x y =
  (x=y) || (x%y <> 0)  

let rec GetPrimes r testval = 
  match r with
  | x when r.Length=testval -> r
  | head :: tail -> GetPrimes (r |> List.filter primeTest (r.Item(testval))) (testval+1)
  

let primelist = GetPrimes range 0

printfn "%A" primelist

