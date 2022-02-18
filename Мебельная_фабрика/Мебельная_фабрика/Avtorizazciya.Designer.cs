namespace Мебельная_фабрика
{
    partial class Avtorizazciya
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblZagolovok = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblParol = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbParol = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.btnAvtorizacziya = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblZagolovok
            // 
            this.lblZagolovok.AutoSize = true;
            this.lblZagolovok.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZagolovok.Location = new System.Drawing.Point(414, 60);
            this.lblZagolovok.Name = "lblZagolovok";
            this.lblZagolovok.Size = new System.Drawing.Size(318, 54);
            this.lblZagolovok.TabIndex = 0;
            this.lblZagolovok.Text = "Авторизация";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(272, 198);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(74, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин:";
            // 
            // lblParol
            // 
            this.lblParol.AutoSize = true;
            this.lblParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParol.Location = new System.Drawing.Point(260, 270);
            this.lblParol.Name = "lblParol";
            this.lblParol.Size = new System.Drawing.Size(86, 25);
            this.lblParol.TabIndex = 2;
            this.lblParol.Text = "Пароль:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRol.Location = new System.Drawing.Point(283, 339);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(63, 25);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Роль:";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(352, 198);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(439, 30);
            this.tbLogin.TabIndex = 4;
            // 
            // tbParol
            // 
            this.tbParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbParol.Location = new System.Drawing.Point(352, 270);
            this.tbParol.Name = "tbParol";
            this.tbParol.Size = new System.Drawing.Size(439, 30);
            this.tbParol.TabIndex = 5;
            // 
            // cbRol
            // 
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Менеджер",
            "Заместитель директора",
            "Заказчик",
            "Директор",
            "Заказчик"});
            this.cbRol.Location = new System.Drawing.Point(352, 336);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(439, 33);
            this.cbRol.TabIndex = 6;
            // 
            // btnAvtorizacziya
            // 
            this.btnAvtorizacziya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAvtorizacziya.Location = new System.Drawing.Point(352, 455);
            this.btnAvtorizacziya.Name = "btnAvtorizacziya";
            this.btnAvtorizacziya.Size = new System.Drawing.Size(439, 67);
            this.btnAvtorizacziya.TabIndex = 7;
            this.btnAvtorizacziya.Text = "Авторизация";
            this.btnAvtorizacziya.UseVisualStyleBackColor = true;
            this.btnAvtorizacziya.Click += new System.EventHandler(this.btnAvtorizacziya_Click);
            // 
            // Avtorizazciya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 645);
            this.Controls.Add(this.btnAvtorizacziya);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.tbParol);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblParol);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblZagolovok);
            this.Name = "Avtorizazciya";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZagolovok;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblParol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbParol;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Button btnAvtorizacziya;
    }
}

