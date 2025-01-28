let mutable x = ref 10
let mutable y = ref 20

let swap x y = 
    let temp = !x
    x := !y
    y := temp

swap x y
printf "%d %d" !x !y //Prints 20 10 as expected

//Alternative solution using tuples:
let swapTuple (x,y) = (y,x)
let a = 10
let b = 20
let (a', b') = swapTuple (a,b)
printf "%d %d" a' b' //Prints 20 10