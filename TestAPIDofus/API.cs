using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAPIDofus
{
    static class API
    {

        static public string GetItem(string typeItem, string idItem)
        {
                WebClient client = new WebClient();
                string url = "https://fr.dofus.dofapi.fr/" + typeItem + "/" + idItem;
                string downloadString = client.DownloadString(url);
                client.Dispose();
                return downloadString;
            
        }

        static public string getValue(string motRecherche, string code)
        {

         
            int start = code.IndexOf(motRecherche) + motRecherche.Length;
            int end;
            if (start < 10)
            {
                end = code.IndexOf(",") - start;
            }
            else
            {
                switch (motRecherche)
                {
                    case "description:":
                            end = code.IndexOf(" ,", start);
                            end = end - start;
                            break;
                    case "roles:":
                            end = code.IndexOf("],", start);
                            end = end - start + 1;
                        break;
                    case "spells:":
                            end = code.IndexOf("],", start);
                            end = end - start + 1;
                        break;
                    case "femaleImg:":
                            end = code.IndexOf("}", start);
                            end = end - start;
                        break;
                    default:
                            end = code.IndexOf(",", start);
                            end = end - start;
                        break;
                }
            }
            string value = code.Substring(start, end);

            return value;
        }

        static public string NormalString(string text)
        {
            byte[] bytes = Encoding.Default.GetBytes(text);
            text = Encoding.UTF8.GetString(bytes);

            return text;
        }
    }
}
