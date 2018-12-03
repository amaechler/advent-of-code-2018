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


module Day2 =
    let run =
        let ids = 
            File.ReadLines("./input/day2.txt") 

        // part 1
        let counts =
            ids
                |> Seq.map( fun a ->
                    let grouped = a |> Seq.groupBy id
                    let count2 = Seq.exists (fun x -> snd x |> Seq.length = 2) grouped
                    let count3 = Seq.exists (fun x -> snd x |> Seq.length = 3) grouped
                    count2, count3 )

        let counts2 = Seq.where ( fun a -> (fst a) ) counts |> Seq.length
        let counts3 = Seq.where ( fun a -> (snd a) ) counts |> Seq.length

        printfn "%d * %d = %d" counts2 counts3 (counts2 * counts3)

        // part 2
        let t = 
            ids
                |> Seq.map( fun a -> a |> Seq.map( char >> int ) )
                |> Seq.toList

        for x in 0..t.Length - 1 do
            for y in (x + 1)..t.Length - 1 do
                Seq.map2( fun a b -> if abs( int a - int b ) > 0 then 1 else 0 ) t.[x] t.[y]
                    |> Seq.sum
                    |> (fun a -> 
                        if a <= 1 then
                            printfn "1: %s" (Seq.toList ids).[x]
                            printfn "2: %s" (Seq.toList ids).[y]
                            printfn "Sum: %d" a
                    )
