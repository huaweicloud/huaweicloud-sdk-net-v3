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
    public class ListServerInterfacesResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attachableQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public InterfaceAttachableQuantity AttachableQuantity { get; set; }

        /// <summary>
        /// 云服务器网卡信息列表
        /// </summary>
        [JsonProperty("interfaceAttachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<InterfaceAttachment> InterfaceAttachments { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServerInterfacesResponse {\n");
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
            return this.Equals(input as ListServerInterfacesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServerInterfacesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttachableQuantity == input.AttachableQuantity ||
                    (this.AttachableQuantity != null &&
                    this.AttachableQuantity.Equals(input.AttachableQuantity))
                ) && 
                (
                    this.InterfaceAttachments == input.InterfaceAttachments ||
                    this.InterfaceAttachments != null &&
                    input.InterfaceAttachments != null &&
                    this.InterfaceAttachments.SequenceEqual(input.InterfaceAttachments)
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
                if (this.AttachableQuantity != null)
                    hashCode = hashCode * 59 + this.AttachableQuantity.GetHashCode();
                if (this.InterfaceAttachments != null)
                    hashCode = hashCode * 59 + this.InterfaceAttachments.GetHashCode();
                return hashCode;
            }
        }
    }
}
