using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStreamForbiddenResponse : SdkResponse
    {

        /// <summary>
        /// 查询结果的总元素数量
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 禁播黑名单列表
        /// </summary>
        [JsonProperty("blocks", NullValueHandling = NullValueHandling.Ignore)]
        public List<StreamForbiddenList> Blocks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStreamForbiddenResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  blocks: ").Append(Blocks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStreamForbiddenResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStreamForbiddenResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Blocks == input.Blocks ||
                    this.Blocks != null &&
                    input.Blocks != null &&
                    this.Blocks.SequenceEqual(input.Blocks)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Blocks != null)
                    hashCode = hashCode * 59 + this.Blocks.GetHashCode();
                return hashCode;
            }
        }
    }
}
