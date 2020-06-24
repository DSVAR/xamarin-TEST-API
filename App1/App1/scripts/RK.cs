using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    class RK
    {
        static public Picker text1, text2;
        static public string theFirst, theSecond;

        static public bool check;
        static public void lango()
        {
            
            check = false;
            if (text1.SelectedItem.ToString() == "азербайджанский")
            {
                theFirst = "az";
                check = true;
            }
            if (text1.SelectedItem.ToString() == "албанский")
            {
                theFirst = "sq";
                check = true;
            }
            if (text1.SelectedItem.ToString() == "амхарский")
            {
                theFirst = "am";
                check = true;
            }

            if (text1.SelectedItem.ToString() == "Английский")
            {
                theFirst = "en";
                check = true;
            }
            if (text1.SelectedItem.ToString() == "Арабский")
            {
                theFirst = "ar";
                check = true;
            }
            if (text1.SelectedItem.ToString() == "Армянский")
            {
                theFirst = "hy";
                check = true;
            }
            if (text1.SelectedItem.ToString() == "Китайский")
            {
                theFirst = "zh";
                check = true;
            }
            if (text1.SelectedItem.ToString() == "Иврит")
            {
                theFirst = "he";
                check = true;
            }
            if (text1.SelectedItem.ToString() == "Латынь")
            {
                theFirst = "la";
                check = true;
            }
            if (text1.SelectedItem.ToString() == "Русский")
            {
                theFirst = "ru";
                check = true;
            }
            if (text1.SelectedItem.ToString() == "Французский")
            {
                theFirst = "fr";
                check = true;
            }
            if (text1.SelectedItem.ToString() == "Японский")
            {
                theFirst = "ja";
                check = true;
            }

            if (check == false)
            {
                theFirst = "ru";
            }

        }

        static public void langtw()
        {
            if (text2.SelectedItem.ToString() == "Азербайджанский")
            {
                theSecond = "az";
            }
            if (text2.SelectedItem.ToString() == "Албанский")
            {
                theSecond = "sq";
            }
            if (text2.SelectedItem.ToString() == "Амхарский")
            {
                theSecond = "am";
            }

            if (text2.SelectedItem.ToString() == "Английский")
            {
                theSecond = "en";
            }
            if (text2.SelectedItem.ToString() == "Арабский")
            {
                theSecond = "ar";
            }
            if (text2.SelectedItem.ToString() == "Армянский")
            {
                theSecond = "hy";
            }
            if (text2.SelectedItem.ToString() == "Китайский")
            {
                theSecond = "zh";
            }
            if (text2.SelectedItem.ToString() == "Иврит")
            {
                theSecond = "he";
            }
            if (text2.SelectedItem.ToString() == "Латынь")
            {
                theSecond = "la";
            }
            if (text2.SelectedItem.ToString() == "Русский")
            {
                theSecond = "ru";
            }
            if (text2.SelectedItem.ToString() == "Французский")
            {
                theSecond = "fr";
            }
            if (text2.SelectedItem.ToString() == "Японский")
            {
                theSecond = "ja";
            }
        }

    }
}
