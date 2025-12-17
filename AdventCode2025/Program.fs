open System.IO

let instructions = 
    File.ReadAllLines("AdventCode2025/Day1_SafeInstructions.txt")
    |> Array.toList

Day1.openSafe instructions |> printfn "Solution part1: %d"
Day1.openSafe_partTwo instructions |> printfn "Solution part2: %d"