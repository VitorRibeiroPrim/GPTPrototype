﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

// Ignore Spelling: ao
// Ignore Spelling: cv
// Ignore Spelling: mz
// Ignore Spelling: ie
// Ignore Spelling: gb
// Ignore Spelling: ar
// Ignore Spelling: mx
// Ignore Spelling: ro
// Ignore Spelling: lu

namespace Primavera.Lithium.ChatGPT.Server.Common.Localization;

#region Code

#region Public Classes

/// <summary>
/// Defines the cultures supported by the service.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
public static partial class CulturesSupported
{
    #region Code

    #region Public Constants

    /// <summary>
    /// The Portuguese base culture.
    /// </summary>
    public const string PortugueseBaseCulture = "pt";

    /// <summary>
    /// The Portuguese culture.
    /// </summary>
    public const string PortugueseDefaultCulture = PortugueseFromPortugalCulture;

    /// <summary>
    /// The Portuguese (Angola) culture.
    /// </summary>
    public const string PortugueseFromAngolaCulture = "pt-ao";

    /// <summary>
    /// The Portuguese (Cape Verde) culture.
    /// </summary>
    public const string PortugueseFromCapeVerdeCulture = "pt-cv";

    /// <summary>
    /// The Portuguese (Mozambique) culture.
    /// </summary>
    public const string PortugueseFromMozambiqueCulture = "pt-mz";

    /// <summary>
    /// The Portuguese (Portugal) culture.
    /// </summary>
    public const string PortugueseFromPortugalCulture = "pt-pt";

    /// <summary>
    /// The English base culture.
    /// </summary>
    public const string EnglishBaseCulture = "en";

    /// <summary>
    /// The English default culture.
    /// </summary>
    public const string EnglishDefaultCulture = EnglishFromUnitedStatesCulture;

    /// <summary>
    /// The English (Ireland) culture.
    /// </summary>
    public const string EnglishFromIrelandCulture = "en-ie";

    /// <summary>
    /// The English (G.B.) culture.
    /// </summary>
    public const string EnglishFromGreatBritainCulture = "en-gb";

    /// <summary>
    /// The English (U.S.) culture.
    /// </summary>
    public const string EnglishFromUnitedStatesCulture = "en-us";

    /// <summary>
    /// The English (Canada) culture.
    /// </summary>
    public const string EnglishFromCanadaCulture = "en-ca";

    /// <summary>
    /// The Spanish base culture.
    /// </summary>
    public const string SpanishBaseCulture = "es";

    /// <summary>
    /// The Spanish default culture.
    /// </summary>
    public const string SpanishDefaultCulture = SpanishFromSpainCulture;

    /// <summary>
    /// The Spanish (Argentina) culture.
    /// </summary>
    public const string SpanishFromArgentinaCulture = "es-ar";

    /// <summary>
    /// The Spanish (Chile) culture.
    /// </summary>
    public const string SpanishFromChileCulture = "es-cl";

    /// <summary>
    /// The Spanish (Mexico) culture.
    /// </summary>
    public const string SpanishFromMexicoCulture = "es-mx";

    /// <summary>
    /// The Spanish (Spain) culture.
    /// </summary>
    public const string SpanishFromSpainCulture = "es-es";

    /// <summary>
    /// The Catalan base culture.
    /// </summary>
    public const string CatalanBaseCulture = "ca";

    /// <summary>
    /// The Catalan default culture.
    /// </summary>
    public const string CatalanDefaultCulture = CatalanFromSpainCulture;

    /// <summary>
    /// The Catalan (Spain) culture.
    /// </summary>
    public const string CatalanFromSpainCulture = "ca-es";

    /// <summary>
    /// The Italian base culture.
    /// </summary>
    public const string ItalianBaseCulture = "it";

    /// <summary>
    /// The Italian default culture.
    /// </summary>
    public const string ItalianDefaultCulture = ItalianFromItalyCulture;

