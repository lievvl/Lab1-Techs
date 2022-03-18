namespace TestFarsh
module Farsh =
    let sum n = 
        [1..n]
        |> List.sum

    type Shape =
    | Circle of radius : float
    | Square of length : float
    | Rectangle of length : float * width : float

    let pi = 3.14

    let area shape =
        match shape with
        | Circle r -> pi * r * r
        | Square s -> s * s
        | Rectangle(l, w) -> l * w