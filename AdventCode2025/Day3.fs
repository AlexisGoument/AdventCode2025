module Day3

let findLargestJoltage (bank : string) =
    let maxDigit1 = bank |> Seq.take (bank.Length - 1) |> Seq.max
    let maxDigit2 = 
        bank.IndexOf(maxDigit1) + 1
        |> bank.Substring
        |> Seq.max
    maxDigit1.ToString() + maxDigit2.ToString() |> int

let findTotalOutputJoltage (banks : string list) =
    banks
    |> List.sumBy findLargestJoltage