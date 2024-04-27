namespace GUI_視窗版本XAXB_遊戲
{
     public partial class MainForm : Form
 {
     private XaXbEngine xaxb; // XAXB 遊戲引擎
     private int counter; // 猜測次數計數器

     // 主表單的建構函式
     public MainForm()
     {
         InitializeComponent();
         xaxb = new XaXbEngine(); // 初始化 XAXB 遊戲引擎
         counter = 0; // 初始化猜測次數為 0
         label1.Text = "請輸入不重複的三個數字(0~9):"; // 設定提示文字
     }

     // "Guess" 按鈕的點擊事件處理方法
     private void btnGuess_Click(object sender, EventArgs e)
     {
         string userNum = txtUserInput.Text.Trim(); // 獲取使用者輸入的數字
         if (xaxb.IsLegalNumber(userNum)) // 檢查輸入的數字是否合法
         {
             counter++; // 猜測次數加一
             string result = xaxb.GetResult(userNum); // 獲取猜測結果
             lstResults.Items.Add($"{userNum}: {result}， 猜測次數: {counter}"); // 將猜測結果顯示在列表框中
             if (result == "3A0B") // 如果猜對了
             {
                 lstResults.Items.Add("恭喜你，猜對了!"); // 顯示恭喜訊息
                 btnGuess.Enabled = false; // 禁用猜測按鈕
             }
         }
         else
         {
             MessageBox.Show("輸入的資料不對，或長度不對!!請重新輸入!!"); // 提示用戶重新輸入
         }
         txtUserInput.Clear(); // 清空輸入框
     }
 }

 // XAXB 遊戲引擎類別
 internal class XaXbEngine
 {
     private string luckyNumber; // 幸運數字

     // XAXB 遊戲引擎的建構函式
     public XaXbEngine()
     {
         GenerateLuckyNumber(); // 初始化幸運數字
     }

     // 生成幸運數字的方法
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
         luckyNumber = string.Join("", digits); // 將數字串接成幸運數字
     }

     // 檢查數字是否合法的方法
     public bool IsLegalNumber(string number)
     {
         if (number.Length != 3)
         {
             return false; // 數字長度不等於 3，不合法
         }
         foreach (char c in number)
         {
             if (!char.IsDigit(c))
             {
                 return false; // 包含非數字字符，不合法
             }
         }
         return number.Distinct().Count() == 3; // 確保數字不重複
     }

     // 獲取猜測結果的方法
     public string GetResult(string guess)
     {
         int a = 0, b = 0;
         for (int i = 0; i < 3; i++)
         {
             if (guess[i] == luckyNumber[i])
             {
                 a++; // 猜中數字和位置，A數加一
             }
             else if (luckyNumber.Contains(guess[i]))
             {
                 b++; // 猜中數字但位置不對，B數加一
             }
         }
         return $"{a}A{b}B"; // 返回結果字串
     }

     // 判斷遊戲是否結束的方法
     public bool IsGameOver(string guess)
     {
         return GetResult(guess) == "3A0B"; // 判斷是否猜中全部數字和位置
     }
 }
}
    

