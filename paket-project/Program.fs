// Learn more about F# at http://fsharp.org

open System
open Davenport.Fsharp

let doSomething() = 
    "localhost:5984"
    |> database "testing_paket"
    |> createDatabase

[<EntryPoint>]
let main argv =
    doSomething() |> Async.RunSynchronously |> ignore
    printfn "Hello World from F#!"
    0 // return an integer exit code
