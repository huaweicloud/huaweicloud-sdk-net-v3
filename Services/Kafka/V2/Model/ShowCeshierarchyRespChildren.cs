using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 子维度信息。
    /// </summary>
    public class ShowCeshierarchyRespChildren 
    {

        /// <summary>
        /// 子维度名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 监控指标名称列表。
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Metrics { get; set; }

        /// <summary>
        /// 监控查询使用的key。
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> KeyName { get; set; }

        /// <summary>
        /// 监控维度路由。
        /// </summary>
        [JsonProperty("dim_router", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DimRouter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCeshierarchyRespChildren {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  metrics: ").Append(Metrics).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  dimRouter: ").Append(DimRouter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCeshierarchyRespChildren);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCeshierarchyRespChildren input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Metrics != input.Metrics || (this.Metrics != null && input.Metrics != null && !this.Metrics.SequenceEqual(input.Metrics))) return false;
            if (this.KeyName != input.KeyName || (this.KeyName != null && input.KeyName != null && !this.KeyName.SequenceEqual(input.KeyName))) return false;
            if (this.DimRouter != input.DimRouter || (this.DimRouter != null && input.DimRouter != null && !this.DimRouter.SequenceEqual(input.DimRouter))) return false;

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
                if (this.Metrics != null) hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.KeyName != null) hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.DimRouter != null) hashCode = hashCode * 59 + this.DimRouter.GetHashCode();
                return hashCode;
            }
        }
    }
}
