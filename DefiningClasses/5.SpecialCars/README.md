# Problem 1.Defining Classes - Lab

# Problem 6.Problem 5. Special Cars

This is the final and most interesting problem in this lab. Until you receive the command **&quot;No more tires&quot;**** ,**you will be given tire info in the format:

**{year} {pressure}**

**{year} {pressure}**

**…**

**&quot;No more tires&quot;**

You have to collect all the tires provided. Next, until you receive the command **&quot;Engines done&quot;** you will be given engine info and you also have to collect all that info.

**{horsePower} {cubicCapacity}**

**{horsePower} {cubicCapacity}**

**…**

The final step - until you receive **&quot;Show special&quot;**** ,**you will be given information about cars in the format:

**{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}**

**…**

Every time you have to create a **new Car** with the information provided. The car engine is the provided **engineIndex**  and the tires are **tiresIndex**. Finally, collect all the created cars. When you receive the command **&quot;Show special&quot;**** ,**drive 20 kilometers all the cars, which were manufactured during 2017 or after, have horse power above 330 and the sum of their tire pressure is between 9 and 10. Finally, print information about each special car in the following format:

&quot;Make: {specialCar.Make}&quot;

&quot;Model: {specialCar.Model}&quot;

&quot;Year: {specialCar.Year}&quot;

&quot;HorsePowers: {specialCar.Engine.HorsePower}&quot;

&quot;FuelQuantity: {specialCar.FuelQuantity}&quot;

| **Input** | **Output** |
| --- | --- |
| 2 2.6 3 1.6 2 3.6 3 1.61 3.3 2 1.6 5 2.4 1 3.2No more tires331 2.2145 2.0Engines doneAudi A5 2017 200 12 0 0BMW X5 2007 175 18 1 1Show special | Make: AudiModel: A5Year: 2017HorsePowers: 331FuelQuantity: 197.6 |