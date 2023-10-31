namespace SimpleWinForm_Project
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;
        public Form1(HttpClient httpClient = null)
        {
            InitializeComponent();
            _httpClient = httpClient ?? new HttpClient();
        }

        private async void Download_btn_Click(object sender, EventArgs e)
        {
            Download_btn.Enabled = false;
            result_lbl.Text = "Receiving information...";
            try
            {
                string result = await DownloadDataAsync();

                result_lbl.Text = "information Reciveed! ✔️";
                MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                result_lbl.Text = "Error! ❌";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Download_btn.Enabled = true;
            }
        }
        private async Task<string> DownloadDataAsync()
        {
            // Use HttpClient to get information from a URL
            string url = "https://swapi.dev/api/people/1/";
            HttpResponseMessage response = await _httpClient.GetAsync(url); // Calling an HTTP request asynchronously

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception("Error in receiving information!");
            }
        }
    }
}