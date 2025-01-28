# F# Mutable Variable Bug

This repository demonstrates a common error in F# related to mutable variables and the use of values vs references.  When passing values to a function that intends to modify them, if the passed values aren't mutable references, the modification within the function doesn't affect the original variables.

The `bug.fs` file showcases this issue.  The `bugSolution.fs` demonstrates how to correctly use mutable references to achieve the desired outcome.  This example specifically focuses on the unexpected behavior when attempting to swap the values of two integer variables.

## How to Reproduce

1. Clone the repository.
2. Compile and run `bug.fs`. Observe the unexpected output.
3. Compile and run `bugSolution.fs`. Observe the correct output.

## Solution

The solution involves using `ref` to create mutable references to the integer variables. The function then operates on these references, correctly modifying the original variables.