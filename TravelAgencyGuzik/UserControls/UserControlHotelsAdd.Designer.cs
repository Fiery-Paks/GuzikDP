namespace TravelAgencyGuzik.UserControls
{
    partial class UserControlHotelsAdd
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityIdLabel;
            System.Windows.Forms.Label hotelNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label starRatingLabel;
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityIdComboBox = new System.Windows.Forms.ComboBox();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelNameTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.trackBarStar = new System.Windows.Forms.TrackBar();
            addressLabel = new System.Windows.Forms.Label();
            cityIdLabel = new System.Windows.Forms.Label();
            hotelNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            starRatingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelName
            // 
            this.labelName.Size = new System.Drawing.Size(520, 40);
            this.labelName.Text = "Добавить отель";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(649, 6);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(757, 10);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(757, 10);
            // 
            // addressLabel
            // 
            addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(49, 168);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(85, 24);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Address:";
            // 
            // cityIdLabel
            // 
            cityIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cityIdLabel.AutoSize = true;
            cityIdLabel.BackColor = System.Drawing.Color.Transparent;
            cityIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cityIdLabel.Location = new System.Drawing.Point(49, 208);
            cityIdLabel.Name = "cityIdLabel";
            cityIdLabel.Size = new System.Drawing.Size(45, 24);
            cityIdLabel.TabIndex = 10;
            cityIdLabel.Text = "City:";
            // 
            // hotelNameLabel
            // 
            hotelNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            hotelNameLabel.AutoSize = true;
            hotelNameLabel.BackColor = System.Drawing.Color.Transparent;
            hotelNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            hotelNameLabel.Location = new System.Drawing.Point(49, 261);
            hotelNameLabel.Name = "hotelNameLabel";
            hotelNameLabel.Size = new System.Drawing.Size(115, 24);
            hotelNameLabel.TabIndex = 12;
            hotelNameLabel.Text = "Hotel Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneNumberLabel.Location = new System.Drawing.Point(49, 310);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(145, 24);
            phoneNumberLabel.TabIndex = 16;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // starRatingLabel
            // 
            starRatingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            starRatingLabel.AutoSize = true;
            starRatingLabel.BackColor = System.Drawing.Color.Transparent;
            starRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            starRatingLabel.Location = new System.Drawing.Point(49, 355);
            starRatingLabel.Name = "starRatingLabel";
            starRatingLabel.Size = new System.Drawing.Size(105, 24);
            starRatingLabel.TabIndex = 20;
            starRatingLabel.Text = "Star Rating:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(200, 168);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(268, 29);
            this.addressTextBox.TabIndex = 9;
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataSource = typeof(TravelAgencyGuzik.ModelEF.Hotels);
            // 
            // cityIdComboBox
            // 
            this.cityIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cityIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "CityId", true));
            this.cityIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hotelsBindingSource, "CityId", true));
            this.cityIdComboBox.DataSource = this.citiesBindingSource;
            this.cityIdComboBox.DisplayMember = "CityName";
            this.cityIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityIdComboBox.FormattingEnabled = true;
            this.cityIdComboBox.Location = new System.Drawing.Point(200, 208);
            this.cityIdComboBox.Name = "cityIdComboBox";
            this.cityIdComboBox.Size = new System.Drawing.Size(268, 32);
            this.cityIdComboBox.TabIndex = 11;
            this.cityIdComboBox.ValueMember = "CountryId";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataSource = typeof(TravelAgencyGuzik.ModelEF.Cities);
            // 
            // hotelNameTextBox
            // 
            this.hotelNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hotelNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelsBindingSource, "HotelName", true));
            this.hotelNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelNameTextBox.Location = new System.Drawing.Point(200, 261);
            this.hotelNameTextBox.Name = "hotelNameTextBox";
            this.hotelNameTextBox.Size = new System.Drawing.Size(268, 29);
            this.hotelNameTextBox.TabIndex = 13;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.hotelsBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(494, 174);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(233, 204);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 19;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.maskedTextBox1.Location = new System.Drawing.Point(200, 308);
            this.maskedTextBox1.Mask = "+7(000) 000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(268, 29);
            this.maskedTextBox1.TabIndex = 23;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(176)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(313, 422);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 40);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // trackBarStar
            // 
            this.trackBarStar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trackBarStar.Location = new System.Drawing.Point(200, 349);
            this.trackBarStar.Maximum = 5;
            this.trackBarStar.Minimum = 2;
            this.trackBarStar.Name = "trackBarStar";
            this.trackBarStar.Size = new System.Drawing.Size(268, 45);
            this.trackBarStar.TabIndex = 25;
            this.trackBarStar.Value = 5;
            // 
            // UserControlHotelsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.trackBarStar);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityIdLabel);
            this.Controls.Add(this.cityIdComboBox);
            this.Controls.Add(hotelNameLabel);
            this.Controls.Add(this.hotelNameTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(starRatingLabel);
            this.Name = "UserControlHotelsAdd";
            this.Size = new System.Drawing.Size(752, 494);
            this.Load += new System.EventHandler(this.UserControlHotelsAdd_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(starRatingLabel, 0);
            this.Controls.SetChildIndex(this.photoPictureBox, 0);
            this.Controls.SetChildIndex(phoneNumberLabel, 0);
            this.Controls.SetChildIndex(this.hotelNameTextBox, 0);
            this.Controls.SetChildIndex(hotelNameLabel, 0);
            this.Controls.SetChildIndex(this.cityIdComboBox, 0);
            this.Controls.SetChildIndex(cityIdLabel, 0);
            this.Controls.SetChildIndex(this.addressTextBox, 0);
            this.Controls.SetChildIndex(addressLabel, 0);
            this.Controls.SetChildIndex(this.maskedTextBox1, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.trackBarStar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox cityIdComboBox;
        private System.Windows.Forms.TextBox hotelNameTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TrackBar trackBarStar;
    }
}
