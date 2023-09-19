using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AcceptanceBillResult 
    {

        /// <summary>
        /// 出票日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 汇票到期日。 
        /// </summary>
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public string DueDate { get; set; }

        /// <summary>
        /// 票据状态。 
        /// </summary>
        [JsonProperty("bill_status", NullValueHandling = NullValueHandling.Ignore)]
        public string BillStatus { get; set; }

        /// <summary>
        /// 票据号码。 
        /// </summary>
        [JsonProperty("bill_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BillNumber { get; set; }

        /// <summary>
        /// 出票人全称。 
        /// </summary>
        [JsonProperty("issuer_full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerFullName { get; set; }

        /// <summary>
        /// 出票人账号。 
        /// </summary>
        [JsonProperty("issuer_account", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerAccount { get; set; }

        /// <summary>
        /// 出票人开户银行。 
        /// </summary>
        [JsonProperty("issuer_bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerBankName { get; set; }

        /// <summary>
        /// 出票人开户行号。 
        /// </summary>
        [JsonProperty("issuer_bank_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerBankNumber { get; set; }

        /// <summary>
        /// 收款人全称。 
        /// </summary>
        [JsonProperty("payee_full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PayeeFullName { get; set; }

        /// <summary>
        /// 收款人账号。 
        /// </summary>
        [JsonProperty("payee_account", NullValueHandling = NullValueHandling.Ignore)]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 收款人开户银行。 
        /// </summary>
        [JsonProperty("payee_bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 收款人开户行号。 
        /// </summary>
        [JsonProperty("payee_bank_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PayeeBankNumber { get; set; }

        /// <summary>
        /// 出票保证人名称。 
        /// </summary>
        [JsonProperty("issuance_guarantor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuanceGuarantorName { get; set; }

        /// <summary>
        /// 出票保证人地址。 
        /// </summary>
        [JsonProperty("issuance_guarantor_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuanceGuarantorAddress { get; set; }

        /// <summary>
        /// 出票保证人账号。 
        /// </summary>
        [JsonProperty("issuance_guarantor_account", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuanceGuarantorAccount { get; set; }

        /// <summary>
        /// 出票保证日期。 
        /// </summary>
        [JsonProperty("issuance_guarantee_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuanceGuaranteeDate { get; set; }

        /// <summary>
        /// 出票保证人开户行行号。 
        /// </summary>
        [JsonProperty("issuance_guarantor_bank_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuanceGuarantorBankNumber { get; set; }

        /// <summary>
        /// 出票保证人开户行名称。 
        /// </summary>
        [JsonProperty("issuance_guarantor_bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuanceGuarantorBankName { get; set; }

        /// <summary>
        /// 大写票据金额。 
        /// </summary>
        [JsonProperty("amount_in_words", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountInWords { get; set; }

        /// <summary>
        /// 小写票据金额。 
        /// </summary>
        [JsonProperty("amount_in_figures", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountInFigures { get; set; }

        /// <summary>
        /// 承兑人全称。 
        /// </summary>
        [JsonProperty("acceptor_full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptorFullName { get; set; }

        /// <summary>
        /// 承兑人账号。 
        /// </summary>
        [JsonProperty("acceptor_account", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptorAccount { get; set; }

        /// <summary>
        /// 承兑人开户行行号。 
        /// </summary>
        [JsonProperty("acceptor_bank_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptorBankNumber { get; set; }

        /// <summary>
        /// 承兑人开户行名称。 
        /// </summary>
        [JsonProperty("acceptor_bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptorBankName { get; set; }

        /// <summary>
        /// 交易合同号。 
        /// </summary>
        [JsonProperty("contract_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractNumber { get; set; }

        /// <summary>
        /// 能否转让。 
        /// </summary>
        [JsonProperty("assignability", NullValueHandling = NullValueHandling.Ignore)]
        public string Assignability { get; set; }

        /// <summary>
        /// 出票人承诺。 
        /// </summary>
        [JsonProperty("issuer_commitment", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerCommitment { get; set; }

        /// <summary>
        /// 承兑人承诺。 
        /// </summary>
        [JsonProperty("acceptor_commitment", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptorCommitment { get; set; }

        /// <summary>
        /// 承兑日期。 
        /// </summary>
        [JsonProperty("acceptance_date", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 承兑保证人名称。 
        /// </summary>
        [JsonProperty("acceptance_guarantor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptanceGuarantorName { get; set; }

        /// <summary>
        /// 承兑保证人地址。 
        /// </summary>
        [JsonProperty("acceptance_guarantor_address", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptanceGuarantorAddress { get; set; }

        /// <summary>
        /// 承兑保证人账号。 
        /// </summary>
        [JsonProperty("acceptance_guarantor_account", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptanceGuarantorAccount { get; set; }

        /// <summary>
        /// 承兑保证日期。 
        /// </summary>
        [JsonProperty("acceptance_guarantee_date", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptanceGuaranteeDate { get; set; }

        /// <summary>
        /// 承兑保证人开户行行号。 
        /// </summary>
        [JsonProperty("acceptance_guarantor_bank_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptanceGuarantorBankNumber { get; set; }

        /// <summary>
        /// 承兑保证人开户行名称。 
        /// </summary>
        [JsonProperty("acceptance_guarantor_bank_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptanceGuarantorBankName { get; set; }

        /// <summary>
        /// 出票人评级主体。 
        /// </summary>
        [JsonProperty("issuer_rating_entity", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerRatingEntity { get; set; }

        /// <summary>
        /// 出票人信用等级。 
        /// </summary>
        [JsonProperty("issuer_credit_rating", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerCreditRating { get; set; }

        /// <summary>
        /// 出票人评级到期日。 
        /// </summary>
        [JsonProperty("issuer_rating_due_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerRatingDueDate { get; set; }

        /// <summary>
        /// 承兑人评级主体。 
        /// </summary>
        [JsonProperty("acceptor_rating_entity", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptorRatingEntity { get; set; }

        /// <summary>
        /// 承兑人信用等级。 
        /// </summary>
        [JsonProperty("acceptor_credit_rating", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptorCreditRating { get; set; }

        /// <summary>
        /// 承兑人评级到期日。 
        /// </summary>
        [JsonProperty("acceptor_rating_due_date", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptorRatingDueDate { get; set; }

        /// <summary>
        /// 票据包号。 
        /// </summary>
        [JsonProperty("bill_package_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BillPackageNumber { get; set; }

        /// <summary>
        /// 备注。   
        /// </summary>
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }

        /// <summary>
        /// 各个字段的置信度。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcceptanceBillResult {\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  dueDate: ").Append(DueDate).Append("\n");
            sb.Append("  billStatus: ").Append(BillStatus).Append("\n");
            sb.Append("  billNumber: ").Append(BillNumber).Append("\n");
            sb.Append("  issuerFullName: ").Append(IssuerFullName).Append("\n");
            sb.Append("  issuerAccount: ").Append(IssuerAccount).Append("\n");
            sb.Append("  issuerBankName: ").Append(IssuerBankName).Append("\n");
            sb.Append("  issuerBankNumber: ").Append(IssuerBankNumber).Append("\n");
            sb.Append("  payeeFullName: ").Append(PayeeFullName).Append("\n");
            sb.Append("  payeeAccount: ").Append(PayeeAccount).Append("\n");
            sb.Append("  payeeBankName: ").Append(PayeeBankName).Append("\n");
            sb.Append("  payeeBankNumber: ").Append(PayeeBankNumber).Append("\n");
            sb.Append("  issuanceGuarantorName: ").Append(IssuanceGuarantorName).Append("\n");
            sb.Append("  issuanceGuarantorAddress: ").Append(IssuanceGuarantorAddress).Append("\n");
            sb.Append("  issuanceGuarantorAccount: ").Append(IssuanceGuarantorAccount).Append("\n");
            sb.Append("  issuanceGuaranteeDate: ").Append(IssuanceGuaranteeDate).Append("\n");
            sb.Append("  issuanceGuarantorBankNumber: ").Append(IssuanceGuarantorBankNumber).Append("\n");
            sb.Append("  issuanceGuarantorBankName: ").Append(IssuanceGuarantorBankName).Append("\n");
            sb.Append("  amountInWords: ").Append(AmountInWords).Append("\n");
            sb.Append("  amountInFigures: ").Append(AmountInFigures).Append("\n");
            sb.Append("  acceptorFullName: ").Append(AcceptorFullName).Append("\n");
            sb.Append("  acceptorAccount: ").Append(AcceptorAccount).Append("\n");
            sb.Append("  acceptorBankNumber: ").Append(AcceptorBankNumber).Append("\n");
            sb.Append("  acceptorBankName: ").Append(AcceptorBankName).Append("\n");
            sb.Append("  contractNumber: ").Append(ContractNumber).Append("\n");
            sb.Append("  assignability: ").Append(Assignability).Append("\n");
            sb.Append("  issuerCommitment: ").Append(IssuerCommitment).Append("\n");
            sb.Append("  acceptorCommitment: ").Append(AcceptorCommitment).Append("\n");
            sb.Append("  acceptanceDate: ").Append(AcceptanceDate).Append("\n");
            sb.Append("  acceptanceGuarantorName: ").Append(AcceptanceGuarantorName).Append("\n");
            sb.Append("  acceptanceGuarantorAddress: ").Append(AcceptanceGuarantorAddress).Append("\n");
            sb.Append("  acceptanceGuarantorAccount: ").Append(AcceptanceGuarantorAccount).Append("\n");
            sb.Append("  acceptanceGuaranteeDate: ").Append(AcceptanceGuaranteeDate).Append("\n");
            sb.Append("  acceptanceGuarantorBankNumber: ").Append(AcceptanceGuarantorBankNumber).Append("\n");
            sb.Append("  acceptanceGuarantorBankName: ").Append(AcceptanceGuarantorBankName).Append("\n");
            sb.Append("  issuerRatingEntity: ").Append(IssuerRatingEntity).Append("\n");
            sb.Append("  issuerCreditRating: ").Append(IssuerCreditRating).Append("\n");
            sb.Append("  issuerRatingDueDate: ").Append(IssuerRatingDueDate).Append("\n");
            sb.Append("  acceptorRatingEntity: ").Append(AcceptorRatingEntity).Append("\n");
            sb.Append("  acceptorCreditRating: ").Append(AcceptorCreditRating).Append("\n");
            sb.Append("  acceptorRatingDueDate: ").Append(AcceptorRatingDueDate).Append("\n");
            sb.Append("  billPackageNumber: ").Append(BillPackageNumber).Append("\n");
            sb.Append("  remarks: ").Append(Remarks).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AcceptanceBillResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AcceptanceBillResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.BillStatus == input.BillStatus ||
                    (this.BillStatus != null &&
                    this.BillStatus.Equals(input.BillStatus))
                ) && 
                (
                    this.BillNumber == input.BillNumber ||
                    (this.BillNumber != null &&
                    this.BillNumber.Equals(input.BillNumber))
                ) && 
                (
                    this.IssuerFullName == input.IssuerFullName ||
                    (this.IssuerFullName != null &&
                    this.IssuerFullName.Equals(input.IssuerFullName))
                ) && 
                (
                    this.IssuerAccount == input.IssuerAccount ||
                    (this.IssuerAccount != null &&
                    this.IssuerAccount.Equals(input.IssuerAccount))
                ) && 
                (
                    this.IssuerBankName == input.IssuerBankName ||
                    (this.IssuerBankName != null &&
                    this.IssuerBankName.Equals(input.IssuerBankName))
                ) && 
                (
                    this.IssuerBankNumber == input.IssuerBankNumber ||
                    (this.IssuerBankNumber != null &&
                    this.IssuerBankNumber.Equals(input.IssuerBankNumber))
                ) && 
                (
                    this.PayeeFullName == input.PayeeFullName ||
                    (this.PayeeFullName != null &&
                    this.PayeeFullName.Equals(input.PayeeFullName))
                ) && 
                (
                    this.PayeeAccount == input.PayeeAccount ||
                    (this.PayeeAccount != null &&
                    this.PayeeAccount.Equals(input.PayeeAccount))
                ) && 
                (
                    this.PayeeBankName == input.PayeeBankName ||
                    (this.PayeeBankName != null &&
                    this.PayeeBankName.Equals(input.PayeeBankName))
                ) && 
                (
                    this.PayeeBankNumber == input.PayeeBankNumber ||
                    (this.PayeeBankNumber != null &&
                    this.PayeeBankNumber.Equals(input.PayeeBankNumber))
                ) && 
                (
                    this.IssuanceGuarantorName == input.IssuanceGuarantorName ||
                    (this.IssuanceGuarantorName != null &&
                    this.IssuanceGuarantorName.Equals(input.IssuanceGuarantorName))
                ) && 
                (
                    this.IssuanceGuarantorAddress == input.IssuanceGuarantorAddress ||
                    (this.IssuanceGuarantorAddress != null &&
                    this.IssuanceGuarantorAddress.Equals(input.IssuanceGuarantorAddress))
                ) && 
                (
                    this.IssuanceGuarantorAccount == input.IssuanceGuarantorAccount ||
                    (this.IssuanceGuarantorAccount != null &&
                    this.IssuanceGuarantorAccount.Equals(input.IssuanceGuarantorAccount))
                ) && 
                (
                    this.IssuanceGuaranteeDate == input.IssuanceGuaranteeDate ||
                    (this.IssuanceGuaranteeDate != null &&
                    this.IssuanceGuaranteeDate.Equals(input.IssuanceGuaranteeDate))
                ) && 
                (
                    this.IssuanceGuarantorBankNumber == input.IssuanceGuarantorBankNumber ||
                    (this.IssuanceGuarantorBankNumber != null &&
                    this.IssuanceGuarantorBankNumber.Equals(input.IssuanceGuarantorBankNumber))
                ) && 
                (
                    this.IssuanceGuarantorBankName == input.IssuanceGuarantorBankName ||
                    (this.IssuanceGuarantorBankName != null &&
                    this.IssuanceGuarantorBankName.Equals(input.IssuanceGuarantorBankName))
                ) && 
                (
                    this.AmountInWords == input.AmountInWords ||
                    (this.AmountInWords != null &&
                    this.AmountInWords.Equals(input.AmountInWords))
                ) && 
                (
                    this.AmountInFigures == input.AmountInFigures ||
                    (this.AmountInFigures != null &&
                    this.AmountInFigures.Equals(input.AmountInFigures))
                ) && 
                (
                    this.AcceptorFullName == input.AcceptorFullName ||
                    (this.AcceptorFullName != null &&
                    this.AcceptorFullName.Equals(input.AcceptorFullName))
                ) && 
                (
                    this.AcceptorAccount == input.AcceptorAccount ||
                    (this.AcceptorAccount != null &&
                    this.AcceptorAccount.Equals(input.AcceptorAccount))
                ) && 
                (
                    this.AcceptorBankNumber == input.AcceptorBankNumber ||
                    (this.AcceptorBankNumber != null &&
                    this.AcceptorBankNumber.Equals(input.AcceptorBankNumber))
                ) && 
                (
                    this.AcceptorBankName == input.AcceptorBankName ||
                    (this.AcceptorBankName != null &&
                    this.AcceptorBankName.Equals(input.AcceptorBankName))
                ) && 
                (
                    this.ContractNumber == input.ContractNumber ||
                    (this.ContractNumber != null &&
                    this.ContractNumber.Equals(input.ContractNumber))
                ) && 
                (
                    this.Assignability == input.Assignability ||
                    (this.Assignability != null &&
                    this.Assignability.Equals(input.Assignability))
                ) && 
                (
                    this.IssuerCommitment == input.IssuerCommitment ||
                    (this.IssuerCommitment != null &&
                    this.IssuerCommitment.Equals(input.IssuerCommitment))
                ) && 
                (
                    this.AcceptorCommitment == input.AcceptorCommitment ||
                    (this.AcceptorCommitment != null &&
                    this.AcceptorCommitment.Equals(input.AcceptorCommitment))
                ) && 
                (
                    this.AcceptanceDate == input.AcceptanceDate ||
                    (this.AcceptanceDate != null &&
                    this.AcceptanceDate.Equals(input.AcceptanceDate))
                ) && 
                (
                    this.AcceptanceGuarantorName == input.AcceptanceGuarantorName ||
                    (this.AcceptanceGuarantorName != null &&
                    this.AcceptanceGuarantorName.Equals(input.AcceptanceGuarantorName))
                ) && 
                (
                    this.AcceptanceGuarantorAddress == input.AcceptanceGuarantorAddress ||
                    (this.AcceptanceGuarantorAddress != null &&
                    this.AcceptanceGuarantorAddress.Equals(input.AcceptanceGuarantorAddress))
                ) && 
                (
                    this.AcceptanceGuarantorAccount == input.AcceptanceGuarantorAccount ||
                    (this.AcceptanceGuarantorAccount != null &&
                    this.AcceptanceGuarantorAccount.Equals(input.AcceptanceGuarantorAccount))
                ) && 
                (
                    this.AcceptanceGuaranteeDate == input.AcceptanceGuaranteeDate ||
                    (this.AcceptanceGuaranteeDate != null &&
                    this.AcceptanceGuaranteeDate.Equals(input.AcceptanceGuaranteeDate))
                ) && 
                (
                    this.AcceptanceGuarantorBankNumber == input.AcceptanceGuarantorBankNumber ||
                    (this.AcceptanceGuarantorBankNumber != null &&
                    this.AcceptanceGuarantorBankNumber.Equals(input.AcceptanceGuarantorBankNumber))
                ) && 
                (
                    this.AcceptanceGuarantorBankName == input.AcceptanceGuarantorBankName ||
                    (this.AcceptanceGuarantorBankName != null &&
                    this.AcceptanceGuarantorBankName.Equals(input.AcceptanceGuarantorBankName))
                ) && 
                (
                    this.IssuerRatingEntity == input.IssuerRatingEntity ||
                    (this.IssuerRatingEntity != null &&
                    this.IssuerRatingEntity.Equals(input.IssuerRatingEntity))
                ) && 
                (
                    this.IssuerCreditRating == input.IssuerCreditRating ||
                    (this.IssuerCreditRating != null &&
                    this.IssuerCreditRating.Equals(input.IssuerCreditRating))
                ) && 
                (
                    this.IssuerRatingDueDate == input.IssuerRatingDueDate ||
                    (this.IssuerRatingDueDate != null &&
                    this.IssuerRatingDueDate.Equals(input.IssuerRatingDueDate))
                ) && 
                (
                    this.AcceptorRatingEntity == input.AcceptorRatingEntity ||
                    (this.AcceptorRatingEntity != null &&
                    this.AcceptorRatingEntity.Equals(input.AcceptorRatingEntity))
                ) && 
                (
                    this.AcceptorCreditRating == input.AcceptorCreditRating ||
                    (this.AcceptorCreditRating != null &&
                    this.AcceptorCreditRating.Equals(input.AcceptorCreditRating))
                ) && 
                (
                    this.AcceptorRatingDueDate == input.AcceptorRatingDueDate ||
                    (this.AcceptorRatingDueDate != null &&
                    this.AcceptorRatingDueDate.Equals(input.AcceptorRatingDueDate))
                ) && 
                (
                    this.BillPackageNumber == input.BillPackageNumber ||
                    (this.BillPackageNumber != null &&
                    this.BillPackageNumber.Equals(input.BillPackageNumber))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.BillStatus != null)
                    hashCode = hashCode * 59 + this.BillStatus.GetHashCode();
                if (this.BillNumber != null)
                    hashCode = hashCode * 59 + this.BillNumber.GetHashCode();
                if (this.IssuerFullName != null)
                    hashCode = hashCode * 59 + this.IssuerFullName.GetHashCode();
                if (this.IssuerAccount != null)
                    hashCode = hashCode * 59 + this.IssuerAccount.GetHashCode();
                if (this.IssuerBankName != null)
                    hashCode = hashCode * 59 + this.IssuerBankName.GetHashCode();
                if (this.IssuerBankNumber != null)
                    hashCode = hashCode * 59 + this.IssuerBankNumber.GetHashCode();
                if (this.PayeeFullName != null)
                    hashCode = hashCode * 59 + this.PayeeFullName.GetHashCode();
                if (this.PayeeAccount != null)
                    hashCode = hashCode * 59 + this.PayeeAccount.GetHashCode();
                if (this.PayeeBankName != null)
                    hashCode = hashCode * 59 + this.PayeeBankName.GetHashCode();
                if (this.PayeeBankNumber != null)
                    hashCode = hashCode * 59 + this.PayeeBankNumber.GetHashCode();
                if (this.IssuanceGuarantorName != null)
                    hashCode = hashCode * 59 + this.IssuanceGuarantorName.GetHashCode();
                if (this.IssuanceGuarantorAddress != null)
                    hashCode = hashCode * 59 + this.IssuanceGuarantorAddress.GetHashCode();
                if (this.IssuanceGuarantorAccount != null)
                    hashCode = hashCode * 59 + this.IssuanceGuarantorAccount.GetHashCode();
                if (this.IssuanceGuaranteeDate != null)
                    hashCode = hashCode * 59 + this.IssuanceGuaranteeDate.GetHashCode();
                if (this.IssuanceGuarantorBankNumber != null)
                    hashCode = hashCode * 59 + this.IssuanceGuarantorBankNumber.GetHashCode();
                if (this.IssuanceGuarantorBankName != null)
                    hashCode = hashCode * 59 + this.IssuanceGuarantorBankName.GetHashCode();
                if (this.AmountInWords != null)
                    hashCode = hashCode * 59 + this.AmountInWords.GetHashCode();
                if (this.AmountInFigures != null)
                    hashCode = hashCode * 59 + this.AmountInFigures.GetHashCode();
                if (this.AcceptorFullName != null)
                    hashCode = hashCode * 59 + this.AcceptorFullName.GetHashCode();
                if (this.AcceptorAccount != null)
                    hashCode = hashCode * 59 + this.AcceptorAccount.GetHashCode();
                if (this.AcceptorBankNumber != null)
                    hashCode = hashCode * 59 + this.AcceptorBankNumber.GetHashCode();
                if (this.AcceptorBankName != null)
                    hashCode = hashCode * 59 + this.AcceptorBankName.GetHashCode();
                if (this.ContractNumber != null)
                    hashCode = hashCode * 59 + this.ContractNumber.GetHashCode();
                if (this.Assignability != null)
                    hashCode = hashCode * 59 + this.Assignability.GetHashCode();
                if (this.IssuerCommitment != null)
                    hashCode = hashCode * 59 + this.IssuerCommitment.GetHashCode();
                if (this.AcceptorCommitment != null)
                    hashCode = hashCode * 59 + this.AcceptorCommitment.GetHashCode();
                if (this.AcceptanceDate != null)
                    hashCode = hashCode * 59 + this.AcceptanceDate.GetHashCode();
                if (this.AcceptanceGuarantorName != null)
                    hashCode = hashCode * 59 + this.AcceptanceGuarantorName.GetHashCode();
                if (this.AcceptanceGuarantorAddress != null)
                    hashCode = hashCode * 59 + this.AcceptanceGuarantorAddress.GetHashCode();
                if (this.AcceptanceGuarantorAccount != null)
                    hashCode = hashCode * 59 + this.AcceptanceGuarantorAccount.GetHashCode();
                if (this.AcceptanceGuaranteeDate != null)
                    hashCode = hashCode * 59 + this.AcceptanceGuaranteeDate.GetHashCode();
                if (this.AcceptanceGuarantorBankNumber != null)
                    hashCode = hashCode * 59 + this.AcceptanceGuarantorBankNumber.GetHashCode();
                if (this.AcceptanceGuarantorBankName != null)
                    hashCode = hashCode * 59 + this.AcceptanceGuarantorBankName.GetHashCode();
                if (this.IssuerRatingEntity != null)
                    hashCode = hashCode * 59 + this.IssuerRatingEntity.GetHashCode();
                if (this.IssuerCreditRating != null)
                    hashCode = hashCode * 59 + this.IssuerCreditRating.GetHashCode();
                if (this.IssuerRatingDueDate != null)
                    hashCode = hashCode * 59 + this.IssuerRatingDueDate.GetHashCode();
                if (this.AcceptorRatingEntity != null)
                    hashCode = hashCode * 59 + this.AcceptorRatingEntity.GetHashCode();
                if (this.AcceptorCreditRating != null)
                    hashCode = hashCode * 59 + this.AcceptorCreditRating.GetHashCode();
                if (this.AcceptorRatingDueDate != null)
                    hashCode = hashCode * 59 + this.AcceptorRatingDueDate.GetHashCode();
                if (this.BillPackageNumber != null)
                    hashCode = hashCode * 59 + this.BillPackageNumber.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
