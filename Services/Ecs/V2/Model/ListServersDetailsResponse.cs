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
    public class ListServersDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 弹性云服务器的列表总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 弹性云服务器详情列表，具体参照-查询云服务器详情接口。查询级别不同，返回的详情不同。
        /// </summary>
        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerDetail> Servers { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServersDetailsResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  servers: ").Append(Servers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServersDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServersDetailsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Servers == input.Servers ||
                    this.Servers != null &&
                    input.Servers != null &&
                    this.Servers.SequenceEqual(input.Servers)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Servers != null)
                    hashCode = hashCode * 59 + this.Servers.GetHashCode();
                return hashCode;
            }
        }
    }
}