    /// <summary>
    /// The Italian (Italy) culture.
    /// </summary>
    public const string ItalianFromItalyCulture = "it-it";

    /// <summary>
    /// The Italian (Switzerland) culture.
    /// </summary>
    public const string ItalianFromSwitzerlandCulture = "it-ch";

    /// <summary>
    /// The Romanian base culture.
    /// </summary>
    public const string RomanianBaseCulture = "ro";

    /// <summary>
    /// The Romanian default culture.
    /// </summary>
    public const string RomanianDefaultCulture = RomanianFromRomaniaCulture;

    /// <summary>
    /// The Romanian (Romania) culture.
    /// </summary>
    public const string RomanianFromRomaniaCulture = "ro-ro";

    /// <summary>
    /// The French base culture.
    /// </summary>
    public const string FrenchBaseCulture = "fr";

    /// <summary>
    /// The French default culture.
    /// </summary>
    public const string FrenchDefaultCulture = FrenchFromFranceCulture;

    /// <summary>
    /// The French (France) culture.
    /// </summary>
    public const string FrenchFromFranceCulture = "fr-fr";

    /// <summary>
    /// The French (Belgium) culture.
    /// </summary>
    public const string FrenchFromBelgiumCulture = "fr-be";

    /// <summary>
    /// The French (Canada) culture.
    /// </summary>
    public const string FrenchFromCanadaCulture = "fr-ca";

    /// <summary>
    /// The French (Switzerland) culture.
    /// </summary>
    public const string FrenchFromLuxembourgCulture = "fr-lu";

    /// <summary>
    /// The French (Luxembourg) culture.
    /// </summary>
    public const string FrenchFromSwitzerlandCulture = "fr-ch";

    #endregion

    #region Private Fields

    private static CulturesInstance instance = new CulturesInstance();

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets the default culture.
    /// </summary>
    public static string DefaultCulture => Instance.DefaultCulture.DefaultInstance!;

    #endregion

    #region Private Properties

    /// <summary>
    /// Gets the instance
    /// </summary>
    private static CulturesInstance Instance => instance;

    #endregion

    #region Public Methods

    /// <summary>
    /// Gets the supported cultures.
    /// </summary>
    /// <param name="includeBaseCultures">A value indicating whether the base cultures should be included in the result.</param>
    /// <param name="includeInstanceCultures">A value indicating whether the instance cultures should be included in the result.</param>
    /// <returns>
    /// The supported cultures.
    /// </returns>
    public static System.Collections.Generic.IEnumerable<string> Get(bool includeBaseCultures = true, bool includeInstanceCultures = true)
    {
        System.Collections.Generic.List<string> result = new System.Collections.Generic.List<string>();
    
        foreach (ExtendedCultureInfo info in Instance.SupportedCultures)
        {
            if (includeBaseCultures && !string.IsNullOrEmpty(info.BaseCulture))
            {
                result.Add(info.BaseCulture);
            }

            if (includeInstanceCultures && info.Instances != null)
            {
                result.AddRange(info.Instances);
            }
        }

        return result;
    }

    /// <summary>
    /// Get the base culture for the specified culture.
    /// </summary>
    /// <param name="culture">The culture.</param>
    /// <returns>
    /// The base culture.
    /// </returns>
    public static string ToBaseCulture(string? culture)
    {
        if (!string.IsNullOrWhiteSpace(culture))
        {
            foreach (ExtendedCultureInfo info in Instance.SupportedCultures)
            {
                if (culture.EqualsNoCase(info.BaseCulture))
                {
                    return info.BaseCulture!;
                }

                if (culture.EqualsAnyNoCase(info.Instances))
                {
                    return info.BaseCulture!;
                }

                if (culture.StartsWithNoCase(info.BaseCulture + "-"))
                {
                    return info.BaseCulture!;
                }
            }
        }

        return Instance.DefaultCulture.BaseCulture!;
    }

