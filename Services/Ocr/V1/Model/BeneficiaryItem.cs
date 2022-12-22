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
    public class BeneficiaryItem 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("beneficiary_name", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail BeneficiaryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("beneficiary_type", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail BeneficiaryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("beneficiary_order", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail BeneficiaryOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("beneficiary_share", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail BeneficiaryShare { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeneficiaryItem {\n");
            sb.Append("  beneficiaryName: ").Append(BeneficiaryName).Append("\n");
            sb.Append("  beneficiaryType: ").Append(BeneficiaryType).Append("\n");
            sb.Append("  beneficiaryOrder: ").Append(BeneficiaryOrder).Append("\n");
            sb.Append("  beneficiaryShare: ").Append(BeneficiaryShare).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BeneficiaryItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BeneficiaryItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BeneficiaryName == input.BeneficiaryName ||
                    (this.BeneficiaryName != null &&
                    this.BeneficiaryName.Equals(input.BeneficiaryName))
                ) && 
                (
                    this.BeneficiaryType == input.BeneficiaryType ||
                    (this.BeneficiaryType != null &&
                    this.BeneficiaryType.Equals(input.BeneficiaryType))
                ) && 
                (
                    this.BeneficiaryOrder == input.BeneficiaryOrder ||
                    (this.BeneficiaryOrder != null &&
                    this.BeneficiaryOrder.Equals(input.BeneficiaryOrder))
                ) && 
                (
                    this.BeneficiaryShare == input.BeneficiaryShare ||
                    (this.BeneficiaryShare != null &&
                    this.BeneficiaryShare.Equals(input.BeneficiaryShare))
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
                if (this.BeneficiaryName != null)
                    hashCode = hashCode * 59 + this.BeneficiaryName.GetHashCode();
                if (this.BeneficiaryType != null)
                    hashCode = hashCode * 59 + this.BeneficiaryType.GetHashCode();
                if (this.BeneficiaryOrder != null)
                    hashCode = hashCode * 59 + this.BeneficiaryOrder.GetHashCode();
                if (this.BeneficiaryShare != null)
                    hashCode = hashCode * 59 + this.BeneficiaryShare.GetHashCode();
                return hashCode;
            }
        }
    }
}
