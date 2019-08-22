### Problem 1.
## Exercises

## : Multidimensional Arrays

1. 7. Knight Game

Chess is the oldest game, but it is still popular these days. For this task we will use only one chess piece – the **Knight**.

The knight moves to the **nearest** square but **not on the same ** [**row**](https://en.wikipedia.org/wiki/Glossary_of_chess#rank), [**column**](https://en.wikipedia.org/wiki/Glossary_of_chess#file), or [**diagonal**](https://en.wikipedia.org/wiki/Glossary_of_chess#diagonal). (This can be thought of as moving two squares horizontally, then one square vertically, or moving one square horizontally then two squares vertically— i.e. in an &quot; **L**&quot; pattern.)

The knight game is played on a board with dimensions **N x N** and a lot of chess knights **0 \&lt;= K \&lt;= N**
# 2
.

You will receive a board with **K** for knights and &#39; **0&#39;** for empty cells. Your task is to remove a minimum of the knights, so there will be no knights left that can attack another knight.

### Input

On the first line, you will receive the **N** size of the board

On the next **N** lines, you will receive strings with **Ks** and **0s**.

### Output

Print a single integer with the minimum number of knights that needs to be removed

### Constraints

- Size of the board will be 0 \&lt; N \&lt; 30
- Time limit: 0.3 sec. Memory limit: 16 MB.

### Examples

| **Input** | **Output** |
| --- | --- |
| 5 0K0K0K000K00K00K000K 0K0K0 | 1 |
| 2KKKK | 0 |
| 80K0KKK000K00KKKK00K0000KKKKKKK0KK0K0000KKK00000K00K0K000000K00KK | 12 |

