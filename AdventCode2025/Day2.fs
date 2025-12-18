module Day2

let getAllIdsInRange (range : string) =
    let parts = range.Split('-')
    let startId = uint64 parts.[0]
    let endId = uint64 parts.[1]
    [ for id in startId .. endId -> id.ToString() ]

let isPalindrome (id : string) =
    let reverse = Seq.rev id |> System.String.Concat
    id = reverse

let isInvalidId (id : string) =
    let isInvalidPattern (pattern : string) =
        let split = id.Split pattern
        Array.forall (fun part -> part = "") split && 
            Array.length split = 3
    
    let rec loop index =
        if index > id.Length / 2 then
            false
        else
            if id.Substring(0, index) |> isInvalidPattern then
                true
            else
                loop (index + 1)
    loop 1

    
let isInvalidId_Part2 (id : string) =
    let isInvalidPattern (pattern : string) =
        let split = id.Split pattern
        Array.forall (fun part -> part = "") split
    
    let rec loop index =
        if index > id.Length / 2 then
            false
        else
            if id.Substring(0, index) |> isInvalidPattern then
                true
            else
                loop (index + 1)
    loop 1

let getInvalidIdsInRange (range : string) =
    getAllIdsInRange range
    |> List.filter isInvalidId

let getInvalidIdsInRange_Part2 (range : string) =
    getAllIdsInRange range
    |> List.filter isInvalidId_Part2

let sumAllInvalidIdsInRanges (ranges : string) =
    ranges.Split(',')
    |> Array.map (fun range -> 
        getInvalidIdsInRange range
        |> List.sumBy uint64)
    |> Array.sum

let sumAllInvalidIdsInRanges_Part2 (ranges : string) =
    ranges.Split(',')
    |> Array.map (fun range -> 
        getInvalidIdsInRange_Part2 range
        |> List.sumBy uint64)
    |> Array.sum