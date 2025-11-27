using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConstraintSpec 
    {

        /// <summary>
        /// 策略执行行为，当前支持warn和deny
        /// </summary>
        [JsonProperty("enforcementAction", NullValueHandling = NullValueHandling.Ignore)]
        public string EnforcementAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("match", NullValueHandling = NullValueHandling.Ignore)]
        public Match Match { get; set; }

        /// <summary>
        /// 可变参数
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Object Parameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstraintSpec {\n");
            sb.Append("  enforcementAction: ").Append(EnforcementAction).Append("\n");
            sb.Append("  match: ").Append(Match).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConstraintSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConstraintSpec input)
        {
            if (input == null) return false;
            if (this.EnforcementAction != input.EnforcementAction || (this.EnforcementAction != null && !this.EnforcementAction.Equals(input.EnforcementAction))) return false;
            if (this.Match != input.Match || (this.Match != null && !this.Match.Equals(input.Match))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && !this.Parameters.Equals(input.Parameters))) return false;

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
                if (this.EnforcementAction != null) hashCode = hashCode * 59 + this.EnforcementAction.GetHashCode();
                if (this.Match != null) hashCode = hashCode * 59 + this.Match.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
