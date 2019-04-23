using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionSum
{
	public partial class Form1 : Form
	{
		
		internal static Fraction fraction1 = null;
		internal static Fraction fraction2 = null;
		internal static Fraction fractionEx = new Fraction(1,1);
		public Form1()
		{
			InitializeComponent();
			txtDec2.Enabled = false;
			txBNum2.Enabled = false;
			txBDen2.Enabled = false;
			btnCreateTwoFraction.Enabled = false;
			
			txtDec.Enabled = false;
			txtDen.Enabled = false;
			txtNum.Enabled = false;
			btnCreate1.Enabled = false;
		}

		private void chBFraction_CheckedChanged(object sender, EventArgs e)
		{
			if (chBFraction.Checked)
			{
				txtDec.Enabled = false;
				txtDen.Enabled = true;
				txtNum.Enabled = true;
				btnCreate1.Enabled = true;
			}
		}

		private void chBDec_CheckedChanged(object sender, EventArgs e)
		{
			if (chBDec.Checked)
			{
				
				txtDec.Enabled = true;
				txtDen.Enabled = false;
				txtNum.Enabled = false;
				btnCreate1.Enabled = true;
			}
		}

		private void btnCreate1_Click(object sender, EventArgs e)
		{
			if (chBFraction.Checked) {
				fraction1 = new Fraction(Convert.ToInt32(txtNum.Text), Convert.ToInt32(txtDen.Text));

			}
			if (chBDec.Checked)
			{
				
				fractionEx.ToDecimal(new DecimalFraction(Convert.ToDouble(txtDec.Text)));
				fraction1 = fractionEx;

			}
			labelDrob1.Text = fraction1.ToString();

		}

		private void chBFraction2_CheckedChanged(object sender, EventArgs e)
		{
			if (chBFraction2.Checked)
			{
				txtDec2.Enabled = false;
				txBNum2.Enabled = true ;
				txBDen2.Enabled = true;
				btnCreateTwoFraction.Enabled = true;
			}
		}

		private void chBDec2_CheckedChanged(object sender, EventArgs e)
		{
			if (chBDec2.Checked)
			{
				txtDec2.Enabled = true;
				txBNum2.Enabled = false;
				txBDen2.Enabled = false;
				btnCreateTwoFraction.Enabled = true;
			}
		}

		private void btnCreateTwoFraction_Click(object sender, EventArgs e)
		{
			if (chBFraction2.Checked)
			{
				fraction2 = new Fraction(Convert.ToInt32(txBNum2.Text), Convert.ToInt32(txBDen2.Text));

			}
			if (chBDec2.Checked)
			{

				fractionEx.ToDecimal(new DecimalFraction(Convert.ToDouble(txtDec2.Text)));
				fraction2 = fractionEx;

			}
			labelDrob2.Text = fraction2.ToString();
		}

		private void buttonSum_Click(object sender, EventArgs e)
		{
			if (fraction1 != null & fraction2 != null)
			{
				Fraction Sumfraction = fraction1 + fraction2;
				textBoxSum.Text = Sumfraction.ToString();
			}
				
		}

		private void buttonMinus_Click(object sender, EventArgs e)
		{
			if (fraction1 != null & fraction2 != null)
			{
				Fraction Sumfraction = fraction1 - fraction2;
				textBoxMinus.Text = Sumfraction.ToString();
			}
		}

		private void buttonMult_Click(object sender, EventArgs e)
		{
			if (fraction1 != null & fraction2 != null)
			{
				Fraction Sumfraction = fraction1 *fraction2;
				textBoxMult.Text = Sumfraction.ToString();
			}
		}

		private void buttonDevide_Click(object sender, EventArgs e)
		{
			if (fraction1 != null & fraction2 != null)
			{
				Fraction Sumfraction = fraction1 /fraction2;
				textBoxDevide.Text = Sumfraction.ToString();
			}
		}
	}
}
