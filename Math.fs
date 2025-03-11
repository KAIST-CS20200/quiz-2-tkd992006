module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let isEven n = n % 2 = 0
let collatz n =
  let rec helper n count =
    if n = 1 then count
    elif isEven n then helper (n / 2) (count + 1)
    else helper ((3 * n + 1))/2 (count + 2)
  helper n 0
