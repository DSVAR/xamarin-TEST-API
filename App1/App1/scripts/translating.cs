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
    class translating
    {
        static public Editor rich ;
        static public string getgive = null;
        static public void translate()
        {
            if (detectedLanguage.decte == true)
                while (true)
                {

                    var post = new Leaf.xNet.HttpRequest();

                    try
                    {

                        getgive = post.Post("https://translate.yandex.net/api/v1.5/tr.json/translate?" +
                           "key=trnsl.1.1.20191207T155655Z.98fc42dcc71b1955.5a64a70d4dcb416d72248a2f5ac02b7eda46213c" +
                           "&text=" + detectedLanguage.lo + "&lang=" + detectedLanguage.lang + "-" + RK.theSecond).ToString();

                    }
                    catch
                    {
                        //MessageBox.Show("Проверьте подключение к сети");
                    }
                    var json = JObject.Parse(getgive);

                    JToken translate = json["text"][0];
                   // rich.Invoke((MethodInvoker)(() => rich.Text = translate.ToString()));

                    rich.Text = translate.ToString();
                    detectedLanguage.decte = false;
                    break;


                }
            else { }
        }

        static public void translatNOT()
        {

            
                var post = new Leaf.xNet.HttpRequest();

                try
                {

                    getgive = post.Post("https://translate.yandex.net/api/v1.5/tr.json/translate?" +
                           "key=trnsl.1.1.20191207T155655Z.98fc42dcc71b1955.5a64a70d4dcb416d72248a2f5ac02b7eda46213c" +
                           "&text=" + detectedLanguage.lo + "&lang=" + RK.theFirst + "-" + RK.theSecond).ToString();

                }
                catch
                {
                    //MessageBox.Show("Проверьте подключение к сети");
                }
                var json = JObject.Parse(getgive);

                JToken translate = json["text"][0];
               // rich.Invoke((MethodInvoker)(() => rich.Text = translate.ToString()));
                rich.Text = translate.ToString();
             


           

        }

    }
}
