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
    /// 组件之间调用指向线。
    /// </summary>
    public class TxLine 
    {

        /// <summary>
        /// 开始节点。
        /// </summary>
        [JsonProperty("tx_from_node", NullValueHandling = NullValueHandling.Ignore)]
        public string TxFromNode { get; set; }

        /// <summary>
        /// 结束节点。
        /// </summary>
        [JsonProperty("tx_to_node", NullValueHandling = NullValueHandling.Ignore)]
        public string TxToNode { get; set; }

        /// <summary>
        /// 调用次数。
        /// </summary>
        [JsonProperty("invoke_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? InvokeCount { get; set; }

        /// <summary>
        /// 平均响应时间。
        /// </summary>
        [JsonProperty("rt", NullValueHandling = NullValueHandling.Ignore)]
        public double? Rt { get; set; }

        /// <summary>
        /// 错误数。
        /// </summary>
        [JsonProperty("error_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ErrorCount { get; set; }

        /// <summary>
        /// 类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 指向。
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TxLine {\n");
            sb.Append("  txFromNode: ").Append(TxFromNode).Append("\n");
            sb.Append("  txToNode: ").Append(TxToNode).Append("\n");
            sb.Append("  invokeCount: ").Append(InvokeCount).Append("\n");
            sb.Append("  rt: ").Append(Rt).Append("\n");
            sb.Append("  errorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TxLine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TxLine input)
        {
            if (input == null) return false;
            if (this.TxFromNode != input.TxFromNode || (this.TxFromNode != null && !this.TxFromNode.Equals(input.TxFromNode))) return false;
            if (this.TxToNode != input.TxToNode || (this.TxToNode != null && !this.TxToNode.Equals(input.TxToNode))) return false;
            if (this.InvokeCount != input.InvokeCount || (this.InvokeCount != null && !this.InvokeCount.Equals(input.InvokeCount))) return false;
            if (this.Rt != input.Rt || (this.Rt != null && !this.Rt.Equals(input.Rt))) return false;
            if (this.ErrorCount != input.ErrorCount || (this.ErrorCount != null && !this.ErrorCount.Equals(input.ErrorCount))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;

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
                if (this.TxFromNode != null) hashCode = hashCode * 59 + this.TxFromNode.GetHashCode();
                if (this.TxToNode != null) hashCode = hashCode * 59 + this.TxToNode.GetHashCode();
                if (this.InvokeCount != null) hashCode = hashCode * 59 + this.InvokeCount.GetHashCode();
                if (this.Rt != null) hashCode = hashCode * 59 + this.Rt.GetHashCode();
                if (this.ErrorCount != null) hashCode = hashCode * 59 + this.ErrorCount.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                return hashCode;
            }
        }
    }
}
