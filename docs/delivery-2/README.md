<h1 align="center">Second Delivery</h1>

Organizing the project. Refining the requeriments and design.

- [Presentation Video describing the delivery]().
- Report with documentation:
1. [Functional requirements.](https://github.com/ChristianFlor/gas-impact-analyzer-in-crops/blob/master/docs/delivery-2/Requerimientos%20funcionales%20ERS.pdf)
2. [Class diagram design](https://github.com/ChristianFlor/gas-impact-analyzer-in-crops/blob/master/docs/delivery-2/Class%20diagram%20design.png)
3. [Git model of the project.](https://github.com/ChristianFlor/gas-impact-analyzer-in-crops/blob/master/docs/delivery-2/Git%20model%20of%20the%20project.pdf)

- Program source code in C#

<h2> 5 reports will be made consisting of:</h2>

* Heat map depending on the crop (an implementation example is ready)
* Linear graphics
* Circular graph with the percentage of contamination in each crop
* Visualization of each database in a Table
* Filter by corresponding fields in a Table relating the data between the 3 databases.

<h2> List of responsibilities: </h2>

+ UI GitHub: [Christian Flor](https://github.com/ChristianFlor)
+ Model: [Cesar Canales](https://github.com/Sleeptightt), [Carlos Restrepo](https://github.com/Carlosches)
+ Data: [Felipe Sánchez](https://github.com/SanchezFelipe01)
+ Documentation - [Cesar Canales](https://github.com/Sleeptightt)
+ Tests: [Daniel Fernández](https://github.com/7yrionLannister)

<h2>The information algorithm that we are going to implement was defined using the Association Rule Learning technique.</h2>

<p>In data mining and machine learning, association rules are used to discover common occurrences within a given data set. Because we have 3 databases we must find combinations of factors (gas concentration, humidity, temperature, elevation, among others) which are determining factors in the growth of crops.<p>

The algorithm we chose to search the association rules in the databases is:

  <h3>Apriori</h3>
  
  - Find the most frequent associations
  - It iterates over the database until the associations
  - Obtained do not have the minimum support
  - Simple but robust method
  - Intuitive output





