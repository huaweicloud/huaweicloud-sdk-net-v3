using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InjectionStatisticsBean 
    {

        /// <summary>
        /// 注入数量
        /// </summary>
        [JsonProperty("injection_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? InjectionNum { get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InjectionStatisticsBean {\n");
            sb.Append("  injectionNum: ").Append(InjectionNum).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InjectionStatisticsBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InjectionStatisticsBean input)
        {
            if (input == null) return false;
            if (this.InjectionNum != input.InjectionNum || (this.InjectionNum != null && !this.InjectionNum.Equals(input.InjectionNum))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;

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
                if (this.InjectionNum != null) hashCode = hashCode * 59 + this.InjectionNum.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                return hashCode;
            }
        }
    }
}
