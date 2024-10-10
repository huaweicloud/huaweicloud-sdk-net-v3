using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListWafQpsRequest 
    {

        /// <summary>
        /// 不传时代表全部域名
        /// </summary>
        [SDKProperty("domains", IsQuery = true)]
        [JsonProperty("domains", NullValueHandling = NullValueHandling.Ignore)]
        public string Domains { get; set; }

        /// <summary>
        /// 用于 QPS、带宽: 平均值 mean、峰值 peak;用于 响应状态码: 源站返回值 source 、高防返回值 proxy
        /// </summary>
        [SDKProperty("value_type", IsQuery = true)]
        [JsonProperty("value_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueType { get; set; }

        /// <summary>
        /// 开始时间（毫秒时间戳）
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间（毫秒时间戳）
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 枚举值：yesterday,today,3days,1week,1month 与开始结束时间不同时为空
        /// </summary>
        [SDKProperty("recent", IsQuery = true)]
        [JsonProperty("recent", NullValueHandling = NullValueHandling.Ignore)]
        public string Recent { get; set; }

        /// <summary>
        /// 实例类型，0-大陆，1-海外
        /// </summary>
        [SDKProperty("overseas_type", IsQuery = true)]
        [JsonProperty("overseas_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? OverseasType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWafQpsRequest {\n");
            sb.Append("  domains: ").Append(Domains).Append("\n");
            sb.Append("  valueType: ").Append(ValueType).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  recent: ").Append(Recent).Append("\n");
            sb.Append("  overseasType: ").Append(OverseasType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWafQpsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWafQpsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domains == input.Domains ||
                    (this.Domains != null &&
                    this.Domains.Equals(input.Domains))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Recent == input.Recent ||
                    (this.Recent != null &&
                    this.Recent.Equals(input.Recent))
                ) && 
                (
                    this.OverseasType == input.OverseasType ||
                    (this.OverseasType != null &&
                    this.OverseasType.Equals(input.OverseasType))
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
                if (this.Domains != null)
                    hashCode = hashCode * 59 + this.Domains.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Recent != null)
                    hashCode = hashCode * 59 + this.Recent.GetHashCode();
                if (this.OverseasType != null)
                    hashCode = hashCode * 59 + this.OverseasType.GetHashCode();
                return hashCode;
            }
        }
    }
}
