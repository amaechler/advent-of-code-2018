namespace Days

open System.IO

module Day1 =
    let run = 
        let changesOfFrequency = 
            File.ReadLines("./input/day1.txt") 
                |> Seq.map (string >> int) 

        // part 1
        let resultingFrequency = changesOfFrequency |> Seq.sum
        printfn "Resulting frequency %d" resultingFrequency

        0