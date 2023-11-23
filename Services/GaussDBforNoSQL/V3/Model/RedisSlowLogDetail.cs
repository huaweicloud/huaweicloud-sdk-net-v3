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
    public class RedisSlowLogDetail 
    {

        /// <summary>
        /// 节点名称。
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// 节点ID。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 执行语句。
        /// </summary>
        [JsonProperty("whole_message", NullValueHandling = NullValueHandling.Ignore)]
        public string WholeMessage { get; set; }

        /// <summary>
        /// 语句类型。
        /// </summary>
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        /// 执行时间。单位：ms
        /// </summary>
        [JsonProperty("cost_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? CostTime { get; set; }

        /// <summary>
        /// 日志产生时间，UTC时间。 格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("log_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTime { get; set; }

        /// <summary>
        /// 日志单行序列号
        /// </summary>
        [JsonProperty("line_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedisSlowLogDetail {\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  wholeMessage: ").Append(WholeMessage).Append("\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("  costTime: ").Append(CostTime).Append("\n");
            sb.Append("  logTime: ").Append(LogTime).Append("\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RedisSlowLogDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RedisSlowLogDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeName == input.NodeName ||
                    (this.NodeName != null &&
                    this.NodeName.Equals(input.NodeName))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.WholeMessage == input.WholeMessage ||
                    (this.WholeMessage != null &&
                    this.WholeMessage.Equals(input.WholeMessage))
                ) && 
                (
                    this.OperateType == input.OperateType ||
                    (this.OperateType != null &&
                    this.OperateType.Equals(input.OperateType))
                ) && 
                (
                    this.CostTime == input.CostTime ||
                    (this.CostTime != null &&
                    this.CostTime.Equals(input.CostTime))
                ) && 
                (
                    this.LogTime == input.LogTime ||
                    (this.LogTime != null &&
                    this.LogTime.Equals(input.LogTime))
                ) && 
                (
                    this.LineNum == input.LineNum ||
                    (this.LineNum != null &&
                    this.LineNum.Equals(input.LineNum))
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
                if (this.NodeName != null)
                    hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.WholeMessage != null)
                    hashCode = hashCode * 59 + this.WholeMessage.GetHashCode();
                if (this.OperateType != null)
                    hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                if (this.CostTime != null)
                    hashCode = hashCode * 59 + this.CostTime.GetHashCode();
                if (this.LogTime != null)
                    hashCode = hashCode * 59 + this.LogTime.GetHashCode();
                if (this.LineNum != null)
                    hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
