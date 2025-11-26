using System;
using System.Windows.Forms;

namespace cheraasje_epp.UI
{
    public interface IPage
    {
        event Action<UserControl> PageChangeRequested;
    }
}
