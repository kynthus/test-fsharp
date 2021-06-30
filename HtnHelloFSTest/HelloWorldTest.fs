module HtnHelloFSTest

open NUnit.Framework
open HtnHelloFS

[<Test>]
let ResultOfGreet () =
    Assert.AreEqual(HtnHelloFS.greet, "Hello, World!")

[<EntryPoint>]
let main _ = 
    ResultOfGreet()
    0
