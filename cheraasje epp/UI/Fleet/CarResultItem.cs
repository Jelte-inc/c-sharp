using cheraasje_epp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheraasje_epp.UI.Fleet
{
    public partial class CarResultItem : UserControl
    {
        public partial class CarResultControl : UserControl
        {
            public CarResultControl(Car car)
            {
                InitializeComponent();

                lblTitle.Text = $"{car.Brand} {car.Model} {car.Year}";
                lblPrice.Text = car.Price.ToString("C");
                lblMileage.Text = $"{car.Mileage:N0} km";
            }
        }

    }
}
