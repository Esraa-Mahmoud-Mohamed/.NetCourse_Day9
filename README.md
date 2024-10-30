# .NET Course - Day 9

## Project Overview
This repository contains tasks and solutions for **Day 9** of the .NET course. The goal of this course is to build foundational skills in C# and .NET, focusing on object-oriented programming, project structuring, and utilizing various .NET libraries and frameworks.

## Project Structure
The repository includes three tasks (`Task1.sln`, `Task2.sln`, and `Task3.sln`). Each solution focuses on specific programming concepts and implementations covered during Day 9 of the course:

### Task 1: Point3D Class
**Description**: This task involves creating a `Point3D` class to represent a point in 3D space with integer coordinates `x`, `y`, and `z`. The class includes:
- **Properties**: Getter and setter methods for each coordinate (`X`, `Y`, `Z`).
- **Constructors**: A default constructor initializes coordinates to `(0, 0, 0)`, and a parameterized constructor allows setting specific values.
- **ToString Method**: Overrides the default `ToString` to display the point as `Point Coordinates: (x, y, z)`.

### Task 2: Math Class
**Description**: This task defines a static `Math` class that provides basic arithmetic operations:
- **Add**: Takes two integers and returns their sum.
- **Subtract**: Takes two integers and returns the result of the first minus the second.
- **Multiply**: Takes two integers and returns their product.
- **Divide**: Takes two integers and returns the result of the first divided by the second (integer division).

**Code Example**:
```csharp
int sum = Math.Add(5, 3);           // Output: 8
int difference = Math.Subtract(5, 3); // Output: 2
int product = Math.Multiply(5, 3);  // Output: 15
int quotient = Math.Divide(6, 3);   // Output: 2
```
### Task 3: Duration Class
**Description**: This task involves creating a Duration class that represents a duration in hours, minutes, and seconds. It includes:

- **Properties**: Hours, Minutes, and Seconds with getter and setter methods.
- **Constructors**:
A parameterized constructor that accepts hours, minutes, and seconds.
A constructor that accepts seconds and converts it into hours, minutes, and seconds.
- **Time Normalization**: Ensures that values remain within standard ranges (e.g., seconds less than 60).
- **Operators**: Overloads for +, ++, --, and comparison operators (>, <, >=, <=).


**Code Example**:
```csharp
Duration duration1 = new Duration(1, 45, 30);  // 1 hour, 45 minutes, and 30 seconds
Duration duration2 = new Duration(3600);       // 1 hour
Duration total = duration1 + duration2;        // Adds the two durations
```
