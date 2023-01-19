using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// 修改裸金属服务器所绑定的弹性网卡属性：终止时删除，即删除裸金属服务器，或者解绑网卡时是否删除该网卡
    /// </summary>
    public class UpdateBaremetalServerInterfaceAttachmentsReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("interface_attachment", NullValueHandling = NullValueHandling.Ignore)]
        public InterfaceAttachmentsReq InterfaceAttachment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBaremetalServerInterfaceAttachmentsReq {\n");
            sb.Append("  interfaceAttachment: ").Append(InterfaceAttachment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateBaremetalServerInterfaceAttachmentsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateBaremetalServerInterfaceAttachmentsReq input)
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
