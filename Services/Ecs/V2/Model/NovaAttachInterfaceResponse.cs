using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class NovaAttachInterfaceResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("interfaceAttachment", NullValueHandling = NullValueHandling.Ignore)]
        public NovaServerInterfaceDetail InterfaceAttachment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaAttachInterfaceResponse {\n");
            sb.Append("  interfaceAttachment: ").Append(InterfaceAttachment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaAttachInterfaceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaAttachInterfaceResponse input)
        {
            if (input == null) return false;
            if (this.InterfaceAttachment != input.InterfaceAttachment || (this.InterfaceAttachment != null && !this.InterfaceAttachment.Equals(input.InterfaceAttachment))) return false;

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
                if (this.InterfaceAttachment != null) hashCode = hashCode * 59 + this.InterfaceAttachment.GetHashCode();
                return hashCode;
            }
        }
    }
}
