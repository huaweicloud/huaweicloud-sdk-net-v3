using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPortsResponse : SdkResponse
    {

        /// <summary>
        /// port列表对象
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public List<Port> Ports { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPortsResponse {\n");
            sb.Append("  ports: ").Append(Ports).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPortsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPortsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
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
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                return hashCode;
            }
        }
    }
}
