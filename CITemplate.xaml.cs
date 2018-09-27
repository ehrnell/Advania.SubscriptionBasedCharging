using Microsoft.EnterpriseManagement.ServiceManager.Application.Common;
namespace Advania.SubscriptionBasedCharing.CustomFormTemplates
{
    /// <summary>
    /// Interaction logic for CITemplate.xaml
    /// </summary>
    public partial class CITemplate
    {
        private readonly RelatedItemsPane _relatedItemsPane;
        public CITemplate()
        {
            InitializeComponent();
            _relatedItemsPane = new RelatedItemsPane(new ConfigItemRelatedItemsConfiguration());
            tabItemRelItems.Content = _relatedItemsPane;
        }
    }
}