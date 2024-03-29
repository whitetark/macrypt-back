﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaCryptApi.Model
{
    public class Responses
    {
        public string AddressOfOwner { get; set; }
        public int NumOfTransactions { get; set; }
        public string TotalReceived { get; set; }
        public string TotalSent { get; set; }
        public string CurrentBalance { get; set; }
        public List<Transaction> Transactions { get; set; }

        public class Transaction
        {
            public string Hash { get; set; }
            public double Fee { get; set; }
            public string Time { get; set; }
            public double ResultOfTransaction { get; set; }
            public double BalanceAfter { get; set; }
        }
    }
}
