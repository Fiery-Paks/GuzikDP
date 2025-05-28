namespace TravelAgencyGuzik.UserControls
{
    partial class UserControlBookingsAddUpdate
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bookingDateLabel;
            System.Windows.Forms.Label clientIdLabel;
            System.Windows.Forms.Label paymentAmountLabel;
            System.Windows.Forms.Label staffIdLabel;
            System.Windows.Forms.Label tourIdLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label scannedDocLabel;
            System.Windows.Forms.Label paymentStatusLabel;
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clientIdComboBox = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentAmountTextBox = new System.Windows.Forms.TextBox();
            this.staffIdComboBox = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourIdComboBox = new System.Windows.Forms.ComboBox();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.scannedDocLinkLabel = new System.Windows.Forms.LinkLabel();
            this.paymentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            bookingDateLabel = new System.Windows.Forms.Label();
            clientIdLabel = new System.Windows.Forms.Label();
            paymentAmountLabel = new System.Windows.Forms.Label();
            staffIdLabel = new System.Windows.Forms.Label();
            tourIdLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            scannedDocLabel = new System.Windows.Forms.Label();
            paymentStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelName
            // 
            this.labelName.Size = new System.Drawing.Size(606, 40);
            this.labelName.Text = "Новое бронирование";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(735, 6);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(843, 10);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(843, 10);
            // 
            // bookingDateLabel
            // 
            bookingDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            bookingDateLabel.AutoSize = true;
            bookingDateLabel.BackColor = System.Drawing.Color.Transparent;
            bookingDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bookingDateLabel.Location = new System.Drawing.Point(30, 282);
            bookingDateLabel.Name = "bookingDateLabel";
            bookingDateLabel.Size = new System.Drawing.Size(127, 24);
            bookingDateLabel.TabIndex = 7;
            bookingDateLabel.Text = "Booking Date:";
            // 
            // clientIdLabel
            // 
            clientIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            clientIdLabel.AutoSize = true;
            clientIdLabel.BackColor = System.Drawing.Color.Transparent;
            clientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            clientIdLabel.Location = new System.Drawing.Point(30, 161);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new System.Drawing.Size(82, 24);
            clientIdLabel.TabIndex = 9;
            clientIdLabel.Text = "Client Id:";
            // 
            // paymentAmountLabel
            // 
            paymentAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            paymentAmountLabel.AutoSize = true;
            paymentAmountLabel.BackColor = System.Drawing.Color.Transparent;
            paymentAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            paymentAmountLabel.Location = new System.Drawing.Point(446, 162);
            paymentAmountLabel.Name = "paymentAmountLabel";
            paymentAmountLabel.Size = new System.Drawing.Size(159, 24);
            paymentAmountLabel.TabIndex = 11;
            paymentAmountLabel.Text = "Payment Amount:";
            // 
            // staffIdLabel
            // 
            staffIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            staffIdLabel.AutoSize = true;
            staffIdLabel.BackColor = System.Drawing.Color.Transparent;
            staffIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            staffIdLabel.Location = new System.Drawing.Point(30, 199);
            staffIdLabel.Name = "staffIdLabel";
            staffIdLabel.Size = new System.Drawing.Size(69, 24);
            staffIdLabel.TabIndex = 17;
            staffIdLabel.Text = "Staff Id:";
            // 
            // tourIdLabel
            // 
            tourIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            tourIdLabel.AutoSize = true;
            tourIdLabel.BackColor = System.Drawing.Color.Transparent;
            tourIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tourIdLabel.Location = new System.Drawing.Point(30, 237);
            tourIdLabel.Name = "tourIdLabel";
            tourIdLabel.Size = new System.Drawing.Size(75, 24);
            tourIdLabel.TabIndex = 21;
            tourIdLabel.Text = "Tour Id:";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            statusLabel.AutoSize = true;
            statusLabel.BackColor = System.Drawing.Color.Transparent;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            statusLabel.Location = new System.Drawing.Point(446, 245);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(65, 24);
            statusLabel.TabIndex = 22;
            statusLabel.Text = "Status:";
            // 
            // scannedDocLabel
            // 
            scannedDocLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            scannedDocLabel.AutoSize = true;
            scannedDocLabel.BackColor = System.Drawing.Color.Transparent;
            scannedDocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            scannedDocLabel.Location = new System.Drawing.Point(446, 286);
            scannedDocLabel.Name = "scannedDocLabel";
            scannedDocLabel.Size = new System.Drawing.Size(130, 24);
            scannedDocLabel.TabIndex = 23;
            scannedDocLabel.Text = "Scanned Doc:";
            // 
            // paymentStatusLabel
            // 
            paymentStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            paymentStatusLabel.AutoSize = true;
            paymentStatusLabel.BackColor = System.Drawing.Color.Transparent;
            paymentStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            paymentStatusLabel.Location = new System.Drawing.Point(446, 207);
            paymentStatusLabel.Name = "paymentStatusLabel";
            paymentStatusLabel.Size = new System.Drawing.Size(143, 24);
            paymentStatusLabel.TabIndex = 24;
            paymentStatusLabel.Text = "Payment Status:";
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataSource = typeof(TravelAgencyGuzik.ModelEF.Bookings);
            // 
            // bookingDateDateTimePicker
            // 
            this.bookingDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookingsBindingSource, "BookingDate", true));
            this.bookingDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookingDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bookingDateDateTimePicker.Location = new System.Drawing.Point(201, 282);
            this.bookingDateDateTimePicker.Name = "bookingDateDateTimePicker";
            this.bookingDateDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.bookingDateDateTimePicker.TabIndex = 8;
            // 
            // clientIdComboBox
            // 
            this.clientIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "ClientId", true));
            this.clientIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookingsBindingSource, "ClientId", true));
            this.clientIdComboBox.DataSource = this.clientsBindingSource;
            this.clientIdComboBox.DisplayMember = "LastName";
            this.clientIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientIdComboBox.FormattingEnabled = true;
            this.clientIdComboBox.Location = new System.Drawing.Point(201, 162);
            this.clientIdComboBox.Name = "clientIdComboBox";
            this.clientIdComboBox.Size = new System.Drawing.Size(200, 32);
            this.clientIdComboBox.TabIndex = 10;
            this.clientIdComboBox.ValueMember = "Id";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(TravelAgencyGuzik.ModelEF.Clients);
            // 
            // paymentAmountTextBox
            // 
            this.paymentAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.paymentAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "PaymentAmount", true));
            this.paymentAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentAmountTextBox.Location = new System.Drawing.Point(617, 163);
            this.paymentAmountTextBox.Name = "paymentAmountTextBox";
            this.paymentAmountTextBox.Size = new System.Drawing.Size(200, 29);
            this.paymentAmountTextBox.TabIndex = 12;
            this.paymentAmountTextBox.Text = "00,00";
            // 
            // staffIdComboBox
            // 
            this.staffIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.staffIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "StaffId", true));
            this.staffIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookingsBindingSource, "StaffId", true));
            this.staffIdComboBox.DataSource = this.staffBindingSource;
            this.staffIdComboBox.DisplayMember = "SecondName";
            this.staffIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staffIdComboBox.FormattingEnabled = true;
            this.staffIdComboBox.Location = new System.Drawing.Point(201, 200);
            this.staffIdComboBox.Name = "staffIdComboBox";
            this.staffIdComboBox.Size = new System.Drawing.Size(200, 32);
            this.staffIdComboBox.TabIndex = 18;
            this.staffIdComboBox.ValueMember = "Id";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(TravelAgencyGuzik.ModelEF.Staff);
            // 
            // tourIdComboBox
            // 
            this.tourIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tourIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "TourId", true));
            this.tourIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookingsBindingSource, "TourId", true));
            this.tourIdComboBox.DataSource = this.toursBindingSource;
            this.tourIdComboBox.DisplayMember = "TourName";
            this.tourIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tourIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tourIdComboBox.FormattingEnabled = true;
            this.tourIdComboBox.Location = new System.Drawing.Point(201, 238);
            this.tourIdComboBox.Name = "tourIdComboBox";
            this.tourIdComboBox.Size = new System.Drawing.Size(200, 32);
            this.tourIdComboBox.TabIndex = 22;
            this.tourIdComboBox.ValueMember = "Id";
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataSource = typeof(TravelAgencyGuzik.ModelEF.Tours);
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "Status", true));
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Completed",
            "Cancelled",
            "Confirmed",
            "Pending"});
            this.statusComboBox.Location = new System.Drawing.Point(617, 245);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(200, 32);
            this.statusComboBox.TabIndex = 23;
            // 
            // scannedDocLinkLabel
            // 
            this.scannedDocLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.scannedDocLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.scannedDocLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "ScannedDoc", true));
            this.scannedDocLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.scannedDocLinkLabel.Location = new System.Drawing.Point(614, 288);
            this.scannedDocLinkLabel.Name = "scannedDocLinkLabel";
            this.scannedDocLinkLabel.Size = new System.Drawing.Size(203, 23);
            this.scannedDocLinkLabel.TabIndex = 24;
            this.scannedDocLinkLabel.TabStop = true;
            this.scannedDocLinkLabel.Text = "linkLabel1";
            this.scannedDocLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.scannedDocLinkLabel_LinkClicked);
            // 
            // paymentStatusComboBox
            // 
            this.paymentStatusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.paymentStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingsBindingSource, "PaymentStatus", true));
            this.paymentStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.paymentStatusComboBox.FormattingEnabled = true;
            this.paymentStatusComboBox.Items.AddRange(new object[] {
            "Paid",
            "PartiallyPaid",
            "Unpaid"});
            this.paymentStatusComboBox.Location = new System.Drawing.Point(617, 207);
            this.paymentStatusComboBox.Name = "paymentStatusComboBox";
            this.paymentStatusComboBox.Size = new System.Drawing.Size(200, 32);
            this.paymentStatusComboBox.TabIndex = 25;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(176)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(316, 366);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(220, 40);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "Сохранить изменения";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UserControlBookingsAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(paymentStatusLabel);
            this.Controls.Add(this.paymentStatusComboBox);
            this.Controls.Add(scannedDocLabel);
            this.Controls.Add(this.scannedDocLinkLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(bookingDateLabel);
            this.Controls.Add(this.bookingDateDateTimePicker);
            this.Controls.Add(clientIdLabel);
            this.Controls.Add(this.clientIdComboBox);
            this.Controls.Add(paymentAmountLabel);
            this.Controls.Add(this.paymentAmountTextBox);
            this.Controls.Add(staffIdLabel);
            this.Controls.Add(this.staffIdComboBox);
            this.Controls.Add(tourIdLabel);
            this.Controls.Add(this.tourIdComboBox);
            this.Name = "UserControlBookingsAddUpdate";
            this.Size = new System.Drawing.Size(838, 432);
            this.Load += new System.EventHandler(this.UserControlBookingsAddUpdate_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(this.tourIdComboBox, 0);
            this.Controls.SetChildIndex(tourIdLabel, 0);
            this.Controls.SetChildIndex(this.staffIdComboBox, 0);
            this.Controls.SetChildIndex(staffIdLabel, 0);
            this.Controls.SetChildIndex(this.paymentAmountTextBox, 0);
            this.Controls.SetChildIndex(paymentAmountLabel, 0);
            this.Controls.SetChildIndex(this.clientIdComboBox, 0);
            this.Controls.SetChildIndex(clientIdLabel, 0);
            this.Controls.SetChildIndex(this.bookingDateDateTimePicker, 0);
            this.Controls.SetChildIndex(bookingDateLabel, 0);
            this.Controls.SetChildIndex(this.statusComboBox, 0);
            this.Controls.SetChildIndex(statusLabel, 0);
            this.Controls.SetChildIndex(this.scannedDocLinkLabel, 0);
            this.Controls.SetChildIndex(scannedDocLabel, 0);
            this.Controls.SetChildIndex(this.paymentStatusComboBox, 0);
            this.Controls.SetChildIndex(paymentStatusLabel, 0);
            this.Controls.SetChildIndex(this.buttonUpdate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private System.Windows.Forms.DateTimePicker bookingDateDateTimePicker;
        private System.Windows.Forms.ComboBox clientIdComboBox;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.TextBox paymentAmountTextBox;
        private System.Windows.Forms.ComboBox staffIdComboBox;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.ComboBox tourIdComboBox;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.LinkLabel scannedDocLinkLabel;
        private System.Windows.Forms.ComboBox paymentStatusComboBox;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
