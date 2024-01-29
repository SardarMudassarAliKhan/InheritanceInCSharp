1. **Base Class (`Vehicle`)**:
   - This class serves as the base for other vehicle types. It has properties like `Brand`, `Model`, and `Year` to represent common attributes of vehicles.
   - It has a constructor to initialize these properties.
   - It has a virtual method `DisplayInfo()` which can be overridden by derived classes.

2. **Derived Classes (`Car`, `Truck`, `Motorcycle`)**:
   - Each derived class represents a specific type of vehicle and inherits from the `Vehicle` base class.
   - Each derived class has its own additional properties (`Type`, `LoadCapacity`, `Style`) specific to its type of vehicle.
   - Each derived class has a constructor to initialize its specific properties and calls the base class constructor using `base()` to initialize the common properties.
   - Each derived class overrides the `DisplayInfo()` method inherited from the base class to provide specific information about the vehicle type along with the common information.

3. **`Main` Method**:
   - This method serves as the entry point of the program.
   - Inside this method, instances of each derived class are created (`Car`, `Truck`, `Motorcycle`) with specific information provided.
   - The `DisplayInfo()` method is called on each instance to display the information specific to that vehicle type.

4. **Inheritance**:
   - Inheritance is demonstrated by the derived classes (`Car`, `Truck`, `Motorcycle`) inheriting properties and methods from the base class `Vehicle`.
   - This allows for code reusability and facilitates organizing related classes in a hierarchy.

5. **Polymorphism**:
   - Polymorphism is demonstrated by the `DisplayInfo()` method being overridden in each derived class to provide specific behavior while still being accessed through a common interface (`Vehicle` base class).
   - This allows for different behavior based on the type of object at runtime.

Overall, this code demonstrates the use of inheritance and polymorphism in C# to model different types of vehicles with shared and specific attributes and behaviors.
