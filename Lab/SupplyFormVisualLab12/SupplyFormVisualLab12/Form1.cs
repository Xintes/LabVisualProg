using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Globalization;

namespace SupplyFormVisualLab12
{
    public partial class SupplyForm : Form
    {
        public SupplyForm()
        {
            Program.f1 = this; // теперь f1 будет ссылкой на форму Form1
            InitializeComponent();
            SetItemGrid();
        }

        public TabControl GetTagControl()
        {
            return tabControlSupply;
        }
        private void SupplyForm_Load(object sender, EventArgs e)
        {
        }

        // Обновляем данные в таблице при нажатии кнопки Обновить
        
        public class SupplyData
        {
            public DateTime Date { get; set; }
            public string Supplier { get; set; }
            public int ItemId { get; set; }
            public string ItemName { get; set; }
            public int Volume { get; set; }
            public decimal Overall { get; set; }
        }

        private void itemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}
        public IEnumerable<Item> GetItems()
        {
            using (var db = new SupplyModel())
            {
                return db.Item.ToList();
            }
        }
        public IEnumerable<Supplier> GetSupplier()
        {
            using (var db = new SupplyModel())
            {
                return db.Supplier.ToList();
            }
        }
        
        public IEnumerable<SupplyData> GetSupplyData()
        {
            using (var db = new SupplyModel())
            {
                var supplyData = db.Supply
                    .Join(db.Item, supply => supply.Item, item => item.Id, (supply, item) => new { Supply = supply, Item = item })
                    .Join(db.Supplier, combined => combined.Supply.Supplier, supplier => supplier.Id, (combined, supplier) => new
                    {
                        Date = combined.Supply.Date,
                        SupplierName = supplier.Name,
                        ItemId = combined.Item.Id,
                        ItemName = combined.Item.Name,
                        Volume = combined.Supply.Volume,
                        Overall = combined.Supply.Volume * combined.Item.Price
                    })
                    .ToList();

                return supplyData.Select(data => new SupplyData
                {
                    Date = data.Date,
                    Supplier = data.SupplierName,
                    ItemId = data.ItemId,
                    ItemName = data.ItemName,
                    Volume = (int)data.Volume,
                    Overall = (decimal)data.Overall
                }).ToList();
            }
        }

        private void refreshItem_Click(object sender, EventArgs e)
        {
            SetItemGrid();
        }

        private void SetItemGrid()
        {
            if (itemGrid.ColumnCount < 4)
            {
                itemGrid.Columns.Add("colId", "Артикул");
                itemGrid.Columns.Add("colName", "Наименование");
                itemGrid.Columns.Add("colManufacturer", "Производитель");
                itemGrid.Columns.Add("colPrice", "Цена");
            }
            itemGrid.Rows.Clear();
            foreach (var item in GetItems())
            {
                itemGrid.Rows.Add(item.Id, item.Name, item.Manufacturer, item.Price);
            }

            //------------------------------------------------------/

            if (itemGrid2.ColumnCount < 4)
            {
                itemGrid2.Columns.Add("colIdSupplier", "Артикул");
                itemGrid2.Columns.Add("colNameSupplier", "Фамилия");
                itemGrid2.Columns.Add("colAdress", "Адрес");
                itemGrid2.Columns.Add("colPhone", "Номер");
            }
            itemGrid2.Rows.Clear();
            foreach (var supplier in GetSupplier())
            {
                itemGrid2.Rows.Add(supplier.Id, supplier.Name, supplier.Address, supplier.Phone);
            }

            //------------------------------------------------------/

            if (itemGrid3.ColumnCount < 6)
            {
                itemGrid3.Columns.Add("colSupplyDate", "Дата поставки");
                itemGrid3.Columns.Add("colSupplierName", "Наименование поставщика");
                itemGrid3.Columns.Add("colIdItem", "Артикул товара");
                itemGrid3.Columns.Add("colNameItem", "Наименование товара");
                itemGrid3.Columns.Add("colVSupply", "Объем поставки");
                itemGrid3.Columns.Add("colTotalSum", "Общая стоимость поставки");
            }
            itemGrid3.Rows.Clear();
            foreach (var supply in GetSupplyData())
            {
                itemGrid3.Rows.Add(supply.Date.ToString("yyyy-MM-dd"), supply.Supplier, supply.ItemId, supply.ItemName, supply.Volume, supply.Overall);
            }

        }

