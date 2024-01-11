# 🌐 Welcome to the "DesignPatterns" repository! 🚀

Explore the world of design patterns through comprehensive implementations, detailed descriptions, diagrams, and practical examples in multiple programming languages.

# ❓ What's Inside :

## Creational Patterns 🏭:

🌱 **Singleton Pattern:** Ensures that a class only has one instance and provides a global point of access to it. <br/><br/>
🏗️ **Builder Pattern:** Separates the construction of a complex object from its representation so that the same construction process can create different representations.<br/><br/>
🏭 **Abstract Factory Pattern:** Provides an interface for creating related or dependent objects without specifying the objects' concrete classes.<br/><br/>
🏭 **Factory Method Pattern:** Allows a class to defer instantiation to subclasses.<br/><br/>
🍃 **Prototype Pattern:** Specifies the kind of object to create using a prototypical instance and creates new objects by cloning this prototype.<br/><br/>

## Structural Patterns 🏗️:

🧩 **Adapter Pattern:** Adapts one interface for a class into one that a client expects.<br/>
  - Adapter Pipeline: Uses multiple adapters for debugging purposes.<br/>
  - Retrofit Interface Pattern: An adapter used as a new interface for multiple classes at the same time.<br/>
  
🏰 **Aggregate Pattern:** A version of the Composite pattern with methods for the aggregation of children.<br/><br/>
🌉 **Bridge Pattern:** Decouples an abstraction from its implementation so that the two can vary independently.<br/>
  - Tombstone: An intermediate "lookup" object contains the real location of an object.<br/>
  
🌲 **Composite Pattern:** A tree structure of objects where every object has the same interface.<br/><br/>
🛡️ **Decorator Pattern:** Adds additional functionality to an object at runtime where subclassing would result in an exponential rise of new classes.<br/><br/>
🚀 **Extensibility Pattern:** A.k.a. Framework - hides complex code behind a simple interface.<br/><br/>
🏰 **Facade Pattern:** Creates a simplified interface of an existing interface to ease usage for common tasks.<br/><br/>
🧱 **Flyweight Pattern:** A large quantity of objects share a common properties object to save space.<br/><br/>
🚩 **Marker Pattern:** An empty interface to associate metadata with a class.<br/><br/>
🚰 **Pipes and Filters:** A chain of processes where the output of each process is the input of the next.<br/><br/>
🕵️ **Opaque Pointer:** A pointer to an undeclared or private type to hide implementation details.<br/><br/>
👥 **Proxy Pattern:** A class functioning as an interface to another thing.<br/><br/>

## Behavioral Patterns 🔄:

⬛ **Blackboard Design Pattern:** Provides a computational framework for the design and implementation of systems that integrate large and diverse specialized modules and implement complex, non-deterministic control strategies.<br/><br/>
⛓ **Chain of Responsibility Pattern:** Command objects are handled or passed on to other objects by logic-containing processing objects.<br/><br/>
⚔️ **Command Pattern:** Command objects encapsulate an action and its parameters.<br/><br/>
🔄 **"Externalize the Stack":** Turns a recursive function into an iterative function that uses a stack.<br/><br/>
🎤 **Interpreter Pattern:** Implements a specialized computer language to rapidly solve a specific set of problems.<br/><br/>
🔍 **Iterator Pattern:** Iterators are used to access the elements of an aggregate object sequentially without exposing its underlying representation.<br/><br/>
🕊️ **Mediator Pattern:** Provides a unified interface to a set of interfaces in a subsystem.<br/><br/>
📜 **Memento Pattern:** Provides the ability to restore an object to its previous state (rollback).<br/><br/>
🚫 **Null Object Pattern:** Designed to act as a default value of an object.<br/><br/>
🕵️ **Observer Pattern:** Also known as Publish/Subscribe or Event Listener. Objects register to observe an event that may be raised by another object.<br/>
  - Weak Reference Pattern: De-couples an observer from an observable.<br/> 
  
🌐 **Protocol Stack:** Communications are handled by multiple layers, forming an encapsulation hierarchy.<br/><br/>
🕰️ **Scheduled-Task Pattern:** A task is scheduled to be performed at a particular interval or clock time (used in real-time computing).<br/><br/>
🍽️ **Single-Serving Visitor Pattern:** Optimizes the implementation of a visitor that is allocated, used only once, and then deleted.<br/><br/>
🔍 **Specification Pattern:** Recombinable business logic in a boolean fashion.<br/><br/>
🔄 **State Pattern:** A clean way for an object to partially change its type at runtime.<br/><br/>
🎭 **Strategy Pattern:** Algorithms can be selected on the fly, using composition.<br/><br/>
📑 **Template Method Pattern:** Describes the skeleton of a program; algorithms can be selected on the fly, using inheritance.<br/><br/>
👨‍👩‍👧‍👦 **Visitor Pattern:** A way to separate an algorithm from an object.<br/><br/>

## 🎨 Examples in Various Languages :

🌟 C#<br/>
🐍 Python<br/>
☕ Java<br/>
🚀 Your Favorite Language: Contribute your implementations in your preferred language!<br/>

# 🛠️ How to Use:

Clone the repository: <br/><br/>
      ```git clone https://github.com/your-username/DesignPatterns.git ``` <br/><br/>
Explore the directories based on the design pattern and language of your choice.<br/>
   Dive into detailed explanations, diagrams, and executable examples.<br/>


# Git workflow

## Branches

In order to start developing, please create your own branch:
`git checkout -b "<type>/<branch-name>"`

- Type: (feature | fix | docs | refactor | test)
- Name: patternName-languageName

ex. refactor: visitor-csharp

## Commits

Please use following commits name convention:
`<type>: commit name`

- Type: feature | fix | docs | refactor | test
- Name: lowercase

ex. fix: add missing dependcy

## Pull request

Please use following pull request name convention:
`<Type>: commit name`

- Type: feature | fix | docs | refactor | test
- Name: lowercase

ex. Feature: add visitor pattern
<br>
Additionally list in pull request description main changes.

### Merging

⚠ Use squash and merge ⚠

# 🤝 How to contribute?

0. Create a new branch with pattern name and language use (lowercase with dash '-' sign) -> vistor-csharp
1. Create a folder for pattern -> /Visitor<br/>
2. Create a README.md inside the pattern folder -> /Visitor/README.md<br/>
3. Create a language folder inside the pattern folder -> /Visitor/CSharp<br/>
4. Create your example project folder inside the language folder with "...Example" suffix -> /Visitor/CSharp/ShoppingCartExample<br/>
5. Create a Diagrams folder inside your project -> /Visitor/CSharp/ShoppingCartExample/Diagrams<br/>
6. Create a diagrams.drawio file with the app.diagrams.net and place it in the Diagrams folder -> /Visitor/CSharp/ShoppingCartExample/Diagrams/diagrams.drawio<br/>
7. Export relevant diagrams to .png/.jpg to the Diagrams folder -> /Visitor/CSharp/ShoppingCartExample/Diagrams<br/>
8. Create a README.md describing your example and paste the images to the README.md using img src tags<br/>
9. Commit, push and create pull request


Share your knowledge by contributing implementations and examples in your favorite programming language. Report issues or suggest improvements to enhance the learning experience for everyone.

Embark on a journey to master design patterns and elevate your software design skills! Happy coding! 🚀✨
