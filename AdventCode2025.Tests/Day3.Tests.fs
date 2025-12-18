module Day3.Tests
open Xunit

[<Fact>]
let ``FindLargestJoltage 98``() =
    let largestJoltage = 
        "987654321111111"
        |> findLargestJoltage
    Assert.Equal<int>(98, largestJoltage)
    
[<Fact>]
let ``FindLargestJoltage 89``() =
    let largestJoltage = 
        "811111111111119"
        |> findLargestJoltage
    Assert.Equal<int>(89, largestJoltage)
    
[<Fact>]
let ``FindLargestJoltage 78``() =
    let largestJoltage = 
        "234234234234278"
        |> findLargestJoltage
    Assert.Equal<int>(78, largestJoltage)
    
[<Fact>]
let ``FindLargestJoltage 92``() =
    let largestJoltage = 
        "818181911112111"
        |> findLargestJoltage
    Assert.Equal<int>(92, largestJoltage)

[<Fact>]
let ``FindTotalOutputJoltage``() =
    let totalJoltage = 
        [ "987654321111111"
          "811111111111119"
          "234234234234278"
          "818181911112111" ]
        |> findTotalOutputJoltage
    Assert.Equal<int>(357, totalJoltage)