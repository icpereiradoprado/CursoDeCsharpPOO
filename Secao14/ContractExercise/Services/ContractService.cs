using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContractExercise.Entities;

namespace ContractExercise.Services
{
    class ContractService
    {
        private IOnlinePaymentsService _onlinePaymentsService;

        public ContractService(IOnlinePaymentsService onlinePaymentsService)
        {
            _onlinePaymentsService = onlinePaymentsService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.ContractValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentsService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePaymentsService.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
