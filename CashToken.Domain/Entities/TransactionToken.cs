using CashToken.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CashToken.Domain.Entities
{
    public class TransactionToken: BaseEntity
    {
        public TransactionToken()
        {

            this.Status = Status.Active;
        }
        [Required]
        public string SourceAccount { get; set; }
        [Required]
        public string BeneficiaryNumber { get; set; }
        [Required]
        public string DepositorNumber { get; set; }
        [Required]
        public decimal? Amount { get; set; }
        [Required]
        public string Token { get; set; }
        [Required]
        public Status Status { get; set; }
    }
}
