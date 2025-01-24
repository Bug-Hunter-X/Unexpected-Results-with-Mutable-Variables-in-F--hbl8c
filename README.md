# Unexpected Results with Mutable Variables in F# 

This example demonstrates a common issue in F# when dealing with mutable variables and function calls.  The result of a function call doesn't automatically update when mutable variables used within the function are later changed. This can lead to confusion and unexpected behaviour in your program.

## Bug
The original code shows a simple function `add` that adds two numbers. However, even though the mutable variables `x` and `y` are modified *after* the initial function call, the output remains the same. This is because the function uses the values of `x` and `y` at the time of its invocation, rather than dynamically updating with the changed values.