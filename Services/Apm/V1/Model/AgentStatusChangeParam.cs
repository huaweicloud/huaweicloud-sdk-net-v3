using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 改变探针状态的参数。
    /// </summary>
    public class AgentStatusChangeParam 
    {

        /// <summary>
        /// 探针实例id列表。
        /// </summary>
        [JsonProperty("instance_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> InstanceList { get; set; }

        /// <summary>
        /// 期望探针改变后的状态，0或1，0表示启用，1表示停用。
        /// </summary>
        [JsonProperty("target_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetStatus { get; set; }

        /// <summary>
        /// 探针所在的区域。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 探针所属环境的id。
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentStatusChangeParam {\n");
            sb.Append("  instanceList: ").Append(InstanceList).Append("\n");
            sb.Append("  targetStatus: ").Append(TargetStatus).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentStatusChangeParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentStatusChangeParam input)
        {
            if (input == null) return false;
            if (this.InstanceList != input.InstanceList || (this.InstanceList != null && input.InstanceList != null && !this.InstanceList.SequenceEqual(input.InstanceList))) return false;
            if (this.TargetStatus != input.TargetStatus || (this.TargetStatus != null && !this.TargetStatus.Equals(input.TargetStatus))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;

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
                if (this.InstanceList != null) hashCode = hashCode * 59 + this.InstanceList.GetHashCode();
                if (this.TargetStatus != null) hashCode = hashCode * 59 + this.TargetStatus.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                return hashCode;
            }
        }
    }
}
