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
    /// This is a auto create Body Object
    /// </summary>
    public class NovaAttachInterfaceRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("interfaceAttachment", NullValueHandling = NullValueHandling.Ignore)]
        public NovaAttachInterfaceOption InterfaceAttachment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaAttachInterfaceRequestBody {\n");
            sb.Append("  interfaceAttachment: ").Append(InterfaceAttachment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaAttachInterfaceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaAttachInterfaceRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InterfaceAttachment == input.InterfaceAttachment ||
                    (this.InterfaceAttachment != null &&
                    this.InterfaceAttachment.Equals(input.InterfaceAttachment))
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
                if (this.InterfaceAttachment != null)
                    hashCode = hashCode * 59 + this.InterfaceAttachment.GetHashCode();
                return hashCode;
            }
        }
    }
}
