using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_MAN_ASS_SHOPPINGLIST
{
	public interface IShoppingList
	{
		public void AddItem(string item);

		public void RemoveItem(string item);

		public void PrintItems();

		public ShoppingListMemento Save();

		public void Restore(ShoppingListMemento memento);
	}

	//HMMM
	public class ShoppingList : IShoppingList
	{
		private List<string> _items = new List<string>();

		public void AddItem(string item)
		{
			_items.Add(item);
		}

		public void RemoveItem(string item)
		{
			_items.Remove(item);
		}

		public ShoppingListMemento Save()
		{
			return new ShoppingListMemento(_items);
		}

		public void Restore(ShoppingListMemento memento)
		{
			_items = memento.GetItems();
		}

		public void PrintItems()
		{
			Console.WriteLine("Shopping List:");
			foreach (var item in _items)
			{
				Console.WriteLine(item);
			}
		}
	}



}

