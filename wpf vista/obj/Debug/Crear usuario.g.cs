﻿#pragma checksum "..\..\Crear usuario.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4E5A1C2692FAB8CACFE61EBB88CE7D954212C0475B05BE4B5CA2B951B21F9DEF"
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
    /// Crear_usuario
    /// </summary>
    public partial class Crear_usuario : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Crear usuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_nombre;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Crear usuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_contrasena;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Crear usuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_empresa_id;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Crear usuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_volver;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Crear usuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_volver;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Crear usuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_tipo_usuario;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Crear usuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ingresar;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Crear usuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img_crear;
        
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
            System.Uri resourceLocater = new System.Uri("/wpf vista;component/crear%20usuario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Crear usuario.xaml"
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
            this.txt_nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_contrasena = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_empresa_id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_volver = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Crear usuario.xaml"
            this.btn_volver.Click += new System.Windows.RoutedEventHandler(this.Btn_volver_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.img_volver = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.txt_tipo_usuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btn_ingresar = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Crear usuario.xaml"
            this.btn_ingresar.Click += new System.Windows.RoutedEventHandler(this.btn_ingresar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.img_crear = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
