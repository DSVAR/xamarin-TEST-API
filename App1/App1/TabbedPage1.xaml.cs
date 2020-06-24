using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        static public string name = null;
        public TabbedPage1()
        {
            InitializeComponent();
           
            pick.Title = "Язык";
            pick1.Title = "Язык перевода";
            pick.SelectedIndex = 0;
            pick1.SelectedIndex =1;
    //

            RK.text1 = pick;
            RK.text2 = pick1;

            detectedLanguage.text1 = texbox1;
         //   detectedLanguage.text3 = texbox2;

            translating.rich = texbox2;

            speller.text = textbox3;
            speller.message = textbox4;

            list.listok = combobox;
            list.vox = Image1;

            save.note = notice;

            
            combobox.SelectedIndex = 0;
            save.saving();
            list.changes();

            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), name);
            try
            {
                notice.Text = File.ReadAllText(filename);
            }
            catch
            {

            }
        }

      private  void OnButtonClicked (object sender, System.EventArgs e)
        {
            detectedLanguage.dec();
            RK.lango();
            RK.langtw();

            translating.translatNOT();

        }

       private void OnButtonClicked2 (object sender, System.EventArgs e)
        {
            speller.spool();
        }

        private void OnButtonClicked3(object sender, System.EventArgs e)
        {
            
            //     PictureBox.Source = ImageSource.FromResource("App1.Resources.C7KhwHO_7CM.jpg");
            string aou = notice.Text;
     

            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), name);
            File.WriteAllText(filename, aou);
      //      notice.Text = "";
           // File.WriteAllText("text.txt",aou);

            
        }

        private void PickChange(object sender, System.EventArgs e)
        {
            list.changes();
            save.saving();
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), name);
            //   Button3.BackgroundColor = Color.Red;
            try
            {
                notice.Text = File.ReadAllText(filename);
            }
            catch
            {

            }
        }
    }
}