        private void ShowItemInput(int num)
        {
            if(num == 0)
            {
                Program.f2.lblIdItem.Visible = false;
                Program.f2.lblNameItem.Visible = false;
                Program.f2.lblManufacturerItem.Visible = false;
                Program.f2.lblPriceItem.Visible = false;


                Program.f2.txtIdItem.Visible = false;
                Program.f2.txtNameItem.Visible = false;
                Program.f2.txtManufacturerItem.Visible = false;
                Program.f2.txtPriceItem.Visible = false;
            }
            else if (num == 1) 
            {
                Program.f2.lblIdItem.Visible = true;
                Program.f2.lblNameItem.Visible = true;
                Program.f2.lblManufacturerItem.Visible = true;
                Program.f2.lblPriceItem.Visible = true;

                Program.f2.txtIdItem.Visible = true;
                Program.f2.txtNameItem.Visible = true;
                Program.f2.txtManufacturerItem.Visible = true;
                Program.f2.txtPriceItem.Visible = true;
            }
        }
        private void ShowSupplierInput(int num)
        {
            if (num == 0)
            {
                Program.f2.lblIdSupplier.Visible = false;
                Program.f2.lblNameSupplier.Visible = false;
                Program.f2.lblAdressSupplier.Visible = false;
                Program.f2.lblPhoneSupplier.Visible = false;

                Program.f2.txtIdSupplier.Visible = false;
                Program.f2.txtNameSupplier.Visible = false;
                Program.f2.txtAdressSupplier.Visible = false;
                Program.f2.txtPhoneSupplier.Visible = false;
            }
            else if (num == 1)
            {
                Program.f2.lblIdSupplier.Visible = true;
                Program.f2.lblNameSupplier.Visible = true;
                Program.f2.lblAdressSupplier.Visible = true;
                Program.f2.lblPhoneSupplier.Visible = true;

                Program.f2.txtIdSupplier.Visible = true;
                Program.f2.txtNameSupplier.Visible = true;
                Program.f2.txtAdressSupplier.Visible = true;
                Program.f2.txtPhoneSupplier.Visible = true;
            }
        }
        private void ShowSupplyInput(int num)
        {
            if (num == 0)
            {
                Program.f2.lblDateSupply.Visible = false;
                Program.f2.lblSupplierSupply.Visible = false;
                Program.f2.lblIdItemSupply.Visible = false;
                Program.f2.lblVSupply.Visible = false;


                Program.f2.txtDateSupply.Visible = false;
                Program.f2.txtSupplierSupply.Visible = false;
                Program.f2.txtNameItemSupply.Visible = false;
                Program.f2.txtVSupply.Visible = false;

            }
            else if (num == 1)
            {
                Program.f2.lblDateSupply.Visible = true;
                Program.f2.lblSupplierSupply.Visible = true;
                Program.f2.lblIdItemSupply.Visible = true;
                Program.f2.lblVSupply.Visible = true;


                Program.f2.txtDateSupply.Visible = true;
                Program.f2.txtSupplierSupply.Visible = true;
                Program.f2.txtNameItemSupply.Visible = true;
                Program.f2.txtVSupply.Visible = true;
            }
        }


