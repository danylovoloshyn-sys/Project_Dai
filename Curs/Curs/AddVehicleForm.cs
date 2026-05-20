using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Curs
{
    public partial class AddVehicleForm : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Vehicle Vehicle { get; set; }

        public AddVehicleForm()
        {
            InitializeComponent();
        }
        public AddVehicleForm(Vehicle vehicle)
        {
            InitializeComponent();

            txtBrand.Text = vehicle.Brand;
            txtColor.Text = vehicle.Color;
            txtPlate.Text = vehicle.PlateNumber;
            numYear.Value = vehicle.Year;
            dtInspection.Value = vehicle.LastInspection;
            txtOwner.Text = vehicle.OwnerName;

            cmbType.Text = vehicle.VehicleType;
            txtPassport.Text = vehicle.PassportData;
            txtContact.Text = vehicle.ContactInfo;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Vehicle == null)
            {
                Vehicle = new Vehicle();
            }

            Vehicle.Brand = txtBrand.Text;
            Vehicle.Color = txtColor.Text;
            Vehicle.PlateNumber = txtPlate.Text;
            Vehicle.Year = (int)numYear.Value;
            Vehicle.LastInspection = dtInspection.Value;
            Vehicle.OwnerName = txtOwner.Text;

            Vehicle.VehicleType = cmbType.Text;
            Vehicle.PassportData = txtPassport.Text;
            Vehicle.ContactInfo = txtContact.Text;

            if (Vehicle.InspectionHistory == null)
            {
                Vehicle.InspectionHistory = new List<DateTime>();
            }

            Vehicle.InspectionHistory.Add(dtInspection.Value);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void dtInspection_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}