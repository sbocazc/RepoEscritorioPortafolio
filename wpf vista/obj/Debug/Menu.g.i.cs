﻿#pragma checksum "..\..\Menu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6B92D36F81A58899EE4702D7E139FEDE8F03A29FDAB1C7280DBB826F8CBBBFAD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using wpf_vista;


namespace wpf_vista {
    
    
    /// <summary>
    /// Menu
    /// </summary>
    public partial class Menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_crear_usuario;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_crear_un_internas;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_crear_rol;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_crear_flujo_tarea;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_salir;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_volver;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_empresa;
        
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
            System.Uri resourceLocater = new System.Uri("/wpf vista;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu.xaml"
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
            this.btn_crear_usuario = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Menu.xaml"
            this.btn_crear_usuario.Click += new System.Windows.RoutedEventHandler(this.Btn_crear_usuario_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_crear_un_internas = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btn_crear_rol = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Menu.xaml"
            this.btn_crear_rol.Click += new System.Windows.RoutedEventHandler(this.Btn_crear_rol_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_crear_flujo_tarea = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Menu.xaml"
            this.btn_crear_flujo_tarea.Click += new System.Windows.RoutedEventHandler(this.Btn_crear_flujo_tarea_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_salir = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Menu.xaml"
            this.btn_salir.Click += new System.Windows.RoutedEventHandler(this.Btn_salir_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.img_volver = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.btn_empresa = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Menu.xaml"
            this.btn_empresa.Click += new System.Windows.RoutedEventHandler(this.btn_empresa_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
