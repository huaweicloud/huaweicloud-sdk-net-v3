using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SwitchShardRequestBody 
    {

        /// <summary>
        /// 节点列表，支持对单个或者多个DN分片做主备切换。节点信息为将要升主的备DN分片对应的节点id和组件id。
        /// </summary>
        [JsonProperty("shards", NullValueHandling = NullValueHandling.Ignore)]
        public List<Shards> Shards { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchShardRequestBody {\n");
            sb.Append("  shards: ").Append(Shards).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchShardRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchShardRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Shards == input.Shards ||
                    this.Shards != null &&
                    input.Shards != null &&
                    this.Shards.SequenceEqual(input.Shards)
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
                if (this.Shards != null)
                    hashCode = hashCode * 59 + this.Shards.GetHashCode();
                return hashCode;
            }
        }
    }
}
