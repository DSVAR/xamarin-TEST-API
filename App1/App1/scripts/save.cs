using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace App1
{
    class save
    {

        static public Editor note;
        static public void saving()
        {
            try
            {
                if (TabbedPage1.name == null) { TabbedPage1.name = "notes.txt"; }
                string MyText;
                MyText = File.ReadAllText(TabbedPage1.name);


               note.Text = MyText;
            }
            catch
            {
                note.Text = null;
            }
        }
    }
}
