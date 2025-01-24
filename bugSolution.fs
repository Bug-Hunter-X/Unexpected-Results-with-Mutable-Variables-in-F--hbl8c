let x = ref 10
let y = ref 20

let add x y = !x + !y

let z = add x y
printf "%d\n" z

(*Change the value of x and y*) 
x := 100
y := 200

printf "%d\n" (add x y)