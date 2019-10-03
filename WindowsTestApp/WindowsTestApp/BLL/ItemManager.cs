using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WindowsTestApp.Repository;
using WindowsTestApp.Model;
namespace WindowsTestApp.BLL
{
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public bool Add(TestItem testItem)
        {
            return _itemRepository.Add(testItem);
        }
        public bool IsNameExits(TestItem testItem)
        {
             return _itemRepository.IsNameExits(testItem);
        }
        public bool Delete(TestItem testItem)
        {
            return _itemRepository.Delete(testItem);
        }
        public DataTable Update(TestItem testItem)
        {
            return _itemRepository.Update(testItem);
        }
        public DataTable InstantDisplayData()
        {
            return _itemRepository.InstantDisplayData();
        }
        public DataTable ShowData()
        {
            return _itemRepository.ShowData();
        }
        public DataTable Search(TestItem testItem)
        {
            return _itemRepository.Search(testItem);
        }
    }
}
