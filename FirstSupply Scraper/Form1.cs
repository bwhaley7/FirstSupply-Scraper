using ExcelDataReader;

namespace FirstSupply_Scraper
{
    public partial class Form1 : Form
    {
        WebScraper ws = new WebScraper();
        List<Product> products = new List<Product>();
        ExcelHelper eh = new ExcelHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void loadExcel_Click(object sender, EventArgs e)
        {
            eh.readExcel(products);
            populateData();
        }

        private void populateData()
        {
            foreach(Product p in products)
            {
                productGrid.Rows.Add(p.prodNum,p.model,p.cat1,p.cat2,p.cat3,p.cat4,p.cat5);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        private void scrapePage_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                ws.Navigate(p.model,p);
                if(ws.getBreadcrumbs(p))
                    ws.assignCategories(p);
            }
            productGrid.Rows.Clear();
            populateData();
        }

        private void exportFile_Click(object sender, EventArgs e)
        {
            eh.writeExcel(products);
        }
    }
}