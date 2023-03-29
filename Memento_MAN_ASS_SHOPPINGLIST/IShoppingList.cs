using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_MAN_ASS_SHOPPINGLIST
{
	// This interface defines the methods for a shopping list
	public interface IShoppingList
	{
        public void AddItem(string item);

		public void RemoveItem(string item);

		public void PrintItems();

		public ShoppingListMemento Save();

		public void Restore(ShoppingListMemento memento);
	}

	// This class implements the IShoppingList interface using a list of strings
	public class ShoppingList : IShoppingList
	{
		// This field holds the items in the shopping list
		private List<string> _items = new List<string>();

		// This method adds an item to the shopping list
		public void AddItem(string item)
		{
			_items.Add(item);
		}

		// This method removes an item from the shopping list
		public void RemoveItem(string item)
		{
			_items.Remove(item);
		}

		// This method creates and returns a memento object that stores the current state of the shopping list
		public ShoppingListMemento Save()
		{
			return new ShoppingListMemento(_items);
		}

		// This method restores the state of the shopping list from a given memento object
		public void Restore(ShoppingListMemento memento)
		{
			_items = memento.GetItems();
		}

		// This method prints the items in the shopping list
		public void PrintItems()
		{
			Console.WriteLine("Shopping List:");
			for (int i = 0; i < _items.Count; i++)
			{
				Console.WriteLine($"{i} {_items[i]}");
			}
			Console.WriteLine("_________________");
			Console.WriteLine("");
		}
	}



}

