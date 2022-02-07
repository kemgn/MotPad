using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotPad.Components
{
    internal class MultiPagePanel : Panel
    {
        private int currentPageIndex;

        public int CurrentPageIndex 
        { 
            get 
            { 
                return currentPageIndex; 
            } 
            set 
            {
                if (value >= 0 && value < Controls.Count)
                {
                    Controls.Find($"pictureBox_{value}", false).FirstOrDefault()?.BringToFront();
                    Controls.Find($"richTextbox_{value}", false).FirstOrDefault()?.BringToFront();
                    
                    //Controls[value].BringToFront();
                    currentPageIndex = value;
                }
            } 
        }



        public MultiPagePanel()
        {
            
        }
        public void AddPages(Control[] pages, int index)
        {
            Controls.AddRange(pages);
            CurrentPageIndex = index;
            //page.Dock = DockStyle.Fill;
        }
    }
}
