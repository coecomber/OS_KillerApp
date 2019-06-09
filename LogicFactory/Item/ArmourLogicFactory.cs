using Logic.Interfaces.ILogic.Item;
using Logic.Item;

namespace LogicFactory.Item
{
    public class ArmourLogicFactory
    {
        public IArmourLogic GetArmourLogic()
        {
            return new ArmourLogic();
        }
    }
}
