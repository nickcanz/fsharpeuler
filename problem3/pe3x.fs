
//prime factorization

let primes =
  let a = [2]
  let grow() = 
    let p0 = a.[a.Length-1]+1
    let bools = Array.create p0 true
    for di in a do
      let rec loop i =
        if i < bools.Length then
          bools.[i] <- false
          loop(i+di)
      let i0 = p0/di*di
      loop(if i0<p0 then i0+di-p0 else i0-p0)
    for i=0 to bools.Length-1 do
      if bools.[i] then a @ (p0+i)
  fun n ->
    while a.[a.Length-1] <= int(sqrt(n)) do
      grow()
    a


let num =  600851475143.0

let primeslist = primes num

printfn "%d" primeslist.[primeslist.Length-1]


