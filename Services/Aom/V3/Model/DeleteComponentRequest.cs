using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteComponentRequest 
    {

        /// <summary>
        /// 组件id
        /// </summary>
        [SDKProperty("component_id", IsPath = true)]
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteComponentRequest {\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteComponentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteComponentRequest input)
        {
            if (input == null) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;

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
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
