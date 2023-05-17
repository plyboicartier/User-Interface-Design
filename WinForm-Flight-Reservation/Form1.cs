using System.Collections;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Web;

namespace FlightReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Passenger
        {
            public string fName;
            public string lName;
            public string postalCode;
            public List<string> seats = new List<string>();
            public Passenger(string fN, string lN, string pC)
            {
                fName = fN;
                lName = lN;
                postalCode = pC;
            }
            public override string ToString()
            {
                return lName + ", " + fName;
            }
        }
            
        private void SeatSelect(object sender, EventArgs e)
        {
            Button button = (Button)sender;  
            if (button.BackColor == Color.PowderBlue)
            {
                button.BackColor = Color.LightGreen;
            }
            else if (button.BackColor == Color.LightGreen)
            {
                button.BackColor = Color.PowderBlue;
                if (IsChecked())
                {
                    FormVisible();
                }
            }
            else
            {
                btnCancel.Enabled = true;
                IfReserved();
            }
        }
        private bool IsChecked()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.BackColor == Color.LightGreen) 
                {
                    return true;
                }
            }
            return false;
        }
        private void FormVisible()
        {
            btnReserve.Enabled = true;  
            txtFName.Enabled = true;
            txtLName.Enabled = true;
            txtPCode.Enabled = true;
            listPassenger.Visible = true;
        }
        private void txtFName_KeyPress(object sender, KeyPressEventArgs e) //doesnt allow user to input any characters besides letters and to press backspace
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtLName_KeyPress(object sender, KeyPressEventArgs e) //doesnt allow user to input any characters besides letters and to press backspace
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        public static bool PostCodeVerify(string posCode) //postal code verification of syntax
        {
            Regex regex = new Regex(@"^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]+$");
            return regex.IsMatch(posCode);
        }

        private void txtPCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if ((txtPCode.Text.Length == txtPCode.MaxLength) && (PostCodeVerify(txtPCode.Text)) && (!String.IsNullOrEmpty(txtFName.Text)) && (!String.IsNullOrEmpty(txtLName.Text)))
            {
                Passenger pass = new Passenger(txtFName.Text, txtLName.Text, txtPCode.Text);
                
                listPassenger.Items.Add(pass);
                foreach (var person in listPassenger.Items)
                {
                    foreach (var button in this.Controls.OfType<Button>())
                    {
                        if (button.BackColor == Color.PowderBlue)
                        {
                            button.BackColor = Color.Red;
                            pass.seats.Add(button.Text);
                            txtFName.Clear();
                            txtLName.Clear();
                            txtPCode.Clear();
                        }
                    }
                    this.Controls.Add(listPassenger);
                }
            }
            else
            {
                txtPCode.Clear();
                txtPCode.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            listPassenger.Items.Remove(listPassenger.SelectedItems);
            foreach(var button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.LightGreen;
            }
        }

        private void IfReserved ()
        {
            
        }

        private void listPassenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = listPassenger.SelectedItem.ToString();
            txtLName.Text = s.Split(',')[0];
            txtFName.Text = s.Substring(s.LastIndexOf(',') + 2);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        private void tipFName_MouseMove(object sender, EventArgs e) //sets tooltip to help user for name
        {
           //tipFName.SetToolTip(tipFName, "Name can consist of letters and spaces");
        }
    }
}