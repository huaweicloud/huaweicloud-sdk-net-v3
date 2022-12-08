using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// 请求参数
    /// </summary>
    public class BatchDeletePublicIpRequestBody 
    {

        /// <summary>
        /// 弹性公网ip的id列表。
        /// </summary>
        [JsonProperty("publicip_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicipIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeletePublicIpRequestBody {\n");
            sb.Append("  publicipIds: ").Append(PublicipIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeletePublicIpRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeletePublicIpRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicipIds == input.PublicipIds ||
                    this.PublicipIds != null &&
                    input.PublicipIds != null &&
                    this.PublicipIds.SequenceEqual(input.PublicipIds)
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
                if (this.PublicipIds != null)
                    hashCode = hashCode * 59 + this.PublicipIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
