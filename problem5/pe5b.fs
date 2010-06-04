//smallest number that is evenly divisible by numbers 1 to 20

let base_nums = [1..20]

let nums = List.rev(base_nums)

let MultipleTest n x =
  x = n || n % x <> 0

let rec RemoveMultiples listnums =
  match listnums with
  | head :: tail -> RemoveAllMultiples ( List.filter (MultipleTest head))
  | [] -> 

