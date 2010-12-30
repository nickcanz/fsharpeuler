// First fibonacci term to have 1000 digits

let digitlength (num : bigint) =
   num.ToString().Length

let rec fibonacci count (m : bigint) (n : bigint) =
 match n with
 | x when digitlength(x) >= 1000 -> count
 | x -> fibonacci (count+1) n (n+m)

let v = fibonacci 1 0I 1I

printfn "%d" v
