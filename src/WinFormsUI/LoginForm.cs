using SUTH.HealthCheckup.WinFormsUI.Interfaces;

namespace SUTH.HealthCheckup.WinFormsUI;
public partial class LoginForm : Form
{
    private readonly IAuthenticationService _authenticationService;
    private CancellationTokenSource _cancellationTokenSource;
    private bool _isAuthenticating = false;
    public bool IsLoginSuccessful { get; private set; }
    public LoginForm(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
        InitializeComponent();
        this.Shown += LoginForm_Shown;
    }

    private async Task PerformAuthenticationAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (_authenticationService.IsAuthenticated && _authenticationService.CurrentUser != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var token = await _authenticationService.GetAccessTokenAsync(cancellationToken);
                if (!string.IsNullOrEmpty(token))
                {
                    IsLoginSuccessful = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }
            
            cancellationToken.ThrowIfCancellationRequested();
            IsLoginSuccessful = await _authenticationService.LoginAsync(cancellationToken);
            if (IsLoginSuccessful)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }
        catch (OperationCanceledException ex)
        {
            System.Diagnostics.Debug.WriteLine($"Authentication was cancelled! with message {ex.Message}");
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Authentication failed: {ex.Message}",
                "Authentication Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        _cancellationTokenSource.Cancel();
    }

    private async void LoginForm_Shown(object sender, EventArgs e)
    {
        if (_isAuthenticating) return;
        _isAuthenticating = true;
        _cancellationTokenSource = new CancellationTokenSource();
        await PerformAuthenticationAsync(_cancellationTokenSource.Token);
    }
}
