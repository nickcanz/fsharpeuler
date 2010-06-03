//largest palindrone number

let reverse (s:string) = new string(s |> Seq.toArray |> Array.rev)

let (|Palindrone|NPalindrone|End|) (x:int,y:int) = 
  let s = string(x*y)
  if s=reverse(s) then 
    Palindrone 
  else if x=100 && y=100 then
    End
  else
    NPalindrone

let rec generate x y = 
  seq {
    match (x,y)  with
    | Palindrone -> yield (x,y)
    | NPalindrone _ when y=100 -> yield! generate (x-1) (x-1)
    | NPalindrone -> yield! generate x (y-1)
    | End -> yield (0,0)
  }

let z = generate 999 999 
//let max = Seq.maxBy (fun e -> fst(e)*snd(e)) z 

printfn "%A" z
