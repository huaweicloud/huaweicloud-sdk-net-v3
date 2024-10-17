using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 预调配模板设备策略资源详情结构体。
    /// </summary>
    public class PolicyResource 
    {

        /// <summary>
        /// **参数说明**：设备需要绑定的策略id列表
        /// </summary>
        [JsonProperty("policy_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PolicyIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyResource {\n");
            sb.Append("  policyIds: ").Append(PolicyIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyResource input)
        {
            if (input == null) return false;
            if (this.PolicyIds != input.PolicyIds || (this.PolicyIds != null && input.PolicyIds != null && !this.PolicyIds.SequenceEqual(input.PolicyIds))) return false;

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
                if (this.PolicyIds != null) hashCode = hashCode * 59 + this.PolicyIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
