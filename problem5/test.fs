let avg acc elem =
  acc+elem

let nums = [1..20]

let total = List.fold avg 0 nums
let total1 = List.sum nums

printfn "%d" total
printfn "%d" total1

