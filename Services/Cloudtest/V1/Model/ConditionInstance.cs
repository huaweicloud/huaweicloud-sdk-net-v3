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
    public class ConditionInstance 
    {

        /// <summary>
        /// 条件索引，用于标识当前处理的是哪个条件
        /// </summary>
        [JsonProperty("conditionIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConditionIndex { get; set; }

        /// <summary>
        /// 条件映射，键为整数，值为字符串列表，用于存储各个条件的信息
        /// </summary>
        [JsonProperty("conditionMap", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<string>> ConditionMap { get; set; }

        /// <summary>
        /// 依赖参数实例的映射
        /// </summary>
        [JsonProperty("depParamMap", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, DepParamInstance> DepParamMap { get; set; }

        /// <summary>
        /// 声明索引，用于标识当前处理的是哪个声明
        /// </summary>
        [JsonProperty("statementIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatementIndex { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionInstance {\n");
            sb.Append("  conditionIndex: ").Append(ConditionIndex).Append("\n");
            sb.Append("  conditionMap: ").Append(ConditionMap).Append("\n");
            sb.Append("  depParamMap: ").Append(DepParamMap).Append("\n");
            sb.Append("  statementIndex: ").Append(StatementIndex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConditionInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConditionInstance input)
        {
            if (input == null) return false;
            if (this.ConditionIndex != input.ConditionIndex || (this.ConditionIndex != null && !this.ConditionIndex.Equals(input.ConditionIndex))) return false;
            if (this.ConditionMap != input.ConditionMap || (this.ConditionMap != null && input.ConditionMap != null && !this.ConditionMap.SequenceEqual(input.ConditionMap))) return false;
            if (this.DepParamMap != input.DepParamMap || (this.DepParamMap != null && input.DepParamMap != null && !this.DepParamMap.SequenceEqual(input.DepParamMap))) return false;
            if (this.StatementIndex != input.StatementIndex || (this.StatementIndex != null && !this.StatementIndex.Equals(input.StatementIndex))) return false;

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
                if (this.ConditionIndex != null) hashCode = hashCode * 59 + this.ConditionIndex.GetHashCode();
                if (this.ConditionMap != null) hashCode = hashCode * 59 + this.ConditionMap.GetHashCode();
                if (this.DepParamMap != null) hashCode = hashCode * 59 + this.DepParamMap.GetHashCode();
                if (this.StatementIndex != null) hashCode = hashCode * 59 + this.StatementIndex.GetHashCode();
                return hashCode;
            }
        }
    }
}
