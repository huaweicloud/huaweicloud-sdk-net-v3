using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MetricDataDetail 
    {

        /// <summary>
        /// 监控指标名称，当前包含指标： - cpu_used：该维度vCPU已使用核数，单位：个，支持维度：site_id，flavor - cpu_available_total：用户可使用该维度vCPU总核数，单位：个，支持维度：site_id，flavor - cpu_total：该维度vCPU总核数（包含HA等预留核数），单位：个，支持维度：site_id，flavor - memory_used：该维度内存已使用量，单位：Gb，支持维度：site_id，flavor - memory_available_total：用户可使用该维度内存总量，单位：Gb，支持维度：site_id，flavor - memory_total：该维度内存总量（包含HA等预留内存量），单位：Gb，支持维度：site_id，flavor - capacity_used：该维度块存储资源已使用量，单位：GiB，支持维度：site_id，storage - capacity_available_total：用户可使用该维度块存储资源总容量（用户订购开通的存储容量），单位：GiB，支持维度：site_id，storage - capacity_total：当前已订购的资源场景下该维度块存储资源最大容量（订购资源包含的存储容量可能大于用户已开通容量），单位：GiB，支持维度：site_id，storage - available：该维度对应规格剩余可发放数量，单位：台，支持维度：flavor_capacity
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 监控值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        /// <summary>
        /// 记录更新时间
        /// </summary>
        [JsonProperty("read_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ReadAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dimension", NullValueHandling = NullValueHandling.Ignore)]
        public MetricDataDetailDimension Dimension { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricDataDetail {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  readAt: ").Append(ReadAt).Append("\n");
            sb.Append("  dimension: ").Append(Dimension).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricDataDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricDataDetail input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.ReadAt != input.ReadAt || (this.ReadAt != null && !this.ReadAt.Equals(input.ReadAt))) return false;
            if (this.Dimension != input.Dimension || (this.Dimension != null && !this.Dimension.Equals(input.Dimension))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ReadAt != null) hashCode = hashCode * 59 + this.ReadAt.GetHashCode();
                if (this.Dimension != null) hashCode = hashCode * 59 + this.Dimension.GetHashCode();
                return hashCode;
            }
        }
    }
}
