using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 参数信息
    /// </summary>
    public class ParamsReqBean 
    {

        /// <summary>
        /// 数据库参数名
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 目标数据库参数值
        /// </summary>
        [JsonProperty("target_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParamsReqBean {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  targetValue: ").Append(TargetValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParamsReqBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParamsReqBean input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.TargetValue != input.TargetValue || (this.TargetValue != null && !this.TargetValue.Equals(input.TargetValue))) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.TargetValue != null) hashCode = hashCode * 59 + this.TargetValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
