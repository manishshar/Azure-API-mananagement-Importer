using apimimporter.lib;
using System;
using System.Web.Script;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace apimimporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btngetapis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtapimname.Text))
            {
                MessageBox.Show("APIM name should not be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(txtaccesstoken.Text))
            {
                MessageBox.Show("SAS primary key should not be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Auth.createToken(txtaccesstoken.Text);
            var jsonresp = getRequest("apis");

            if (!string.IsNullOrEmpty(jsonresp))
            {
                var serializer = new JavaScriptSerializer();

                //var respItems = JsonConvert.DeserializeObject<Rootobject>(jsonresp);
                var respItems = serializer.Deserialize<Rootobject>(jsonresp);

                comboapislist.DataSource = (respItems.value.Select(n => new
                {
                    name = string.Format("{0} ({1})", n.name, n.id),
                    id = n.id.Remove(0, 1)
                }).ToList());

                comboapislist.DisplayMember = "name";
                comboapislist.ValueMember = "id";
                txtfilebrowse.Text = "";
                comboapis2.DataSource = null;

                grpApis.Enabled = true;
                grpApis.Text = string.Format("Existing apis - {0}", txtapimname.Text);

                grpLogin.Enabled = false;
                btnreset.Enabled = true;


            }
        }



        public string getRequest(string methodpath)
        {
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri(string.Format(@"https://{0}.management.azure-api.net", txtapimname.Text));
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("SharedAccessSignature", Auth.SaSTokengenerated);
                HttpResponseMessage resp = null;
                try
                {
                    resp = Client.GetAsync(string.Format("{0}?api-version={1}", methodpath, "2018-01-01")).Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message.ToString(), "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
                if (resp.IsSuccessStatusCode)
                {
                    var Json = resp.Content.ReadAsStringAsync().Result;
                    //JObject Items = JObject.Parse(Json);
                    //var Items = JsonConvert.DeserializeObject<Rootobject>(Json);

                    //comboapislist.Items.Add()
                    // now use you have the date on Items !
                    return Json;
                }
                else
                {
                    // deal with error or here ...
                    var Json = resp.StatusCode;
                    MessageBox.Show(Json.ToString(), "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show(Json.ToString());
                    return null;
                }
            }
        }

        private void OnProgressReported(object sender, EventArgs e)
        {
            // because this thread has the context of the main thread no InvokeRequired!
            this.toolStripProgressBar1.Increment(10);
        }



        private async Task ExecutepostrequestAsync(IProgress<int> progress, string methodpath, string data)
        {

            //await Task.Run(() =>
            //{
            bool flag = false;
            cloudmessage Items = new cloudmessage();
            progress.Report(10);
            Console.WriteLine("1");
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri(string.Format(@"https://{0}.management.azure-api.net", txtapimname.Text));
                Client.DefaultRequestHeaders.Accept.Clear();
                //Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("SharedAccessSignature", Auth.SaSTokengenerated);
                Client.DefaultRequestHeaders.TryAddWithoutValidation("If-Match", "*");
                Client.Timeout = TimeSpan.FromMinutes(30);
                var httpContent = new StringContent(data, Encoding.UTF8, "application/json");
                Console.WriteLine("2");

                progress.Report(50);
                HttpResponseMessage response = await Client.PutAsync(string.Format("{0}?import=true&api-version={1}", methodpath, "2018-01-01"), httpContent);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("3");

                    var Json = response.Content.ReadAsStringAsync().Result;
                    //JObject Items = JObject.Parse(Json);
                    //var Items = JsonConvert.DeserializeObject<Rootobject>(Json);

                    //comboapislist.Items.Add()
                    // now use you have the date on Items !
                    toolStripStatusLabel1.Text = "Complete";

                    flag = true;
                }
                else
                {
                    Console.WriteLine("4");
                    var Json = response.Content.ReadAsStringAsync().Result;
                    //JObject Items = JObject.Parse(Json);
                    var serializer = new JavaScriptSerializer();
                    Items = serializer.Deserialize<cloudmessage>(Json);


                    //Items = JsonConvert.DeserializeObject<cloudmessage>(Json);
                    toolStripStatusLabel1.Text = "Failed";


                    flag = false;
                }

                stopWatch.Stop();
                toolStripStatusLabel1.Text = toolStripStatusLabel1.Text + "- (Time Elapsed:" + TimeSpan.FromSeconds(Convert.ToDouble(stopWatch.ElapsedMilliseconds) / 1000).Duration() + ")";

            }
            // });

            progress.Report(100);

            if (flag == true)
            {
                MessageBox.Show("Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show((Items.error.details != null) ? Convert.ToString(Items.error.details.FirstOrDefault().message) : Convert.ToString(Items.error.message), "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void PostrequestAsync(string methodpath, string data)
        {
            Progress<int> progress = new Progress<int>(i => toolStripProgressBar1.Value = i);

            await ExecutepostrequestAsync(progress, methodpath, data);
        }


        private void btngetapisrev_Click(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                MessageBox.Show("Last Import operation is running. Please wait..", "Operation Running", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var jsonresp = getRequest(comboapislist.SelectedValue.ToString() + "/revisions");

            var serializer = new JavaScriptSerializer();
            var respItems = serializer.Deserialize<singleApiRevsion>(jsonresp);

            //var respItems = JsonConvert.DeserializeObject<singleApiRevsion>(jsonresp);
            comboapis2.DataSource = (respItems.value.Select(n => new
            {
                n.apiId,
                n.privateUrl
            }).ToList());

            comboapis2.DisplayMember = "apiId";
            comboapis2.ValueMember = "apiId";

            btngetapis.Enabled = false;
        }

        public string contentFormat { get; set; }
        public string importdescription { get; set; }
        public string apiType { get; set; }
        private void btnimport_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Browse json/wsdl Files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            //openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "openapi specification file (*.json)|*.json"
                + "|soap pass-thorugh file (*.wsdl)|*.wsdl"
                + "|soap to rest file (*.wsdl)|*.wsdl"
            + "|wadl file (*.xml)|*.xml";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfilebrowse.Text = openFileDialog1.FileName;
                selectfiletypes(openFileDialog1);
                lblimporttype.Text = importdescription;
            }
        }


        private void selectfiletypes(OpenFileDialog openFileDialog)
        {

            switch (openFileDialog.FilterIndex)
            {
                case 1:
                    contentFormat = "swagger-json";
                    apiType = "";
                    importdescription = "OpenApi Specification file (Replace API with new one)";
                    break;
                case 2:
                    contentFormat = "wsdl";
                    apiType = "soap";
                    importdescription = "soap pass-thorugh file";
                    break;
                case 3:
                    contentFormat = "wsdl";
                    apiType = "http";
                    importdescription = "soap to rest file";
                    break;
                case 4:
                    contentFormat = "wadl-xml";
                    apiType = "";
                    importdescription = "standard xml representation of your restful apis";
                    break;


                default:
                    importdescription = "Not supported!";
                    break;
            }
        }

        Stopwatch stopWatch = new Stopwatch();
        Boolean complete = false;
        private void btnfinalimport_Click(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                MessageBox.Show("Last Import operation is running. Please wait..", "Operation Running", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (comboapis2.Items.Count == 0)
            {
                MessageBox.Show("click fetch details for api revisions.");
                btngetapisrev.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtfilebrowse.Text))
            {
                MessageBox.Show("Please select file to import.");
                return;
            }





            toolStripProgressBar1.Visible = true;
            toolStripStatusLabel1.Visible = true;

            stopWatch.Start();
            string fileName = txtfilebrowse.Text;
            using (StreamReader sr = File.OpenText(fileName))
            {

                toolStripStatusLabel1.Text = "Inprogress..";

                string s = String.Empty;
                s = sr.ReadToEnd();
                //while ((s = sr.ReadLine()) != null)
                //{
                //    //do your stuff here
                //}

                selectfiletypes(openFileDialog1);

                Import import = new Import();
                import.contentFormat = this.contentFormat;
                import.contentValue = s;
                import.apiType = this.apiType;

                var serializer = new JavaScriptSerializer();
                var myJSON = serializer.Serialize(import);

                //var myJSON = JsonConvert.SerializeObject(import);

                PostrequestAsync(comboapis2.SelectedValue.ToString(), myJSON);



            }


        }



        private void lblfilepath_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtapimname_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void comboapislist_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboapis2.DataSource = null;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                MessageBox.Show("Last Import operation is running. Please wait..", "Operation Running", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btngetapis.Enabled = true;
            comboapislist.DataSource = null;
            lblimporttype.Text = "";
            txtfilebrowse.Text = "";
            comboapis2.DataSource = null;
            toolStripProgressBar1.ProgressBar.Value = 0;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel1.Text = "Idle...";
            toolStripStatusLabel1.Visible = false;
            grpLogin.Enabled = true;
            grpApis.Enabled = false;
        }
    }
}
