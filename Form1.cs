namespace GUI_視窗版本XAXB_遊戲
{
    public partial class MainForm : Form
    {
        
        private XaXbEngine xaxb;
        private int counter;

        public MainForm()
        {
            InitializeComponent();
            xaxb = new XaXbEngine();
            counter = 0;
            label1.Text = "請輸入不重複的三個數字(0~9):";
        }


        private void btnGuess_Click(object sender, EventArgs e)
        {
            string userNum = txtUserInput.Text.Trim();
            if (xaxb.IsLegalNumber(userNum))
            {
                counter++;
                string result = xaxb.GetResult(userNum);
                lstResults.Items.Add($"{userNum}: {result}， 猜測次數: {counter}");
                if (result == "3A0B")
                {
                    lstResults.Items.Add("恭喜你，猜對了!");
                    btnGuess.Enabled = false; // Disable guess button
                }
            }
            else
            {
                MessageBox.Show("輸入的資料不對，或長度不對!!請重新輸入!!");
            }
            txtUserInput.Clear();
        }
    }

    internal class XaXbEngine
    {
        private string luckyNumber;

        public XaXbEngine()
        {
            GenerateLuckyNumber();
        }

        public void GenerateLuckyNumber()
        {
            Random random = new Random();
            List<int> digits = new List<int>();
            while (digits.Count < 3)
            {
                int digit = random.Next(0, 10);
                if (!digits.Contains(digit))
                {
                    digits.Add(digit);
                }
            }
            luckyNumber = string.Join("", digits);
        }

        public bool IsLegalNumber(string number)
        {
            if (number.Length != 3)
            {
                return false;
            }
            foreach (char c in number)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return number.Distinct().Count() == 3;
        }

        public string GetResult(string guess)
        {
            int a = 0, b = 0;
            for (int i = 0; i < 3; i++)
            {
                if (guess[i] == luckyNumber[i])
                {
                    a++;
                }
                else if (luckyNumber.Contains(guess[i]))
                {
                    b++;
                }
            }
            return $"{a}A{b}B";
        }

        public bool IsGameOver(string guess)
        {
            return GetResult(guess) == "3A0B";
        }
    }
}
    

