

using Memento_MAN_ASS_SHOPPINGLIST;

IShoppingList shoppingList = new ShoppingList();
var caretaker = new ShoppingListCaretaker(shoppingList);

//add things to shoppingList and print
shoppingList.AddItem("Milk");
shoppingList.AddItem("Bread");
shoppingList.AddItem("Eggs");
shoppingList.PrintItems();

//Take snapshot
caretaker.AddMemento();

//remove a thing, add a thing and print
shoppingList.RemoveItem("Bread");
shoppingList.AddItem("cola");
shoppingList.PrintItems();

//Undo the remove and return to state hid in snapshot
caretaker.Undo();

//Print to confirm it worked
shoppingList.PrintItems();

//make list to (bread, egg and water)
shoppingList.AddItem("Water");
shoppingList.RemoveItem("Milk");

//take new snapshot
caretaker.AddMemento();

//adds 4th item and print
shoppingList.AddItem("Butter");
shoppingList.PrintItems();

//go back to 2nd snapshot of (bread, egg and water)
caretaker.Undo();
shoppingList.PrintItems();
