using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPublicBorderGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 功能说明：公共池分组对象
        /// </summary>
        [JsonProperty("public_border_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<CommonPoolsWithBorderGroupDict> PublicBorderGroups { get; set; }

        /// <summary>
        /// 本次请求的编号
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPublicBorderGroupsResponse {\n");
            sb.Append("  publicBorderGroups: ").Append(PublicBorderGroups).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPublicBorderGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPublicBorderGroupsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicBorderGroups == input.PublicBorderGroups ||
                    this.PublicBorderGroups != null &&
                    input.PublicBorderGroups != null &&
                    this.PublicBorderGroups.SequenceEqual(input.PublicBorderGroups)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.PublicBorderGroups != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroups.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