    /// <summary>
    /// Get the default culture for the specified culture.
    /// </summary>
    /// <param name="culture">The culture.</param>
    /// <returns>
    /// The default culture.
    /// </returns>
    public static string ToDefaultCulture(string? culture)
    {
        if (!string.IsNullOrWhiteSpace(culture))
        {
            foreach (ExtendedCultureInfo info in Instance.SupportedCultures)
            {
                if (culture.EqualsNoCase(info.BaseCulture))
                {
                    return info.DefaultInstance!;
                }

                if (culture.EqualsAnyNoCase(info.Instances))
                {
                    return info.DefaultInstance!;
                }

                if (culture.StartsWithNoCase(info.BaseCulture + "-"))
                {
                    return info.DefaultInstance!;
                }
            }
        }

        return Instance.DefaultCulture.DefaultInstance!;
    }

    /// <summary>
    /// Converts the specified culture to one of the supported cultures.
    /// </summary>
    /// <param name="culture">The culture.</param>
    /// <param name="includeBaseCultures">A value indicating whether the base cultures should be considered.</param>
    /// <param name="includeInstanceCultures">A value indicating whether the instance cultures should be considered.</param>
    /// <returns>
    /// The supported culture.
    /// </returns>
    public static string ToSupportedCulture(string? culture, bool includeBaseCultures = true, bool includeInstanceCultures = true)
    {
        if (!string.IsNullOrWhiteSpace(culture))
        {
            System.Collections.Generic.IEnumerable<string> cultures = Get(includeBaseCultures, includeInstanceCultures);

            if (culture.EqualsAnyNoCase(cultures))
            {
                return culture.Transform().ToLowerCase()!;
            }

            foreach (ExtendedCultureInfo info in Instance.SupportedCultures)
            {
                if (culture.EqualsNoCase(info.BaseCulture) || culture.StartsWithNoCase(info.BaseCulture + "-"))
                {
                    return info.DefaultInstance!;
                }
            }
        }

        return DefaultCulture;
    }

    #endregion

    #endregion
}

#endregion

#region Internal Classes

/// <summary>
/// Provides extended information about a culture.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
internal partial class ExtendedCultureInfo
{
    #region Code

    #region Internal Properties

    /// <summary>
    /// Gets the base culture (e.g. 'pt').
    /// </summary>
    [System.Diagnostics.CodeAnalysis.MaybeNull]
    internal string BaseCulture
    {
        get;
        set;
    }

    /// <summary>
    /// Gets the default culture instance (e.g. 'pt-PT').
    /// </summary>
    [System.Diagnostics.CodeAnalysis.MaybeNull]
    internal string DefaultInstance
    {
        get;
        set;
    }

    /// <summary>
    /// Gets the culture instances (e.g. 'pt-PT', 'pt-AO', etc.).
    /// </summary>
    [System.Diagnostics.CodeAnalysis.MaybeNull]
    internal System.Collections.Generic.IEnumerable<string> Instances
    {
        get;
        set;
    }

    #endregion

    #endregion
}

/// <summary>
/// Defines the base class of the instance class that allows overriding the behavior of <see cref="CulturesSupported"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
internal abstract partial class CulturesInstanceBase
{
    #region Code

    #region Internal Properties

