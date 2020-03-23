using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    public class PaymentService
    {
        public bool Change(PaymentAccount paymentAccount, float amount)
        {
            if (paymentAccount == null)
                return false;
            return paymentAccount.Charge(amount);
        }

        public void Fund(PaymentAccount paymentAccount, float amount)
        {
            if (paymentAccount == null)
                return;
            paymentAccount.Fund(amount);
        }
    }
}
