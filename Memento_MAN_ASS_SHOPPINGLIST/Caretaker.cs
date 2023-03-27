using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_MAN_ASS_SHOPPINGLIST
{
	public class ShoppingListCaretaker
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
	}

}
