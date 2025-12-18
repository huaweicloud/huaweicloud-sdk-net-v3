using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SetAutoEnlargePolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 设置磁盘自动扩容策略失败的实例信息列表。 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("error_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<SetAutoPolicyErrorResults> ErrorResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetAutoEnlargePolicyResponse {\n");
            sb.Append("  errorResults: ").Append(ErrorResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetAutoEnlargePolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetAutoEnlargePolicyResponse input)
        {
            if (input == null) return false;
            if (this.ErrorResults != input.ErrorResults || (this.ErrorResults != null && input.ErrorResults != null && !this.ErrorResults.SequenceEqual(input.ErrorResults))) return false;

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
                if (this.ErrorResults != null) hashCode = hashCode * 59 + this.ErrorResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
