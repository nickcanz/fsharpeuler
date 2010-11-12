//What is 10,001st prime?

let primes = 
  let rec get_primes elem primelist =
    if primelist.Length=10001 then
      primelist.Head
    else
      let match_prime = List.filter (fun e -> (elem%e)=0) primelist
      if match_prime.Length = 0 then
        get_primes (int64(elem)+1L) (elem :: primelist)
      else
        get_primes (int64(elem)+1L) primelist
  get_primes 2L [1L].Tail

printfn "%d" primes
