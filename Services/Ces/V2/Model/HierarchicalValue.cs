using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 多层级告警阈值。当hierarchical_value和value同时使用时以hierarchical_value为准。 创建或修改告警规则以下2种场景只支持设置一个阈值：   1.告警类型为&#x60;指标告警&#x60;且告警策略为&#x60;所有策略都满足才告警&#x60;的场景。   2.告警类型为&#x60;事件告警&#x60;的场景。 
    /// </summary>
    public class HierarchicalValue 
    {

        /// <summary>
        /// 紧急级别的阈值
        /// </summary>
        [JsonProperty("critical", NullValueHandling = NullValueHandling.Ignore)]
        public double? Critical { get; set; }

        /// <summary>
        /// 重要级别的阈值
        /// </summary>
        [JsonProperty("major", NullValueHandling = NullValueHandling.Ignore)]
        public double? Major { get; set; }

        /// <summary>
        /// 次要级别的阈值
        /// </summary>
        [JsonProperty("minor", NullValueHandling = NullValueHandling.Ignore)]
        public double? Minor { get; set; }

        /// <summary>
        /// 提示级别的阈值
        /// </summary>
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public double? Info { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HierarchicalValue {\n");
            sb.Append("  critical: ").Append(Critical).Append("\n");
            sb.Append("  major: ").Append(Major).Append("\n");
            sb.Append("  minor: ").Append(Minor).Append("\n");
            sb.Append("  info: ").Append(Info).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HierarchicalValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HierarchicalValue input)
        {
            if (input == null) return false;
            if (this.Critical != input.Critical || (this.Critical != null && !this.Critical.Equals(input.Critical))) return false;
            if (this.Major != input.Major || (this.Major != null && !this.Major.Equals(input.Major))) return false;
            if (this.Minor != input.Minor || (this.Minor != null && !this.Minor.Equals(input.Minor))) return false;
            if (this.Info != input.Info || (this.Info != null && !this.Info.Equals(input.Info))) return false;

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
                if (this.Critical != null) hashCode = hashCode * 59 + this.Critical.GetHashCode();
                if (this.Major != null) hashCode = hashCode * 59 + this.Major.GetHashCode();
                if (this.Minor != null) hashCode = hashCode * 59 + this.Minor.GetHashCode();
                if (this.Info != null) hashCode = hashCode * 59 + this.Info.GetHashCode();
                return hashCode;
            }
        }
    }
}
