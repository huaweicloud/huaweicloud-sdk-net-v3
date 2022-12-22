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
    public class InsuranceItem 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insurance_name", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail InsuranceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insurance_period", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail InsurancePeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insurance_amount", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail InsuranceAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("payment_frequency", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail PaymentFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("payment_period", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail PaymentPeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("payment_amount", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail PaymentAmount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsuranceItem {\n");
            sb.Append("  insuranceName: ").Append(InsuranceName).Append("\n");
            sb.Append("  insurancePeriod: ").Append(InsurancePeriod).Append("\n");
            sb.Append("  insuranceAmount: ").Append(InsuranceAmount).Append("\n");
            sb.Append("  paymentFrequency: ").Append(PaymentFrequency).Append("\n");
            sb.Append("  paymentPeriod: ").Append(PaymentPeriod).Append("\n");
            sb.Append("  paymentAmount: ").Append(PaymentAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InsuranceItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InsuranceItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InsuranceName == input.InsuranceName ||
                    (this.InsuranceName != null &&
                    this.InsuranceName.Equals(input.InsuranceName))
                ) && 
                (
                    this.InsurancePeriod == input.InsurancePeriod ||
                    (this.InsurancePeriod != null &&
                    this.InsurancePeriod.Equals(input.InsurancePeriod))
                ) && 
                (
                    this.InsuranceAmount == input.InsuranceAmount ||
                    (this.InsuranceAmount != null &&
                    this.InsuranceAmount.Equals(input.InsuranceAmount))
                ) && 
                (
                    this.PaymentFrequency == input.PaymentFrequency ||
                    (this.PaymentFrequency != null &&
                    this.PaymentFrequency.Equals(input.PaymentFrequency))
                ) && 
                (
                    this.PaymentPeriod == input.PaymentPeriod ||
                    (this.PaymentPeriod != null &&
                    this.PaymentPeriod.Equals(input.PaymentPeriod))
                ) && 
                (
                    this.PaymentAmount == input.PaymentAmount ||
                    (this.PaymentAmount != null &&
                    this.PaymentAmount.Equals(input.PaymentAmount))
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
                if (this.InsuranceName != null)
                    hashCode = hashCode * 59 + this.InsuranceName.GetHashCode();
                if (this.InsurancePeriod != null)
                    hashCode = hashCode * 59 + this.InsurancePeriod.GetHashCode();
                if (this.InsuranceAmount != null)
                    hashCode = hashCode * 59 + this.InsuranceAmount.GetHashCode();
                if (this.PaymentFrequency != null)
                    hashCode = hashCode * 59 + this.PaymentFrequency.GetHashCode();
                if (this.PaymentPeriod != null)
                    hashCode = hashCode * 59 + this.PaymentPeriod.GetHashCode();
                if (this.PaymentAmount != null)
                    hashCode = hashCode * 59 + this.PaymentAmount.GetHashCode();
                return hashCode;
            }
        }
    }
}
