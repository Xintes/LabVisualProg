namespace SupplyFormVisualLab12
{
    partial class SupplyForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControlSupply = new System.Windows.Forms.TabControl();
            this.itemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageItem = new System.Windows.Forms.TabPage();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.tabPageSupplier = new System.Windows.Forms.TabPage();
            this.itemGrid2 = new System.Windows.Forms.DataGridView();
            this.tabPageSupply = new System.Windows.Forms.TabPage();
            this.itemGrid3 = new System.Windows.Forms.DataGridView();
            this.tabControlSupply.SuspendLayout();
            this.itemContextMenu.SuspendLayout();
            this.tabPageItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.tabPageSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid2)).BeginInit();
            this.tabPageSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSupply
            // 
            this.tabControlSupply.ContextMenuStrip = this.itemContextMenu;
            this.tabControlSupply.Controls.Add(this.tabPageItem);
            this.tabControlSupply.Controls.Add(this.tabPageSupplier);
            this.tabControlSupply.Controls.Add(this.tabPageSupply);
            this.tabControlSupply.Location = new System.Drawing.Point(4, 4);
            this.tabControlSupply.Name = "tabControlSupply";
            this.tabControlSupply.SelectedIndex = 0;
            this.tabControlSupply.Size = new System.Drawing.Size(784, 434);
            this.tabControlSupply.TabIndex = 0;
            // 
            // itemContextMenu
            // 
            this.itemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshItem,
            this.addItem,
            this.updateItem,
            this.removeItem});
            this.itemContextMenu.Name = "itemContextMenu";
            this.itemContextMenu.Size = new System.Drawing.Size(129, 92);
            // 
            // refreshItem
            // 
            this.refreshItem.Name = "refreshItem";
            this.refreshItem.Size = new System.Drawing.Size(128, 22);
            this.refreshItem.Text = "Обновить";
            this.refreshItem.Click += new System.EventHandler(this.refreshItem_Click);
            // 
            // addItem
            // 
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(128, 22);
            this.addItem.Text = "Добавить";
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // updateItem
            // 
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(128, 22);
            this.updateItem.Text = "Изменить";
            this.updateItem.Click += new System.EventHandler(this.updateItem_Click);
            // 
            // removeItem
            // 
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(128, 22);
            this.removeItem.Text = "Удалить";
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // tabPageItem
            // 
            this.tabPageItem.ContextMenuStrip = this.itemContextMenu;
            this.tabPageItem.Controls.Add(this.itemGrid);
            this.tabPageItem.Location = new System.Drawing.Point(4, 22);
            this.tabPageItem.Name = "tabPageItem";
            this.tabPageItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItem.Size = new System.Drawing.Size(776, 408);
            this.tabPageItem.TabIndex = 0;
            this.tabPageItem.Text = "Товары";
            this.tabPageItem.UseVisualStyleBackColor = true;
            // 
            // itemGrid
            // 
            this.itemGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.itemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Location = new System.Drawing.Point(6, 6);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ReadOnly = true;
            this.itemGrid.Size = new System.Drawing.Size(764, 399);
            this.itemGrid.TabIndex = 0;
            this.itemGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGrid_CellContentClick);
            // 
            // tabPageSupplier
            // 
            this.tabPageSupplier.Controls.Add(this.itemGrid2);
            this.tabPageSupplier.Location = new System.Drawing.Point(4, 22);
            this.tabPageSupplier.Name = "tabPageSupplier";
            this.tabPageSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupplier.Size = new System.Drawing.Size(776, 408);
            this.tabPageSupplier.TabIndex = 1;
            this.tabPageSupplier.Text = "Поставщики";
            this.tabPageSupplier.UseVisualStyleBackColor = true;
            // 
            // itemGrid2
            // 
            this.itemGrid2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.itemGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.itemGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid2.Location = new System.Drawing.Point(6, 5);
            this.itemGrid2.Name = "itemGrid2";
            this.itemGrid2.ReadOnly = true;
            this.itemGrid2.Size = new System.Drawing.Size(764, 399);
            this.itemGrid2.TabIndex = 1;
            // 
            // tabPageSupply
            // 
            this.tabPageSupply.Controls.Add(this.itemGrid3);
            this.tabPageSupply.Location = new System.Drawing.Point(4, 22);
            this.tabPageSupply.Name = "tabPageSupply";
            this.tabPageSupply.Size = new System.Drawing.Size(776, 408);
            this.tabPageSupply.TabIndex = 2;
            this.tabPageSupply.Text = "Поставки";
            this.tabPageSupply.UseVisualStyleBackColor = true;
            // 
            // itemGrid3
            // 
            this.itemGrid3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.itemGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.itemGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid3.Location = new System.Drawing.Point(6, 5);
            this.itemGrid3.Name = "itemGrid3";
            this.itemGrid3.ReadOnly = true;
            this.itemGrid3.Size = new System.Drawing.Size(764, 399);
            this.itemGrid3.TabIndex = 2;
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSupply);
            this.Name = "SupplyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставки";
            this.Load += new System.EventHandler(this.SupplyForm_Load);
            this.tabControlSupply.ResumeLayout(false);
            this.itemContextMenu.ResumeLayout(false);
            this.tabPageItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.tabPageSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid2)).EndInit();
            this.tabPageSupply.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControlSupply;
        public System.Windows.Forms.TabPage tabPageItem;
        public System.Windows.Forms.TabPage tabPageSupplier;
        public System.Windows.Forms.TabPage tabPageSupply;
        public System.Windows.Forms.DataGridView itemGrid;
        public System.Windows.Forms.ContextMenuStrip itemContextMenu;
        public System.Windows.Forms.ToolStripMenuItem refreshItem;
        public System.Windows.Forms.ToolStripMenuItem addItem;
        public System.Windows.Forms.ToolStripMenuItem updateItem;
        public System.Windows.Forms.ToolStripMenuItem removeItem;
        public System.Windows.Forms.DataGridView itemGrid2;
        public System.Windows.Forms.DataGridView itemGrid3;
    }
}

