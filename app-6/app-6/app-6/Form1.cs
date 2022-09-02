using System.Net;

namespace app_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_TestNoneAsync_Click(object sender, EventArgs e)
        {
            var result1 = TestNoneAsync();
        }


        public string TestNoneAsync()
        {
            var webClient = new WebClient();

            return webClient.DownloadString("https://www.dntips.ir");

        }

        private void btn_TestAsync_Click(object sender, EventArgs e)
        {
            TestAsync();
        }

        public void TestAsync()
        {
            //Event based asynchronous pattern ---- EAP
            var webClient = new WebClient();
            webClient.DownloadStringAsync(new Uri("https://www.dntips.ir"));
            webClient.DownloadStringCompleted += webClientDownloadStringCompleted;
        }

        void webClientDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            var result = e.Result;
        }

        private void btn_btnGetInfo_Click(object sender, EventArgs e)
        {
            var sync = SynchronizationContext.Current;
            var req = (HttpWebRequest)WebRequest.Create("https://www.dntips.ir");
            req.Method = "HEAD";
            req.BeginGetResponse(
                asyncResult =>
                {
                    var resp = (HttpWebResponse)req.EndGetResponse(asyncResult);
                    var headersText = formatHeaders(resp.Headers);
                    sync.Post(delegate { txtResults.Text = headersText; }, null);
                }, null);
        }

        private string formatHeaders(WebHeaderCollection headers)
        {
            var headerString = headers.Keys.Cast<string>()
                                      .Select(header => string.Format("{0}:{1}", header, headers[header]));
            return string.Join(Environment.NewLine, headerString.ToArray());
        }

        private void btn_DoWorkAsync_Click(object sender, EventArgs e)
        {
            Task task = DoWorkAsync(3000);
        }

        public async Task DoWorkAsync(int parameter)
        {
            await Task.Delay(parameter);
            MessageBox.Show(parameter.ToString());
        }


        public async Task<double> GetNumberAsync()
        {
            var generator = new Random();
            await Task.Delay(generator.Next(1000));

            return generator.NextDouble();
        }

        public async Task<string> DownloadAsync()
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync("http://www.google.com");
        }
    }
}