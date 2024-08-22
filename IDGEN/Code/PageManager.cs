using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace IDGEN.Code
{
    public class PageManager
    {
        private readonly Main main;

        public PageManager(Main main)
        {
            this.main = main;
        }

        public void LoadPage(UserControl pageUserControl)
        {
            // Load old page
            var oldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();


            if (oldPage != null && oldPage != pageUserControl)
            {
                main.panelContainer.Controls.Remove(oldPage); // Remove Old Page
            }

            if (oldPage != pageUserControl)
            {
                // Load New Page
                pageUserControl.Dock = DockStyle.Fill;
                main.panelContainer.Controls.Add(pageUserControl);
            }


        }
    }
}
