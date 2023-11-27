using System.Collections.ObjectModel;

namespace WinFormsAppSalescomp
{
    public partial class Form1 : Form
    {
        private Componentcs[] componentcs;
        private ObservableCollection<Product> products;
        public decimal TotalTopay
        {
            get
            {
                return BasketListBox.Items.OfType<Product>().Sum(e => e.Price);
            }
        }

        public Form1()
        {
            InitializeComponent();
            componentcs = new Componentcs[]
            {
                new Componentcs{ Name= "Процессоры" },
                new Componentcs{ Name= "Материнские платы" },
                new Componentcs{ Name= "Видеокарты" },
                new Componentcs{ Name= "Блоки питания" },
               
            };
            products = new ObservableCollection<Product>
            {
                new Product{ Name="Intel Core i5-124OOF",Componentcs=componentcs[0], Price=5779,Quntity=100},
                new Product{ Name="AMD Ryzen 5 5600G",Componentcs=componentcs[0],Price=4659,Quntity=90},
                new Product{ Name="Asus TUF Gaming A52OM-Plus",Componentcs=componentcs[1],Price=2799,Quntity=50},
                new Product{ Name="Gigabyte GeForse RTX3060",Componentcs=componentcs[2],Price=11599,Quntity=40},
                new Product{ Name="Asus TUF Gaming 750W",Componentcs=componentcs[3],Price=3899,Quntity=20},
            };
            NameComboBox.DataSource = componentcs;
            NameComboBox.DisplayMember = "Name";
            NameComboBox.ValueMember = "Id";
            ComponentListBox.SelectionMode = SelectionMode.MultiExtended;

            FillListBox();
        }

        private void FillListBox()
        {
            ComponentListBox.DataSource = products.Where(e => e.Componentcs.Id.Equals(NameComboBox.SelectedValue)).ToList();
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            var selectedProducts = ComponentListBox.SelectedItems.OfType<Product>().ToArray();
            if (selectedProducts != null)
            {
                BasketListBox.Items.AddRange(selectedProducts);
                TotalCostTextBox.Text = $"К оплате:{TotalTopay.ToString()}";
            }

        }

        private void DiscpirButton_Click(object sender, EventArgs e)
        {
            var selectedProducts = ComponentListBox.SelectedItems.OfType<Product>().ToArray();
            
                SalesForm salesForm = new SalesForm(selectedProducts);
                var result = salesForm.ShowDialog();
                FillListBox();
            

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = BasketListBox.SelectedIndex;
            if (index != -1)
            {
                BasketListBox.Items.RemoveAt(index);
                TotalCostTextBox.Text = $"К оплате:{TotalTopay.ToString()}";
            }
        }

        private void CloseOrderButton_Click(object sender, EventArgs e)
        {
            if (TotalTopay > 0)
            {
                OrderConfirmationForm orderConfirmationForm = new OrderConfirmationForm(BasketListBox.Items.OfType<Product>().ToArray());
                var result = orderConfirmationForm.ShowDialog();
                if (result == DialogResult.OK) ;
               
            }
        }
    }
}