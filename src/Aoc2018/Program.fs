[<EntryPoint>]
let main argv =
    let arglist = argv |> List.ofSeq
    let dayToRun = 
        match arglist with 
            | [first] ->
                first |> int
            | _ ->
                0

    // day runs are expected to print their results to stdout
    match dayToRun with
        | 1 ->
            Days.Day1.run |> ignore
            Aoc2018Lib.Days.RunDay1() |> ignore
            0
        | _ ->
            printfn "Unknown day"
            -1
