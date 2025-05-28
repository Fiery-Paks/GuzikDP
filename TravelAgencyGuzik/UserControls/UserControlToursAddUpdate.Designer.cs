namespace TravelAgencyGuzik.UserControls
{
    partial class UserControlToursAddUpdate
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
            System.Windows.Forms.Label availablePlacesLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label hotelIdLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label tourNameLabel;
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.availablePlacesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hotelIdComboBox = new System.Windows.Forms.ComboBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tourNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            availablePlacesLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            hotelIdLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            tourNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePlacesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelName
            // 
            this.labelName.Size = new System.Drawing.Size(506, 40);
            this.labelName.Text = "Добавление тура";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(635, 6);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(743, 10);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(743, 10);
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataSource = typeof(TravelAgencyGuzik.ModelEF.Tours);
            // 
            // availablePlacesLabel
            // 
            availablePlacesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            availablePlacesLabel.AutoSize = true;
            availablePlacesLabel.BackColor = System.Drawing.Color.Transparent;
            availablePlacesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            availablePlacesLabel.Location = new System.Drawing.Point(24, 289);
            availablePlacesLabel.Name = "availablePlacesLabel";
            availablePlacesLabel.Size = new System.Drawing.Size(127, 20);
            availablePlacesLabel.TabIndex = 8;
            availablePlacesLabel.Text = "Available Places:";
            // 
            // availablePlacesNumericUpDown
            // 
            this.availablePlacesNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.availablePlacesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.toursBindingSource, "AvailablePlaces", true));
            this.availablePlacesNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.availablePlacesNumericUpDown.Location = new System.Drawing.Point(176, 289);
            this.availablePlacesNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.availablePlacesNumericUpDown.Name = "availablePlacesNumericUpDown";
            this.availablePlacesNumericUpDown.Size = new System.Drawing.Size(200, 26);
            this.availablePlacesNumericUpDown.TabIndex = 9;
            this.availablePlacesNumericUpDown.ThousandsSeparator = true;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(412, 291);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(416, 317);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(290, 129);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // endDateLabel
            // 
            endDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            endDateLabel.AutoSize = true;
            endDateLabel.BackColor = System.Drawing.Color.Transparent;
            endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            endDateLabel.Location = new System.Drawing.Point(24, 254);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(81, 20);
            endDateLabel.TabIndex = 12;
            endDateLabel.Text = "End Date:";
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.toursBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(176, 250);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.endDateDateTimePicker.TabIndex = 13;
            // 
            // hotelIdLabel
            // 
            hotelIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            hotelIdLabel.AutoSize = true;
            hotelIdLabel.BackColor = System.Drawing.Color.Transparent;
            hotelIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            hotelIdLabel.Location = new System.Drawing.Point(24, 187);
            hotelIdLabel.Name = "hotelIdLabel";
            hotelIdLabel.Size = new System.Drawing.Size(69, 20);
            hotelIdLabel.TabIndex = 14;
            hotelIdLabel.Text = "Hotel Id:";
            // 
            // hotelIdComboBox
            // 
            this.hotelIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hotelIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "HotelId", true));
            this.hotelIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.toursBindingSource, "Id", true));
            this.hotelIdComboBox.DataSource = this.hotelsBindingSource;
            this.hotelIdComboBox.DisplayMember = "HotelName";
            this.hotelIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotelIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelIdComboBox.FormattingEnabled = true;
            this.hotelIdComboBox.Location = new System.Drawing.Point(176, 184);
            this.hotelIdComboBox.Name = "hotelIdComboBox";
            this.hotelIdComboBox.Size = new System.Drawing.Size(200, 28);
            this.hotelIdComboBox.TabIndex = 15;
            this.hotelIdComboBox.ValueMember = "Id";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.toursBindingSource, "Photo", true));
            this.photoPictureBox.Image = global::TravelAgencyGuzik.Properties.Resources.placeholder;
            this.photoPictureBox.Location = new System.Drawing.Point(416, 134);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(290, 143);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 17;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // priceLabel
            // 
            priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            priceLabel.AutoSize = true;
            priceLabel.BackColor = System.Drawing.Color.Transparent;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(24, 330);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(48, 20);
            priceLabel.TabIndex = 18;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(176, 327);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 26);
            this.priceTextBox.TabIndex = 19;
            this.priceTextBox.Text = "00,00";
            // 
            // startDateLabel
            // 
            startDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            startDateLabel.AutoSize = true;
            startDateLabel.BackColor = System.Drawing.Color.Transparent;
            startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            startDateLabel.Location = new System.Drawing.Point(24, 222);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(87, 20);
            startDateLabel.TabIndex = 20;
            startDateLabel.Text = "Start Date:";
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.toursBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(176, 218);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.startDateDateTimePicker.TabIndex = 21;
            // 
            // tourNameLabel
            // 
            tourNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            tourNameLabel.AutoSize = true;
            tourNameLabel.BackColor = System.Drawing.Color.Transparent;
            tourNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tourNameLabel.Location = new System.Drawing.Point(24, 150);
            tourNameLabel.Name = "tourNameLabel";
            tourNameLabel.Size = new System.Drawing.Size(91, 20);
            tourNameLabel.TabIndex = 22;
            tourNameLabel.Text = "Tour Name:";
            // 
            // tourNameTextBox
            // 
            this.tourNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tourNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "TourName", true));
            this.tourNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tourNameTextBox.Location = new System.Drawing.Point(176, 147);
            this.tourNameTextBox.Name = "tourNameTextBox";
            this.tourNameTextBox.Size = new System.Drawing.Size(200, 26);
            this.tourNameTextBox.TabIndex = 23;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(176)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(156, 388);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(220, 40);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Сохранить изменения";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataSource = typeof(TravelAgencyGuzik.ModelEF.Hotels);
            // 
            // UserControlToursAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(availablePlacesLabel);
            this.Controls.Add(this.availablePlacesNumericUpDown);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(hotelIdLabel);
            this.Controls.Add(this.hotelIdComboBox);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(tourNameLabel);
            this.Controls.Add(this.tourNameTextBox);
            this.Name = "UserControlToursAddUpdate";
            this.Size = new System.Drawing.Size(738, 460);
            this.Load += new System.EventHandler(this.UserControlToursAddUpdate_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(this.tourNameTextBox, 0);
            this.Controls.SetChildIndex(tourNameLabel, 0);
            this.Controls.SetChildIndex(this.startDateDateTimePicker, 0);
            this.Controls.SetChildIndex(startDateLabel, 0);
            this.Controls.SetChildIndex(this.priceTextBox, 0);
            this.Controls.SetChildIndex(priceLabel, 0);
            this.Controls.SetChildIndex(this.photoPictureBox, 0);
            this.Controls.SetChildIndex(this.hotelIdComboBox, 0);
            this.Controls.SetChildIndex(hotelIdLabel, 0);
            this.Controls.SetChildIndex(this.endDateDateTimePicker, 0);
            this.Controls.SetChildIndex(endDateLabel, 0);
            this.Controls.SetChildIndex(this.descriptionTextBox, 0);
            this.Controls.SetChildIndex(descriptionLabel, 0);
            this.Controls.SetChildIndex(this.availablePlacesNumericUpDown, 0);
            this.Controls.SetChildIndex(availablePlacesLabel, 0);
            this.Controls.SetChildIndex(this.buttonUpdate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availablePlacesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource toursBindingSource;
        private System.Windows.Forms.NumericUpDown availablePlacesNumericUpDown;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.ComboBox hotelIdComboBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.TextBox tourNameTextBox;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
    }
}
