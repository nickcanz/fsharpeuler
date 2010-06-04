//What is the smallest positive number evenly divisible by all numbers from
//#1 to 20

let base_nums = [1..10]

let nums = List.rev(base_nums)

let MultipleTest n x =
  (x=n) || (n%x <> 0)

let rec RemoveMultiples listnums listhead =
  match listhead with
  | head :: tail -> RemoveMultiples ( listnums |> List.filter (MultipleTest head)) tail
  | [] -> listnums


let v = RemoveMultiples nums nums

let p = List.fold (fun x y -> (x*y)) 1 v

printfn "%d" p

