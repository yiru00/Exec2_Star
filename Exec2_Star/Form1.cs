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

			//���o�C��
			int rows = 0;
			try
			{
				rows = GetRows(); //������return rows(int)
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

			// �ͦ��a�k�P���T����
			string stars =GetRightStars(rows);

			// �e�{Stars
			Display(stars);
		}

		private void btbIso_Click(object sender, EventArgs e)
		{
			//���o�C��
			int rows = 0;
			try
			{
				rows = GetRows(); //������return rows(int)
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

			// �ͦ��a�k�P���T����
			string stars = GetRightStars(rows);

			// �e�{Stars
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
				throw new Exception("�п�J�C��");
			}
			if (rows<0)
			{
				throw new Exception("�C�ƻݤj��0");
			}
			return rows;
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{

		}
	}
}