using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using SharpShell.Attributes;
using SharpShell.SharpContextMenu;
using Newtonsoft.Json;

namespace VirusTotalContextMenu
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.AllFiles)]
    public class VirusTotalExtension : SharpContextMenu
    {
        protected override bool CanShowMenu()
        {
            //  We will always show the menu.
            return true;
        }

        protected override ContextMenuStrip CreateMenu()
        {
            //  Create the menu strip.
            var menu = new ContextMenuStrip();

            //  Create a 'context menu' item.
            var itemVirusTotalScan = new ToolStripMenuItem
            {
                Text = "Scan SHA1 in VirusTotal",
                Image = Properties.Resources.virustotal_icon
            };

            //  When we click, we'll call the 'CountLines' function.
            itemVirusTotalScan.Click += (sender, args) => ScanSha1WithVirusTotal();

            //  Add the item to the context menu.
            menu.Items.Add(itemVirusTotalScan);

            //  Return the menu.
            return menu;
        }

        private void ScanSha1WithVirusTotal()
        {
            try
            {
                var fileProperties = new List<string>();

                //  Go through each file.
                foreach (var filePath in SelectedItemPaths)
                {
                    fileProperties.Add(Path.GetFileName(filePath));

                    using (var sha1 = new SHA1CryptoServiceProvider())
                    {
                        fileProperties.Add(GetSha1Hash(filePath));
                    }

                    break;
                }

                var request = (HttpWebRequest)WebRequest.Create("https://www.virustotal.com/vtapi/v2/file/report");

                var postData = "resource=" + fileProperties[1];
                postData += "&apikey=bfdca6b146f5fecbd3d216144a0473943584829c430e516f1b9c0f258e7dd026";
                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                var dynamicObject = JObject.Parse(responseString);

                //  Show the ouput.

                Result resultDialog = new Result();

                resultDialog.lbl_filename.Text = fileProperties[0];
                resultDialog.lbl_response_code.Text = dynamicObject["response_code"].ToString();
                resultDialog.lbl_verbose_msg.Text = dynamicObject["verbose_msg"].ToString();

                if (dynamicObject["response_code"].ToString() == "1")
                {
                    resultDialog.lbl_permalink.Text = dynamicObject["permalink"].ToString();
                    resultDialog.lbl_permalink.LinkClicked += lbl_permalink_LinkClicked;
                    resultDialog.lbl_detection_ratio.Text = dynamicObject["positives"] + "/" + dynamicObject["total"];
                    resultDialog.lbl_scan_date.Text = dynamicObject["scan_date"].ToString();
                }

                resultDialog.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        void lbl_permalink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sInfo = new ProcessStartInfo(((LinkLabel)sender).Text);
            Process.Start(sInfo);
        }

        public string GetSha1Hash(string filePath)
        {
            using (FileStream fs = File.OpenRead(filePath))
            {
                SHA1 sha = new SHA1Managed();
                string hash = BitConverter.ToString(sha.ComputeHash(fs));
                return hash.Replace("-", "");
            }
        }

    }
}
