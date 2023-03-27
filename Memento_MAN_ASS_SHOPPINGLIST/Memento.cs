using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_MAN_ASS_SHOPPINGLIST
{
	public class ShoppingListMemento
	{
		private readonly List<string> _items;

		public ShoppingListMemento(List<string> items)
		{
			_items = new List<string>(items);
		}

		public List<string> GetItems()
		{
			return _items;
		}
	}

}
