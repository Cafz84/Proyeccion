﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MONNAACI-18;Initial Catalog=DB_BasePruebas;Integrated Security=True")]
        public string cadenaConeccion_DB_BasePruebas {
            get {
                return ((string)(this["cadenaConeccion_DB_BasePruebas"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=EVSQL.EVAWS.Local;Initial Catalog=Lavoraziones_Monnaaci_P;Persist Sec" +
            "urity Info=True;User ID=Reporting;Password=Rep0rt1$")]
        public string cadenaConeccion_Lavoraciones_Monnaaci_p {
            get {
                return ((string)(this["cadenaConeccion_Lavoraciones_Monnaaci_p"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ec2-52-52-139-21.us-west-1.compute.amazonaws.com,1433;Initial Catalog" +
            "=Pruebas_Lavoraziones;Persist Security Info=True;User ID=reports;Password=Cloud@" +
            "123")]
        public string cadenaConeccion_Pruebas_Lavoraziones {
            get {
                return ((string)(this["cadenaConeccion_Pruebas_Lavoraziones"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=EVSQL.EVAWS.Local;Initial Catalog=ERPLavoraziones_Monnaaci;Persist Se" +
            "curity Info=True;User ID=Reporting;Password=Rep0rt1$")]
        public string cadenaConeccion_ERPLavoraziones_Monnaaci {
            get {
                return ((string)(this["cadenaConeccion_ERPLavoraziones_Monnaaci"]));
            }
        }
    }
}
