using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_MAN_ASS_SHOPPINGLIST
{
	// This class represents a memento object that stores a snapshot of a shopping list
	public class ShoppingListMemento
	{
		// This field holds a copy of the items in the shopping list
		private readonly List<string> _items;

		// This constructor creates a new memento object with the given items
		public ShoppingListMemento(List<string> items)
		{
			// This line creates a new list and copies the items from the parameter
			_items = new List<string>(items);
		}

		// This method returns the items stored in the memento object
		public List<string> GetItems()
		{
			return _items;
		}
	}

}
