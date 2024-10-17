using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ivs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IdcardResult 
    {

        /// <summary>
        /// 身份证上识别的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 身份证号。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 性别。
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 出生日期。
        /// </summary>
        [JsonProperty("birth", NullValueHandling = NullValueHandling.Ignore)]
        public string Birth { get; set; }

        /// <summary>
        /// 民族。
        /// </summary>
        [JsonProperty("ethnicity", NullValueHandling = NullValueHandling.Ignore)]
        public string Ethnicity { get; set; }

        /// <summary>
        /// 地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 发证机关。
        /// </summary>
        [JsonProperty("issue", NullValueHandling = NullValueHandling.Ignore)]
        public string Issue { get; set; }

        /// <summary>
        /// 有效起始日期。
        /// </summary>
        [JsonProperty("valid_from", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidFrom { get; set; }

        /// <summary>
        /// 有效结束日期。
        /// </summary>
        [JsonProperty("valid_to", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidTo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdcardResult {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  birth: ").Append(Birth).Append("\n");
            sb.Append("  ethnicity: ").Append(Ethnicity).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  issue: ").Append(Issue).Append("\n");
            sb.Append("  validFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  validTo: ").Append(ValidTo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdcardResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdcardResult input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Sex != input.Sex || (this.Sex != null && !this.Sex.Equals(input.Sex))) return false;
            if (this.Birth != input.Birth || (this.Birth != null && !this.Birth.Equals(input.Birth))) return false;
            if (this.Ethnicity != input.Ethnicity || (this.Ethnicity != null && !this.Ethnicity.Equals(input.Ethnicity))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Issue != input.Issue || (this.Issue != null && !this.Issue.Equals(input.Issue))) return false;
            if (this.ValidFrom != input.ValidFrom || (this.ValidFrom != null && !this.ValidFrom.Equals(input.ValidFrom))) return false;
            if (this.ValidTo != input.ValidTo || (this.ValidTo != null && !this.ValidTo.Equals(input.ValidTo))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Sex != null) hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Birth != null) hashCode = hashCode * 59 + this.Birth.GetHashCode();
                if (this.Ethnicity != null) hashCode = hashCode * 59 + this.Ethnicity.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Issue != null) hashCode = hashCode * 59 + this.Issue.GetHashCode();
                if (this.ValidFrom != null) hashCode = hashCode * 59 + this.ValidFrom.GetHashCode();
                if (this.ValidTo != null) hashCode = hashCode * 59 + this.ValidTo.GetHashCode();
                return hashCode;
            }
        }
    }
}
