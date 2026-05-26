using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Curs
{
    public partial class FineForm : Form
    {
        public FineForm()
        {
            InitializeComponent();
        }

        // Заповнення даних
        public void SetVehicleData(Vehicle vehicle)
        {
            txtOwner.Text = vehicle.OwnerName;

            txtPlate.Text = vehicle.PlateNumber;

            numFine.Value = 1700;

            txtReason.Text =
                "Прострочений технічний огляд";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string text =
                "ШТРАФ\n\n" +

                "Власник: " +
                txtOwner.Text + "\n" +

                "Держ. номер: " +
                txtPlate.Text + "\n" +

                "Причина: " +
                txtReason.Text + "\n" +

                "Сума штрафу: " +
                numFine.Value + " грн\n\n";

            File.AppendAllText(
                "fines.txt",
                text
            );

            MessageBox.Show(
                "Штраф успішно виписаний!",
                "Штраф",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            string text =
    "ШТРАФ\n\n" +

    "Власник: " +
    txtOwner.Text + "\n" +

    "Держ. номер: " +
    txtPlate.Text + "\n" +

    "Причина: " +
    txtReason.Text + "\n" +

    "Сума штрафу: " +
    numFine.Value + " грн\n\n";

            File.AppendAllText(
                "fines.txt",
                text
            );

            MessageBox.Show(
                "Штраф успішно виписаний!",
                "Штраф",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}