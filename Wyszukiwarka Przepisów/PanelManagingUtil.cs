using FontAwesome.Sharp;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyszukiwarka_Przepisów
{
    class PanelManagingUtil
    {

        private static PanelManagingUtil instance;

        private PanelManagingUtil(){}

        public static PanelManagingUtil getInstance()
        {
            if (instance == null) instance = new PanelManagingUtil();
            return instance;
        }
        

        public void ShowControlElement(Control[] components, Control componentToShow)
        {
            foreach(Control component in components)
            {
                if (component.Equals(componentToShow))
                {
                    component.Visible = true;
                    continue;
                }
                component.Visible = false;
            }
        }


    }
}
