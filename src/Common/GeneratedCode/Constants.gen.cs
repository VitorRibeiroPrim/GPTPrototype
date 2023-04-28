﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

namespace Primavera.Lithium.ChatGPT.Server.Common;

#region Code

#region Public Classes

/// <summary>
/// Defines constants used by various types.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public static partial class Constants
{
    #region Code

    #region Public Classes

    /// <summary>
    /// Defines constants used to identify authentication policies.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
    public static partial class Policies
    {
        #region Code

        #region Public Constants

        /// <summary>
        /// Defines the name of the policy that applies the default scope.
        /// </summary>
        public const string DefaultScope = "chatgpt";

        #endregion

        #endregion
    }

    /// <summary>
    /// Defines constants used by MVC controllers.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
    public static partial class Controllers
    {
        #region Code

        #region Public Classes

        /// <summary>
        /// Defines constants used by the home MVC controller.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
        public static partial class Home
        {
            #region Code

            #region Public Classes

            /// <summary>
            /// Defines constants that specify the routes used in the home MVC controller.
            /// </summary>
            [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
            public static partial class Routes
            {
                #region Code

                #region Public Constants

                /// <summary>
                /// Defines the route of the index action.
                /// </summary>
                public const string Index = "";

                /// <summary>
                /// Defines the route of the error action.
                /// </summary>
                public const string Error = "/error";

                #endregion

                #endregion
            }

            /// <summary>
            /// Defines constants that specify the action names used in the home MVC controller.
            /// </summary>
            [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
            public static partial class Actions
            {
                #region Code

                #region Public Constants

                /// <summary>
                /// Defines the name of the index action.
                /// </summary>
                public const string Index = "Home.Index";

                /// <summary>
                /// Defines the name of the error action.
                /// </summary>
                public const string Error = "Home.Error";

                #endregion

                #endregion
            }

            #endregion

            #region Public Constants

            /// <summary>
            /// Defines the name of the controller.
            /// </summary>
            public const string Name = "Home";

            #endregion

            #endregion
        }

        /// <summary>
        /// Defines constants used by the client library documentation MVC controller.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
        public static partial class ClientLibDocumentation
        {
            #region Code

            #region Public Classes

            /// <summary>
            /// Defines constants that specify the routes used in the client library documentation MVC controller.
            /// </summary>
            [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
            public static partial class Routes
            {
                #region Code

                #region Public Constants

                /// <summary>
                /// Defines the route of the documentation action.
                /// </summary>
                public const string Documentation = "/.doc/clientlib";

                #endregion

                #endregion
            }

            /// <summary>
            /// Defines constants that specify the action names used in the client library documentation MVC controller.
            /// </summary>
            [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
            public static partial class Actions
            {
                #region Code

                #region Public Constants

                /// <summary>
                /// Defines the name of the documentation action.
                /// </summary>
                public const string Documentation = "ClientLibDocumentation.Documentation";

                #endregion

                #endregion
            }

            #endregion

            #region Public Constants

            /// <summary>
            /// Defines the name of the controller.
            /// </summary>
            public const string Name = "ClientLibDocumentation";

            #endregion

            #endregion
        }

        /// <summary>
        /// Defines constants used by the monitoring MVC controller.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
        public static partial class Monitoring
        {
            #region Code

            #region Public Classes

            /// <summary>
            /// Defines constants that specify the routes used in the monitoring MVC controller.
            /// </summary>
            [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
            public static partial class Routes
            {
                #region Code

                #region Public Constants

                /// <summary>
                /// Defines the route of the probe action.
                /// </summary>
                public const string Probe = "/.monitoring/probe";

                /// <summary>
                /// Defines the route of the diagnostics action.
                /// </summary>
                public const string Diagnostics = "/.monitoring/diagnostics";

                /// <summary>
                /// Defines the route of the endpoints action.
                /// </summary>
                public const string Endpoints = "/.monitoring/endpoints";

                /// <summary>
                /// Defines the route of the configuration action.
                /// </summary>
                public const string Configuration = "/.monitoring/configuration";

                /// <summary>
                /// Defines the route of the information action.
                /// </summary>
                public const string Information = "/.monitoring/info";

                #endregion

                #endregion
            }

            /// <summary>
            /// Defines constants that specify the action names used in the monitoring MVC controller.
            /// </summary>
            [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
            public static partial class Actions
            {
                #region Code

                #region Public Constants

                /// <summary>
                /// Defines the name of the probe action.
                /// </summary>
                public const string Probe = "Monitoring.Probe";

                /// <summary>
                /// Defines the name of the diagnostics action.
                /// </summary>
                public const string Diagnostics = "Monitoring.Diagnostics";

                /// <summary>
                /// Defines the name of the endpoints action.
                /// </summary>
                public const string Endpoints = "Monitoring.Endpoints";

                /// <summary>
                /// Defines the name of the configuration action.
                /// </summary>
                public const string Configuration = "Monitoring.Configuration";

                /// <summary>
                /// Defines the name of the information action.
                /// </summary>
                public const string Information = "Monitoring.Information";

                #endregion

                #endregion
            }

            #endregion

            #region Public Constants

            /// <summary>
            /// Defines the name of the controller.
            /// </summary>
            public const string Name = "Monitoring";

            #endregion

            #endregion
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Defines constants used in the documentation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
    public static partial class Documentation
    {
        #region Code

        #region Public Constants

        /// <summary>
        /// Defines the base route of the REST API documentation.
        /// </summary>
        public const string RestApiBaseRoute = "/.doc/restapi";

        /// <summary>
        /// Defines the legacy base route of the REST API documentation.
        /// </summary>
        public const string RestApiBaseRouteLegacy = "/.doc/webapi";

        /// <summary>
        /// Defines the route of the REST API documentation documents.
        /// </summary>
        public const string RestApiDocumentsRoute = "/.doc/restapi/{documentName}/openapi.json";

        /// <summary>
        /// Defines the path of the custom style sheet used to customize the UI.
        /// </summary>
        public const string RestApiStyleSheetPath = "openapi.custom.css";

        #endregion

        #endregion
    }

    /// <summary>
    /// Defines constants used to identify views.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
    public static partial class Views
    {
        #region Code

        #region Public Constants

        /// <summary>
        /// Defines the path of the home view.
        /// </summary>
        public const string Home = "~/GeneratedCode/HomeView.gen.cshtml";

        /// <summary>
        /// Defines the path of the error view.
        /// </summary>
        public const string Error = "~/GeneratedCode/ErrorView.gen.cshtml";

        /// <summary>
        /// Defines the path of the copyright partial view.
        /// </summary>
        public const string CopyrightPartial = "~/GeneratedCode/CopyrightPartialView.gen.cshtml";

        /// <summary>
        /// Defines the path of the client library documentation view.
        /// </summary>
        public const string ClientLibDocumentation = "~/GeneratedCode/ClientLibDocView.gen.cshtml";

        #endregion

        #endregion
    }

    #endregion

    #region Public Constants

    /// <summary>
    /// Defines the default API version.
    /// </summary>
    public const string DefaultApiVersion = "1.0";

    #endregion

    #endregion
}

#endregion

#endregion
