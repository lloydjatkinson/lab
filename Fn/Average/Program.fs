open System

let isNumericValue n =
    let valid, _ = Double.TryParse n
    valid

let (|OnlyNumbers|) n =
    Seq.forall isNumericValue n

let calculateAverage numbers =
    Seq.average numbers

[<EntryPoint>]
let main argv =
    match argv with
        | [||] | OnlyNumbers false ->
            eprintfn "%s" "Non-numeric value was supplied."
            1
        | _ ->
            argv |> calculateAverage |> printfn "%d"
            0