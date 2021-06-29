using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Threading;

namespace TestAPIDofus
{
    public partial class Fm_principal : Form
    {
        public Fm_principal()
        {
            InitializeComponent();
        }

        private void Fm_principal_Load(object sender, EventArgs e)
        {
            cb_Type.SelectedIndex = 0;
        }

        private void bt_Valider_Click(object sender, EventArgs e)
        {
            try 
            {

                string code = API.GetItem(cb_Type.Text, tb_id.Text);
                code = code.Replace("\"", "");
                code = code.Replace(@"\n", " ");
                tb_Txt.Text = code;

                if(tb_id.Text != "")
                {
                    switch (cb_Type.Text)
                    {
                        case "classes":
                            string id = API.getValue("_id:", code);
                            string ankamaID = API.getValue("ankamaId:", code);
                            string name = API.getValue("name:", code);
                            string level = API.getValue("level:", code);
                            string type = API.getValue("type:", code);
                            string url = API.getValue("url:", code);
                            string description = API.getValue("description:", code);
                            string roles = API.getValue("roles:", code);
                            string spells = API.getValue("spells:", code);
                            string maleImg = API.getValue("maleImg:", code);
                            string femaleImg = API.getValue("femaleImg:", code);

                            System.Windows.Forms.Clipboard.SetText(femaleImg);
                            Uri uri = new Uri(femaleImg);
                            wv_img.Source = uri;
                               

                            

                            roles = API.NormalString(roles);
                            description = API.NormalString(description);

                            lb_1.Text = "id: " + id;
                            lb_2.Text = "name: " + name;
                            lb_3.Text = "type: " + type;
                            lb_4.Text = "roles: " + roles;


                            lb_5.Text = "Description: " + description;

                            //MessageBox.Show(id);
                            //MessageBox.Show(ankamaID);
                            //MessageBox.Show(name);
                            //MessageBox.Show(level);
                            //MessageBox.Show(type);
                            //MessageBox.Show(url);
                            //MessageBox.Show(description);
                            //MessageBox.Show(roles);
                            //MessageBox.Show(spells);
                            //MessageBox.Show(maleImg);
                            //MessageBox.Show(femaleImg);
                            break;
                        case "consumables":

                            id = API.getValue("_id:", code);
                            ankamaID = API.getValue("ankamaId:", code);

                            lb_1.Text = "id:" + id;

                            break;
                    }



                }
             }
            catch(WebException exc)
            {
                if (exc.Status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse reponse = exc.Response as HttpWebResponse;
                    if((int)reponse.StatusCode == 404)
                    {
                        MessageBox.Show("404: dofapi est hors ligne");
                    }
                    else
                    {
                        MessageBox.Show("Impossible de trouver un objet avec l'id choisi");
                    }
                }
                    
            }
        }
    }
}
