//prime factorization
//What is the largest prime factor of the number 600851475143

let primes =
  let a = ResizeArray[2]
  let b = ResizeArray[2]
  let grow() = 
    let p0 = a.[a.Count-1]+1
    let bools = Array.create p0 true
    for di in a do
      let rec loop i =
        if i < bools.Length then
          bools.[i] <- false
          loop(i+di)
      let i0 = p0/di*di
      loop(if i0<p0 then i0+di-p0 else i0-p0)
    for i=0 to bools.Length-1 do
      if bools.[i] then a.Add(p0+i)
      if bools.[i] && 600851475143I % bigint(p0+i)=0I then b.Add(p0+i)
  fun n ->
    while a.[a.Count-1] <= int(sqrt(n)) do
      grow()
    b.[b.Count-1]


let num =  600851475143.0

let factor = primes num

printfn "%d" factor

