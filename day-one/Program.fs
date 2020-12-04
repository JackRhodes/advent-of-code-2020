// Learn more about F# at http://fsharp.org

open System
open FSharp.Data
open System.IO
open System.Reflection

type DayOneCsv = CsvProvider<"input.csv">

[<EntryPoint>]
let main argv =
    let inputCsv = DayOneCsv.Load "/workspace/advent-of-code-2020/day-one/input.csv"
    let input = [for row in inputCsv.Rows -> row.Input]

    printfn "%A" input
  
    0 // return an integer exit code
