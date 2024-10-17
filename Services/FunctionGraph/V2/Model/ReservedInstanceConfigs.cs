using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReservedInstanceConfigs 
    {

        /// <summary>
        /// 函数URN
        /// </summary>
        [JsonProperty("function_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionUrn { get; set; }

        /// <summary>
        /// 限定类型, 支持version和alias
        /// </summary>
        [JsonProperty("qualifier_type", NullValueHandling = NullValueHandling.Ignore)]
        public string QualifierType { get; set; }

        /// <summary>
        /// 限定类型对应的取值
        /// </summary>
        [JsonProperty("qualifier_name", NullValueHandling = NullValueHandling.Ignore)]
        public string QualifierName { get; set; }

        /// <summary>
        /// 预留实例个数
        /// </summary>
        [JsonProperty("min_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinCount { get; set; }

        /// <summary>
        /// 是否开启闲置模式配置
        /// </summary>
        [JsonProperty("idle_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IdleMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tactics_config", NullValueHandling = NullValueHandling.Ignore)]
        public TacticsConfig TacticsConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReservedInstanceConfigs {\n");
            sb.Append("  functionUrn: ").Append(FunctionUrn).Append("\n");
            sb.Append("  qualifierType: ").Append(QualifierType).Append("\n");
            sb.Append("  qualifierName: ").Append(QualifierName).Append("\n");
            sb.Append("  minCount: ").Append(MinCount).Append("\n");
            sb.Append("  idleMode: ").Append(IdleMode).Append("\n");
            sb.Append("  tacticsConfig: ").Append(TacticsConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReservedInstanceConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReservedInstanceConfigs input)
        {
            if (input == null) return false;
            if (this.FunctionUrn != input.FunctionUrn || (this.FunctionUrn != null && !this.FunctionUrn.Equals(input.FunctionUrn))) return false;
            if (this.QualifierType != input.QualifierType || (this.QualifierType != null && !this.QualifierType.Equals(input.QualifierType))) return false;
            if (this.QualifierName != input.QualifierName || (this.QualifierName != null && !this.QualifierName.Equals(input.QualifierName))) return false;
            if (this.MinCount != input.MinCount || (this.MinCount != null && !this.MinCount.Equals(input.MinCount))) return false;
            if (this.IdleMode != input.IdleMode || (this.IdleMode != null && !this.IdleMode.Equals(input.IdleMode))) return false;
            if (this.TacticsConfig != input.TacticsConfig || (this.TacticsConfig != null && !this.TacticsConfig.Equals(input.TacticsConfig))) return false;

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
                if (this.FunctionUrn != null) hashCode = hashCode * 59 + this.FunctionUrn.GetHashCode();
                if (this.QualifierType != null) hashCode = hashCode * 59 + this.QualifierType.GetHashCode();
                if (this.QualifierName != null) hashCode = hashCode * 59 + this.QualifierName.GetHashCode();
                if (this.MinCount != null) hashCode = hashCode * 59 + this.MinCount.GetHashCode();
                if (this.IdleMode != null) hashCode = hashCode * 59 + this.IdleMode.GetHashCode();
                if (this.TacticsConfig != null) hashCode = hashCode * 59 + this.TacticsConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
