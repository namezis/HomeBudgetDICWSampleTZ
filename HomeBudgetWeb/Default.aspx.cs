using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeBudget.Web
{
    public partial class Default : System.Web.UI.Page
    {

        protected void AccountDataSource_ObjectCreating(object sender, ObjectDataSourceEventArgs e)
        {
            e.ObjectInstance = Ioc.Container.Resolve<Domain.Services.AccountService>();
        }

        protected void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Domain.Entities.Account account = new Domain.Entities.Account();
                account.AccountName = txtAccountName.Text;
                Ioc.Container.Resolve<Domain.Services.AccountService>().AddAccount(account);

                // Refresh from data source
                gvAccount.DataBind();                
            }
            catch (Exception ex)
            {
                lblAddNewAccountError.Visible = true;
                lblAddNewAccountError.Text = ex.Message;

            }
        }

        protected void ReceiptDataSource_ObjectCreating(object sender, ObjectDataSourceEventArgs e)
        {
            e.ObjectInstance = Ioc.Container.Resolve<Domain.Services.ReceiptService>();
        }

        protected void btnAddNewReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                Domain.Entities.Receipt receipt = new Domain.Entities.Receipt();

                decimal convertAmount = 0;
                if (decimal.TryParse(txtReceiptAmount.Text, out convertAmount))
                {
                    receipt.Amount = convertAmount;
                }
                else
                {
                    throw new ArgumentException("Invalid amount");
                }

                receipt.Description = txtReceiptDescription.Text.Trim();                
                 
                Ioc.Container.Resolve<Domain.Services.ReceiptService>().AddReceipt(receipt);

                // Refresh from data source
                gvReceipt.DataBind();
            }
            catch (Exception ex)
            {
                lblAddNewReceiptError.Visible = true;
                lblAddNewReceiptError.Text = ex.Message;

            }
        }        
    }
}