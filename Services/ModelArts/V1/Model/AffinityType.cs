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
    public class AffinityType 
    {

        /// <summary>
        /// 参数描述： 专属池场景下设置强亲和特性 参数约束： key、values、operator必填
        /// </summary>
        [JsonProperty("required_during_scheduling_ignored_during_execution", NullValueHandling = NullValueHandling.Ignore)]
        public List<AffinityRule> RequiredDuringSchedulingIgnoredDuringExecution { get; set; }

        /// <summary>
        /// 参数描述： 专属池场景下设置弱亲和特性 参数约束： key、values、operator必填，weight选填
        /// </summary>
        [JsonProperty("preferred_during_scheduling_ignored_during_execution", NullValueHandling = NullValueHandling.Ignore)]
        public List<AffinityRule> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffinityType {\n");
            sb.Append("  requiredDuringSchedulingIgnoredDuringExecution: ").Append(RequiredDuringSchedulingIgnoredDuringExecution).Append("\n");
            sb.Append("  preferredDuringSchedulingIgnoredDuringExecution: ").Append(PreferredDuringSchedulingIgnoredDuringExecution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AffinityType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AffinityType input)
        {
            if (input == null) return false;
            if (this.RequiredDuringSchedulingIgnoredDuringExecution != input.RequiredDuringSchedulingIgnoredDuringExecution || (this.RequiredDuringSchedulingIgnoredDuringExecution != null && input.RequiredDuringSchedulingIgnoredDuringExecution != null && !this.RequiredDuringSchedulingIgnoredDuringExecution.SequenceEqual(input.RequiredDuringSchedulingIgnoredDuringExecution))) return false;
            if (this.PreferredDuringSchedulingIgnoredDuringExecution != input.PreferredDuringSchedulingIgnoredDuringExecution || (this.PreferredDuringSchedulingIgnoredDuringExecution != null && input.PreferredDuringSchedulingIgnoredDuringExecution != null && !this.PreferredDuringSchedulingIgnoredDuringExecution.SequenceEqual(input.PreferredDuringSchedulingIgnoredDuringExecution))) return false;

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
                if (this.RequiredDuringSchedulingIgnoredDuringExecution != null) hashCode = hashCode * 59 + this.RequiredDuringSchedulingIgnoredDuringExecution.GetHashCode();
                if (this.PreferredDuringSchedulingIgnoredDuringExecution != null) hashCode = hashCode * 59 + this.PreferredDuringSchedulingIgnoredDuringExecution.GetHashCode();
                return hashCode;
            }
        }
    }
}
