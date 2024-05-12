namespace SupplyFormVisualLab12
{
    partial class AddItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtManufacturerItem = new System.Windows.Forms.TextBox();
            this.txtPriceItem = new System.Windows.Forms.TextBox();
            this.txtNameItem = new System.Windows.Forms.TextBox();
            this.txtIdItem = new System.Windows.Forms.TextBox();
            this.lblPriceItem = new System.Windows.Forms.Label();
            this.lblManufacturerItem = new System.Windows.Forms.Label();
            this.lblNameItem = new System.Windows.Forms.Label();
            this.lblIdItem = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAdressSupplier = new System.Windows.Forms.TextBox();
            this.txtNameSupplier = new System.Windows.Forms.TextBox();
            this.txtIdSupplier = new System.Windows.Forms.TextBox();
            this.lblPhoneSupplier = new System.Windows.Forms.Label();
            this.lblAdressSupplier = new System.Windows.Forms.Label();
            this.lblNameSupplier = new System.Windows.Forms.Label();
            this.lblIdSupplier = new System.Windows.Forms.Label();
            this.txtPhoneSupplier = new System.Windows.Forms.MaskedTextBox();
            this.lblIdItemSupply = new System.Windows.Forms.Label();
            this.lblSupplierSupply = new System.Windows.Forms.Label();
            this.lblDateSupply = new System.Windows.Forms.Label();
            this.lblVSupply = new System.Windows.Forms.Label();
            this.txtVSupply = new System.Windows.Forms.TextBox();
            this.txtSupplierSupply = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyDataSet = new SupplyFormVisualLab12.SupplyDataSet();
            this.txtNameItemSupply = new System.Windows.Forms.ComboBox();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new SupplyFormVisualLab12.SupplyDataSetTableAdapters.SupplierTableAdapter();
            this.itemTableAdapter = new SupplyFormVisualLab12.SupplyDataSetTableAdapters.ItemTableAdapter();
            this.txtDateSupply = new System.Windows.Forms.MaskedTextBox();
            this.btnCh = new System.Windows.Forms.Button();
            this.txtSupplierSupplyCH1 = new System.Windows.Forms.MaskedTextBox();
            this.txtNameItemSupplyCH1 = new System.Windows.Forms.MaskedTextBox();
            this.txtDateSupplyCH = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(142, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 35);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtManufacturerItem
            // 
            this.txtManufacturerItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtManufacturerItem.Location = new System.Drawing.Point(32, 161);
            this.txtManufacturerItem.Name = "txtManufacturerItem";
            this.txtManufacturerItem.Size = new System.Drawing.Size(203, 22);
            this.txtManufacturerItem.TabIndex = 17;
            this.txtManufacturerItem.TextChanged += new System.EventHandler(this.txtManufacturer_TextChanged);
            // 
            // txtPriceItem
            // 
            this.txtPriceItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPriceItem.Location = new System.Drawing.Point(32, 221);
            this.txtPriceItem.Name = "txtPriceItem";
            this.txtPriceItem.Size = new System.Drawing.Size(203, 22);
            this.txtPriceItem.TabIndex = 16;
            this.txtPriceItem.TextChanged += new System.EventHandler(this.txtPriceItem_TextChanged);
            // 
            // txtNameItem
            // 
            this.txtNameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameItem.Location = new System.Drawing.Point(32, 102);
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.Size = new System.Drawing.Size(203, 22);
            this.txtNameItem.TabIndex = 15;
            // 
            // txtIdItem
            // 
            this.txtIdItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIdItem.Location = new System.Drawing.Point(32, 37);
            this.txtIdItem.Name = "txtIdItem";
            this.txtIdItem.Size = new System.Drawing.Size(203, 22);
            this.txtIdItem.TabIndex = 14;
            // 
            // lblPriceItem
            // 
            this.lblPriceItem.AutoSize = true;
            this.lblPriceItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPriceItem.Location = new System.Drawing.Point(28, 194);
            this.lblPriceItem.Name = "lblPriceItem";
            this.lblPriceItem.Size = new System.Drawing.Size(54, 24);
            this.lblPriceItem.TabIndex = 13;
            this.lblPriceItem.Text = "Цена";
            // 
            // lblManufacturerItem
            // 
            this.lblManufacturerItem.AutoSize = true;
            this.lblManufacturerItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblManufacturerItem.Location = new System.Drawing.Point(28, 134);
            this.lblManufacturerItem.Name = "lblManufacturerItem";
            this.lblManufacturerItem.Size = new System.Drawing.Size(153, 24);
            this.lblManufacturerItem.TabIndex = 12;
            this.lblManufacturerItem.Text = "Производитель";
            // 
            // lblNameItem
            // 
            this.lblNameItem.AutoSize = true;
            this.lblNameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameItem.Location = new System.Drawing.Point(28, 75);
            this.lblNameItem.Name = "lblNameItem";
            this.lblNameItem.Size = new System.Drawing.Size(144, 24);
            this.lblNameItem.TabIndex = 11;
            this.lblNameItem.Text = "Наименование";
            // 
            // lblIdItem
            // 
            this.lblIdItem.AutoSize = true;
            this.lblIdItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIdItem.Location = new System.Drawing.Point(28, 9);
            this.lblIdItem.Name = "lblIdItem";
            this.lblIdItem.Size = new System.Drawing.Size(177, 24);
            this.lblIdItem.TabIndex = 10;
            this.lblIdItem.Text = "Артикул предмета";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtAdressSupplier
            // 
            this.txtAdressSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAdressSupplier.Location = new System.Drawing.Point(32, 160);
            this.txtAdressSupplier.Name = "txtAdressSupplier";
            this.txtAdressSupplier.Size = new System.Drawing.Size(203, 22);
            this.txtAdressSupplier.TabIndex = 26;
            // 
            // txtNameSupplier
            // 
            this.txtNameSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameSupplier.Location = new System.Drawing.Point(32, 101);
            this.txtNameSupplier.Name = "txtNameSupplier";
            this.txtNameSupplier.Size = new System.Drawing.Size(203, 22);
            this.txtNameSupplier.TabIndex = 24;
            // 
            // txtIdSupplier
            // 
            this.txtIdSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIdSupplier.Location = new System.Drawing.Point(32, 36);
            this.txtIdSupplier.Name = "txtIdSupplier";
            this.txtIdSupplier.Size = new System.Drawing.Size(203, 22);
            this.txtIdSupplier.TabIndex = 23;
            // 
            // lblPhoneSupplier
            // 
            this.lblPhoneSupplier.AutoSize = true;
            this.lblPhoneSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneSupplier.Location = new System.Drawing.Point(28, 193);
            this.lblPhoneSupplier.Name = "lblPhoneSupplier";
            this.lblPhoneSupplier.Size = new System.Drawing.Size(90, 24);
            this.lblPhoneSupplier.TabIndex = 22;
            this.lblPhoneSupplier.Text = "Телефон";
            // 
            // lblAdressSupplier
            // 
            this.lblAdressSupplier.AutoSize = true;
            this.lblAdressSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdressSupplier.Location = new System.Drawing.Point(28, 133);
            this.lblAdressSupplier.Name = "lblAdressSupplier";
            this.lblAdressSupplier.Size = new System.Drawing.Size(67, 24);
            this.lblAdressSupplier.TabIndex = 21;
            this.lblAdressSupplier.Text = "Адрес";
            // 
            // lblNameSupplier
            // 
            this.lblNameSupplier.AutoSize = true;
            this.lblNameSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameSupplier.Location = new System.Drawing.Point(28, 74);
            this.lblNameSupplier.Name = "lblNameSupplier";
            this.lblNameSupplier.Size = new System.Drawing.Size(91, 24);
            this.lblNameSupplier.TabIndex = 20;
            this.lblNameSupplier.Text = "Фамилия";
            // 
            // lblIdSupplier
            // 
            this.lblIdSupplier.AutoSize = true;
            this.lblIdSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIdSupplier.Location = new System.Drawing.Point(28, 8);
            this.lblIdSupplier.Name = "lblIdSupplier";
            this.lblIdSupplier.Size = new System.Drawing.Size(194, 24);
            this.lblIdSupplier.TabIndex = 19;
            this.lblIdSupplier.Text = "Артикул поставщика";
            // 
            // txtPhoneSupplier
            // 
            this.txtPhoneSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhoneSupplier.Location = new System.Drawing.Point(32, 220);
            this.txtPhoneSupplier.Name = "txtPhoneSupplier";
            this.txtPhoneSupplier.Size = new System.Drawing.Size(203, 22);
            this.txtPhoneSupplier.TabIndex = 27;
            this.txtPhoneSupplier.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPhoneSupplier_MaskInputRejected);
            this.txtPhoneSupplier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPhoneSupplier_MouseClick);
            // 
            // lblIdItemSupply
            // 
            this.lblIdItemSupply.AutoSize = true;
            this.lblIdItemSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIdItemSupply.Location = new System.Drawing.Point(28, 133);
            this.lblIdItemSupply.Name = "lblIdItemSupply";
            this.lblIdItemSupply.Size = new System.Drawing.Size(65, 24);
            this.lblIdItemSupply.TabIndex = 30;
            this.lblIdItemSupply.Text = "Товар";
            // 
            // lblSupplierSupply
            // 
            this.lblSupplierSupply.AutoSize = true;
            this.lblSupplierSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplierSupply.Location = new System.Drawing.Point(28, 69);
            this.lblSupplierSupply.Name = "lblSupplierSupply";
            this.lblSupplierSupply.Size = new System.Drawing.Size(108, 24);
            this.lblSupplierSupply.TabIndex = 29;
            this.lblSupplierSupply.Text = "Поставщик";
            // 
            // lblDateSupply
            // 
            this.lblDateSupply.AutoSize = true;
            this.lblDateSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateSupply.Location = new System.Drawing.Point(28, 8);
            this.lblDateSupply.Name = "lblDateSupply";
            this.lblDateSupply.Size = new System.Drawing.Size(142, 24);
            this.lblDateSupply.TabIndex = 28;
            this.lblDateSupply.Text = "Дата поставки";
            // 
            // lblVSupply
            // 
            this.lblVSupply.AutoSize = true;
            this.lblVSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVSupply.Location = new System.Drawing.Point(28, 193);
            this.lblVSupply.Name = "lblVSupply";
            this.lblVSupply.Size = new System.Drawing.Size(159, 24);
            this.lblVSupply.TabIndex = 36;
            this.lblVSupply.Text = "Объём поставки";
            // 
            // txtVSupply
            // 
            this.txtVSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVSupply.Location = new System.Drawing.Point(32, 220);
            this.txtVSupply.Name = "txtVSupply";
            this.txtVSupply.Size = new System.Drawing.Size(203, 22);
            this.txtVSupply.TabIndex = 40;
            // 
            // txtSupplierSupply
            // 
            this.txtSupplierSupply.DataSource = this.supplierBindingSource;
            this.txtSupplierSupply.DisplayMember = "Name";
            this.txtSupplierSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSupplierSupply.FormattingEnabled = true;
            this.txtSupplierSupply.Location = new System.Drawing.Point(32, 96);
            this.txtSupplierSupply.Name = "txtSupplierSupply";
            this.txtSupplierSupply.Size = new System.Drawing.Size(203, 24);
            this.txtSupplierSupply.TabIndex = 42;
            this.txtSupplierSupply.ValueMember = "Id";
            this.txtSupplierSupply.SelectedIndexChanged += new System.EventHandler(this.txtSupplierSupply_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.supplyDataSetBindingSource;
            // 
            // supplyDataSetBindingSource
            // 
            this.supplyDataSetBindingSource.DataSource = this.supplyDataSet;
            this.supplyDataSetBindingSource.Position = 0;
            // 
            // supplyDataSet
            // 
            this.supplyDataSet.DataSetName = "SupplyDataSet";
            this.supplyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNameItemSupply
            // 
            this.txtNameItemSupply.DataSource = this.itemBindingSource1;
            this.txtNameItemSupply.DisplayMember = "Name";
            this.txtNameItemSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameItemSupply.FormattingEnabled = true;
            this.txtNameItemSupply.Location = new System.Drawing.Point(32, 160);
            this.txtNameItemSupply.Name = "txtNameItemSupply";
            this.txtNameItemSupply.Size = new System.Drawing.Size(203, 24);
            this.txtNameItemSupply.TabIndex = 43;
            this.txtNameItemSupply.ValueMember = "Id";
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "Item";
            this.itemBindingSource1.DataSource = this.supplyDataSet;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.supplyDataSetBindingSource;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // txtDateSupply
            // 
            this.txtDateSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDateSupply.Location = new System.Drawing.Point(32, 36);
            this.txtDateSupply.Name = "txtDateSupply";
            this.txtDateSupply.Size = new System.Drawing.Size(203, 22);
            this.txtDateSupply.TabIndex = 44;
            // 
            // btnCh
            // 
            this.btnCh.Location = new System.Drawing.Point(32, 262);
            this.btnCh.Name = "btnCh";
            this.btnCh.Size = new System.Drawing.Size(93, 35);
            this.btnCh.TabIndex = 45;
            this.btnCh.Text = "Изменить";
            this.btnCh.UseVisualStyleBackColor = true;
            this.btnCh.Click += new System.EventHandler(this.btnCh_Click);
            // 
            // txtSupplierSupplyCH1
            // 
            this.txtSupplierSupplyCH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSupplierSupplyCH1.Location = new System.Drawing.Point(32, 96);
            this.txtSupplierSupplyCH1.Name = "txtSupplierSupplyCH1";
            this.txtSupplierSupplyCH1.Size = new System.Drawing.Size(203, 22);
            this.txtSupplierSupplyCH1.TabIndex = 46;
            // 
            // txtNameItemSupplyCH1
            // 
            this.txtNameItemSupplyCH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameItemSupplyCH1.Location = new System.Drawing.Point(32, 160);
            this.txtNameItemSupplyCH1.Name = "txtNameItemSupplyCH1";
            this.txtNameItemSupplyCH1.Size = new System.Drawing.Size(203, 22);
            this.txtNameItemSupplyCH1.TabIndex = 47;
            // 
            // txtDateSupplyCH
            // 
            this.txtDateSupplyCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDateSupplyCH.Location = new System.Drawing.Point(32, 35);
            this.txtDateSupplyCH.Name = "txtDateSupplyCH";
            this.txtDateSupplyCH.Size = new System.Drawing.Size(203, 22);
            this.txtDateSupplyCH.TabIndex = 48;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(488, 309);
            this.Controls.Add(this.txtDateSupplyCH);
            this.Controls.Add(this.txtNameItemSupplyCH1);
            this.Controls.Add(this.txtSupplierSupplyCH1);
            this.Controls.Add(this.btnCh);
            this.Controls.Add(this.txtDateSupply);
            this.Controls.Add(this.txtNameItemSupply);
            this.Controls.Add(this.txtSupplierSupply);
            this.Controls.Add(this.txtVSupply);
            this.Controls.Add(this.lblVSupply);
            this.Controls.Add(this.lblIdItemSupply);
            this.Controls.Add(this.lblSupplierSupply);
            this.Controls.Add(this.lblDateSupply);
            this.Controls.Add(this.txtPhoneSupplier);
            this.Controls.Add(this.txtAdressSupplier);
            this.Controls.Add(this.txtNameSupplier);
            this.Controls.Add(this.txtIdSupplier);
            this.Controls.Add(this.lblPhoneSupplier);
            this.Controls.Add(this.lblAdressSupplier);
            this.Controls.Add(this.lblNameSupplier);
            this.Controls.Add(this.lblIdSupplier);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtManufacturerItem);
            this.Controls.Add(this.txtPriceItem);
            this.Controls.Add(this.txtNameItem);
            this.Controls.Add(this.txtIdItem);
            this.Controls.Add(this.lblPriceItem);
            this.Controls.Add(this.lblManufacturerItem);
            this.Controls.Add(this.lblNameItem);
            this.Controls.Add(this.lblIdItem);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtManufacturerItem;
        public System.Windows.Forms.TextBox txtPriceItem;
        public System.Windows.Forms.TextBox txtNameItem;
        public System.Windows.Forms.TextBox txtIdItem;
        public System.Windows.Forms.Label lblPriceItem;
        public System.Windows.Forms.Label lblManufacturerItem;
        public System.Windows.Forms.Label lblNameItem;
        public System.Windows.Forms.Label lblIdItem;
        public System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.TextBox txtAdressSupplier;
        public System.Windows.Forms.TextBox txtNameSupplier;
        public System.Windows.Forms.TextBox txtIdSupplier;
        public System.Windows.Forms.Label lblPhoneSupplier;
        public System.Windows.Forms.Label lblAdressSupplier;
        public System.Windows.Forms.Label lblNameSupplier;
        public System.Windows.Forms.Label lblIdSupplier;
        public System.Windows.Forms.MaskedTextBox txtPhoneSupplier;
        public System.Windows.Forms.Label lblIdItemSupply;
        public System.Windows.Forms.Label lblSupplierSupply;
        public System.Windows.Forms.Label lblDateSupply;
        public System.Windows.Forms.Label lblVSupply;
        public System.Windows.Forms.TextBox txtVSupply;
        public System.Windows.Forms.ComboBox txtNameItemSupply;
        public System.Windows.Forms.ComboBox txtSupplierSupply;
        public System.Windows.Forms.BindingSource supplyDataSetBindingSource;
        public SupplyDataSet supplyDataSet;
        public System.Windows.Forms.BindingSource supplierBindingSource;
        public SupplyDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        public System.Windows.Forms.BindingSource itemBindingSource;
        public SupplyDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        public System.Windows.Forms.MaskedTextBox txtDateSupply;
        public System.Windows.Forms.BindingSource itemBindingSource1;
        public System.Windows.Forms.Button btnCh;
        public System.Windows.Forms.MaskedTextBox txtNameItemSupplyCH1;
        public System.Windows.Forms.MaskedTextBox txtSupplierSupplyCH1;
        public System.Windows.Forms.MaskedTextBox txtDateSupplyCH;
    }
}