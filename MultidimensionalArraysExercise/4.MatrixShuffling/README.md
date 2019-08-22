### Problem 1.
## Exercises

## : Multidimensional Arrays

1. 4.Matrix shuffling

Write a program which reads a string matrix from the console and performs certain operations with its elements. User input is provided in a similar way like in the problems above – first you read the **dimensions** and then the **data**.

Your program should then receive commands in format: &quot; **swap row1 col1 row2c col2**&quot; where row1, row2, col1, col2 are **coordinates** in the matrix. In order for a command to be valid, it should start with the &quot; **swap**&quot; keyword along with **four valid coordinates** (no more, no less). You should **swap the values** at the given coordinates (cell [row1, col1] with cell [row2, col2]) **and print the matrix at each step** (thus you&#39;ll be able to check if the operation was performed correctly).

If the **command is not valid** (doesn&#39;t contain the keyword &quot;swap&quot;, has fewer or more coordinates entered or the given coordinates do not exist), print &quot; **Invalid input!**&quot; and move on to the next command. Your program should finish when the string &quot; **END**&quot; is entered.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 31 2 34 5 6swap 0 0 1 1swap 10 9 8 7swap 0 1 1 0END | 5 2 34 1 6Invalid input!5 4 32 1 6 |
| 1 2Hello World0 0 0 1swap 0 0 0 1swap 0 1 0 0END | Invalid input!World HelloHello World |

