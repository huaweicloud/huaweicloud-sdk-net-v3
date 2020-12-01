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
    /// Response Object
    /// </summary>
    public class ShowBaremetalServerInterfaceAttachmentsResponse : SdkResponse
    {

        /// <summary>
        /// 裸金属服务器网卡信息列表，详情请参见表2 interfaceAttachments字段数据结构说明。
        /// </summary>
        [JsonProperty("interfaceAttachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<InterfaceAttachments> InterfaceAttachments { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBaremetalServerInterfaceAttachmentsResponse {\n");
            sb.Append("  interfaceAttachments: ").Append(InterfaceAttachments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBaremetalServerInterfaceAttachmentsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBaremetalServerInterfaceAttachmentsResponse input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.InterfaceAttachments != null)
                    hashCode = hashCode * 59 + this.InterfaceAttachments.GetHashCode();
                return hashCode;
            }
        }
    }
}
