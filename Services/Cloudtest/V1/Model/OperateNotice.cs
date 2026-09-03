using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OperateNotice 
    {

        /// <summary>
        /// 发送告警渠道
        /// </summary>
        [JsonProperty("alert_channel", NullValueHandling = NullValueHandling.Ignore)]
        public string AlertChannel { get; set; }

        /// <summary>
        /// 操作通知 0 关闭 1开启
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public string Enable { get; set; }

        /// <summary>
        /// 通知组列表
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlertGroup> Groups { get; set; }

        /// <summary>
        /// 通知类型列表
        /// </summary>
        [JsonProperty("operateTypes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OperateTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateNotice {\n");
            sb.Append("  alertChannel: ").Append(AlertChannel).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("  operateTypes: ").Append(OperateTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateNotice);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateNotice input)
        {
            if (input == null) return false;
            if (this.AlertChannel != input.AlertChannel || (this.AlertChannel != null && !this.AlertChannel.Equals(input.AlertChannel))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.Groups != input.Groups || (this.Groups != null && input.Groups != null && !this.Groups.SequenceEqual(input.Groups))) return false;
            if (this.OperateTypes != input.OperateTypes || (this.OperateTypes != null && input.OperateTypes != null && !this.OperateTypes.SequenceEqual(input.OperateTypes))) return false;

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
                if (this.AlertChannel != null) hashCode = hashCode * 59 + this.AlertChannel.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Groups != null) hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.OperateTypes != null) hashCode = hashCode * 59 + this.OperateTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
