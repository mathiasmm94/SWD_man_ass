using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_MAN_ASS_SHOPPINGLIST
{
	/*public class ShoppingListCaretaker
	{
		private readonly Stack<ShoppingListMemento> _mementos = new Stack<ShoppingListMemento>();
		private readonly IShoppingList _shoppingList;

		public ShoppingListCaretaker(IShoppingList shoppingList)
		{
			_shoppingList = shoppingList;
		}

		public void AddMemento()
		{
			_mementos.Push(_shoppingList.Save());
		}

		public void Undo()
		{
			if (_mementos.Count == 0)
			{
				Console.WriteLine("Cannot undo: No previous state.");
				return;
			}

			var memento = _mementos.Pop();
			_shoppingList.Restore(memento);
		}
	}*/
	// This class implements the caretaker role in the memento pattern
	public class ShoppingListCaretaker
	{
		// This field stores a stack of memento objects that represent the previous states of the shopping list
		private readonly Stack<ShoppingListMemento> _mementos = new Stack<ShoppingListMemento>();
		// This field stores a reference to the shopping list object that implements the originator role in the memento pattern
		private readonly IShoppingList _shoppingList;

		// The constructor that takes a shopping list object as an argument and assigns it to the field
		public ShoppingListCaretaker(IShoppingList shoppingList)
		{
			_shoppingList = shoppingList;
		}

		// This method creates a new memento object from the current state of the shopping list and pushes it to the stack
		public void AddMemento()
		{
			_mementos.Push(_shoppingList.Save());
		}

		// This method pops the latest memento object from the stack and passes it to the shopping list to restore its state
		public void Undo()
		{
			// If the stack is empty, there is no previous state to restore
			if (_mementos.Count == 0)
			{
				Console.WriteLine("Cannot undo: No previous state.");
				return;
			}

			var memento = _mementos.Pop();
			_shoppingList.Restore(memento);
		}
	}
}
