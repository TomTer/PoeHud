﻿namespace PoeHUD.Poe.UI

{
    public class WindowState : Element
    {
        public bool IsVisibleLocal
        {
            get
            {
                return M.ReadInt(this.Address + 0x860) == 1;
            }
        }
    }
}