    /// <summary>
    /// Gets the list of the supported cultures.
    /// </summary>
    internal virtual System.Collections.Generic.IEnumerable<ExtendedCultureInfo> SupportedCultures
    {
        get
        {
            return new ExtendedCultureInfo[]
            {
                new ExtendedCultureInfo()
                {
                    BaseCulture = CulturesSupported.EnglishBaseCulture,
                    DefaultInstance =  CulturesSupported.EnglishDefaultCulture,
                    Instances = new System.Collections.Generic.List<string>()
                    {
                        CulturesSupported.EnglishFromIrelandCulture,
                        CulturesSupported.EnglishFromGreatBritainCulture,
                        CulturesSupported.EnglishFromUnitedStatesCulture,
                        CulturesSupported.EnglishFromCanadaCulture
                    }
                },
                new ExtendedCultureInfo()
                {
                    BaseCulture = CulturesSupported.PortugueseBaseCulture,
                    DefaultInstance =  CulturesSupported.PortugueseDefaultCulture,
                    Instances = new System.Collections.Generic.List<string>()
                    {
                        CulturesSupported.PortugueseFromAngolaCulture,
                        CulturesSupported.PortugueseFromCapeVerdeCulture,
                        CulturesSupported.PortugueseFromMozambiqueCulture,
                        CulturesSupported.PortugueseFromPortugalCulture
                    }
                },
                new ExtendedCultureInfo()
                {
                    BaseCulture = CulturesSupported.SpanishBaseCulture,
                    DefaultInstance =  CulturesSupported.SpanishDefaultCulture,
                    Instances = new System.Collections.Generic.List<string>()
                    {
                        CulturesSupported.SpanishFromArgentinaCulture,
                        CulturesSupported.SpanishFromChileCulture,
                        CulturesSupported.SpanishFromMexicoCulture,
                        CulturesSupported.SpanishFromSpainCulture
                    }
                },
                new ExtendedCultureInfo()
                {
                    BaseCulture = CulturesSupported.CatalanBaseCulture,
                    DefaultInstance =  CulturesSupported.CatalanDefaultCulture,
                    Instances = new System.Collections.Generic.List<string>()
                    {
                        CulturesSupported.CatalanFromSpainCulture
                    }
                },
                new ExtendedCultureInfo()
                {
                    BaseCulture = CulturesSupported.ItalianBaseCulture,
                    DefaultInstance =  CulturesSupported.ItalianDefaultCulture,
                    Instances = new System.Collections.Generic.List<string>()
                    {
                        CulturesSupported.ItalianFromItalyCulture,
                        CulturesSupported.ItalianFromSwitzerlandCulture
                    }
                },
                new ExtendedCultureInfo()
                {
                    BaseCulture = CulturesSupported.RomanianBaseCulture,
                    DefaultInstance =  CulturesSupported.RomanianDefaultCulture,
                    Instances = new System.Collections.Generic.List<string>()
                    {
                        CulturesSupported.RomanianFromRomaniaCulture
                    }
                },
                new ExtendedCultureInfo()
                {
                    BaseCulture = CulturesSupported.FrenchBaseCulture,
                    DefaultInstance =  CulturesSupported.FrenchDefaultCulture,
                    Instances = new System.Collections.Generic.List<string>()
                    {
                        CulturesSupported.FrenchFromFranceCulture,
                        CulturesSupported.FrenchFromBelgiumCulture,
                        CulturesSupported.FrenchFromCanadaCulture,
                        CulturesSupported.FrenchFromLuxembourgCulture,
                        CulturesSupported.FrenchFromSwitzerlandCulture
                    }
                }
            };
        }
    }

    /// <summary>
    /// Gets the default culture.
    /// </summary>
    internal virtual ExtendedCultureInfo DefaultCulture
    {
        get
        {
            return SupportedCultures
                .FirstOrDefault(i => i.BaseCulture.EqualsNoCase(CulturesSupported.EnglishBaseCulture))!;
        }
    }

    #endregion

    #region Protected Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="CulturesInstanceBase"/> class.
    /// </summary>
    protected CulturesInstanceBase()
    {
    }

    #endregion

    #endregion
}

/// <summary>
/// Defines the instance class that allows overriding the behavior of <see cref="CulturesSupported"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("Lithium", "5")]
internal partial class CulturesInstance : CulturesInstanceBase
{
    #region Code

    #region Internal Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="CulturesInstance"/> class.
    /// </summary>
    internal CulturesInstance()
    {
    }

    #endregion

    #endregion
}

#endregion

#endregion
