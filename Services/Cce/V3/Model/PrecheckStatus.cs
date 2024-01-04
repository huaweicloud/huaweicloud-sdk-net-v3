using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 升级前检查状态
    /// </summary>
    public class PrecheckStatus 
    {

        /// <summary>
        /// 状态，取值如下 - Init: 初始化 - Running 运行中 - Success 成功 - Failed 失败 - Error 错误
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// 检查结果过期时间
        /// </summary>
        [JsonProperty("expireTimeStamp", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTimeStamp { get; set; }

        /// <summary>
        /// 信息，一般是执行错误的日志信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("clusterCheckStatus", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterCheckStatus ClusterCheckStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("addonCheckStatus", NullValueHandling = NullValueHandling.Ignore)]
        public AddonCheckStatus AddonCheckStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeCheckStatus", NullValueHandling = NullValueHandling.Ignore)]
        public NodeCheckStatus NodeCheckStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrecheckStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  expireTimeStamp: ").Append(ExpireTimeStamp).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  clusterCheckStatus: ").Append(ClusterCheckStatus).Append("\n");
            sb.Append("  addonCheckStatus: ").Append(AddonCheckStatus).Append("\n");
            sb.Append("  nodeCheckStatus: ").Append(NodeCheckStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrecheckStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrecheckStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
                ) && 
                (
                    this.ExpireTimeStamp == input.ExpireTimeStamp ||
                    (this.ExpireTimeStamp != null &&
                    this.ExpireTimeStamp.Equals(input.ExpireTimeStamp))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ClusterCheckStatus == input.ClusterCheckStatus ||
                    (this.ClusterCheckStatus != null &&
                    this.ClusterCheckStatus.Equals(input.ClusterCheckStatus))
                ) && 
                (
                    this.AddonCheckStatus == input.AddonCheckStatus ||
                    (this.AddonCheckStatus != null &&
                    this.AddonCheckStatus.Equals(input.AddonCheckStatus))
                ) && 
                (
                    this.NodeCheckStatus == input.NodeCheckStatus ||
                    (this.NodeCheckStatus != null &&
                    this.NodeCheckStatus.Equals(input.NodeCheckStatus))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.ExpireTimeStamp != null)
                    hashCode = hashCode * 59 + this.ExpireTimeStamp.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ClusterCheckStatus != null)
                    hashCode = hashCode * 59 + this.ClusterCheckStatus.GetHashCode();
                if (this.AddonCheckStatus != null)
                    hashCode = hashCode * 59 + this.AddonCheckStatus.GetHashCode();
                if (this.NodeCheckStatus != null)
                    hashCode = hashCode * 59 + this.NodeCheckStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
