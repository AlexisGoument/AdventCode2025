module Day1.Tests

open System
open Xunit
open Day1

let ``given dialPosition is`` dialPosition =
    dialPosition

let ``when operateSafe`` (instruction: string) dialPosition =
    findNextDialPosition dialPosition instruction

let ``then dialPosition should be`` (expected: int) (actual: int) =
    Assert.Equal(expected, actual)

let ``when countNbTimesPassing0`` (instructions: string list) dialPosition =
    countNbTimesPassing0 dialPosition instructions

let ``then NbTimes0Passed should be`` (expected: int) (actual: int) =
    Assert.Equal(expected, actual)

[<Fact>]
let ``Rotate L0`` () =
    ``given dialPosition is`` 50
    |> ``when operateSafe`` "L0"
    |> ``then dialPosition should be`` 50

[<Fact>]
let ``Rotate R0`` () =
    ``given dialPosition is`` 50
    |> ``when operateSafe`` "R0"
    |> ``then dialPosition should be`` 50

[<Fact>]
let ``Rotate L1`` () =
    ``given dialPosition is`` 50
    |> ``when operateSafe`` "L1"
    |> ``then dialPosition should be`` 49

[<Fact>]
let ``Rotate R1`` () =
    ``given dialPosition is`` 50
    |> ``when operateSafe`` "R1"
    |> ``then dialPosition should be`` 51

[<Fact>]
let ``Rotate L51`` () =
    ``given dialPosition is`` 50
    |> ``when operateSafe`` "L51"
    |> ``then dialPosition should be`` 99

[<Fact>]
let ``Rotate L50`` () =
    ``given dialPosition is`` 50
    |> ``when operateSafe`` "L50"
    |> ``then dialPosition should be`` 0

[<Fact>]
let ``Rotate L1000`` () =
    ``given dialPosition is`` 50
    |> ``when operateSafe`` "L1000"
    |> ``then dialPosition should be`` 50

[<Fact>]
let ``Rotate R50`` () =
    ``given dialPosition is`` 50
    |> ``when operateSafe`` "R50"
    |> ``then dialPosition should be`` 0

[<Fact>]
let ``Rotate R51`` () =
    ``given dialPosition is`` 50
    |> ``when operateSafe`` "R51"
    |> ``then dialPosition should be`` 1

[<Fact>]
let ``Rotate R1000`` () =
    ``given dialPosition is`` 50
    |> ``when operateSafe`` "R1000"
    |> ``then dialPosition should be`` 50

[<Fact>]
let ``Open safe with multiple instructions`` () =
    let instructions = [ "L68"; "L30"; "R48"; "L5"; "R60"; "L55"; "L1"; "L99"; "R14"; "L82" ]
    let finalPosition = openSafe instructions
    Assert.Equal(3, finalPosition)

[<Fact>]
let ``Open safe with multiple instructions 2`` () =
    let instructions = [ "R1000"; "L1000"; "L50"; "R1"; "L1"; "L1"; "R1"; "R100"; "R1"]
    let finalPosition = openSafe instructions
    Assert.Equal(4, finalPosition)

[<Fact>]
let ``countNbTimesPassing0 R151`` () =
    ``given dialPosition is`` 50
    |> ``when countNbTimesPassing0`` ["R151"]
    |> ``then NbTimes0Passed should be`` 2

[<Fact>]
let ``countNbTimesPassing0 L151`` () =
    ``given dialPosition is`` 50
    |> ``when countNbTimesPassing0`` ["L151"]
    |> ``then NbTimes0Passed should be`` 2

[<Fact>]
let ``countNbTimesPassing0 R1000`` () =
    ``given dialPosition is`` 50
    |> ``when countNbTimesPassing0`` ["R1000"]
    |> ``then NbTimes0Passed should be`` 10

[<Fact>]
let ``countNbTimesPassing0 L1000`` () =
    ``given dialPosition is`` 50
    |> ``when countNbTimesPassing0`` ["L1000"]
    |> ``then NbTimes0Passed should be`` 10

[<Fact>]
let ``method 0x434C49434B`` () =
    let instructions = [ "L68"; "L30"; "R48"; "L5"; "R60"; "L55"; "L1"; "L99"; "R14"; "L82" ]
    let solution = openSafe_partTwo instructions
    Assert.Equal(6, solution)