// Decompiled with JetBrains decompiler
// Type: Litware.SCSM.CustomFormTemplates.CITemplate
// Assembly: Litware.SCSM.CustomFormTemplates, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BD87F157-E99D-4502-926C-8A4B23067EAF
// Assembly location: C:\Users\maehr001\Documents\Visual Studio 2012\Projects\AdvaniaOrganizationStructure\AdvaniaOrganizationStructure\Form\Litware.SCSM.CustomFormTemplates.dll

using Microsoft.EnterpriseManagement.ServiceManager.Application.Common;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Advania.SubscriptionBasedCharging
{
    public class CITemplate : UserControl, IComponentConnector
    {
        private readonly RelatedItemsPane _relatedItemsPane;
        internal TabItem tabItemGeneral;
        internal TabItem tabItemRelItems;
        internal TabItem tabItemHistory;
        private bool _contentLoaded;

        public CITemplate()
        {
            this.InitializeComponent();
            this._relatedItemsPane = new RelatedItemsPane((IRelatedItemsConfiguration)new ConfigItemRelatedItemsConfiguration());
            this.tabItemRelItems.Content = (object)this._relatedItemsPane;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (this._contentLoaded)
                return;
            this._contentLoaded = true;
            Application.LoadComponent((object)this, new Uri("/Advania.SubscriptionBasedCharging;component/citemplate.xaml", UriKind.Relative));
        }

        [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.tabItemGeneral = (TabItem)target;
                    break;
                case 2:
                    this.tabItemRelItems = (TabItem)target;
                    break;
                case 3:
                    this.tabItemHistory = (TabItem)target;
                    break;
                default:
                    this._contentLoaded = true;
                    break;
            }
        }
    }
}

