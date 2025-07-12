let rec fib n =
    match n with
    | 0 | 1 -> n
    | n -> fib (n-1) + fib (n-2)

//implicit rec keyword
type MyClass() =
    member this.Fib(n) =
        match n with
        | 0 | 1 -> n
        | n -> this.Fib(n-1) + this.Fib(n-2)

//Mutually Recursive Functions
let rec Even x = if x = 0 then true else Odd(x - 1)
and Odd x = if x = 0 then false else Even(x - 1)

//Recursive values
let rec nameDoubles = nameof nameDoubles + nameof nameDoubles


