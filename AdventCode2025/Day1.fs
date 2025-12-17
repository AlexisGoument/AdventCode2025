module Day1

type Instruction = 
| Left of int
| Right of int

let (|Instruction|_|) (str: string) =
    let convertToInt chars = int (System.String(List.toArray chars))
    match Seq.toList str with
    | 'L'::rest -> Some (Left (convertToInt rest))
    | 'R'::rest -> Some (Right (convertToInt rest))
    | _ -> None

let intToRange (n:int) =
    let modn = n % 100
    if modn < 0 then modn + 100 else modn

let increment position n = 
    position + n
    |> intToRange

let decrement position n = 
    position - n
    |> intToRange

let findNextDialPosition dialPosition (instruction:string) =
    match instruction with
    | Instruction (Left nb) -> decrement dialPosition nb
    | Instruction (Right nb) -> increment dialPosition nb
    | _ -> failwithf "Invalid instruction: %s" instruction

let openSafe (instructions: string list) =
    instructions
    |> List.scan findNextDialPosition 50
    |> List.filter (fun dialPosition -> dialPosition = 0)
    |> List.length

let rec countNbTimesPassing0 dialPosition (instructions: string list) =
    match instructions with
    | [] -> 0
    | instruction::next ->
        let nextDialPositions =
            match instruction with
            | Instruction (Left nb) ->
                List.init nb (fun i -> intToRange(dialPosition - i - 1))
            | Instruction (Right nb) ->
                List.init nb (fun i -> intToRange(dialPosition + i + 1))
            | _ -> failwithf "Invalid instruction: %s" instruction
        let newDialPosition = List.last nextDialPositions
        let nbPasses0 = nextDialPositions |> List.filter (fun pos -> pos = 0) |> List.length
        nbPasses0 + countNbTimesPassing0 newDialPosition next

let openSafe_partTwo (instructions: string list) =
    countNbTimesPassing0 50 instructions
