using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 创建单个任务请求体。
    /// </summary>
    public class CreateJobReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("base_info", NullValueHandling = NullValueHandling.Ignore)]
        public JobBaseInfo BaseInfo { get; set; }

        /// <summary>
        /// 创建任务数据库信息体。
        /// </summary>
        [JsonProperty("source_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobEndpointInfo> SourceEndpoint { get; set; }

        /// <summary>
        /// 创建任务数据库信息体。
        /// </summary>
        [JsonProperty("target_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobEndpointInfo> TargetEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("period_order", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodOrderInfo PeriodOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("node_info", NullValueHandling = NullValueHandling.Ignore)]
        public JobNodeInfo NodeInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateJobReq {\n");
            sb.Append("  baseInfo: ").Append(BaseInfo).Append("\n");
            sb.Append("  sourceEndpoint: ").Append(SourceEndpoint).Append("\n");
            sb.Append("  targetEndpoint: ").Append(TargetEndpoint).Append("\n");
            sb.Append("  periodOrder: ").Append(PeriodOrder).Append("\n");
            sb.Append("  nodeInfo: ").Append(NodeInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateJobReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseInfo == input.BaseInfo ||
                    (this.BaseInfo != null &&
                    this.BaseInfo.Equals(input.BaseInfo))
                ) && 
                (
                    this.SourceEndpoint == input.SourceEndpoint ||
                    this.SourceEndpoint != null &&
                    input.SourceEndpoint != null &&
                    this.SourceEndpoint.SequenceEqual(input.SourceEndpoint)
                ) && 
                (
                    this.TargetEndpoint == input.TargetEndpoint ||
                    this.TargetEndpoint != null &&
                    input.TargetEndpoint != null &&
                    this.TargetEndpoint.SequenceEqual(input.TargetEndpoint)
                ) && 
                (
                    this.PeriodOrder == input.PeriodOrder ||
                    (this.PeriodOrder != null &&
                    this.PeriodOrder.Equals(input.PeriodOrder))
                ) && 
                (
                    this.NodeInfo == input.NodeInfo ||
                    (this.NodeInfo != null &&
                    this.NodeInfo.Equals(input.NodeInfo))
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
                if (this.BaseInfo != null)
                    hashCode = hashCode * 59 + this.BaseInfo.GetHashCode();
                if (this.SourceEndpoint != null)
                    hashCode = hashCode * 59 + this.SourceEndpoint.GetHashCode();
                if (this.TargetEndpoint != null)
                    hashCode = hashCode * 59 + this.TargetEndpoint.GetHashCode();
                if (this.PeriodOrder != null)
                    hashCode = hashCode * 59 + this.PeriodOrder.GetHashCode();
                if (this.NodeInfo != null)
                    hashCode = hashCode * 59 + this.NodeInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
