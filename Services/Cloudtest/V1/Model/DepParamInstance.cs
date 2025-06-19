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
    public class DepParamInstance 
    {

        /// <summary>
        /// 比较值
        /// </summary>
        [JsonProperty("compareValue", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareValue { get; set; }

        /// <summary>
        /// 比较
        /// </summary>
        [JsonProperty("comparison", NullValueHandling = NullValueHandling.Ignore)]
        public string Comparison { get; set; }

        /// <summary>
        /// 条件
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Condition { get; set; }

        /// <summary>
        /// 无效值列表
        /// </summary>
        [JsonProperty("inValidValues", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InValidValues { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 空值信息
        /// </summary>
        [JsonProperty("nullInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string NullInfo { get; set; }

        /// <summary>
        /// 关系映射，key为整数，value为字符串
        /// </summary>
        [JsonProperty("relationMap", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> RelationMap { get; set; }

        /// <summary>
        /// 关系数量
        /// </summary>
        [JsonProperty("relationNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? RelationNum { get; set; }

        /// <summary>
        /// 值列表
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepParamInstance {\n");
            sb.Append("  compareValue: ").Append(CompareValue).Append("\n");
            sb.Append("  comparison: ").Append(Comparison).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  inValidValues: ").Append(InValidValues).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nullInfo: ").Append(NullInfo).Append("\n");
            sb.Append("  relationMap: ").Append(RelationMap).Append("\n");
            sb.Append("  relationNum: ").Append(RelationNum).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DepParamInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DepParamInstance input)
        {
            if (input == null) return false;
            if (this.CompareValue != input.CompareValue || (this.CompareValue != null && !this.CompareValue.Equals(input.CompareValue))) return false;
            if (this.Comparison != input.Comparison || (this.Comparison != null && !this.Comparison.Equals(input.Comparison))) return false;
            if (this.Condition != input.Condition || (this.Condition != null && !this.Condition.Equals(input.Condition))) return false;
            if (this.InValidValues != input.InValidValues || (this.InValidValues != null && input.InValidValues != null && !this.InValidValues.SequenceEqual(input.InValidValues))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NullInfo != input.NullInfo || (this.NullInfo != null && !this.NullInfo.Equals(input.NullInfo))) return false;
            if (this.RelationMap != input.RelationMap || (this.RelationMap != null && input.RelationMap != null && !this.RelationMap.SequenceEqual(input.RelationMap))) return false;
            if (this.RelationNum != input.RelationNum || (this.RelationNum != null && !this.RelationNum.Equals(input.RelationNum))) return false;
            if (this.Values != input.Values || (this.Values != null && input.Values != null && !this.Values.SequenceEqual(input.Values))) return false;

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
                if (this.CompareValue != null) hashCode = hashCode * 59 + this.CompareValue.GetHashCode();
                if (this.Comparison != null) hashCode = hashCode * 59 + this.Comparison.GetHashCode();
                if (this.Condition != null) hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.InValidValues != null) hashCode = hashCode * 59 + this.InValidValues.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NullInfo != null) hashCode = hashCode * 59 + this.NullInfo.GetHashCode();
                if (this.RelationMap != null) hashCode = hashCode * 59 + this.RelationMap.GetHashCode();
                if (this.RelationNum != null) hashCode = hashCode * 59 + this.RelationNum.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
