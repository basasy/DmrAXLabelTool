using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmrAXLabelTool
{
    internal class LabelProcess
    {
        public string text { get; set; }
        public string[] textArray { get; set; }
        List<String> textList =  new List<String>();

        public int changeLabelCount { get; set; }


        public LabelProcess(string text) { 
            
            this.text = text;
            textArray = this.text.Split('\n');
            textList = textArray.ToList();
        }


        public string removeDuplicate()
        {
           
            List<String>  tmp = textList.Distinct().ToList();
            //string[] tmp = textArray.Distinct().ToArray();

            tmp.Remove("\r");
            tmp.Remove("");
            tmp.Remove("\n");

            for (int i = 0; i < tmp.Count; i++)
            {
                string dub = tmp[i].Split('=')[0];

                for(int j=i+1;j< tmp.Count;j++)
                {
                    if (tmp[j].Split('=')[0] == dub)
                    {
                        tmp.RemoveAt(j);
                    }
                }
            
            }

            string textTmp = "";
            for (int i = 0; i < tmp.Count; i++)
            { 
                textTmp += tmp[i] + "\n";

            }

            this.changeLabelCount = textList.Count - tmp.Count - 1;

            return textTmp;
        }

       
        public string sortAndRemoveDuplicate()
        {
            string[] tmp = new HashSet<string>(textArray).ToArray();

            textList = tmp.ToList();
            textList.Remove("\r");
            textList.Remove("");
            textList.Remove("\n");

            for (int i = 0; i < textList.Count; i++)
            {
                string dub = textList[i].Split('=')[0];

                for (int j = i+1; j < textList.Count; j++)
                {
                    if (textList[j].Split('=')[0] == dub)
                    {
                        textList.RemoveAt(j);
                    }
                }

            }

            string textTmp = "";
            for (int i = 0; i < textList.Count; i++)
            {
                textTmp += textList[i] + "\n";

            }
            this.changeLabelCount = textArray.Length - textList.Count -1;
            return textTmp;
        }

        public string sortString()
        {

            List<String> tmp = textList;

            tmp.Remove("\r");
            tmp.Remove("");
            tmp.Remove("\n");

            tmp.Sort();

            string textTmp = "";
            for (int i = 0; i < tmp.Count; i++)
            {
                textTmp += tmp[i] + "\n";

            }

            this.changeLabelCount = tmp.Count;
            return textTmp;
        }
    }
}
