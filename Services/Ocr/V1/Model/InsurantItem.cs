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
    public class InsurantItem 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insurant_name", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail InsurantName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insurant_sex", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail InsurantSex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insurant_birthday", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail InsurantBirthday { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insurant_id_type", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail InsurantIdType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insurant_id_number", NullValueHandling = NullValueHandling.Ignore)]
        public InsurancePolicyDetail InsurantIdNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsurantItem {\n");
            sb.Append("  insurantName: ").Append(InsurantName).Append("\n");
            sb.Append("  insurantSex: ").Append(InsurantSex).Append("\n");
            sb.Append("  insurantBirthday: ").Append(InsurantBirthday).Append("\n");
            sb.Append("  insurantIdType: ").Append(InsurantIdType).Append("\n");
            sb.Append("  insurantIdNumber: ").Append(InsurantIdNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InsurantItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InsurantItem input)
        {
            if (input == null) return false;
            if (this.InsurantName != input.InsurantName || (this.InsurantName != null && !this.InsurantName.Equals(input.InsurantName))) return false;
            if (this.InsurantSex != input.InsurantSex || (this.InsurantSex != null && !this.InsurantSex.Equals(input.InsurantSex))) return false;
            if (this.InsurantBirthday != input.InsurantBirthday || (this.InsurantBirthday != null && !this.InsurantBirthday.Equals(input.InsurantBirthday))) return false;
            if (this.InsurantIdType != input.InsurantIdType || (this.InsurantIdType != null && !this.InsurantIdType.Equals(input.InsurantIdType))) return false;
            if (this.InsurantIdNumber != input.InsurantIdNumber || (this.InsurantIdNumber != null && !this.InsurantIdNumber.Equals(input.InsurantIdNumber))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.InsurantName != null) hashCode = hashCode * 59 + this.InsurantName.GetHashCode();
                if (this.InsurantSex != null) hashCode = hashCode * 59 + this.InsurantSex.GetHashCode();
                if (this.InsurantBirthday != null) hashCode = hashCode * 59 + this.InsurantBirthday.GetHashCode();
                if (this.InsurantIdType != null) hashCode = hashCode * 59 + this.InsurantIdType.GetHashCode();
                if (this.InsurantIdNumber != null) hashCode = hashCode * 59 + this.InsurantIdNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
