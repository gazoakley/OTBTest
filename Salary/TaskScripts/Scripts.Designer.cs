﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Salary.TaskScripts {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Scripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Scripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Salary.TaskScripts.Scripts", typeof(Scripts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT 
        ///	Employees.id,
        ///	Employees.name,
        ///	CAST((Salaries.annual_amount / Currencies.conversion_factor) AS DECIMAL(10, 2)) AS salary
        ///FROM Salaries
        ///JOIN Employees ON Salaries.employee_id = Employees.id
        ///JOIN Currencies ON Salaries.currency = Currencies.id
        ///JOIN Roles ON Employees.role_id = Roles.id
        ///WHERE Roles.name = @Role
        ///ORDER BY salary DESC.
        /// </summary>
        internal static string Role {
            get {
                return ResourceManager.GetString("Role", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT 
        ///	Employees.id,
        ///	Employees.name,
        ///	Salaries.annual_amount AS local_salary,
        ///	CAST((Salaries.annual_amount / Currencies.conversion_factor) AS DECIMAL(10, 2)) AS gbp_salary
        ///FROM Salaries
        ///JOIN Employees ON Salaries.employee_id = Employees.id
        ///JOIN Currencies ON Salaries.currency = Currencies.id
        ///JOIN Roles ON Employees.role_id = Roles.id
        ///WHERE Employees.name LIKE @Name
        ///ORDER BY gbp_salary DESC.
        /// </summary>
        internal static string Search {
            get {
                return ResourceManager.GetString("Search", resourceCulture);
            }
        }
    }
}