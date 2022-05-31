
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace NetOrderApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : TabbedPage
    {
        

        private List<OrderPage> _orders = new List<OrderPage>();
        private OrderPage order;

        public List<OrderPage> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }
        public OrderPage()
        {
            InitializeComponent();

            CreateOrders();

            BindingContext = this;

        }

        public OrderPage(OrderPage order)
        {
            this.order = order;
        }

        public void CreateOrders()
        {
            OrderPage myorder = new OrderPage();

        }

       

        private async void OrderListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if ((OrderPage)e.Item is OrderPage order)
            {
                await Navigation.PushAsync(new OrderPage(order));

            }


        }
    }
}