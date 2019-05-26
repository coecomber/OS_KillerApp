using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.IContexts
{
    public interface IAccountContext
    {
        void Update();

        /// <summary>
        /// Heb ik deze wel nodig?
        /// 
        /// Vermoedelijk kan ik uitloggen volledig in de controller
        /// verwerken waarbij ik enkel de sessie destroy.
        /// </summary>
        void LogOut();
    }
}
