﻿using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Configuration;

namespace Nop.Plugin.Payments.VivaWallet
{
   public class VivaSettings : ISettings
    {
        public string VivaWalletEndPoint { get; set; }

        public string ApiKey { get; set; }

        public string ApiPassword { get; set; }

        public string SourceCode { get; set; }

        public string VivaCheckoutUrl { get; set; }
        public Guid MerchantId { get; set; }
        public string BaseApiUrl { get; set; }
        public string PaymentsUrl { get; set; }
        public string PaymentsCreateOrderUrl { get; set; }
        public string PublicKey { get; set; }
    }
}
