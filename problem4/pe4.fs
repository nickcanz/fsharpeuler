//largest palindrone number made from product of two 3-digit numbers

let reverse (s:string) = new string(s |> Seq.toArray |> Array.rev)

let isPalindrone (x,y) =
  let s = string(x*y)
  s = reverse(s) 

let calculateSequence = Seq.unfold (fun (x,y) ->
  if(isPalindrone (x,y)) then
    Some((x,y), (x,(y-1)))
  else if(x=100 && y=100) then
    None
  else if(y=100) then
    Some((0,0), ((x-1),(x-1)))
  else
    Some((0,0), (x,(y-1)))) (999,999)
  

let max = 
  calculateSequence
  |> Seq.filter (fun x -> x>(1,1)) 
  |> Seq.maxBy (fun e -> fst(e)*snd(e))  

printfn "%A" max
