using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormKitchen : Form
    {
        public FormKitchen()
        {
            InitializeComponent();
        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
            {
                tbCategoryID.Text = lvCategory.SelectedItems[0].SubItems[0].Text;
                tbCategoryName.Text = lvCategory.SelectedItems[0].SubItems[1].Text;

            }
        }

        private void pnlCategory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbCategoryName_Click(object sender, EventArgs e)
        {

        }

        private void FormKitchen_Load(object sender, EventArgs e)
        {
            cProductsCategory pc = new cProductsCategory();
            pc.getProductsCategorycb(cbProductCategory);
            cbProductCategory.Items.Insert(0, "All Categories");
            cbProductCategory.SelectedIndex = 0;

            cProducts p = new cProducts();
            p.ListProducts(lvProductList);
            pc.getProductsCategorylv(lvCategory);

        }
        private void Clear()
        {
            tbProductName.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbProduct.Checked)
            {
                if (tbProductName.Text.Trim() == "" || tbProductPrice.Text.Trim() == "" || cbProductCategory.SelectedItem.ToString() == "All Categories")
                {
                    MessageBox.Show("Information is missing");
                }
                else
                {
                    cProducts p = new cProducts();
                    p.ID=Convert.ToInt32(tbProductID.Text);
                    p.Price = Convert.ToDecimal(tbProductPrice.Text);
                    p.ProductName = tbProductName.Text;
                    cGeneral._categoryD = Convert.ToInt32(tbCategoryID2.Text);
                    p.CategoryID = cGeneral._categoryD;
                    int result = p.ProductAdd(p);

                    if (result != 0)
                    {
                        MessageBox.Show("Product added");
                        refresh();
                        Clear();
                    }
                }
            }
            else
            {
                if (tbCategoryName.Text.Trim() == "")
                {
                    MessageBox.Show("Information is missing");
                }
                else
                {
                    cProductsCategory pc = new cProductsCategory();
                    pc.CategoryName = tbCategoryName.Text;
                    int result = pc.ProductCategoryAdd(pc);

                    if (result != 0)
                    {
                        MessageBox.Show("Category added");
                        refresh();
                        cbProductCategory_SelectedIndexChanged(sender, e);
                        Clear();
                    }
                }
            }
        }

        int categoryID = 0;
        private void cbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cProducts p = new cProducts();

            if (cbProductCategory.SelectedItem.ToString() == "All Categories")
            {
                p.ListProducts(lvProductList);
            }
            else
            {
                cProductsCategory pc = (cProductsCategory)cbProductCategory.SelectedItem;
                categoryID = pc.ID;
                p.ListProductsbyProductID(lvProductList, categoryID);

            }
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();
            this.Close();
            frm.Show();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (rbProduct.Checked)
            {
                if (tbProductName.Text.Trim() == "" || tbProductPrice.Text.Trim() == "" || cbProductCategory.SelectedItem.ToString() == "All Categories")
                {
                    MessageBox.Show("Information is missing");
                }
                else
                {
                    cProducts p = new cProducts();
                    p.Price = Convert.ToDecimal(tbProductPrice.Text);
                    cGeneral._productID =Convert.ToInt32( tbProductID.Text);
                    p.ID = cGeneral._productID;
                    p.ProductName = tbProductName.Text;
                    cGeneral._categoryD = Convert.ToInt32(tbCategoryID2.Text);
                    p.CategoryID = cGeneral._categoryD;
                    int result = p.ProductUpdate(p);

                    if (result != 0)
                    {
                        MessageBox.Show("Product updated");
                        refresh();
                        Clear();
                    }

                }
            }
            else
            {
                if (tbCategoryName.Text.Trim() == "")
                {
                    MessageBox.Show("Information is missing");
                }
                else
                {
                    cProductsCategory pc = new cProductsCategory();
                    pc.CategoryName = tbCategoryName.Text;
                    pc.ID = Convert.ToInt32(tbCategoryID.Text);
                    int result = pc.ProductCategoryUpdate(pc);

                    if (result != 0)
                    {
                        MessageBox.Show("Category updated");
                        pc.getProductsCategorylv(lvCategory);
                        refresh();
                        Clear();
                    }
                }
            }
        }

        private void lvProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProductList.SelectedItems.Count > 0)
            {
                tbProductID.Text = lvProductList.SelectedItems[0].SubItems[0].Text;
                tbCategoryID2.Text = lvProductList.SelectedItems[0].SubItems[1].Text;
                tbProductName.Text = lvProductList.SelectedItems[0].SubItems[2].Text;
                tbProductPrice.Text = lvProductList.SelectedItems[0].SubItems[3].Text;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rbProduct.Checked)
            {
                if (lvProductList.SelectedItems.Count > 0)
                {

                    cProducts p = new cProducts();
                    p.ID = Convert.ToInt32(tbProductID.Text);
                    int result = p.ProductDelete(p, 1);

                    if (result != 0)
                    {
                        MessageBox.Show("Product deleted");
                        cProducts c = new cProducts();
                        c.ID = Convert.ToInt32(tbProductID.Text);
                        c.ProductDelete(c, 0);
                        refresh();
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Select a product!!!");
                }

            }
            else
            {
                if (lvCategory.SelectedItems.Count > 0)
                {

                    cProductsCategory pc = new cProductsCategory();

                    int result = pc.ProductCategoryDelete(Convert.ToInt32(tbCategoryID.Text));

                    if (result != 0)
                    {
                        MessageBox.Show("Category deleted");
                        refresh();
                        Clear();
                    }

                }
            }
        }

        private void rbProduct_CheckedChanged(object sender, EventArgs e)
        {
            pnlCategory.Visible = false;
            lvCategory.Visible = false;
            refresh();
        }

        private void refresh()
        {
            cProductsCategory cp = new cProductsCategory();
            cp.getProductsCategorycb(cbProductCategory);
            cp.getProductsCategorylv(lvCategory);
            cbProductCategory.SelectedIndex = 0;

            cProducts c = new cProducts();
            c.ListProducts(lvProductList);
            cp.getProductsCategorylv(lvCategory);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void tbProductID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
