## I.
# Lab: Sets and Dictionaries Advanced

1. II.Sets

1. 6.Parking Lot

Write a program that:

- Records a **car number** for every car that enters the **parking lot**
- Removes a **car number** when the car leaves the **parking lot**

The input will be a string in the format: **[direction, carNumber]**. You will be receiving commands, until the **&quot;**** END ****&quot;** commandisgiven.

Print the car numbers of the cars, which are still in the parking lot:

#### Examples

| **Input** | **Output** |
| --- | --- |
| IN, CA2844AAIN, CA1234TAOUT, CA2844AAIN, CA9999TTIN, CA2866HIOUT, CA1234TAIN, CA2844AAOUT, CA2866HIIN, CA9876HHIN, CA2822UUEND | CA9999TTCA2844AACA9876HHCA2822UU |
| IN, CA2844AAIN, CA1234TAOUT, CA2844AAOUT, CA1234TAEND | Parking Lot is Empty |

#### Hints

- Car numbers are **unique**
- Before printing, **first**** check** if the set has any elements

