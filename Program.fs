// Learn more about F# at http://fsharp.org

open System



let mylist = [2;45;2;12;1;89;61]

// operations implemented with right fold

// length
let length list = list |> Seq.fold (fun aggr item -> aggr + 1) 0

// max
let max list = list |> Seq.fold (fun aggr item -> if item > aggr then item else aggr) Int32.MinValue

// filter
let filter pred list = list |> Seq.fold (fun aggr item -> if pred item = true then item::aggr else aggr) []

// map
let map proj list = list |> Seq.fold (fun aggr item -> proj item :: aggr) []


[<EntryPoint>]

length mylist |> printfn "Length of list: %i"

max mylist |> printfn "Max elem of list: %i"

filter (fun i -> i % 2 = 0) mylist |> printfn "Even elems: %A"

map (fun i -> i * i) mylist |> printfn "Square of elems: %A"
