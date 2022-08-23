# Geometry

## Story

Online learning is a hot topic these days. Your company just won a state tender for an e-learning tool that helps high school students learn maths.

Your team has just started planning a geometry module. Hierarchical object-oriented modelling seemed a natural choice here: after all, every square is a rectangle, isn't it? So you came up with a class hierarchy for six basic shapes, and now your job is to implement the core features (such as area and perimeter) of these shape types.

You also need to add a simple console UI to list and add shapes to a shape repository. This will be replaced with GUI later.

Oh, and don't forget to contribute to the emerging documentation, so please draw a UML class diagram as well.

## What are you going to learn?

- Draw UML class diagrams.

- Use inheritance.

- Override methods.

- Understand when static contexts (the static keyword) can be useful.

- Understand hiding (the new keyword) vs overriding (the override keyword).

- Use sealed.

- Represent objects with strings.



## Tasks

1. Implement the constructors and the required methods in shape subclasses. The shapes must be immutable. that is, their state (stored in attributes) cannot be changed.
   - All attributes are immutable.
   - All attributes are private, and only the methods and properties used by other classes are not private.
   - All shape subclasses have an overridden version for calculating the corresponding perimeter and area.
   - All shape subclasses have (or inherit) their custom ToString() representation. The representation includes the name of the shape (such as "Rectangle") and the names and values of its base attributes (in this case "r=...").

2. Implement ShapeCollection to manage a list of shapes. The collection can consist of any subtype of Shape.
    - It is possible to add shapes to the collection using the AddShape method.
    - The GetShapesTable() method returns a printable table with all the shapes in the collection and their parameter values. The table looks like the example in table_example.txt.
    - The GetLargestShapeByPerimeter() method returns the shape instance with the largest perimeter in the collection.
    - The GetLargestShapeByArea() method returns the shape instance with the largest area in the collection.

3. Show a main menu upon starting the program that provides access to basic operations on a shape collection.
    - By choosing the "Add new shape" option, the user can select from a list of existing shapes (such as circle). Then the user must specify the required parameters (such as the radius).
    - By choosing the "Show all shapes" option, the table view provided by the shape collection is displayed.
    - Choosing the "Show shape with the largest perimeter" option displays the shape with the largest perimeter in the collection.
    - Choosing the "Show shape with the largest area" option displays the shape with the largest area in the collection
    - By choosing the "Show formulas" option, the user can select from a list of existing shapes (such as circle), and the stored formulas for the shape class (such as Circle area formula: π×r×r, Circle perimeter formula: 2×π×r) are displayed.
    - The user can exit the program by selecting "Exit".

4. Create a class diagram based on the existing project skeleton structure and keep extending it when extending the code. Use PlantUML to generate it.
    - The PlantUML source file named uml.txt and a rendered diagram named uml.png are updated in the repository.
    - Relation indicators on the diagram represent the actual state of code (such as inheritance or composition between classes).
    - All fields are indicated on the diagram.
    - All methods are indicated on the diagram.


