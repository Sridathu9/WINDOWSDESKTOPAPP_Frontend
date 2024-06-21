using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleFormsReplicaApp
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var email = textBox2.Text;
            var phone = textBox3.Text;
            var githubLink = textBox4.Text;
            var stopwatchTime = textBox5.Text;

            var submission = new
            {
                name,
                email,
                phone,
                github_link = githubLink,
                stopwatch_time = stopwatchTime
            };

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(submission);
            var content = new StringContent(json, Encoding.UTF8, "BACKEND/package.json");

            var response = await client.PostAsync("http://localhost:3000/submit", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Submission successful!");
            }
            else
            {
                MessageBox.Show("Submission failed.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
public class Submission
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string GitHubLink { get; set; }
    public string StopwatchTime { get; set; }
}
