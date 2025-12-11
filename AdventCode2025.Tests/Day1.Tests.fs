module Day1.Tests

open System
open Xunit
open Day1

let ``given dialPosition is`` dialPosition =
    dialPosition

let ``when operateSafe`` (instruction: string) dialPosition =
    operateSafe dialPosition instruction

let ``then dialPosition should be`` (expected: int) (actual: int) =
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
let ``Open safe with multiple instructions`` () =
    let instructions = [ "R10"; "L20"; "R30"; "L40" ]
    let finalPosition = openSafe instructions
    Assert.Equal(30, finalPosition)