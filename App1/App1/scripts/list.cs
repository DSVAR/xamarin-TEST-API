using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;


namespace App1
{

    class list
    {
        static public Picker listok;
        static public Image vox;
        static public void changes()
        {
            if (listok.SelectedItem.ToString() == "БАРСЕЛОНА")
            {
                vox.Source = ImageSource.FromResource("App1.Resources.bart.jpg");
                TabbedPage1.name = "BARS.txt";
                
            }
            if (listok.SelectedItem.ToString() == "АБУ-ДАБИ")
            {
                vox.Source = ImageSource.FromResource("App1.Resources.Abu-Dabi.jpg");
                TabbedPage1.name = "ABU.txt";
            }
            if (listok.SelectedItem.ToString() == "ЕРЕВАН")
            {

                TabbedPage1.name = "erevan.txt";
                vox.Source = ImageSource.FromResource("App1.Resources.era.jpg");
            }
            if (listok.SelectedItem.ToString() == "АМСТЕРДАМ")
            {
                vox.Source = ImageSource.FromResource("App1.Resources.amsterdam.jpg");
                TabbedPage1.name = "amster.txt";
            }
            if (listok.SelectedItem.ToString() == "РИМ")
            {
                vox.Source = ImageSource.FromResource("App1.Resources.rim.jpg");
                TabbedPage1.name = "Rim.txt";
            }
            if (listok.SelectedItem.ToString() == "ПЕКИН")
            {
                vox.Source = ImageSource.FromResource("App1.Resources.pekin.jpg");
                TabbedPage1.name = "Pekin.txt";
            }

            if (listok.SelectedItem.ToString() == "МОСКВА")
            {
                vox.Source = ImageSource.FromResource("App1.Resources.moscow.jpg");
                TabbedPage1.name = "Moscow.txt";
            }
            if (listok.SelectedItem.ToString() == "ЛОНДОН")
            {
                vox.Source = ImageSource.FromResource("App1.Resources.london.jpg");
                TabbedPage1.name = "London.txt";
            }
            if (listok.SelectedItem.ToString() == "ПАРИЖ")
            {
                vox.Source = ImageSource.FromResource("App1.Resources.parij.jpg");
                TabbedPage1.name = "Par.txt";
            }
            if (listok.SelectedItem.ToString() == "БЕРЛИН")
            {
                vox.Source = ImageSource.FromResource("App1.Resources.berlin.jpg");
                TabbedPage1.name = "Berlin.txt";
            }

            if (TabbedPage1.name == null) { TabbedPage1.name = "notes.txt"; }
        }
    }
}
