#pragma checksum "..\..\..\Windows\ProductListWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "749758B0128C3A53641168C862637AF713D38B2E04F37F72A2821F684B53D804"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Bakery.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Bakery.Windows {
    
    
    /// <summary>
    /// ProductListWindow
    /// </summary>
    public partial class ProductListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 21 "..\..\..\Windows\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbSearch;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbSort;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox allcheck;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Windows\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbFilter;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Windows\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LvProduct;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\Windows\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgCart;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\Windows\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddProduct;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Bakery;component/windows/productlistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ProductListWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\Windows\ProductListWindow.xaml"
            this.TbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CmbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\Windows\ProductListWindow.xaml"
            this.CmbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.allcheck = ((System.Windows.Controls.CheckBox)(target));
            
            #line 40 "..\..\..\Windows\ProductListWindow.xaml"
            this.allcheck.Checked += new System.Windows.RoutedEventHandler(this.allcheck_Checked_2);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Windows\ProductListWindow.xaml"
            this.allcheck.Unchecked += new System.Windows.RoutedEventHandler(this.Allcheck_UnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CmbFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 46 "..\..\..\Windows\ProductListWindow.xaml"
            this.CmbFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LvProduct = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.ImgCart = ((System.Windows.Controls.Image)(target));
            
            #line 152 "..\..\..\Windows\ProductListWindow.xaml"
            this.ImgCart.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ImgCart_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnAddProduct = ((System.Windows.Controls.Button)(target));
            
            #line 160 "..\..\..\Windows\ProductListWindow.xaml"
            this.BtnAddProduct.Click += new System.Windows.RoutedEventHandler(this.BtnAddProduct_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 124 "..\..\..\Windows\ProductListWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditProduct_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 134 "..\..\..\Windows\ProductListWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnAddToCartProduct_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

