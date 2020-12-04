// Learn more about F# at http://fsharp.org

open System
open FSharp.Data
open System.IO
open System.Reflection

type DayOneCsv = CsvProvider<"/workspace/advent-of-code-2020/day-one/input.csv">

[<EntryPoint>]
let main argv =
    let inputCsv = DayOneCsv.Load "/workspace/advent-of-code-2020/day-one/input.csv"

    let input = [for row in inputCsv.Rows -> row.Input]

    let rec getAnswerOne myList =
        match myList with
        h :: t -> match List.tryPick (fun v -> if(v + h = 2020) then Some(v, h) else None) t with
                    | Some answer -> answer
                    | None -> getAnswerOne t
        | [] -> (0, 0)            

    let (x, y) = getAnswerOne input
    printfn "Value One: %i Value Two: %i" x y
    printfn "The answer is %i" (x * y)

    0 // return an integer exit code
