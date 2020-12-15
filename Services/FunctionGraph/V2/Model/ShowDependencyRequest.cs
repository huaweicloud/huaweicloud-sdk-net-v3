using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowDependencyRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("depend_id", IsPath = true)]
        [JsonProperty("depend_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DependId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDependencyRequest {\n");
            sb.Append("  dependId: ").Append(DependId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDependencyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDependencyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DependId == input.DependId ||
                    (this.DependId != null &&
                    this.DependId.Equals(input.DependId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DependId != null)
                    hashCode = hashCode * 59 + this.DependId.GetHashCode();
                return hashCode;
            }
        }
    }
}
