using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteResourcesResponse : SdkResponse
    {

        /// <summary>
        /// 成功删除的资源数目
        /// </summary>
        [JsonProperty("succeed_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SucceedCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteResourcesResponse {\n");
            sb.Append("  succeedCount: ").Append(SucceedCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteResourcesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteResourcesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SucceedCount == input.SucceedCount ||
                    (this.SucceedCount != null &&
                    this.SucceedCount.Equals(input.SucceedCount))
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
                if (this.SucceedCount != null)
                    hashCode = hashCode * 59 + this.SucceedCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
