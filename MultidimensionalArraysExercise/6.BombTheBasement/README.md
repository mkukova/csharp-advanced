### Problem 1.
## Exercises

## : Multidimensional Arrays


1. 6.Bomb the Basement

You are angry with your neighbor and you wish to get back on him for the constant noise complaints that he files against you. The most valuable things he has are stored in his basement. You have a plan – designing small bombs to bomb it. The basement is in the form of a square. It is full of cells with items.

You will be given the dimensions of the basement. After that you will be given the coordinates of the cells that store the most valuable items – you should bomb them. When a bomb explodes it has an impact and it destroys all of the items in a certain radius, which will be given to you. The items **should be represented by**** 0 **. You can check whether a cell is inside the blast radius using the** Pythagorean Theorem **. The bomb leaves the cells without an item.** You should use the number 1 to represent that **. The items above the exploded area start going up until they land on another symbol** (meaning an item moves down a row as long as there is a -1 below) **. When the horror ends, print on the console the** resulting basement, each row on a new line**. You should check out the examples.

### **Input**

- The input data should be read from the console. It consists of exactly three lines
- On the first line, you&#39;ll receive the **dimensions** of the stairs in format: **&quot;N M&quot;** , where **N** is the number of **rows** , and **M** is the number of **columns**. They&#39;ll be separated by a single space
- On the second line, you&#39;ll receive the **bomb parameters (target row, target column and radius)**, all separated by a **single space**
- The input data will always be valid and in the format described. There is no need to check it explicitly

### **Output**

- The output should be printed on the console. It should consist of **N lines**
- Each line should contain a string representing the respective row of the final matrix

### **Constraints**

- The **dimensions** N and M of the matrix will be integers in the range [1 … 12]
- The items will represent characters
- The shot&#39;s **impact row and column** will always be **valid coordinates** in the matrix – they will be integers in the range [0 … N – 1] and [0 … M – 1] respectively
- The shot&#39;s **radius** will be an integer in the range [0 … 4]

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 5 62 3 2 | 011111001110001110000100000100 | The matrix has 5 rows and 6 columns. Fill it with zeros:

| 0 | 0 | 0 | 0 | 0 | 0 |
| --- | --- | --- | --- | --- | --- |
| 0 | 0 | 0 | 0 | 0 | 0 |
| 0 | 0 | 0 | 0 | 0 | 0 |
| 0 | 0 | 0 | 0 | 0 | 0 |
| 0 | 0 | 0 | 0 | 0 | 0 |

The shot lands on cell (2,3). It has a radius of 2 cells. The impact cell is shaded black and the other cells within the shot radius are shaded grey.

| 0 | 0 | 0 | 0 | 0 | 0 |
| --- | --- | --- | --- | --- | --- |
| 0 | 0 | 0 | 0 | 0 | 0 |
| 0 | 0 | 0 | 0 | 0 | 0 |
| 0 | 0 | 0 | 0 | 0 | 0 |
| 0 | 0 | 0 | 0 | 0 | 0 |

 Replace all zeros in the blast area with 1:

| 0 | 0 | 0 | 1 | 0 | 0 |
| --- | --- | --- | --- | --- | --- |
| 0 | 0 | 1 | 1 | 1 | 0 |
| 0 | 1 | 1 | 1 | 1 | 1 |
| 0 | 0 | 1 | 1 | 1 | 0 |
| 0 | 0 | 0 | 1 | 0 | 0 |

 The resulting matrix should look like this:

| 0 | 1 | 1 | 1 | 1 | 1 |
| --- | --- | --- | --- | --- | --- |
| 0 | 0 | 1 | 1 | 1 | 0 |
| 0 | 0 | 1 | 1 | 1 | 0 |
| 0 | 0 | 0 | 1 | 0 | 0 |
| 0 | 0 | 0 | 1 | 0 | 0 |

  |

