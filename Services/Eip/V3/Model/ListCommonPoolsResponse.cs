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
    public class ListCommonPoolsResponse : SdkResponse
    {

        /// <summary>
        /// 功能说明：公共池对象
        /// </summary>
        [JsonProperty("common_pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<CommonPoolDict> CommonPools { get; set; }

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
            sb.Append("class ListCommonPoolsResponse {\n");
            sb.Append("  commonPools: ").Append(CommonPools).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCommonPoolsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCommonPoolsResponse input)
        {
            if (input == null) return false;
            if (this.CommonPools != input.CommonPools || (this.CommonPools != null && input.CommonPools != null && !this.CommonPools.SequenceEqual(input.CommonPools))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;

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
                if (this.CommonPools != null) hashCode = hashCode * 59 + this.CommonPools.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
