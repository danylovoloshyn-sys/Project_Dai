using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Curs
{
    public partial class Form1 : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        public Form1()
        {
            InitializeComponent();

            LoadData();
        }

        private void SaveData()
        {
            string json =
                JsonSerializer.Serialize(vehicles);

            File.WriteAllText("vehicles.json", json);
        }

        private void LoadData()
        {
            if (File.Exists("vehicles.json"))
            {
                string json =
                    File.ReadAllText("vehicles.json");

                vehicles =
                    JsonSerializer.Deserialize<List<Vehicle>>(json);

                dgvVehicles.Rows.Clear();

                foreach (Vehicle vehicle in vehicles)
                {
                    dgvVehicles.Rows.Add(
                        vehicle.PlateNumber,
                        vehicle.Brand,
                        vehicle.Color,
                        vehicle.Year,
                        vehicle.LastInspection.ToShortDateString(),
                        vehicle.OwnerName
                    );
                }
            }
        }
        private void RefreshTable()
        {
            dgvVehicles.Rows.Clear();

            foreach (Vehicle vehicle in vehicles)
            {
                dgvVehicles.Rows.Add(
                    vehicle.PlateNumber,
                    vehicle.Brand,
                    vehicle.Color,
                    vehicle.Year,
                    vehicle.LastInspection.ToShortDateString(),
                    vehicle.OwnerName
                );
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            int total = vehicles.Count;

            MessageBox.Show(
                "Загальна кількість транспортних засобів: " + total,
                "Статистика",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVehicleForm form = new AddVehicleForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                vehicles.Add(form.Vehicle);
                RefreshTable();
                SaveData();
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count > 0)
            {
                int index = dgvVehicles.SelectedRows[0].Index;

                Vehicle selectedVehicle = vehicles[index];

                AddVehicleForm form = new AddVehicleForm(selectedVehicle);

                if (form.ShowDialog() == DialogResult.OK)
{
    vehicles[index] = form.Vehicle;

    RefreshTable();

    SaveData();
}
            }
            else
            {
                MessageBox.Show(
                    "Оберіть транспортний засіб!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void dgvVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVehicles.Rows[e.RowIndex];

                txtInfoPlate.Text = row.Cells[0].Value.ToString();
                txtInfoBrand.Text = row.Cells[1].Value.ToString();
                txtInfoColor.Text = row.Cells[2].Value.ToString();
                txtInfoYear.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count > 0)
            {
                int index = dgvVehicles.SelectedRows[0].Index;

                vehicles.RemoveAt(index);
                SaveData();
                RefreshTable();
                dgvVehicles.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show(
                    "Оберіть транспортний засіб!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvVehicles.Rows.Clear();

            foreach (Vehicle vehicle in vehicles)
            {
                bool match = true;

                // Марка
                if (!string.IsNullOrWhiteSpace(txtBrand.Text))
                {
                    if (!vehicle.Brand.ToLower().Contains(txtBrand.Text.ToLower()))
                    {
                        match = false;
                    }
                }

                // Колір
                if (!string.IsNullOrWhiteSpace(txtColor.Text))
                {
                    if (!vehicle.Color.ToLower().Contains(txtColor.Text.ToLower()))
                    {
                        match = false;
                    }
                }

                // Номер
                if (!string.IsNullOrWhiteSpace(txtPlate.Text))
                {
                    if (!vehicle.PlateNumber.ToLower().Contains(txtPlate.Text.ToLower()))
                    {
                        match = false;
                    }
                }

                // Тип ТЗ
                if (!string.IsNullOrWhiteSpace(cmbSearchType.Text))
                {
                    if (!vehicle.VehicleType.ToLower()
                        .Contains(cmbSearchType.Text.ToLower()))
                    {
                        match = false;
                    }
                }

                // Власник
                if (!string.IsNullOrWhiteSpace(txtSearchOwner.Text))
                {
                    if (!vehicle.OwnerName.ToLower()
                        .Contains(txtSearchOwner.Text.ToLower()))
                    {
                        match = false;
                    }
                }

                // Паспорт
                if (!string.IsNullOrWhiteSpace(txtSearchPassport.Text))
                {
                    if (!vehicle.PassportData.ToLower()
                        .Contains(txtSearchPassport.Text.ToLower()))
                    {
                        match = false;
                    }
                }

                // Контакти
                if (!string.IsNullOrWhiteSpace(txtSearchContact.Text))
                {
                    if (!vehicle.ContactInfo.ToLower()
                        .Contains(txtSearchContact.Text.ToLower()))
                    {
                        match = false;
                    }
                }

                if (match)
                {
                    dgvVehicles.Rows.Add(
                        vehicle.PlateNumber,
                        vehicle.Brand,
                        vehicle.Color,
                        vehicle.Year,
                        vehicle.LastInspection.ToShortDateString(),
                        vehicle.OwnerName
                    );
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtBrand.Text = "";
            txtColor.Text = "";
            txtPlate.Text = "";
            cmbSearchType.Text = "";
            txtSearchOwner.Text = "";
            txtSearchPassport.Text = "";
            txtSearchContact.Text = "";

            dgvVehicles.Rows.Clear();

            foreach (Vehicle vehicle in vehicles)
            {
                dgvVehicles.Rows.Add(
                    vehicle.PlateNumber,
                    vehicle.Brand,
                    vehicle.Color,
                    vehicle.Year,
                    vehicle.LastInspection.ToShortDateString(),
                    vehicle.OwnerName
                );
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInspection_Click(object sender, EventArgs e)
        {
            dgvVehicles.Rows.Clear();

            DateTime today = DateTime.Now;

            int expiredCount = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                DateTime nextInspection =
                    vehicle.LastInspection.AddYears(1);

                // Прострочений
                bool expired = nextInspection < today;

                // Менше 30 днів
                bool soon =
                    (nextInspection - today).TotalDays <= 30 &&
                    (nextInspection - today).TotalDays >= 0;

                if (expired || soon)
                {
                    dgvVehicles.Rows.Add(
                        vehicle.PlateNumber,
                        vehicle.Brand,
                        vehicle.Color,
                        vehicle.Year,
                        vehicle.LastInspection.ToShortDateString(),
                        vehicle.OwnerName
                    );
                    MessageBox.Show(
    "Власнику " + vehicle.OwnerName +
    " необхідно пройти техогляд.\n\n" +
    "Транспортний засіб: " +
    vehicle.Brand +
    " (" + vehicle.PlateNumber + ")",
    "Запрошення на техогляд",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning
);
                }

                if (expired)
                {
                    expiredCount++;
                }
            }

            MessageBox.Show(
    "Прострочених техоглядів: " + expiredCount,
    "Статистика техогляду",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning
);

            MessageBox.Show(
                "Показані транспортні засоби, що потребують техогляду.",
                "Контроль техогляду",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
