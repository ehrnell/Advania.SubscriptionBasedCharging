using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Advania.SubscriptionBasedCharging
{
    /// <summary>
    /// Interaction logic for MyTemplate.xaml
    /// </summary>
    public partial class MyTemplate : UserControl
    {
        private RelatedItemsPane _relatedItemsPane;
        public MyTemplate()
        {
            InitializeComponent();
            _relatedItemsPane = new RelatedItemsPane(new ConfigItemRelatedItemsConfiguration());
            tabItemRelItems.Content = _relatedItemsPane;
        }
    }
}
