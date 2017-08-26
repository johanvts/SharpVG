﻿namespace SharpVG.Tests

open SharpVG
open Xunit
module TestImage =

    [<Fact>]
    let ``create image`` () =
        Assert.Equal("<image x=\"0\" y=\"0\" height=\"100%\" width=\"100%\" xlink:href=\"test.jpg\"/>", Image.create Point.origin Area.full "test.jpg" |> Image.toString)