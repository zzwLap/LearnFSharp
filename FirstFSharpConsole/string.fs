
let simpleStr:string ="abc"
let byteArray:byte[]="abc"B

let orgStr="abc
def"
let noOrgStr="abc\
def"

printfn "%s" orgStr
printfn "%s" noOrgStr

let printChar(str:string)(index:int)=printfn "first character: %c" (str.Chars(index))

printChar(orgStr)(1)

printfn ""
printfn "Interpolated strings";
printfn ""


let name = "Phillip"
let age = 30
printfn $"Name: {name}, Age: {age}"

printfn $"I think {3.0 + 0.14} is close to {System.Math.PI}!"

//escape {}
let escapeBraceStr = $"A pair of braces: {{}}"    // "A pair of braces: {}"

printfn "%s" escapeBraceStr


printfn $"""Name: {"Phillip"}, Age: %d{age}"""

let pi = $"%0.3f{System.Math.PI}"  // "3.142"
let code = $"0x%08x{43962}"  // "0x0000abba"

let data = [0..4]
let output = $"The data is %A{data}"  // "The data is [0; 1; 2; 3; 4]"

let dotnetStyle_pi = $"{System.Math.PI:N4}"  // "3.1416"
let dotnetStyle_now = $"{System.DateTime.UtcNow:yyyyMMdd}" // for example, "20220210"

// `` escape unusual character
let dotnetStyle_now2 = $"{System.DateTime.UtcNow:``yyyy~~MM~~dd``}" // for example, "20220210"

printfn "%s" dotnetStyle_now 
printfn "%s" dotnetStyle_now2 

//align rules
printfn $"""|{"Left",-7}|{"Right",7}|"""  // |Left   |  Right|


//escape $ rules
let twoDollarEscape = $$"""A string containing some {curly braces} and an {{"F#" + " " + "expression"}}."""
// "A string containing some {curly braces} and an F# expression."
let threeDollarEscape = $$$"""A string with pairs of {{ and }} characters and {{{ "an F# expression" }}}."""
// "A string with pairs of {{ and }} characters and an F# expression."""

// % also affected
let percent = $$"""50% of 20 is %%.1f{{20m * 0.5m}}""" 
// "50% of 20 is 10.0"

printfn "%s"  twoDollarEscape
printfn "%s"  threeDollarEscape
printfn "%s"  percent

