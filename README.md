# Solid Principles
#### SOLID Principles and Design Models play an important role in achieving all of the following points.
* **Sustainability** : Sustainable systems are very important for organizations.</br>
* **Testability** : Test-oriented development (TDD) is required when designing and developing large-scale systems</br>
* **Flexibility and Extensibility** : Flexibility and extensibility is a very desirable factor in enterprise applications. Therefore, we should design the application in such a way as to make it flexible, so that it can be expanded so that we can adapt to work in different ways and easily add new features.</br>
* **Parallel Development**: It is one of the key features in application development because it is impractical for the entire development team to work on the same feature or component at the same time.</br>
* **Loose Coupling**: By ensuring that our design results in an application that loosely combines many of the parts that make up the application, we can address many of the requirements listed above.</br>
## Single Responsibility Principle (SRP)
[Go To Example](https://github.com/kadir-code/SolidPrinciples/tree/master/Solid_Principles/1_SingleResponsibility)
> According to the principle of sole responsibility;
There should be only one reason for a class to change.This means that each module or class must be responsible for a single piece of functionality provided by the software, and this responsibility must be fully covered by the class.
### On the Principle of Single Responsibility
* Each class and module should focus on one task at a time
* Everything in the classroom should be related to this single goal
* There can be many members in the class, as long as they are bound by one responsibility.
* With SRP, classes get smaller and become cleaner jul
* The code is less fragile

## Open Closed Principle
[Go To Example](https://github.com/kadir-code/SolidPrinciples/tree/master/Solid_Principles/2_OpenClosed)
> In object-oriented programming, the open/closed principle states that software entities such as classes, modules, functions, etc. should be open for extension, but closed for modification.
* The simplest way to apply OCP is to implement the new functionality on new derived (sub) classes that inherit the original class implementation.
* Another way is to allow client to access the original class with an abstract interface.
* So, at any given point of time when there is a requirement change instead of touching the existing functionality it’s always suggested to create new classes and leave the original implementation untouched.

## Liskov Substitution Principle
[Go To Example](https://github.com/kadir-code/SolidPrinciples/tree/master/Solid_Principles/4_LiskovSubstitution)

>  Substitutability is a principle in object-oriented programming and it states that, in a computer program, if S is a Subtype of T, then objects of type T may be replaced with objects of type S.
 * No new exceptions can be thrown by the subtype unless they are part of the existing exception hierarchy.
* We should also ensure that Clients should not know which specific subtype they are calling, nor should they need to know that. The client should behave the same regardless of the subtype instance that it is given.
* New derived classes just extend without replacing the functionality of old classes.
## Interface Segregation Principle
[Go To Example](https://github.com/kadir-code/SolidPrinciples/tree/master/Solid_Principles/3_InterfaceSegregation)

* The interface-segregation principle (ISP) states that "no client should be forced to depend on methods it does not use".
* This means, instead of one fat interface many small interfaces are preferred based on groups of methods with each one serving one sub-module.

## Dependency Inversion Principle 
[Go To Example](https://github.com/kadir-code/SolidPrinciples/tree/master/Solid_Principles/5_DependencyInversion)

During the process of the application design, lower-level components are designed to be consumed by higher-level components which enable increasingly complex systems to be built. In this Process of Composition, higher-level components depend directly upon lower-level components to achieve some task. 

This dependency upon lower-level components limits the reuse opportunities of the higher-level components and ends up in a bad design.

![alt text for screen readers](https://2.bp.blogspot.com/-t7SjX8d-qO4/WmelpGLuMYI/AAAAAAAApVg/w1dKddt0kLQvY5WZqdZcACx85tIlzuvPACLcBGAs/s1600/dependency%2Binversion%2Bprinciple.png "Text to show on mouseover")

From the illustrated diagram, High-level Modules depends directly on Low-level Modules and this does not follow the first point of DIP. 
This flow certainly looks good, but we're combining different layers, so any further changes would be complex and hard to change.
