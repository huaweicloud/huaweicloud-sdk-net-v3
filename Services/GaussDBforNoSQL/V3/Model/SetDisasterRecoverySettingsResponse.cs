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
    public class SetDisasterRecoverySettingsResponse : SdkResponse
    {

        /// <summary>
        /// 设置容灾切换故障节点比例成功的实例列表。
        /// </summary>
        [JsonProperty("successed_instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SuccessedInstanceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetDisasterRecoverySettingsResponse {\n");
            sb.Append("  successedInstanceIds: ").Append(SuccessedInstanceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetDisasterRecoverySettingsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetDisasterRecoverySettingsResponse input)
        {
            if (input == null) return false;
            if (this.SuccessedInstanceIds != input.SuccessedInstanceIds || (this.SuccessedInstanceIds != null && input.SuccessedInstanceIds != null && !this.SuccessedInstanceIds.SequenceEqual(input.SuccessedInstanceIds))) return false;

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
                if (this.SuccessedInstanceIds != null) hashCode = hashCode * 59 + this.SuccessedInstanceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
