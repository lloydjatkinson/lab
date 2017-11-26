// Learn more about F# at http://fsharp.org

open System
open BelkinWemoCsv

let fizzbuzz n =
    match n % 3 = 0, n % 5 = 0 with
        | true, false -> "Fizz"
        | false, true -> "Buzz"
        | true, true -> "FizzBuzz"
        | false, false -> sprintf "%d" n

let fizzbuzzSequence x y =
    [x..y] |> Seq.map fizzbuzz



[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    // let reading = 
    //     { Device: "Fireplace"
    //       Date: DateTimeOffset.UtcNow
    //       Total: 5.0
    //       AverageWatts: 2000 }
    
    fizzbuzzSequence 1 10 |> Seq.iter (printfn "%s")
    0 // return an integer exit code