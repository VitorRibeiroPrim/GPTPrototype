﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Primavera.Lithium.ChatGPT.Server.Common.Tests;

#region Code

#region Public Classes

/// <summary>
/// Provides unit tests for the <see cref="ExtensionMethods"/> type.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public partial class ExtensionMethodsTests
{
    #region Code

    #region Public Methods

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetId(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetId_Principal_Null()
    {
        System.Security.Claims.ClaimsPrincipal principal = null;
        principal.GetId().Should().BeNull();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetId(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetId_Subject()
    {
        System.Security.Claims.ClaimsIdentity identity = new System.Security.Claims.ClaimsIdentity(new System.Security.Claims.Claim[] { new System.Security.Claims.Claim(Primavera.Hydrogen.IdentityModel.JwtClaimTypes.Subject, "subject") });
        System.Security.Claims.ClaimsPrincipal principal = new System.Security.Claims.ClaimsPrincipal(identity);
        principal.GetId().Should().Be("subject");
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetId(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetId_NameIdentifier()
    {
        System.Security.Claims.ClaimsIdentity identity = new System.Security.Claims.ClaimsIdentity(new System.Security.Claims.Claim[] { new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.NameIdentifier, "identifier") });
        System.Security.Claims.ClaimsPrincipal principal = new System.Security.Claims.ClaimsPrincipal(identity);
        principal.GetId().Should().Be("identifier");
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetEmail(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetId_NotFound()
    {
        System.Security.Claims.ClaimsPrincipal principal = new System.Security.Claims.ClaimsPrincipal();
        principal.GetId().Should().BeNull();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetEmail(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetEmail_Principal_Null()
    {
        System.Security.Claims.ClaimsPrincipal principal = null;
        principal.GetEmail().Should().BeNull();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetEmail(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetEmail_Email1()
    {
        System.Security.Claims.ClaimsIdentity identity = new System.Security.Claims.ClaimsIdentity(new System.Security.Claims.Claim[] { new System.Security.Claims.Claim(Primavera.Hydrogen.IdentityModel.JwtClaimTypes.Email, "email") });
        System.Security.Claims.ClaimsPrincipal principal = new System.Security.Claims.ClaimsPrincipal(identity);
        principal.GetEmail().Should().Be("email");
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetEmail(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetEmail_Email2()
    {
        System.Security.Claims.ClaimsIdentity identity = new System.Security.Claims.ClaimsIdentity(new System.Security.Claims.Claim[] { new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Email, "email") });
        System.Security.Claims.ClaimsPrincipal principal = new System.Security.Claims.ClaimsPrincipal(identity);
        principal.GetEmail().Should().Be("email");
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetEmail(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetEmail_NotFound()
    {
        System.Security.Claims.ClaimsPrincipal principal = new System.Security.Claims.ClaimsPrincipal();
        principal.GetEmail().Should().BeNull();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetClientId(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetClientId_Principal_Null()
    {
        System.Security.Claims.ClaimsPrincipal principal = null;
        principal.GetClientId().Should().BeNull();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetClientId(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetClientId_ClientId()
    {
        System.Security.Claims.ClaimsIdentity identity = new System.Security.Claims.ClaimsIdentity(new System.Security.Claims.Claim[] { new System.Security.Claims.Claim(Primavera.Hydrogen.IdentityModel.JwtClaimTypes.ClientId, "clientId") });
        System.Security.Claims.ClaimsPrincipal principal = new System.Security.Claims.ClaimsPrincipal(identity);
        principal.GetClientId().Should().Be("clientId");
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetClientId(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetClientId_NotFound()
    {
        System.Security.Claims.ClaimsPrincipal principal = new System.Security.Claims.ClaimsPrincipal();
        principal.GetClientId().Should().BeNull();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetDisplayName(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetDisplayName_Principal_Null()
    {
        System.Security.Claims.ClaimsPrincipal principal = null;
        principal.GetDisplayName().Should().BeNull();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetDisplayName(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetDisplayName_DisplayName()
    {
        System.Security.Claims.ClaimsIdentity identity = new System.Security.Claims.ClaimsIdentity(new System.Security.Claims.Claim[] { new System.Security.Claims.Claim(Primavera.Hydrogen.IdentityModel.JwtCustomClaimTypes.DisplayName, "display") });
        System.Security.Claims.ClaimsPrincipal principal = new System.Security.Claims.ClaimsPrincipal(identity);
        principal.GetDisplayName().Should().Be("display");
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetDisplayName(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetDisplayName_Email()
    {
        System.Security.Claims.ClaimsIdentity identity = new System.Security.Claims.ClaimsIdentity(new System.Security.Claims.Claim[] { new System.Security.Claims.Claim(Primavera.Hydrogen.IdentityModel.JwtClaimTypes.Email, "email") });
        System.Security.Claims.ClaimsPrincipal principal = new System.Security.Claims.ClaimsPrincipal(identity);
        principal.GetDisplayName().Should().Be("email");
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetDisplayName(System.Security.Claims.ClaimsPrincipal?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetDisplayName_NotFound()
    {
        System.Security.Claims.ClaimsPrincipal principal = new System.Security.Claims.ClaimsPrincipal();
        principal.GetDisplayName().Should().BeNull();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsApi(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsApi_Request_Null()
    {
        Microsoft.AspNetCore.Http.HttpRequest request = null;
        request.PathIsApi().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsApi(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsApi_True()
    {
        // Ignore Spelling: api

        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/api/path");
        httpContext.Request.PathIsApi().Should().BeTrue();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsApi(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsApi_False()
    {
        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/path");
        httpContext.Request.PathIsApi().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsMonitoring(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsMonitoring_Request_Null()
    {
        Microsoft.AspNetCore.Http.HttpRequest request = null;
        request.PathIsMonitoring().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsMonitoring(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsMonitoring_Monitoring()
    {
        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/.monitoring/probe");
        httpContext.Request.PathIsMonitoring().Should().BeTrue();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsMonitoring(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsMonitoring_AdminFunctions()
    {
        // Ignore Spelling: admin

        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/admin/functions");
        httpContext.Request.PathIsMonitoring().Should().BeTrue();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsMonitoring(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsMonitoring_False()
    {
        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/path");
        httpContext.Request.PathIsMonitoring().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsDocumentation(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsDocumentation_Request_Null()
    {
        Microsoft.AspNetCore.Http.HttpRequest request = null;
        request.PathIsDocumentation().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsDocumentation(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsDocumentation_True()
    {
        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/.doc/path");
        httpContext.Request.PathIsDocumentation().Should().BeTrue();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsDocumentation(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsDocumentation_False()
    {
        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/path");
        httpContext.Request.PathIsDocumentation().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsRestApiDocumentation(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsRestApiDocumentation_Request_Null()
    {
        Microsoft.AspNetCore.Http.HttpRequest request = null;
        request.PathIsRestApiDocumentation().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsRestApiDocumentation(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsRestApiDocumentation_True()
    {
        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString(Common.Constants.Documentation.RestApiBaseRoute);
        httpContext.Request.PathIsRestApiDocumentation().Should().BeTrue();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsRestApiDocumentation(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsRestApiDocumentation_False()
    {
        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString(Common.Constants.Controllers.ClientLibDocumentation.Routes.Documentation);
        httpContext.Request.PathIsRestApiDocumentation().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsRestApiDocumentationCustomization(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsRestApiDocumentationCustomization_Request_Null()
    {
        Microsoft.AspNetCore.Http.HttpRequest request = null;
        request.PathIsRestApiDocumentationCustomization().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsRestApiDocumentationCustomization(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsRestApiDocumentationCustomization_True()
    {
        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/" + Common.Constants.Documentation.RestApiStyleSheetPath);
        httpContext.Request.PathIsRestApiDocumentationCustomization().Should().BeTrue();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsRestApiDocumentationCustomization(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsRestApiDocumentationCustomization_False()
    {
        // Ignore Spelling: clientlib

        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/.doc/clientlib");
        httpContext.Request.PathIsRestApiDocumentationCustomization().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsContent(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsContent_Request_Null()
    {
        Microsoft.AspNetCore.Http.HttpRequest request = null;
        request.PathIsContent().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsContent(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsContent_Css()
    {
        // Ignore Spelling: css

        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/css/x.css");
        httpContext.Request.PathIsContent().Should().BeTrue();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsContent(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsContent_Fonts()
    {
        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/fonts/font.ttf");
        httpContext.Request.PathIsContent().Should().BeTrue();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsContent(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsContent_Img()
    {
        // Ignore Spelling: img

        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/img/image.jpg");
        httpContext.Request.PathIsContent().Should().BeTrue();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsContent(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsContent_Lib()
    {
        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/lib/lib.js");
        httpContext.Request.PathIsContent().Should().BeTrue();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.PathIsContent(Microsoft.AspNetCore.Http.HttpRequest)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_PathIsContent_False()
    {
        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Path = new Microsoft.AspNetCore.Http.PathString("/path");
        httpContext.Request.PathIsContent().Should().BeFalse();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetBaseUri(Microsoft.AspNetCore.Http.HttpRequest)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetBaseUri_Request_Null()
    {
        Microsoft.AspNetCore.Http.HttpRequest request = null;
        Action action = () => request.GetBaseUri();
        action.Should().ThrowIfNull();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetBaseUri(Microsoft.AspNetCore.Http.HttpRequest?)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetBaseUri()
    {
        // Ignore Spelling: https
        // Ignore Spelling: localhost

        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Scheme = "https";
        httpContext.Request.Host = new Microsoft.AspNetCore.Http.HostString("localhost", 1001);
        httpContext.Request.GetBaseUri().AbsoluteUri.Should().Be("https://localhost:1001/");
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetRestProblemDetailsType(Microsoft.AspNetCore.Http.HttpRequest, string)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetRestProblemDetailsType_Request_Null()
    {
        Microsoft.AspNetCore.Http.HttpRequest request = null;
        Action action = () => request.GetRestProblemDetailsType("Error");
        action.Should().ThrowIfNull();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetRestProblemDetailsType(Microsoft.AspNetCore.Http.HttpRequest, string)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetRestProblemDetailsType_ErrorCode_NullOrWhiteSpace()
    {
        // Ignore Spelling: https
        // Ignore Spelling: localhost

        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Scheme = "https";
        httpContext.Request.Host = new Microsoft.AspNetCore.Http.HostString("localhost");
        Action<string> action = (x) => httpContext.Request.GetRestProblemDetailsType(x);
        action.Should().ThrowIfNullOrWhiteSpace();
    }

    /// <summary>
    /// Tests the <see cref="ExtensionMethods.GetRestProblemDetailsType(Microsoft.AspNetCore.Http.HttpRequest, string)"/> method.
    /// </summary>
    [Fact]
    public void ExtensionMethods_GetRestProblemDetailsType()
    {
        // Ignore Spelling: https
        // Ignore Spelling: localhost

        Microsoft.AspNetCore.Http.HttpContext httpContext = new Microsoft.AspNetCore.Http.DefaultHttpContext();
        httpContext.Request.Scheme = "https";
        httpContext.Request.Host = new Microsoft.AspNetCore.Http.HostString("localhost");
        string result = httpContext.Request.GetRestProblemDetailsType("Error");
        result.Should().Be("https://localhost/.doc/restapi/errors/Error");
    }

    #endregion

    #endregion
}

#endregion

#endregion
