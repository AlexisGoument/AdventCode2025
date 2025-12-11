module Day1

// let openSafe instructions

type Instruction = 
| Left of int
| Right of int

let (|Instruction|_|) (str: string) =
    let convertToInt chars = int (System.String(List.toArray chars))
    match Seq.toList str with
    | 'L'::rest -> Some (Left (convertToInt rest))
    | 'R'::rest -> Some (Right (convertToInt rest))
    | _ -> None

let increment position n = 
    let newPosition = position + n
    if newPosition >= 100 then
        newPosition - 100
    else
        newPosition

let decrement position n = 
    let newPosition = position - n
    if newPosition < 0 then
        100 + newPosition
    else
        newPosition

let operateSafe dialPosition (instruction:string) =
    match instruction with
    | Instruction (Left nb) -> decrement dialPosition nb
    | Instruction (Right nb) -> increment dialPosition nb
    | _ -> failwithf "Invalid instruction: %s" instruction

let openSafe (instructions: string list) =
    instructions
    |> List.scan operateSafe 50
    |> List.filter (fun dialPosition -> dialPosition = 0)
    |> List.length