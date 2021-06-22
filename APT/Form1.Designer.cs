namespace APT
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.labActualPrice = new System.Windows.Forms.Label();
            this.labMinimalPrice = new System.Windows.Forms.Label();
            this.labMaximalPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butAddItem = new System.Windows.Forms.Button();
            this.butDeleteItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEs = new System.Windows.Forms.RadioButton();
            this.radCa = new System.Windows.Forms.RadioButton();
            this.radDe = new System.Windows.Forms.RadioButton();
            this.radIt = new System.Windows.Forms.RadioButton();
            this.radFr = new System.Windows.Forms.RadioButton();
            this.radCom = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPID = new System.Windows.Forms.TextBox();
            this.butCloseGB = new System.Windows.Forms.Button();
            this.butAddItemGB = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 92);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // clock
            // 
            this.clock.Interval = 20000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // labActualPrice
            // 
            this.labActualPrice.AutoSize = true;
            this.labActualPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.labActualPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labActualPrice.ForeColor = System.Drawing.Color.White;
            this.labActualPrice.Location = new System.Drawing.Point(100, 171);
            this.labActualPrice.Name = "labActualPrice";
            this.labActualPrice.Size = new System.Drawing.Size(15, 17);
            this.labActualPrice.TabIndex = 1;
            this.labActualPrice.Text = "0";
            // 
            // labMinimalPrice
            // 
            this.labMinimalPrice.AutoSize = true;
            this.labMinimalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.labMinimalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMinimalPrice.ForeColor = System.Drawing.Color.White;
            this.labMinimalPrice.Location = new System.Drawing.Point(100, 148);
            this.labMinimalPrice.Name = "labMinimalPrice";
            this.labMinimalPrice.Size = new System.Drawing.Size(15, 17);
            this.labMinimalPrice.TabIndex = 2;
            this.labMinimalPrice.Text = "0";
            // 
            // labMaximalPrice
            // 
            this.labMaximalPrice.AutoSize = true;
            this.labMaximalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.labMaximalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaximalPrice.ForeColor = System.Drawing.Color.White;
            this.labMaximalPrice.Location = new System.Drawing.Point(100, 194);
            this.labMaximalPrice.Name = "labMaximalPrice";
            this.labMaximalPrice.Size = new System.Drawing.Size(15, 17);
            this.labMaximalPrice.TabIndex = 3;
            this.labMaximalPrice.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amazon price tracker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Made with ♥ by Mesrine Nathanaël";
            // 
            // butAddItem
            // 
            this.butAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.butAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddItem.ForeColor = System.Drawing.Color.White;
            this.butAddItem.Location = new System.Drawing.Point(212, 51);
            this.butAddItem.Name = "butAddItem";
            this.butAddItem.Size = new System.Drawing.Size(75, 23);
            this.butAddItem.TabIndex = 7;
            this.butAddItem.Text = "Add Item";
            this.butAddItem.UseVisualStyleBackColor = false;
            // 
            // butDeleteItem
            // 
            this.butDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.butDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butDeleteItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeleteItem.ForeColor = System.Drawing.Color.White;
            this.butDeleteItem.Location = new System.Drawing.Point(212, 115);
            this.butDeleteItem.Name = "butDeleteItem";
            this.butDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.butDeleteItem.TabIndex = 8;
            this.butDeleteItem.Text = "Delete Item";
            this.butDeleteItem.UseVisualStyleBackColor = false;
            this.butDeleteItem.Click += new System.EventHandler(this.butDeleteItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Minimal price   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Actual price     ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Maximal price   ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEs);
            this.groupBox1.Controls.Add(this.radCa);
            this.groupBox1.Controls.Add(this.radDe);
            this.groupBox1.Controls.Add(this.radIt);
            this.groupBox1.Controls.Add(this.radFr);
            this.groupBox1.Controls.Add(this.radCom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxPL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxPID);
            this.groupBox1.Controls.Add(this.butCloseGB);
            this.groupBox1.Controls.Add(this.butAddItemGB);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(293, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 160);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new item";
            // 
            // radEs
            // 
            this.radEs.AutoSize = true;
            this.radEs.Location = new System.Drawing.Point(182, 105);
            this.radEs.Name = "radEs";
            this.radEs.Size = new System.Drawing.Size(81, 19);
            this.radEs.TabIndex = 23;
            this.radEs.TabStop = true;
            this.radEs.Text = "amazon.es";
            this.radEs.UseVisualStyleBackColor = true;
            // 
            // radCa
            // 
            this.radCa.AutoSize = true;
            this.radCa.Location = new System.Drawing.Point(182, 80);
            this.radCa.Name = "radCa";
            this.radCa.Size = new System.Drawing.Size(82, 19);
            this.radCa.TabIndex = 22;
            this.radCa.TabStop = true;
            this.radCa.Text = "amazon.ca";
            this.radCa.UseVisualStyleBackColor = true;
            // 
            // radDe
            // 
            this.radDe.AutoSize = true;
            this.radDe.Location = new System.Drawing.Point(99, 105);
            this.radDe.Name = "radDe";
            this.radDe.Size = new System.Drawing.Size(83, 19);
            this.radDe.TabIndex = 21;
            this.radDe.TabStop = true;
            this.radDe.Text = "amazon.de";
            this.radDe.UseVisualStyleBackColor = true;
            // 
            // radIt
            // 
            this.radIt.AutoSize = true;
            this.radIt.Location = new System.Drawing.Point(6, 105);
            this.radIt.Name = "radIt";
            this.radIt.Size = new System.Drawing.Size(77, 19);
            this.radIt.TabIndex = 20;
            this.radIt.TabStop = true;
            this.radIt.Text = "amazon.it";
            this.radIt.UseVisualStyleBackColor = true;
            // 
            // radFr
            // 
            this.radFr.AutoSize = true;
            this.radFr.Location = new System.Drawing.Point(99, 80);
            this.radFr.Name = "radFr";
            this.radFr.Size = new System.Drawing.Size(78, 19);
            this.radFr.TabIndex = 19;
            this.radFr.TabStop = true;
            this.radFr.Text = "amazon.fr";
            this.radFr.UseVisualStyleBackColor = true;
            // 
            // radCom
            // 
            this.radCom.AutoSize = true;
            this.radCom.Location = new System.Drawing.Point(6, 80);
            this.radCom.Name = "radCom";
            this.radCom.Size = new System.Drawing.Size(94, 19);
            this.radCom.TabIndex = 18;
            this.radCom.TabStop = true;
            this.radCom.Text = "amazon.com";
            this.radCom.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(87, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "2 for 59$ | 3 for 159$...";
            // 
            // tbxPL
            // 
            this.tbxPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbxPL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPL.ForeColor = System.Drawing.Color.White;
            this.tbxPL.Location = new System.Drawing.Point(6, 51);
            this.tbxPL.MaxLength = 6;
            this.tbxPL.Name = "tbxPL";
            this.tbxPL.Size = new System.Drawing.Size(75, 23);
            this.tbxPL.TabIndex = 16;
            this.tbxPL.Text = "Price lenght";
            this.tbxPL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxPL_MouseClick);
            this.tbxPL.TextChanged += new System.EventHandler(this.tbxPL_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(87, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "amazon.com/dp/[ProductID]";
            // 
            // tbxPID
            // 
            this.tbxPID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tbxPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPID.ForeColor = System.Drawing.Color.White;
            this.tbxPID.Location = new System.Drawing.Point(6, 22);
            this.tbxPID.Name = "tbxPID";
            this.tbxPID.Size = new System.Drawing.Size(75, 23);
            this.tbxPID.TabIndex = 15;
            this.tbxPID.Text = "Product ID";
            this.tbxPID.Click += new System.EventHandler(this.tbxPID_TextChanged);
            this.tbxPID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxPID_MouseClick);
            this.tbxPID.TextChanged += new System.EventHandler(this.tbxPID_TextChanged);
            // 
            // butCloseGB
            // 
            this.butCloseGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.butCloseGB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butCloseGB.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCloseGB.ForeColor = System.Drawing.Color.White;
            this.butCloseGB.Location = new System.Drawing.Point(6, 131);
            this.butCloseGB.Name = "butCloseGB";
            this.butCloseGB.Size = new System.Drawing.Size(75, 23);
            this.butCloseGB.TabIndex = 14;
            this.butCloseGB.Text = "Cancel";
            this.butCloseGB.UseVisualStyleBackColor = false;
            // 
            // butAddItemGB
            // 
            this.butAddItemGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.butAddItemGB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAddItemGB.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddItemGB.ForeColor = System.Drawing.Color.White;
            this.butAddItemGB.Location = new System.Drawing.Point(186, 131);
            this.butAddItemGB.Name = "butAddItemGB";
            this.butAddItemGB.Size = new System.Drawing.Size(75, 23);
            this.butAddItemGB.TabIndex = 13;
            this.butAddItemGB.Text = "Add Item";
            this.butAddItemGB.UseVisualStyleBackColor = false;
            this.butAddItemGB.Click += new System.EventHandler(this.butAddItemGB_Click);
            // 
            // refresh
            // 
            this.refresh.Interval = 5000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(335, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Last update :";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.labTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.ForeColor = System.Drawing.Color.White;
            this.labTime.Location = new System.Drawing.Point(416, 1);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(101, 17);
            this.labTime.TabIndex = 14;
            this.labTime.Text = "not updated yet";
            // 
            // butStart
            // 
            this.butStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(234)))));
            this.butStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butStart.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart.ForeColor = System.Drawing.Color.White;
            this.butStart.Location = new System.Drawing.Point(197, 188);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(90, 23);
            this.butStart.TabIndex = 15;
            this.butStart.Text = "Start tracking !";
            this.butStart.UseVisualStyleBackColor = false;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(572, 219);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butDeleteItem);
            this.Controls.Add(this.butAddItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labMaximalPrice);
            this.Controls.Add(this.labMinimalPrice);
            this.Controls.Add(this.labActualPrice);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Amazon price tracker C#";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label labActualPrice;
        private System.Windows.Forms.Label labMinimalPrice;
        private System.Windows.Forms.Label labMaximalPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butAddItem;
        private System.Windows.Forms.Button butDeleteItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butCloseGB;
        private System.Windows.Forms.Button butAddItemGB;
        private System.Windows.Forms.TextBox tbxPL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radEs;
        private System.Windows.Forms.RadioButton radCa;
        private System.Windows.Forms.RadioButton radDe;
        private System.Windows.Forms.RadioButton radIt;
        private System.Windows.Forms.RadioButton radFr;
        private System.Windows.Forms.RadioButton radCom;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer refresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Button butStart;
    }
}