        private void addItem_Click(object sender, EventArgs e)
        {
           
            if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageItem)
            {
                AddItemForm add = new AddItemForm();
                Program.f2.btnCh.Visible = false;
                Program.f2.txtSupplierSupplyCH1.Visible = false;
                Program.f2.txtNameItemSupplyCH1.Visible = false;
                Program.f2.txtDateSupplyCH.Visible = false;

                ShowItemInput(1);
                ShowSupplierInput(0);
                ShowSupplyInput(0);
                //ShowSupplyInput(0);
                if (add.ShowDialog(this) == DialogResult.OK)
                {
                    SetItemGrid();
                }
            }
            else if(Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageSupplier)
            {
                AddItemForm add = new AddItemForm();
                Program.f2.btnCh.Visible = false;
                Program.f2.txtSupplierSupplyCH1.Visible = false;
                Program.f2.txtNameItemSupplyCH1.Visible = false;
                Program.f2.txtDateSupplyCH.Visible = false;

                ShowItemInput(0);
                ShowSupplierInput(1);
                ShowSupplyInput(0);
                if (add.ShowDialog(this) == DialogResult.OK)
                {
                    SetItemGrid();
                }
            }
            else if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageSupply)
            {
                AddItemForm add = new AddItemForm();
                Program.f2.btnCh.Visible = false;
                Program.f2.txtSupplierSupplyCH1.Visible = false;
                Program.f2.txtNameItemSupplyCH1.Visible = false;
                Program.f2.txtDateSupplyCH.Visible = false;

                ShowItemInput(0);
                ShowSupplierInput(0);
                ShowSupplyInput(1);
                if (add.ShowDialog(this) == DialogResult.OK)
                {
                    SetItemGrid();
                }
            }
        }
        private void removeItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эти элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageItem)
                {
                    if (itemGrid.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow selectedRow in itemGrid.SelectedRows)
                        {
                            int itemId = (int)selectedRow.Cells["colId"].Value;
                            using (var db = new SupplyModel())
                            {
                                Item item = db.Item.FirstOrDefault(x => x.Id == itemId);
                                if (item != null)
                                {
                                    db.Item.Remove(item);
                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                }
                else if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageSupplier)
                {
                    if (itemGrid2.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow selectedRow in itemGrid2.SelectedRows)
                        {
                            int supplierId = (int)selectedRow.Cells["colIdSupplier"].Value;
                            using (var db = new SupplyModel())
                            {
                                Supplier supplier = db.Supplier.FirstOrDefault(x => x.Id == supplierId);
                                if (supplier != null)
                                {
                                    db.Supplier.Remove(supplier);
                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                }
                else if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageSupply)
                {
                    if (itemGrid3.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow selectedRow in itemGrid3.SelectedRows)
                        {
                            var dateCellValue = selectedRow.Cells["colSupplyDate"].Value;
                            var nameSupplierCellValue = selectedRow.Cells["colSupplierName"].Value;
                            int ItemIdCellValue = (int)selectedRow.Cells["colIdItem"].Value;
                            DateTime parsedDate;
                            if (DateTime.TryParseExact(dateCellValue.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                            {
                                using (var db = new SupplyModel())
                                {
                                    int supplierID = db.Supplier.FirstOrDefault(x => x.Name == nameSupplierCellValue)?.Id ?? 0;
                                    Supply supply = db.Supply.FirstOrDefault(x => x.Date == parsedDate && x.Item == ItemIdCellValue && x.Supplier == supplierID);
                                    if (supply != null)
                                    {
                                        db.Supply.Remove(supply);
                                        db.SaveChanges();
                                    }
                                }
                            }
                            else
                            {
                                // Обработайте случай, если дата не может быть распарсена
                                // Например, выведите сообщение об ошибке или выполните другие действия
                            }
                        }
                    }
                }
            }

            SetItemGrid();
        }

        private void updateItem_Click(object sender, EventArgs e)
        {
            if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageItem)
            {
                AddItemForm add = new AddItemForm();
                Program.f2.btnAdd.Visible = false;
                Program.f2.txtSupplierSupplyCH1.Visible = false;
                Program.f2.txtNameItemSupplyCH1.Visible = false;
                Program.f2.txtSupplierSupply.Visible = true;
                Program.f2.txtNameItemSupply.Visible = true;
                Program.f2.txtDateSupplyCH.Visible = false;
                Program.f2.txtIdItem.Enabled = false;
                // Get the selected row index
                int rowIndex = Program.f1.itemGrid.SelectedCells[0].RowIndex;

                // Load the values from the selected row into the textboxes
                add.txtIdItem.Text = Program.f1.itemGrid.Rows[rowIndex].Cells["colId"].Value.ToString();
                add.txtNameItem.Text = Program.f1.itemGrid.Rows[rowIndex].Cells["colName"].Value.ToString();
                add.txtManufacturerItem.Text = Program.f1.itemGrid.Rows[rowIndex].Cells["colManufacturer"].Value.ToString();
                add.txtPriceItem.Text = Program.f1.itemGrid.Rows[rowIndex].Cells["colPrice"].Value.ToString();

                ShowItemInput(1);
                ShowSupplierInput(0);
                ShowSupplyInput(0);
                //ShowSupplyInput(0);
                if (add.ShowDialog(this) == DialogResult.OK)
                {
                    SetItemGrid();
                }
            }
            else if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageSupplier)
            {
                AddItemForm add = new AddItemForm();

                Program.f2.btnAdd.Visible = false;
                Program.f2.txtSupplierSupplyCH1.Visible = false;
                Program.f2.txtNameItemSupplyCH1.Visible = false;
                Program.f2.txtSupplierSupply.Visible = true;
                Program.f2.txtNameItemSupply.Visible = true;
                Program.f2.txtDateSupplyCH.Visible = false;
                Program.f2.txtIdSupplier.Enabled = false;
                // Get the selected row indexCon
                int rowIndex = Program.f1.itemGrid2.SelectedCells[0].RowIndex;

                // Load the values from the selected row into the textboxes
                add.txtIdSupplier.Text = Program.f1.itemGrid2.Rows[rowIndex].Cells["colIdSupplier"].Value.ToString();
                add.txtNameSupplier.Text = Program.f1.itemGrid2.Rows[rowIndex].Cells["colNameSupplier"].Value.ToString();
                add.txtAdressSupplier.Text = Program.f1.itemGrid2.Rows[rowIndex].Cells["colAdress"].Value.ToString();
                add.txtPhoneSupplier.Text = Program.f1.itemGrid2.Rows[rowIndex].Cells["colPhone"].Value.ToString();

                ShowItemInput(0);
                ShowSupplierInput(1);
                ShowSupplyInput(0);
                if (add.ShowDialog(this) == DialogResult.OK)
                {
                    SetItemGrid();
                }
            }
            else if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageSupply)
            {
                AddItemForm add = new AddItemForm();

                Program.f2.btnAdd.Visible = false;
                Program.f2.txtSupplierSupplyCH1.Visible = true;
                Program.f2.txtNameItemSupplyCH1.Visible = true;
                Program.f2.txtSupplierSupplyCH1.Visible = true;
                Program.f2.txtNameItemSupplyCH1.Visible = true;
                Program.f2.txtDateSupplyCH.Visible = true;
                Program.f2.txtSupplierSupply.Visible = false;

                Program.f2.txtDateSupply.Enabled = false;
                //Program.f2.txtSupplierSupplyCH1.Enabled = false;
                //Program.f2.txtNameItemSupplyCH1.Enabled = false;
                Program.f2.txtDateSupplyCH.Enabled = false;


                // Get the selected row index
                int rowIndex = Program.f1.itemGrid3.SelectedCells[0].RowIndex;

                // Load the values from the selected row into the textboxes
                add.txtDateSupplyCH.Text = Program.f1.itemGrid3.Rows[rowIndex].Cells["colSupplyDate"].Value.ToString();
                add.txtSupplierSupplyCH1.Text = (string)Program.f1.itemGrid3.Rows[rowIndex].Cells["colSupplierName"].Value;
                add.txtNameItemSupplyCH1.Text = (string)Program.f1.itemGrid3.Rows[rowIndex].Cells["colNameItem"].Value;

                add.txtVSupply.Text = Program.f1.itemGrid3.Rows[rowIndex].Cells["colVSupply"].Value.ToString();

                ShowItemInput(0);
                ShowSupplierInput(0);
                ShowSupplyInput(1);
                if (add.ShowDialog(this) == DialogResult.OK)
                {
                    SetItemGrid();
                }
            }
        }
    }


}
