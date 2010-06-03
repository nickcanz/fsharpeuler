let primes =

    let a = ResizeArray[2]
    let num =  600851475143.0

    let grow() =

      let p0 = a.[a.Count-1]+1

      let b = Array.create p0 true

      for di in a do

        let rec loop i =

          if i<b.Length then

            b.[i] <- false

            loop(i+di)

        let i0 = p0/di*di

        loop(if i0<p0 then i0+di-p0 else i0-p0)

      for i=0 to b.Length-1 do

        if b.[i] then a.Add(p0+i)

    fun n ->

      while a.[a.Count-1] <= int(sqrt(num)) do

        grow()

      a.[n]


let x = primes 100000
printfn "%d" x
