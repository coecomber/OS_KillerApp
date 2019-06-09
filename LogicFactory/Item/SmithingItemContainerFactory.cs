using Logic.Interfaces.ILogic.Item;
using Logic.Item;

namespace LogicFactory.Item
{
    public class SmithingItemContainerFactory
    {
        public ISmithingItemLogic GetSmithingItemLogic()
        {
            return new SmithingItemLogic();
        }
    }
}
