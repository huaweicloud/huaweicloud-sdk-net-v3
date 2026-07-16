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
    /// dag policy struct
    /// </summary>
    public class WorkflowDagPoliciesResp 
    {

        /// <summary>
        /// **参数解释**：是否使用缓存。 **取值范围**： - true：使用缓存 - false：不使用缓存
        /// </summary>
        [JsonProperty("use_cache", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseCache { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowDagPoliciesResp {\n");
            sb.Append("  useCache: ").Append(UseCache).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowDagPoliciesResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowDagPoliciesResp input)
        {
            if (input == null) return false;
            if (this.UseCache != input.UseCache || (this.UseCache != null && !this.UseCache.Equals(input.UseCache))) return false;

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
                if (this.UseCache != null) hashCode = hashCode * 59 + this.UseCache.GetHashCode();
                return hashCode;
            }
        }
    }
}
