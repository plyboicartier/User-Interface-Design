namespace FlightReservation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listPassenger = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPCode = new System.Windows.Forms.TextBox();
            this.C4 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.D1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.D2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.D3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.D4 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A4 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tipFName = new System.Windows.Forms.TextBox();
            this.tipLName = new System.Windows.Forms.TextBox();
            this.tipPCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPassenger
            // 
            this.listPassenger.FormattingEnabled = true;
            this.listPassenger.ItemHeight = 15;
            this.listPassenger.Location = new System.Drawing.Point(530, 310);
            this.listPassenger.Name = "listPassenger";
            this.listPassenger.Size = new System.Drawing.Size(301, 259);
            this.listPassenger.TabIndex = 16;
            this.listPassenger.SelectedIndexChanged += new System.EventHandler(this.listPassenger_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(402, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 39);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel Seat";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Enabled = false;
            this.btnReserve.Location = new System.Drawing.Point(402, 355);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 39);
            this.btnReserve.TabIndex = 18;
            this.btnReserve.Text = "Reserve Seat";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // txtFName
            // 
            this.txtFName.Enabled = false;
            this.txtFName.Location = new System.Drawing.Point(189, 310);
            this.txtFName.Name = "txtFName";
            this.txtFName.PlaceholderText = "First Name";
            this.txtFName.Size = new System.Drawing.Size(158, 23);
            this.txtFName.TabIndex = 19;
            this.txtFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFName_KeyPress);
            // 
            // txtLName
            // 
            this.txtLName.Enabled = false;
            this.txtLName.Location = new System.Drawing.Point(189, 354);
            this.txtLName.Name = "txtLName";
            this.txtLName.PlaceholderText = "Last Name";
            this.txtLName.Size = new System.Drawing.Size(158, 23);
            this.txtLName.TabIndex = 20;
            this.txtLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLName_KeyPress);
            // 
            // txtPCode
            // 
            this.txtPCode.Enabled = false;
            this.txtPCode.Location = new System.Drawing.Point(189, 400);
            this.txtPCode.MaxLength = 6;
            this.txtPCode.Name = "txtPCode";
            this.txtPCode.PlaceholderText = "Postal Code (ex. L3K6H4)";
            this.txtPCode.Size = new System.Drawing.Size(158, 23);
            this.txtPCode.TabIndex = 21;
            this.txtPCode.TextChanged += new System.EventHandler(this.txtPCode_TextChanged);
            // 
            // C4
            // 
            this.C4.BackColor = System.Drawing.Color.LightGreen;
            this.C4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C4.Location = new System.Drawing.Point(413, 210);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(75, 23);
            this.C4.TabIndex = 11;
            this.C4.Text = "C4";
            this.C4.UseVisualStyleBackColor = false;
            this.C4.Click += new System.EventHandler(this.SeatSelect);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.LightGreen;
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Location = new System.Drawing.Point(413, 181);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 23);
            this.C3.TabIndex = 10;
            this.C3.Text = "C3";
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.SeatSelect);
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.Color.LightGreen;
            this.D1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D1.Location = new System.Drawing.Point(332, 102);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(75, 23);
            this.D1.TabIndex = 12;
            this.D1.Text = "D1";
            this.D1.UseVisualStyleBackColor = false;
            this.D1.Click += new System.EventHandler(this.SeatSelect);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.LightGreen;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Location = new System.Drawing.Point(413, 131);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 23);
            this.C2.TabIndex = 9;
            this.C2.Text = "C2";
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.SeatSelect);
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.Color.LightGreen;
            this.D2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D2.Location = new System.Drawing.Point(332, 131);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(75, 23);
            this.D2.TabIndex = 13;
            this.D2.Text = "D2";
            this.D2.UseVisualStyleBackColor = false;
            this.D2.Click += new System.EventHandler(this.SeatSelect);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.LightGreen;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Location = new System.Drawing.Point(413, 102);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 23);
            this.C1.TabIndex = 8;
            this.C1.Text = "C1";
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.SeatSelect);
            // 
            // D3
            // 
            this.D3.BackColor = System.Drawing.Color.LightGreen;
            this.D3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D3.Location = new System.Drawing.Point(332, 181);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(75, 23);
            this.D3.TabIndex = 14;
            this.D3.Text = "D3";
            this.D3.UseVisualStyleBackColor = false;
            this.D3.Click += new System.EventHandler(this.SeatSelect);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.Color.LightGreen;
            this.B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B4.Location = new System.Drawing.Point(494, 210);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(75, 23);
            this.B4.TabIndex = 7;
            this.B4.Text = "B4";
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Click += new System.EventHandler(this.SeatSelect);
            // 
            // D4
            // 
            this.D4.BackColor = System.Drawing.Color.LightGreen;
            this.D4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D4.Location = new System.Drawing.Point(332, 210);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(75, 23);
            this.D4.TabIndex = 15;
            this.D4.Text = "D4";
            this.D4.UseVisualStyleBackColor = false;
            this.D4.Click += new System.EventHandler(this.SeatSelect);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.LightGreen;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Location = new System.Drawing.Point(494, 181);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 23);
            this.B3.TabIndex = 6;
            this.B3.Text = "B3";
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.SeatSelect);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.LightGreen;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Location = new System.Drawing.Point(494, 102);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 23);
            this.B1.TabIndex = 4;
            this.B1.Text = "B1";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.SeatSelect);
            // 
            // A4
            // 
            this.A4.BackColor = System.Drawing.Color.LightGreen;
            this.A4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A4.Location = new System.Drawing.Point(575, 210);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(75, 23);
            this.A4.TabIndex = 3;
            this.A4.Text = "A4";
            this.A4.UseVisualStyleBackColor = false;
            this.A4.Click += new System.EventHandler(this.SeatSelect);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.LightGreen;
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3.Location = new System.Drawing.Point(575, 181);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 23);
            this.A3.TabIndex = 2;
            this.A3.Text = "A3";
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.SeatSelect);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.LightGreen;
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2.Location = new System.Drawing.Point(575, 131);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 23);
            this.A2.TabIndex = 1;
            this.A2.Text = "A2";
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.SeatSelect);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.LightGreen;
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1.Location = new System.Drawing.Point(575, 102);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 23);
            this.A1.TabIndex = 0;
            this.A1.Text = "A1";
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.SeatSelect);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.LightGreen;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Location = new System.Drawing.Point(494, 131);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 23);
            this.B2.TabIndex = 5;
            this.B2.Text = "B2";
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.SeatSelect);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(402, 400);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 39);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit Info";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tipFName
            // 
            this.tipFName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tipFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipFName.Cursor = System.Windows.Forms.Cursors.Help;
            this.tipFName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipFName.Location = new System.Drawing.Point(353, 313);
            this.tipFName.Name = "tipFName";
            this.tipFName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tipFName.Size = new System.Drawing.Size(16, 16);
            this.tipFName.TabIndex = 23;
            this.tipFName.Text = "i";
            this.tipFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tipLName
            // 
            this.tipLName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tipLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipLName.Cursor = System.Windows.Forms.Cursors.Help;
            this.tipLName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipLName.Location = new System.Drawing.Point(353, 357);
            this.tipLName.Name = "tipLName";
            this.tipLName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tipLName.Size = new System.Drawing.Size(16, 16);
            this.tipLName.TabIndex = 24;
            this.tipLName.Text = "i";
            this.tipLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tipPCode
            // 
            this.tipPCode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tipPCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipPCode.Cursor = System.Windows.Forms.Cursors.Help;
            this.tipPCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipPCode.Location = new System.Drawing.Point(353, 403);
            this.tipPCode.Name = "tipPCode";
            this.tipPCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tipPCode.Size = new System.Drawing.Size(16, 16);
            this.tipPCode.TabIndex = 25;
            this.tipPCode.Text = "i";
            this.tipPCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(153, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer Information:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipPCode);
            this.Controls.Add(this.tipLName);
            this.Controls.Add(this.tipFName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.txtPCode);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.listPassenger);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.D2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listPassenger;
        private Button btnCancel;
        private Button btnReserve;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtPCode;
        private Button C4;
        private Button C3;
        private Button D1;
        private Button C2;
        private Button D2;
        private Button C1;
        private Button D3;
        private Button B4;
        private Button D4;
        private Button B3;
        private Button B1;
        private Button A4;
        private Button A3;
        private Button A2;
        private Button A1;
        private Button B2;
        private Button btnEdit;
        private TextBox tipFName;
        private TextBox tipLName;
        private TextBox tipPCode;
        private Label label1;
    }
}