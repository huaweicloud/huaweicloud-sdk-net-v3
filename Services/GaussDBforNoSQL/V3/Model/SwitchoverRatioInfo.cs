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
    /// 
    /// </summary>
    public class SwitchoverRatioInfo 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 容灾切换的故障节点比例，下限是50，步长是10，最大是100，默认为100。
        /// </summary>
        [JsonProperty("switchover_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? SwitchoverRatio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchoverRatioInfo {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  switchoverRatio: ").Append(SwitchoverRatio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchoverRatioInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchoverRatioInfo input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.SwitchoverRatio != input.SwitchoverRatio || (this.SwitchoverRatio != null && !this.SwitchoverRatio.Equals(input.SwitchoverRatio))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.SwitchoverRatio != null) hashCode = hashCode * 59 + this.SwitchoverRatio.GetHashCode();
                return hashCode;
            }
        }
    }
}
