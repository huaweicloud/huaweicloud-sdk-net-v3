using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelArtsAgencyRequest 
    {

        /// <summary>
        /// 委托名称后缀。  长度不大于50位。  委托名称前缀固定为ma_agency。  如该字段为iam-user01，则创建出来的委托名称为ma_agency_iam-user01。  默认为空，表示创建名称为modelarts_agency的委托。
        /// </summary>
        [JsonProperty("agency_name_suffix", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyNameSuffix { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelArtsAgencyRequest {\n");
            sb.Append("  agencyNameSuffix: ").Append(AgencyNameSuffix).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelArtsAgencyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModelArtsAgencyRequest input)
        {
            if (input == null) return false;
            if (this.AgencyNameSuffix != input.AgencyNameSuffix || (this.AgencyNameSuffix != null && !this.AgencyNameSuffix.Equals(input.AgencyNameSuffix))) return false;

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
                if (this.AgencyNameSuffix != null) hashCode = hashCode * 59 + this.AgencyNameSuffix.GetHashCode();
                return hashCode;
            }
        }
    }
}
