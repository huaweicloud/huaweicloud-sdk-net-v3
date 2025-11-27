using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchModifyPublicationResponse : SdkResponse
    {

        /// <summary>
        /// 修改发布结果。
        /// </summary>
        [JsonProperty("publications", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchOperateResponseInfo> Publications { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchModifyPublicationResponse {\n");
            sb.Append("  publications: ").Append(Publications).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchModifyPublicationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchModifyPublicationResponse input)
        {
            if (input == null) return false;
            if (this.Publications != input.Publications || (this.Publications != null && input.Publications != null && !this.Publications.SequenceEqual(input.Publications))) return false;

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
                if (this.Publications != null) hashCode = hashCode * 59 + this.Publications.GetHashCode();
                return hashCode;
            }
        }
    }
}
