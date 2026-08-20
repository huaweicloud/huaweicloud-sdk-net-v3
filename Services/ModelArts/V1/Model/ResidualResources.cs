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
    public class ResidualResources 
    {

        /// <summary>
        /// **参数解释：** 负载均衡器监听器ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("elb_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ElbListenerId { get; set; }

        /// <summary>
        /// **参数解释：** 后端服务器组ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("elb_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ElbPoolId { get; set; }

        /// <summary>
        /// **参数解释：** 终端节点ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("vpcep_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcepId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResidualResources {\n");
            sb.Append("  elbListenerId: ").Append(ElbListenerId).Append("\n");
            sb.Append("  elbPoolId: ").Append(ElbPoolId).Append("\n");
            sb.Append("  vpcepId: ").Append(VpcepId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResidualResources);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResidualResources input)
        {
            if (input == null) return false;
            if (this.ElbListenerId != input.ElbListenerId || (this.ElbListenerId != null && !this.ElbListenerId.Equals(input.ElbListenerId))) return false;
            if (this.ElbPoolId != input.ElbPoolId || (this.ElbPoolId != null && !this.ElbPoolId.Equals(input.ElbPoolId))) return false;
            if (this.VpcepId != input.VpcepId || (this.VpcepId != null && !this.VpcepId.Equals(input.VpcepId))) return false;

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
                if (this.ElbListenerId != null) hashCode = hashCode * 59 + this.ElbListenerId.GetHashCode();
                if (this.ElbPoolId != null) hashCode = hashCode * 59 + this.ElbPoolId.GetHashCode();
                if (this.VpcepId != null) hashCode = hashCode * 59 + this.VpcepId.GetHashCode();
                return hashCode;
            }
        }
    }
}
