//What is the smallest number divisible by the numbers 1 to 20

let nums = [1..20]

let nearest_multiple elem =
  let rec get_multiple control_elem test_elem =
    match test_elem with
    | x when control_elem%test_elem=0 -> test_elem
    | x when test_elem=1 -> 1
    | x -> get_multiple control_elem (test_elem-1)
  get_multiple elem (elem-1)

let get_lcm acc elem = 
  match acc with
  | x when x%elem=0 -> acc
  | x -> (acc*elem) / nearest_multiple elem

let value = List.fold get_lcm 1 nums
printfn "%d" value
