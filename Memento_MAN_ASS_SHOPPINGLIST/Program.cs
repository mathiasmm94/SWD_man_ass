

using Memento_MAN_ASS_SHOPPINGLIST;

var shoppingList = new ShoppingList();
var caretaker = new ShoppingListCaretaker(shoppingList);

//add things to shoppingList and print
shoppingList.AddItem("Milk");
shoppingList.AddItem("Bread");
shoppingList.AddItem("Eggs");
shoppingList.PrintItems();

//Take snapshot
caretaker.AddMemento();

//remove a thing and print
shoppingList.RemoveItem("Bread");
shoppingList.PrintItems();

//Undo the remove and return to state hid in snapshot
caretaker.Undo();

//Print to confirm it worked
shoppingList.PrintItems();