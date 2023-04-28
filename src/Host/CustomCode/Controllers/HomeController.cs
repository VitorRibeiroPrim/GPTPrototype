namespace Primavera.Lithium.ChatGPT.Server.Host.Controllers;

/// <content/>
public partial class HomeController
{
    #region Public Methods

    /// <inheritdoc/>
    public override Task<IActionResult> IndexAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult<IActionResult>(
            this.View("~/CustomCode/Views/Index.cshtml"));
    }

    #endregion
}
