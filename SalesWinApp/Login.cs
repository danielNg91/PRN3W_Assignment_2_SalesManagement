using DataAccess.Context;

namespace SalesWinApp;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        /**
         * Test DbContext
         */

        /*var _db = (new SaleManagementContext()).Members;
        btnLogin.Text = _db.FirstOrDefault().Email;*/
    }
}
