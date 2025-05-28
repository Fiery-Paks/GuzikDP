namespace TravelAgencyGuzik.UserControlsTile
{
    partial class UserControlTileTour
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label availablePlacesLabel;
            this.descriptionLabelData = new System.Windows.Forms.Label();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLabelData = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.priceLabelData = new System.Windows.Forms.Label();
            this.tourNameLabelData = new System.Windows.Forms.Label();
            this.startDateLabelData = new System.Windows.Forms.Label();
            this.endDateLabelData = new System.Windows.Forms.Label();
            this.availablePlacesLabelData = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            availablePlacesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(28, 402);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            descriptionLabel.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            descriptionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(27, 322);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(48, 20);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "Price:";
            priceLabel.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            priceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            startDateLabel.Location = new System.Drawing.Point(27, 251);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(87, 20);
            startDateLabel.TabIndex = 18;
            startDateLabel.Text = "Start Date:";
            startDateLabel.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            startDateLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            endDateLabel.Location = new System.Drawing.Point(27, 287);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(81, 20);
            endDateLabel.TabIndex = 19;
            endDateLabel.Text = "End Date:";
            endDateLabel.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            endDateLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            // 
            // descriptionLabelData
            // 
            this.descriptionLabelData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "Description", true));
            this.descriptionLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabelData.Location = new System.Drawing.Point(141, 402);
            this.descriptionLabelData.Name = "descriptionLabelData";
            this.descriptionLabelData.Size = new System.Drawing.Size(235, 89);
            this.descriptionLabelData.TabIndex = 4;
            this.descriptionLabelData.Text = "label1";
            this.descriptionLabelData.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            this.descriptionLabelData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataSource = typeof(TravelAgencyGuzik.ModelEF.Tours);
            // 
            // idLabelData
            // 
            this.idLabelData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "Id", true));
            this.idLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabelData.Location = new System.Drawing.Point(20, 216);
            this.idLabelData.Name = "idLabelData";
            this.idLabelData.Size = new System.Drawing.Size(71, 23);
            this.idLabelData.TabIndex = 10;
            this.idLabelData.Text = "label1";
            this.idLabelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.idLabelData.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            this.idLabelData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.Color.Silver;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.toursBindingSource, "Photo", true));
            this.photoPictureBox.Image = global::TravelAgencyGuzik.Properties.Resources.placeholder;
            this.photoPictureBox.Location = new System.Drawing.Point(20, 20);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(356, 170);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 12;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            this.photoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            // 
            // priceLabelData
            // 
            this.priceLabelData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "Price", true));
            this.priceLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabelData.Location = new System.Drawing.Point(174, 319);
            this.priceLabelData.Name = "priceLabelData";
            this.priceLabelData.Size = new System.Drawing.Size(202, 23);
            this.priceLabelData.TabIndex = 14;
            this.priceLabelData.Text = "label1";
            this.priceLabelData.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            this.priceLabelData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            // 
            // tourNameLabelData
            // 
            this.tourNameLabelData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "TourName", true));
            this.tourNameLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tourNameLabelData.Location = new System.Drawing.Point(97, 216);
            this.tourNameLabelData.Name = "tourNameLabelData";
            this.tourNameLabelData.Size = new System.Drawing.Size(279, 23);
            this.tourNameLabelData.TabIndex = 18;
            this.tourNameLabelData.Text = "label1";
            this.tourNameLabelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tourNameLabelData.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            this.tourNameLabelData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            // 
            // startDateLabelData
            // 
            this.startDateLabelData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "StartDate", true));
            this.startDateLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateLabelData.Location = new System.Drawing.Point(174, 251);
            this.startDateLabelData.Name = "startDateLabelData";
            this.startDateLabelData.Size = new System.Drawing.Size(202, 23);
            this.startDateLabelData.TabIndex = 19;
            this.startDateLabelData.Text = "label1";
            this.startDateLabelData.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            this.startDateLabelData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            // 
            // endDateLabelData
            // 
            this.endDateLabelData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "EndDate", true));
            this.endDateLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateLabelData.Location = new System.Drawing.Point(174, 287);
            this.endDateLabelData.Name = "endDateLabelData";
            this.endDateLabelData.Size = new System.Drawing.Size(202, 23);
            this.endDateLabelData.TabIndex = 20;
            this.endDateLabelData.Text = "label1";
            this.endDateLabelData.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            this.endDateLabelData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            // 
            // availablePlacesLabel
            // 
            availablePlacesLabel.AutoSize = true;
            availablePlacesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            availablePlacesLabel.Location = new System.Drawing.Point(28, 362);
            availablePlacesLabel.Name = "availablePlacesLabel";
            availablePlacesLabel.Size = new System.Drawing.Size(127, 20);
            availablePlacesLabel.TabIndex = 20;
            availablePlacesLabel.Text = "Available Places:";
            // 
            // availablePlacesLabelData
            // 
            this.availablePlacesLabelData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toursBindingSource, "AvailablePlaces", true));
            this.availablePlacesLabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.availablePlacesLabelData.Location = new System.Drawing.Point(170, 359);
            this.availablePlacesLabelData.Name = "availablePlacesLabelData";
            this.availablePlacesLabelData.Size = new System.Drawing.Size(206, 23);
            this.availablePlacesLabelData.TabIndex = 21;
            this.availablePlacesLabelData.Text = "label1";
            // 
            // UserControlTileTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(availablePlacesLabel);
            this.Controls.Add(this.availablePlacesLabelData);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateLabelData);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateLabelData);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionLabelData);
            this.Controls.Add(this.idLabelData);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceLabelData);
            this.Controls.Add(this.tourNameLabelData);
            this.Name = "UserControlTileTour";
            this.Size = new System.Drawing.Size(396, 511);
            this.Load += new System.EventHandler(this.UserControlTileTour_Load);
            this.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource toursBindingSource;
        private System.Windows.Forms.Label descriptionLabelData;
        private System.Windows.Forms.Label idLabelData;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label priceLabelData;
        private System.Windows.Forms.Label tourNameLabelData;
        private System.Windows.Forms.Label startDateLabelData;
        private System.Windows.Forms.Label endDateLabelData;
        private System.Windows.Forms.Label availablePlacesLabelData;
    }
}
