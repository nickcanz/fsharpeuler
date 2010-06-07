//Find the difference betwen the sum of squares of first 100 natural numbers
//and the square of the sum
//ie
//1^2 + 2^2 + ... + 10^2 = 385
// (1+2+..+10)^2 = 3025

let nums = [1.0..100.0]

let sum_of_squares = List.fold (fun acc elem -> float acc + (float elem)**2.0) 0.0 nums

let square_of_sums = (List.sum nums)**2.0

let difference = square_of_sums - sum_of_squares

printfn "%f" difference
