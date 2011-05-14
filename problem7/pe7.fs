//10,001st prime

let next_prime prev_primes =
  let start_num = Seq.max prev_primes + 1I
  let untested_nums = Seq.initInfinite (fun index -> start_num+bigint(index))

  let not_a_prime num = 
    prev_primes |> Seq.exists (fun p -> num%p = 0I)

  let find_a_prime untested_num =
    if not(not_a_prime untested_num) then
      Some(untested_num)
    else
      None

  let found_a_prime = 
    untested_nums |> Seq.tryPick find_a_prime   

  let known_primes = seq { yield! (Seq.cache prev_primes); yield found_a_prime.Value}
  Some(found_a_prime.Value, Seq.cache(known_primes))


let primes = Seq.cache(Seq.unfold next_prime (Seq.singleton 2I))

let target_prime0 = Seq.nth 9999 primes
printfn "%A" target_prime0

let target_prime = Seq.nth 10000 primes
printfn "%A" target_prime

let target_prime2 = Seq.nth 10001 primes
printfn "%A" target_prime2

let target_prime3 = Seq.nth 10002 primes
printfn "%A" target_prime3

let target_prime4 = Seq.nth 10003 primes
printfn "%A" target_prime4
