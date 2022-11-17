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
    /// Request Object
    /// </summary>
    public class DisassociateServerVirtualIpRequest 
    {

        /// <summary>
        /// 云服务器网卡ID。
        /// </summary>
        [SDKProperty("nic_id", IsPath = true)]
        [JsonProperty("nic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NicId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public DisassociateServerVirtualIpRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateServerVirtualIpRequest {\n");
            sb.Append("  nicId: ").Append(NicId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateServerVirtualIpRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateServerVirtualIpRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NicId == input.NicId ||
                    (this.NicId != null &&
                    this.NicId.Equals(input.NicId))
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
                if (this.NicId != null)
                    hashCode = hashCode * 59 + this.NicId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
