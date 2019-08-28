## Problem 1.
# Exercises

# : Sets and Dictionaries Advanced

1. Problem 6.Wardrobe

Write a program that helps you decide what **clothes** to wear from your **wardrobe**. You will receive the **clothes** , which are currently in your wardrobe, sorted by their **color** in the following **format** :

&quot; **{color} -\&gt; {item1},{item2},{item3}…**&quot;

If you receive a certain color, which already **exists** in your wardrobe, just **add** the clothes to **its**** records **. You can also receive** repeating ****items** for a certain **color** and you have to keep their **count**.

In the end, you will receive a **color** and a piece of **clothing** , which you will **look for** in the wardrobe, separated by a space in the following format:

**&quot;{color} {clothing}&quot;**

Your task is to print all the **items** and their **count** for **each**** color **in the following format** :**

**&quot;{color}**** clothes**:

\* **{item1}** - **{count}**

\* **{item2}** - **{count}**

\* **{item3}** - **{count}**

…

\* **{itemN}** - **{count}&quot;**

If you find the **item** you are **looking for** , you need to print **&quot;(found!)&quot;** next to it:

&quot;\* **{itemN}** - **{count} (found!)&quot;**

### Input

- On the **first**** line **, you will receive** n **–  the** number of lines** of clothes, which you will receive.
- On the next **n** lines, you will receive the **clothes** in the **format**** described** above.

### Output

- Print the **clothes** from your wardrobe in the **format**** described** above.

### Examples

| **Input** | **Output** |
| --- | --- |
| 4Blue -\&gt; dress,jeans,hatGold -\&gt; dress,t-shirt,boxersWhite -\&gt; briefs,tanktopBlue -\&gt; glovesBlue dress | Blue clothes:\* dress - 1 (found!)\* jeans - 1\* hat - 1\* gloves - 1Gold clothes:\* dress - 1\* t-shirt - 1\* boxers - 1White clothes:\* briefs - 1\* tanktop - 1 |
| 4Red -\&gt; hatRed -\&gt; dress,t-shirt,boxersWhite -\&gt; briefs,tanktopBlue -\&gt; glovesWhite tanktop | Red clothes:\* hat - 1\* dress - 1\* t-shirt - 1\* boxers - 1White clothes:\* briefs - 1\* tanktop - 1 (found!)Blue clothes:\* gloves - 1  |
| 5Blue -\&gt; shoesBlue -\&gt; shoes,shoes,shoesBlue -\&gt; shoes,shoesBlue -\&gt; shoesBlue -\&gt; shoes,shoesRed tanktop | Blue clothes:\* shoes - 9 |


