using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("transactions")]
    public class Transaction : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string type { get; set; }
        public string document_number { get; set; }
        public string description { get; set; }
        public string comment { get; set; }
        public float value { get; set; }
        public bool paid { get; set; }
        public string payment_plan { get; set; } // recurrent, one_time, installment
        public bool split { get; set; }
        public bool has_nf { get; set; }
        public bool has_boleto { get; set; }
        public bool has_attachment { get; set; }
        // OS CAMPOS FREQUENCY SÃO USADOS PARA TRANSAÇÕES RECORRENTES OU PARCELAMENTOS
        public int frequency_main_id { get; set; } // ID da Transação Principal, Ex.: Se a Transação atual é marcada como recorrente ou parcelamento e seu Id é 1014, então o campo FrequencyMainId será 1014 já que a frequência atual é também a principal
        public int frequency_number { get; set; } // NÚMERO DA FREQUÊNCIA, EX.: 1, 2, 3...
        public int frequency_total { get; set; } // QUANTITATIVO DE PARCELAS NO CASO DE PARCELAMENTO.
        public string frequency_type { get; set; } // TIPO DE FREQUÊNCIA, Ex.: SEMANAL, QUINZENAL, MENSAL, BIMESTRAL, TRIMESTRAL, SEMESTRAL OU ANUAL.
        public int transaction_category_id { get; set; }

        [ForeignKey("transaction_category_id")]
        public TransactionCategory transaction_category { get; set; }
        public int cost_center_id { get; set; }

        [ForeignKey("cost_center_id")]
        public CostCenter cost_center { get; set; }
        public int contact_id { get; set; }

        [ForeignKey("contact_id")]
        public Contact contact { get; set; } // Recebido de | Pago a
        public int account_id { get; set; }
        
        [ForeignKey("account_id")]
        public Account account { get; set; }
        public int payment_type_id { get; set; }

        [ForeignKey("payment_type_id")]
        public PaymentType payment_type { get; set; }
        public ICollection<Split> splits { get; set; }
        public ICollection<Installment> installments { get; set; }
        public ICollection<Attachment> attachments { get; set; }
        public ICollection<Tag> tags { get; set; }
        public DateTime pay_date { get; set; }
        public DateTime due_date { get; set; }
    }
}
