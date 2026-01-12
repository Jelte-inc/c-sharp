using System;
using System.Windows.Forms;

namespace CheraasjeEpp.UI
{
    public interface IPage
    {
        event Action<UserControl> PageChangeRequested;
    }
}
