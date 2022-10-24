namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblResult.Text=String.Empty;
		}

       

		private void btnRight_Click(object sender, EventArgs e)
		{
			//靠右對齊

			//取得列數
			int rows = 0;
			try
			{
				rows = GetRows(); //報錯或return rows(int)
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

			// 生成靠右星號三角形
			string stars = GetRightStars(rows);

			// 呈現Stars
			Display(stars);

		}

		private void btbIso_Click(object sender, EventArgs e)
		{
			//等腰三角形

			//取得列數
			int rows = 0;
			try
			{
				rows = GetRows(); //報錯或return rows(int)
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

			// 生成等腰星號三角形
			string stars = GetIsoStars(rows);

			// 呈現Stars
			Display(stars);

		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			//取得列數
			//靠左對齊

			int rows = 0;
			try
			{
				rows = GetRows(); //報錯或return rows(int)
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

			// 生成靠左星號三角形
			string stars = GetLeftStars(rows);

			// 呈現Stars
			Display(stars);
		}

		private void Display(string stars)
		{
			txtResult.Text = stars;
			lblResult.Text = stars;

		}

		//靠右對齊
		private string GetRightStars(int rows)
		{
			string stars = string.Empty;
			for (int i = 1; i<=rows ; i++)
			{
				stars += new string(' ',rows-i) + new string(' ', rows - i) + new string('*',i) + "\r\n";
			}
			return stars;
		}

		//等腰
		private string GetIsoStars(int rows)
		{
			string stars = string.Empty;
			for (int i = 1; i <=rows; i++)
			{
				stars += new string(' ', rows-i) + new string(' ', rows - i) + new string('*', 2*i-1) + "\r\n";
			}
			return stars;
		}

		//靠左
		private string GetLeftStars(int rows)
		{
			string stars = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				stars +=  new string('*', i) + "\r\n";
			}
			return stars;
		}
		private int GetRows()
		{
			string input = rowstxt.Text;
			bool isInt = int.TryParse(input, out int rows);
			if (isInt == false)
			{
				throw new Exception("請輸入列數");
			}
			if (rows<1 ||rows>5)
			{
				throw new Exception("列數需介於1~5");
			}
			return rows;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}