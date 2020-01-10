# GildedRose

Note to assessor:

I wasn't sure how to deliver the exercise. I uploaded my complete Visual Studio solution folder to at least provide the code to view.

This is a console app. Running it displays the input data and the processed output.

The Program class creates an Inventory instance and calls the AddItem method to add the items individually.
To avoid a mess of conditional statements when processing the items, an Item base class is extended to give functionality to 
the various Item types. This approach minimisses code duplication and allows for additional Item types to be added in the future.

The AddItem() method looks at the item's name, creates an appropriate Item sub-class object, and adds it to the Inventory's List<> collection.

Processing is handled by the overridden UpdateSellin() and UpdateQuality() methods in the Item sub-classes.
