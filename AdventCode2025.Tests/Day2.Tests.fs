module Day2.Tests

open Xunit
open Day2

let ``given range is`` range =
    range

let ``should return `` (expectedIds : string list) (actualIds : string list) =
    Assert.Equal<string list>(expectedIds, actualIds)

let ``should return sum `` (expectedSum : uint64) (actualSum : uint64) =
    Assert.Equal<uint64>(expectedSum, actualSum)

[<Fact>]
let ``GetAllIdsInRange 11-22``() =
    ``given range is`` "11-22"
    |> getAllIdsInRange
    |> ``should return `` ["11"; "12"; "13"; "14"; "15"; "16"; "17"; "18"; "19"; "20"; "21"; "22"]
    
[<Fact>]
let ``GetAllIdsInRange 95-115``() =
    ``given range is`` "95-115"
    |> getAllIdsInRange
    |> ``should return `` ["95"; "96"; "97"; "98"; "99"; "100"; "101"; "102"; "103"; "104"; "105"; "106"; "107"; "108"; "109"; "110"; "111"; "112"; "113"; "114"; "115"]

[<Fact>]
let ``GetAllIdsInRange 998-1012``() =
    ``given range is`` "998-1012"
    |> getAllIdsInRange
    |> ``should return `` ["998"; "999"; "1000"; "1001"; "1002"; "1003"; "1004"; "1005"; "1006"; "1007"; "1008"; "1009"; "1010"; "1011"; "1012"]

[<Fact>]
let ``IsInvalidId 11``() =
    Assert.True(isInvalidId "11")

[<Fact>]
let ``IsInvalidId 12``() =
    Assert.False(isInvalidId "12")

[<Fact>]
let ``IsInvalidId 1010``() =
    Assert.True(isInvalidId "1010")

[<Fact>]
let ``GetInvalidIdsInRange 11-22``() =
    ``given range is`` "11-22"
    |> getInvalidIdsInRange
    |> ``should return `` ["11"; "22"]

[<Fact>]
let ``GetInvalidIdsInRange 95-115``() =
    ``given range is`` "95-115"
    |> getInvalidIdsInRange
    |> ``should return `` ["99"]

[<Fact>]
let ``GetInvalidIdsInRange 1188511880-1188511890``() =
    ``given range is`` "1188511880-1188511890"
    |> getInvalidIdsInRange
    |> ``should return `` ["1188511885"]
    
[<Fact>]
let ``Sum all invalid IDs in ranges``() =
    ``given range is`` "11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124"
    |> sumAllInvalidIdsInRanges 
    |> ``should return sum `` 1227775554UL

[<Fact>]
let ``getInvalidIdsInRange_Part2 11-22``() =
    ``given range is`` "11-22"
    |> getInvalidIdsInRange_Part2
    |> ``should return `` ["11"; "22"]


[<Fact>]
let ``GetInvalidIdsInRange_Part2 95-115``() =
    ``given range is`` "95-115"
    |> getInvalidIdsInRange_Part2
    |> ``should return `` ["99"; "111"]
