﻿module GraphExample

open SharpVG
open Helpers.File
open System

[<EntryPoint>]
let main argv =

    let fileName = "Graph.html"
    let plot2 = Plot.plot[ for i in 0.0 .. 0.02 .. 2.0 * Math.PI -> (500.0 * cos i * sin i, 500.0 * sin i) ]

    Plot.plot [ for i in 0.0 .. 0.02 .. 2.0 * Math.PI -> (1000.0 * sin i, 1000.0 * cos i * sin i) ]
        |> Plot.addPlot plot2
        |> Svg.ofPlot
        |> Svg.toHtml "SVG Graph Example"
        |> saveToFile fileName

    openFile fileName
    0 // return an integer exit code
