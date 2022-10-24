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
			//�a�k���

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

		private void btbIso_Click(object sender, EventArgs e)
		{
			//���y�T����

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

			// �ͦ����y�P���T����
			string stars = GetIsoStars(rows);

			// �e�{Stars
			Display(stars);

		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			//���o�C��
			//�a�����

			int rows = 0;
			try
			{
				rows = GetRows(); //������return rows(int)
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

			// �ͦ��a���P���T����
			string stars = GetLeftStars(rows);

			// �e�{Stars
			Display(stars);
		}

		private void Display(string stars)
		{
			txtResult.Text = stars;
			lblResult.Text = stars;

		}

		//�a�k���
		private string GetRightStars(int rows)
		{
			string stars = string.Empty;
			for (int i = 1; i<=rows ; i++)
			{
				stars += new string(' ',rows-i) + new string(' ', rows - i) + new string('*',i) + "\r\n";
			}
			return stars;
		}

		//���y
		private string GetIsoStars(int rows)
		{
			string stars = string.Empty;
			for (int i = 1; i <=rows; i++)
			{
				stars += new string(' ', rows-i) + new string(' ', rows - i) + new string('*', 2*i-1) + "\r\n";
			}
			return stars;
		}

		//�a��
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
				throw new Exception("�п�J�C��");
			}
			if (rows<1 ||rows>5)
			{
				throw new Exception("�C�ƻݤ���1~5");
			}
			return rows;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}