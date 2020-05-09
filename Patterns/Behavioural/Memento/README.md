Memento is a behavioural pattern as it defines a manner for controlling communication between classes or entities. The memento pattern is used to capture the 
current state of an object and store it in such a manner that it can be restored at a later time. Importantly, the pattern allows for the internal state of an 
object to be saved without breaking the rules of encapsulation. This design pattern is commonly used to provide an application with Undo functionality.

<p align="center">
  <img src="./Memento.png">
</p>

The UML class diagram above describes an implementation of the memento design pattern. The items in the diagram are described below:
- **Originator.** This is the class whose state is to be stored. The Originator includes a method, named "CreateMemento", that is used to generate a Memento object
containing a snapshot of the Originator's current state. It also includes the "SetMemento" method, which restores the Originator to a previously stored state.
- **Memento.** The Memento class is used to hold the information from an Originator's state. The amount of information held is controlled by the Originator. 
The Memento can provide protection against change to the stored state by including a very limited interface with no means of modifying the values it holds.
- **Caretaker.** The Caretaker class is used to hold a Memento object for later use. The Caretaker provides storage only; it should neither examine nor modify the 
contents of the Memento object. In the UML diagram and the examples in this article the Caretaker holds a single Memento object. It can be modified to hold a 
collection of Mementos to support multi-level undo and redo functionality.