namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnRight_Click(object sender, EventArgs e)
		{

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
			string stars =GetRightStars(rows);

			// 呈現Stars
			Display(stars);
		}

		private void btbIso_Click(object sender, EventArgs e)
		{
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

		private void Display(string stars)
		{
			txtResult.Text = stars;
			lblresult.Text = stars;
			
		}

		private  string GetRightStars(int rows)
		{
			string stars=string.Empty;
			for (int i = 1; i <=rows; i++)
			{
				stars+=new string('*',i)+"\r\n";
			}
			return stars;
		}

		private int GetRows()
		{
			string input=rowstxt.Text;
			bool isInt = int.TryParse(input,out int rows); 
			if (isInt==false)
			{
				throw new Exception("請輸入列數");
			}
			if (rows<0)
			{
				throw new Exception("列數需大於0");
			}
			return rows;
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{

		}
	}
}