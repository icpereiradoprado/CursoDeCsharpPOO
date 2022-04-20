﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractExercise.Entities
{
    class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractValue { get; set; }

        public List<Installment> Installments { get; set; }


        public Contract(int contractNumber, DateTime contractDate, double contractValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            ContractValue = contractValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
