using Logic.Interfaces.ILogic.Item;
using Logic.Item;

namespace LogicFactory.Item
{
    public class FishItemContainerFactory
    {
        public IFishItemLogic GetFishItemLogic()
        {
            return new FishItemLogic();
        }
    }
}
