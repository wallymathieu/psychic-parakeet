module Tests

open System
open Xunit

[<Interface>]
type MyInterface<'T> =
    static member Map (x: MyInterface<'t>, f) = x  // error FS0868

[<Fact>]
let ``My test`` () =
    Assert.True(true)
