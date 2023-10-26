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
    public class UpdateComponentRequest 
    {

        /// <summary>
        /// 组件id
        /// </summary>
        [SDKProperty("component_id", IsPath = true)]
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ComponentUpdateParam Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateComponentRequest {\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateComponentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateComponentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComponentId == input.ComponentId ||
                    (this.ComponentId != null &&
                    this.ComponentId.Equals(input.ComponentId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.ComponentId != null)
                    hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
