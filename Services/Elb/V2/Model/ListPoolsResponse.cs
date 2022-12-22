using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPoolsResponse : SdkResponse
    {

        /// <summary>
        /// 后端云服务器对象组列表
        /// </summary>
        [JsonProperty("pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolResp> Pools { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPoolsResponse {\n");
            sb.Append("  pools: ").Append(Pools).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPoolsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPoolsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pools == input.Pools ||
                    this.Pools != null &&
                    input.Pools != null &&
                    this.Pools.SequenceEqual(input.Pools)
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
                if (this.Pools != null)
                    hashCode = hashCode * 59 + this.Pools.GetHashCode();
                return hashCode;
            }
        }
    }
}
