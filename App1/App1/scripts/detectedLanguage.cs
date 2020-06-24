using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using Leaf.xNet;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Web;
using Xamarin.Forms;

namespace App1
{
    public class detectedLanguage
    {
        static public string lo, lang;
        static public bool decte = false;


        static public Editor text1;
   //     static public Editor text3;






        static public void deteck()
        {
            lang = null;
            //   label.Invoke((MethodInvoker) (()=>label.Text = "halalujah")); 


            string floop = null;
            lo = text1.Text;

            var Post = new Leaf.xNet.HttpRequest();
            //var Post = new xNet.HttpRequest();

            for (int i = 0; i <= 1; i++)
            {




                try
                {
                    floop = Post.Post("https://translate.yandex.net/api/v1.5/tr.json/detect?" +
                         "key=trnsl.1.1.20191207T155655Z.98fc42dcc71b1955.5a64a70d4dcb416d72248a2f5ac02b7eda46213c" +
                         "&text=" + lo).ToString();

                }
                catch
                {
                    
                }


                var json = JObject.Parse(floop);


                JToken dec = json["lang"];
                lang = dec.ToString();

                decte = true;

                //        text2.Invoke((MethodInvoker)(() => text2.Text = lang ));  

            }
        }

        static public void dec()
        {
            lo = text1.Text;
        }


    }
}
