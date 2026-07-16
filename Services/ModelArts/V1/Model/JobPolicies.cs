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
    /// 作业支持的策略，用于超参搜索。
    /// </summary>
    public class JobPolicies 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auto_search", NullValueHandling = NullValueHandling.Ignore)]
        public AutoSearch AutoSearch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobPolicies {\n");
            sb.Append("  autoSearch: ").Append(AutoSearch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobPolicies);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobPolicies input)
        {
            if (input == null) return false;
            if (this.AutoSearch != input.AutoSearch || (this.AutoSearch != null && !this.AutoSearch.Equals(input.AutoSearch))) return false;

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
                if (this.AutoSearch != null) hashCode = hashCode * 59 + this.AutoSearch.GetHashCode();
                return hashCode;
            }
        }
    }
}
