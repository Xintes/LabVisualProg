using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupplyFormVisualLab12
{
    public partial class AddItemForm : Form
    {

       /// private TabControl tagControl;
        private int _id;
        private string _name;
        private string _manufacturer;
        private decimal _price;
        public AddItemForm()
        {
            Program.f2 = this; // теперь f1 будет ссылкой на форму Form1
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}
        
        private void AddItemForm_Load(object sender, EventArgs e)
        {// TODO: данная строка кода позволяет загрузить данные в таблицу "supplyDataSet.Item". При необходимости она может быть перемещена или удалена.
            this.itemTableAdapter.Fill(this.supplyDataSet.Item);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "supplyDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.supplyDataSet.Supplier);
            txtSupplierSupply.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNameItemSupply.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPhoneSupplier.Mask = "+7 000 000-00-00";
            txtDateSupply.Mask = "0000-00-00";
        }

        private void AddRecord<T>(T record, string errorMessage) where T : class
        {
            try
            {
                using (var db = new SupplyModel())
                {
                    db.Set<T>().Add(record);
                    db.SaveChanges();
                }

                MessageBox.Show("Запись успешно добавлена в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
            }
        }
        //-----------------------ДОБАВЛЕНИЕ В ТАБЛИЦУ--------------------------------------------------------------------
        private void AddItem()
        {
            errorProvider.Clear();
            int parsedId;
            if (!int.TryParse(txtIdItem.Text.Trim(), out parsedId))
            {
                errorProvider.SetError(txtIdItem, "Ошибка! Некорректный ID");
                return;
            }

            using (var db = new SupplyModel())
            {
                var existingItem = db.Item.Find(parsedId);
                if (existingItem != null)
                {
                    errorProvider.SetError(txtIdItem, "Ошибка! Запись с таким ID уже существует в таблице Item");
                    return;
                }
            }

            decimal? parsedPrice = null;
            if (!string.IsNullOrEmpty(txtPriceItem.Text))
            {
                if (!decimal.TryParse(txtPriceItem.Text.Trim(), out decimal price))
                {
                    errorProvider.SetError(txtPriceItem, "Ошибка! Некорректная цена");
                    return;
                }
                parsedPrice = price;
            }

            if (string.IsNullOrEmpty(txtNameItem.Text))
            {
                errorProvider.SetError(txtNameItem, "Ошибка! Некорректное название предмета");
                return;
            }
            if (string.IsNullOrEmpty(txtManufacturerItem.Text))
            {
                errorProvider.SetError(txtManufacturerItem, "Ошибка! Некорректное название фирмы");
                return;
            }

            var item = new Item
            {
                Id = parsedId,
                Name = txtNameItem.Text.Trim(),
                Manufacturer = txtManufacturerItem.Text.Trim(),
                Price = parsedPrice.HasValue ? parsedPrice.Value : (decimal)0
            };

            AddRecord(item, "Ошибка при добавлении записи в таблицу Supply");
        }

        private void AddSupplier()
        {
            errorProvider.Clear();

            int parsedId;
            if (!int.TryParse(txtIdSupplier.Text.Trim(), out parsedId))
            {
                errorProvider.SetError(txtIdSupplier, "Ошибка! Некорректный ID");
            }
            // Проверка наличия ключа в таблице Supplier
            using (var db = new SupplyModel())
            {
                var existingSupplier = db.Supplier.Find(parsedId);
                if (existingSupplier != null)
                {
                    errorProvider.SetError(txtIdSupplier, "Ошибка! Запись с таким ID уже существует в таблице Supplier");
                    return;
                }
            }
            if (string.IsNullOrEmpty(txtNameSupplier.Text))
            {
                errorProvider.SetError(txtNameSupplier, "Ошибка! Некорректное имя поставщика");

            }
            if (string.IsNullOrEmpty(txtAdressSupplier.Text))
            {
                errorProvider.SetError(txtAdressSupplier, "Ошибка! Некорректное название адреса");

            }
            if (txtPhoneSupplier.MaskCompleted)
            {
                var item = new Supplier
                {
                    Id = parsedId,
                    Name = txtNameSupplier.Text.Trim(),
                    Address = txtAdressSupplier.Text.Trim(),
                    Phone = txtPhoneSupplier.Text.Trim()
                };

                AddRecord(item, "Ошибка при добавлении записи в таблицу Supplier");
            }
            else
            {
                errorProvider.SetError(txtPhoneSupplier, "Ошибка! Неполный номер телефона");
            }
        }
        private void AddSupply()
        {
            errorProvider.Clear();

            int parsedItemID;
            int parsedVSupply;
            int selectIdItem = (int)txtNameItemSupply.SelectedValue;
            int parsedSupplier = (int)txtSupplierSupply.SelectedValue;
            string inputDate = txtDateSupply.Text.Trim();
            DateTime parsedDate;

            if (!txtDateSupply.MaskCompleted)
            {
                //errorProvider.SetError(txtDateSupply, "Некорректный формат даты");

                //// Проверка допустимости месяца (от 1 до 12)
                //if (parsedDate.Month < 1 || parsedDate.Month > 12)
                //{
                //    errorProvider.SetError(txtDateSupply, "Некорректный месяц");
                //    return;
                //}

                //// Проверка допустимости дня (от 1 до 30)
                //if (parsedDate.Day < 1 || parsedDate.Day > 30)
                //{
                //    errorProvider.SetError(txtDateSupply, "Некорректный день");
                //    return;
                //}

                errorProvider.SetError(txtDateSupply, "Ошибка! Некорректный ввод даты");
                
            }
            if (!int.TryParse(txtVSupply.Text.Trim(), out parsedVSupply) && string.IsNullOrEmpty(txtVSupply.Text))
            {
                errorProvider.SetError(txtVSupply, "Ошибка! Некорректный ввод количества поставок");

            }
            else
            {
                parsedDate = DateTime.ParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                using (var db = new SupplyModel())
                {
                    var existingSupply = db.Supply.Find(parsedSupplier, selectIdItem, parsedDate);
                    if (existingSupply != null)
                    {
                        if (existingSupply.Supplier == parsedSupplier)
                        {
                            errorProvider.SetError(txtSupplierSupply, "Ошибка! Запись с таким значением Supplier уже существует в таблице Supply");
                        }

                        if (existingSupply.Item == selectIdItem)
                        {
                            errorProvider.SetError(txtNameItemSupply, "Ошибка! Запись с таким значением Item уже существует в таблице Supply");
                        }

                        if (existingSupply.Date == parsedDate)
                        {
                            errorProvider.SetError(txtDateSupply, "Ошибка! Запись с таким значением Date уже существует в таблице Supply");
                        }

                        return;
                    }
                }
                var supply = new Supply
                {
                    Supplier = parsedSupplier,
                    Item = selectIdItem,
                    Date = parsedDate,
                    Volume = parsedVSupply
                };

                AddRecord(supply, "Ошибка при добавлении записи в таблицу Supply");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageItem)
            {

                AddItem();

            }
            else if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageSupplier)
            {

                AddSupplier();

            }
            else if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageSupply)
            {

                AddSupply();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            this.Close();
        }
        private void txtManufacturer_TextChanged(object sender, EventArgs e){}
        private void txtPriceItem_TextChanged(object sender, EventArgs e) {}
        private void txtSupplierSupply_SelectedIndexChanged(object sender, EventArgs e)
        {}
        private void txtDateSupply_TextChanged(object sender, EventArgs e)
        {}
        private void txtPhoneSupplier_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { }
        private void txtPhoneSupplier_MouseClick(object sender, MouseEventArgs e)
        {
                        (sender as MaskedTextBox).Select(0, 0);
        }

        private void btnCh_Click(object sender, EventArgs e)
        {
            if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageItem)
            {
                double parsedPrice;
                if (!double.TryParse(txtPriceItem.Text.Trim(), out parsedPrice))
                {
                    errorProvider.SetError(txtPriceItem, "Ошибка! Некорректная цена");
                    return;
                }

                int itemId = int.Parse(txtIdItem.Text);
                using (var db = new SupplyModel())
                {
                    Item item = db.Item.FirstOrDefault(x => x.Id == itemId);
                    if (item != null)
                    {
                        // Внесите изменения в элемент
                        item.Name = txtNameItem.Text;
                        item.Manufacturer = txtManufacturerItem.Text;
                        item.Price = decimal.Parse(txtPriceItem.Text);

                        db.SaveChanges();
                    }
                }

                this.DialogResult = DialogResult.OK; // Установите DialogResult в OK, если добавление поставщика прошло успешно
            }
            else if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageSupplier)
            {
                
                int SupplierId;
                if (!int.TryParse(txtIdSupplier.Text, out SupplierId))
                {
                        errorProvider.SetError(txtIdSupplier, "Ошибка! Некорректный ID поставщика");
                        return;
                }
                if (!txtPhoneSupplier.MaskCompleted)
                {
                    errorProvider.SetError(txtPhoneSupplier, "Ошибка! Некорректный номер телефона");
                    return;
                }


                using (var db = new SupplyModel())
                {
                        Supplier item = db.Supplier.FirstOrDefault(x => x.Id == SupplierId);
                        if (item != null)
                        {
                            // Внесите изменения в элемент
                            item.Name = txtNameSupplier.Text;
                            item.Address = txtAdressSupplier.Text;
                            item.Phone = txtPhoneSupplier.Text;

                            db.SaveChanges();
                        }
                }

                this.DialogResult = DialogResult.OK; // Установите DialogResult в OK, если добавление поставщика прошло успешно
                
                
            }
            else if (Program.f1.tabControlSupply.SelectedTab == Program.f1.tabPageSupply)
            {
                int SupplierId, IdItem; 
                string date = txtDateSupplyCH.Text.Trim();
                using (var db = new SupplyModel())
                {
                    Supplier supplier = db.Supplier.FirstOrDefault(s => s.Name == txtSupplierSupplyCH1.Text);
                    if (supplier != null)
                    {
                        SupplierId = supplier.Id;
                    }
                    else
                    {
                        // Обработайте случай, если поставщик не найден
                        // Например, выведите сообщение об ошибке или выполните другие действия
                        return;
                    }

                    Item item = db.Item.FirstOrDefault(i => i.Name == txtNameItemSupplyCH1.Text);
                    if (item != null)
                    {
                        IdItem = item.Id;
                    }
                    else
                    {
                        // Обработайте случай, если товар не найден
                        // Например, выведите сообщение об ошибке или выполните другие действия
                        return;
                    }
                }

                DateTime Date;
                if (!DateTime.TryParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out Date))
                {
                    errorProvider.SetError(txtDateSupplyCH, "Ошибка! Некорректный формат даты");
                    return;
                }

                int parsedVSupply;
                if (!int.TryParse(txtVSupply.Text.Trim(), out parsedVSupply) || string.IsNullOrEmpty(txtVSupply.Text))
                {
                    errorProvider.SetError(txtVSupply, "Ошибка! Некорректный ввод количества поставок");
                    return;
                }

                using (var db = new SupplyModel())
                {
                    Supply item = db.Supply.FirstOrDefault(x => x.Supplier == SupplierId && x.Item == IdItem && x.Date == Date);
                    if (item != null)
                    {
                        item.Volume = parsedVSupply;
                        db.SaveChanges();
                    }
                }

                this.DialogResult = DialogResult.OK; // Установите DialogResult в OK, если добавление поставки прошло успешно
            }


            /////НЕ РАБОБАЕТ ИЗМНЕНИЕ
        }
    }
}
