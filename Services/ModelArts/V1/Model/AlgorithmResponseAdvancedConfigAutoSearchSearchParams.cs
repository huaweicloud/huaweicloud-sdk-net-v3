using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AlgorithmResponseAdvancedConfigAutoSearchSearchParams 
    {

        /// <summary>
        /// 超参名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数类型。 - continuous：指定时表示这个超参是连续类型的。连续类型的超参在算法使用于训练作业时，控制台显示为输入框。 - discrete：指定时表示这个超参是离散类型的。离散类型的超参在算法使用于训练作业时，控制台显示为下拉选择框架。
        /// </summary>
        [JsonProperty("param_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamType { get; set; }

        /// <summary>
        /// 超参下界。
        /// </summary>
        [JsonProperty("lower_bound", NullValueHandling = NullValueHandling.Ignore)]
        public string LowerBound { get; set; }

        /// <summary>
        /// 超参上界。
        /// </summary>
        [JsonProperty("upper_bound", NullValueHandling = NullValueHandling.Ignore)]
        public string UpperBound { get; set; }

        /// <summary>
        /// 连续型超参离散化取值个数。
        /// </summary>
        [JsonProperty("discrete_points_num", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscretePointsNum { get; set; }

        /// <summary>
        /// 离散型超参的取值列表。
        /// </summary>
        [JsonProperty("discrete_values", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscreteValues { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlgorithmResponseAdvancedConfigAutoSearchSearchParams {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  paramType: ").Append(ParamType).Append("\n");
            sb.Append("  lowerBound: ").Append(LowerBound).Append("\n");
            sb.Append("  upperBound: ").Append(UpperBound).Append("\n");
            sb.Append("  discretePointsNum: ").Append(DiscretePointsNum).Append("\n");
            sb.Append("  discreteValues: ").Append(DiscreteValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlgorithmResponseAdvancedConfigAutoSearchSearchParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlgorithmResponseAdvancedConfigAutoSearchSearchParams input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ParamType != input.ParamType || (this.ParamType != null && !this.ParamType.Equals(input.ParamType))) return false;
            if (this.LowerBound != input.LowerBound || (this.LowerBound != null && !this.LowerBound.Equals(input.LowerBound))) return false;
            if (this.UpperBound != input.UpperBound || (this.UpperBound != null && !this.UpperBound.Equals(input.UpperBound))) return false;
            if (this.DiscretePointsNum != input.DiscretePointsNum || (this.DiscretePointsNum != null && !this.DiscretePointsNum.Equals(input.DiscretePointsNum))) return false;
            if (this.DiscreteValues != input.DiscreteValues || (this.DiscreteValues != null && !this.DiscreteValues.Equals(input.DiscreteValues))) return false;

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
                if (this.ParamType != null) hashCode = hashCode * 59 + this.ParamType.GetHashCode();
                if (this.LowerBound != null) hashCode = hashCode * 59 + this.LowerBound.GetHashCode();
                if (this.UpperBound != null) hashCode = hashCode * 59 + this.UpperBound.GetHashCode();
                if (this.DiscretePointsNum != null) hashCode = hashCode * 59 + this.DiscretePointsNum.GetHashCode();
                if (this.DiscreteValues != null) hashCode = hashCode * 59 + this.DiscreteValues.GetHashCode();
                return hashCode;
            }
        }
    }
}
