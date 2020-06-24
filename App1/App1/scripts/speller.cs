using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Leaf.xNet;
//using xNet;

namespace App1
{
    class speller
    {
        static public Editor text, message;
        static public string get, test, brut = null;
        static public int kol;
   //     static public string koil;


        static public void spool()
        {
            test = text.Text;

            var post = new Leaf.xNet.HttpRequest();
          
            //  var por = new xNet.HttpResponse();
            try
            {
                get = post.Get("https://speller.yandex.net/services/spellservice.json/checkText?text=" + test).ToString();
               
                var mar = JArray.Parse(get);
                JToken spell = mar[0]["s"];
                kol = spell.Count();

                for (int j = 0; j < kol; j++)
                {
                    if (j != kol)
                        brut += spell[j] + ", ";
                    else
                        brut += spell[j] + ". ";
                }




              
                message.Text = brut;
                brut = null;
            }
            catch
            {
                message.Text = "проблема с сервером от яндекс";
            }







        }
    }
}
