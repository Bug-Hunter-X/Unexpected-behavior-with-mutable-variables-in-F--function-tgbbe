let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //Prints 20 20 as expected

let swap2 x y = 
    let temp = x
    x <- y
    y <- temp

let a = 10
let b = 20
swap2 a b
printf "%d %d" a b  //Prints 10 20, mutation on immutable values failed