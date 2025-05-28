namespace TravelAgencyGuzik.UserControls
{
    partial class UserControlMenu
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
            this.buttonShowHotels = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonBookings = new System.Windows.Forms.Button();
            this.buttonShowTours = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelName
            // 
            this.labelName.Text = "Меню";
            // 
            // buttonShowHotels
            // 
            this.buttonShowHotels.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowHotels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(176)))));
            this.buttonShowHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonShowHotels.Location = new System.Drawing.Point(395, 300);
            this.buttonShowHotels.Name = "buttonShowHotels";
            this.buttonShowHotels.Size = new System.Drawing.Size(143, 84);
            this.buttonShowHotels.TabIndex = 15;
            this.buttonShowHotels.Text = "Посмотреть отели";
            this.buttonShowHotels.UseVisualStyleBackColor = false;
            this.buttonShowHotels.Click += new System.EventHandler(this.buttonShowHotels_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(176)))));
            this.buttonClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonClients.Location = new System.Drawing.Point(167, 301);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(143, 84);
            this.buttonClients.TabIndex = 14;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = false;
            // 
            // buttonBookings
            // 
            this.buttonBookings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(176)))));
            this.buttonBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonBookings.Location = new System.Drawing.Point(395, 182);
            this.buttonBookings.Name = "buttonBookings";
            this.buttonBookings.Size = new System.Drawing.Size(143, 84);
            this.buttonBookings.TabIndex = 13;
            this.buttonBookings.Text = "Забронированные туры";
            this.buttonBookings.UseVisualStyleBackColor = false;
            // 
            // buttonShowTours
            // 
            this.buttonShowTours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowTours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(215)))), ((int)(((byte)(176)))));
            this.buttonShowTours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonShowTours.Location = new System.Drawing.Point(167, 181);
            this.buttonShowTours.Name = "buttonShowTours";
            this.buttonShowTours.Size = new System.Drawing.Size(143, 84);
            this.buttonShowTours.TabIndex = 12;
            this.buttonShowTours.Text = "Посмотреть туры";
            this.buttonShowTours.UseVisualStyleBackColor = false;
            // 
            // UserControlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonShowHotels);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonBookings);
            this.Controls.Add(this.buttonShowTours);
            this.Name = "UserControlMenu";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.buttonBack, 0);
            this.Controls.SetChildIndex(this.buttonShowTours, 0);
            this.Controls.SetChildIndex(this.buttonBookings, 0);
            this.Controls.SetChildIndex(this.buttonClients, 0);
            this.Controls.SetChildIndex(this.buttonShowHotels, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonShowHotels;
        public System.Windows.Forms.Button buttonClients;
        public System.Windows.Forms.Button buttonBookings;
        public System.Windows.Forms.Button buttonShowTours;
    }
}
