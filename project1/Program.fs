// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    "string" // error expected here -> "This expression was expected to have type 'int' but here has type 'string'"
