using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 解除实例容灾关系请求体
    /// </summary>
    public class DeleteDisasterRecoveryRequestBody 
    {

        /// <summary>
        /// 解除目标的实例id
        /// </summary>
        [JsonProperty("target_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// 解除目标的project id
        /// </summary>
        [JsonProperty("target_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetProjectId { get; set; }

        /// <summary>
        /// 解除目标的region
        /// </summary>
        [JsonProperty("target_region", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetRegion { get; set; }

        /// <summary>
        /// 解除目标的数据浮动ip
        /// </summary>
        [JsonProperty("target_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetIp { get; set; }

        /// <summary>
        /// 当前操作对象是否是主实例
        /// </summary>
        [JsonProperty("is_master", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMaster { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDisasterRecoveryRequestBody {\n");
            sb.Append("  targetInstanceId: ").Append(TargetInstanceId).Append("\n");
            sb.Append("  targetProjectId: ").Append(TargetProjectId).Append("\n");
            sb.Append("  targetRegion: ").Append(TargetRegion).Append("\n");
            sb.Append("  targetIp: ").Append(TargetIp).Append("\n");
            sb.Append("  isMaster: ").Append(IsMaster).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDisasterRecoveryRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDisasterRecoveryRequestBody input)
        {
            if (input == null) return false;
            if (this.TargetInstanceId != input.TargetInstanceId || (this.TargetInstanceId != null && !this.TargetInstanceId.Equals(input.TargetInstanceId))) return false;
            if (this.TargetProjectId != input.TargetProjectId || (this.TargetProjectId != null && !this.TargetProjectId.Equals(input.TargetProjectId))) return false;
            if (this.TargetRegion != input.TargetRegion || (this.TargetRegion != null && !this.TargetRegion.Equals(input.TargetRegion))) return false;
            if (this.TargetIp != input.TargetIp || (this.TargetIp != null && !this.TargetIp.Equals(input.TargetIp))) return false;
            if (this.IsMaster != input.IsMaster || (this.IsMaster != null && !this.IsMaster.Equals(input.IsMaster))) return false;

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
                if (this.TargetInstanceId != null) hashCode = hashCode * 59 + this.TargetInstanceId.GetHashCode();
                if (this.TargetProjectId != null) hashCode = hashCode * 59 + this.TargetProjectId.GetHashCode();
                if (this.TargetRegion != null) hashCode = hashCode * 59 + this.TargetRegion.GetHashCode();
                if (this.TargetIp != null) hashCode = hashCode * 59 + this.TargetIp.GetHashCode();
                if (this.IsMaster != null) hashCode = hashCode * 59 + this.IsMaster.GetHashCode();
                return hashCode;
            }
        }
    }
}
