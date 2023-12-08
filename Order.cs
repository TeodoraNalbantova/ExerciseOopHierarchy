using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy;

public class Order
//в момента,в който създам обект ордер, създай ми празен списък в него.
{
    //поле, което се зпаълва с празен списък, в момента в който се съдава поръчка.тук използваме синтаксис шугара.
    private List<MenuItem> _items = new();
    public IReadOnlyCollection<MenuItem> Items => this._items.AsReadOnly();
    //Щом започва I е интерфейс. Така създваме read only колекция на този списък.Така се сетва.
    //Tова се случва в момента на инстанциране на този клас в обект.По този начин виждаме всички елеметни от поръчката но без да може да ги правим нещо.
    public void AddItem(MenuItem item)
    {
        this._items.Add(item);
    }
    public decimal GetTotal()
    {
        // взимам списъска, избирам цената на всеки от елементите му Select и с ламбда и сумирам с LINQ.!!! 
        return this._items.Select(i => i.Price).Sum();
    }


}
