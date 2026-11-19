using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowKeyUsageFlowResponseBodyEdges 
    {

        /// <summary>
        /// **参数解释：** 边起点节点ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// **参数解释：** 边终点节点ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKeyUsageFlowResponseBodyEdges {\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKeyUsageFlowResponseBodyEdges);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKeyUsageFlowResponseBodyEdges input)
        {
            if (input == null) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.Target != input.Target || (this.Target != null && !this.Target.Equals(input.Target))) return false;

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
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Target != null) hashCode = hashCode * 59 + this.Target.GetHashCode();
                return hashCode;
            }
        }
    }
}
