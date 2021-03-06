# SharpVG

A .NET Standard library for F# to generate vector graphics in SVG format.

_[Pull requests](https://github.com/ChrisNikkel/SharpVG/pulls) and [suggestions](https://github.com/ChrisNikkel/SharpVG/issues) are greatly appreciated._

[Source code on GitHub](https://github.com/ChrisNikkel/SharpVG)

[![Travis CI Build Status](https://travis-ci.org/ChrisNikkel/SharpVG.svg?branch=master)](https://travis-ci.org/ChrisNikkel/SharpVG) [![Join the chat at https://gitter.im/SharpVG/Lobby](https://badges.gitter.im/SharpVG/Lobby.svg)](https://gitter.im/SharpVG/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)[![NuGet Badge](https://buildstats.info/nuget/SharpVG)](https://www.nuget.org/packages/SharpVG/)

[![Build history](https://buildstats.info/travisci/chart/ChrisNikkel/SharpVG?showStats=false)](https://travis-ci.org/ChrisNikkel/SharpVG)

## Why SharpVG?

  - Allows you to emit SVG using simple F# commands so that you can create graphics and animations that are easy to distribute
  - Ability to render dynamically using [Fable](http://fable.io) to create interactive web pages
  - All basic SVG elements are supported: [line](https://github.com/ChrisNikkel/SharpVG/wiki/Line), [circle](https://github.com/ChrisNikkel/SharpVG/wiki/Circle), [ellipse](https://github.com/ChrisNikkel/SharpVG/wiki/Ellipse), [rect](https://github.com/ChrisNikkel/SharpVG/wiki/Rect), [text](https://github.com/ChrisNikkel/SharpVG/wiki/Text), [polygon](https://github.com/ChrisNikkel/SharpVG/wiki/Polygon), [polyline](https://github.com/ChrisNikkel/SharpVG/wiki/polyLine), [path](https://github.com/ChrisNikkel/SharpVG/wiki/Path), [image](https://github.com/ChrisNikkel/SharpVG/wiki/Image), and [groups](https://github.com/ChrisNikkel/SharpVG/wiki/Group)
  - No understanding of SVG is required and its as easy as using seq, list, or array
  - No external dependencies other than SharpVG are required
  - .NET Standard cross platform support on Windows, Linux, and OSX
  - Limited support for SVG animations
  - Limited support for cartesian plotting
  - Reusable styles

## Examples

```F#
let position = Point.ofInts (10, 10)
let area = Area.ofInts (50, 50)
let style = Style.create (Color.ofName Colors.Cyan) (Color.ofName Colors.Blue) (Length.ofInt 3) 1.0 1.0

Rect.create position area
  |> Element.createWithStyle style
  |> printf "%O"
```

```html
<rect stroke="blue" stroke-width="3" fill="cyan" opacity="1" x="10" y="10" height="50" width="50"/>
```

```F#
let center = Point.ofInts (60, 60)
let radius = Length.ofInt 50
let style = Style.create (Color.ofName Colors.Violet) (Color.ofName Colors.Indigo) (Length.ofInt 3) 1.0 1.0

Circle.create center radius
  |> Element.createWithStyle style
  |> Svg.ofElement
  |> Svg.toHtml "Example"
  |> printf "%s"
```

```html
<!DOCTYPE html>
<html>
<head>
<title>Example</title>
</head>
<body>
<svg><circle stroke="indigo" stroke-width="3" fill="violet" opacity="1" r="50" cx="60" cy="60"/></svg>
</body>
</html>
```

## Building SharpVG

Clone the repository:
```bash
git clone https://github.com/ChrisNikkel/SharpVG.git
cd SharpVG/SharpVG
```

Start the build:
```bash
dotnet build
```

Run the tests:
```bash
dotnet test Tests
```

Run the examples:
```bash
dotnet run -p Examples\Triangle\Triangle.fsproj
dotnet run -p Examples\Life\Life.fsproj
dotnet run -p Examples\Graph\Graph.fsproj
```

Run the [Fable](http://fable.io) example ([prerequisites](http://fable.io/pages/prerequisites.html)):
```bash
cd Examples\Bounce\src
dotnet restore
dotnet fable yarn-run start
```

Explore interactively:
```bash
fsharpi -r:SharpVG/bin/Debug/netcoreapp2.0/SharpVG.dll
```
```F#
open SharpVG;;
Circle.create Point.origin (Length.ofInt 10) |> printf "%O";;
Circle.create Point.origin (Length.ofInt 10) |> Element.create |> Svg.ofElement |> Svg.toHtml "Example";;
#quit;;
```
## Documentation

Read the documentation [here](https://github.com/ChrisNikkel/SharpVG/wiki).

## Support

Please submit bugs and feature requests [here](https://github.com/ChrisNikkel/SharpVG/issues).

## Library License

The library is available under the MIT license. For more information see the [license file](https://github.com/ChrisNikkel/SharpVG/blob/master/LICENSE.md).

## Maintainer(s)

  - [@ChrisNikkel](https://githu://github.com/ChrisNikkel/SharpVG/wikib.com/ChrisNikkel)
