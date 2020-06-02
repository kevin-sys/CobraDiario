using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace CobraDiario
{
    public partial class Form1 : Form
    {
        DebtCollectorService service = new DebtCollectorService();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var answer = new DebtCollectorService.Answer();
            try
            {
                debtCollector collector = new debtCollector();
                collector.ID = TxtID.Text.ToUpper();
                collector.FirstName = TxtFirstName.Text.ToUpper();
                collector.SecondName = TxtSecondName.Text.ToUpper();
                collector.LastName = TxtLastName.Text.ToUpper();
                collector.MoneyCharge = double.Parse(TxtMoneyCharge.Text.Trim());
                collector.ZoneWork = CmbZoneWork.Text;
                collector.BirthDate = DtpBirthDate.Value.Date;
                collector.RegistrationDate = DtpRegistrationDate.Value.Date;
                answer = service.Save(collector);
                MessageBox.Show(answer.Message, "Resultado de guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
