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
    public class ShowServerAttachableNicNumResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attachableQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public AttachableQuantityForNic AttachableQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("interfaceAttachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<InterfaceExt> InterfaceAttachments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerAttachableNicNumResponse {\n");
            sb.Append("  attachableQuantity: ").Append(AttachableQuantity).Append("\n");
            sb.Append("  interfaceAttachments: ").Append(InterfaceAttachments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerAttachableNicNumResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerAttachableNicNumResponse input)
        {
            if (input == null) return false;
            if (this.AttachableQuantity != input.AttachableQuantity || (this.AttachableQuantity != null && !this.AttachableQuantity.Equals(input.AttachableQuantity))) return false;
            if (this.InterfaceAttachments != input.InterfaceAttachments || (this.InterfaceAttachments != null && input.InterfaceAttachments != null && !this.InterfaceAttachments.SequenceEqual(input.InterfaceAttachments))) return false;

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
                if (this.AttachableQuantity != null) hashCode = hashCode * 59 + this.AttachableQuantity.GetHashCode();
                if (this.InterfaceAttachments != null) hashCode = hashCode * 59 + this.InterfaceAttachments.GetHashCode();
                return hashCode;
            }
        }
    }
}
