using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTrainingSegmentInfoResponse : SdkResponse
    {

        /// <summary>
        /// 确认过的语句索引。
        /// </summary>
        [JsonProperty("confirmed_index", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ConfirmedIndex { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTrainingSegmentInfoResponse {\n");
            sb.Append("  confirmedIndex: ").Append(ConfirmedIndex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTrainingSegmentInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTrainingSegmentInfoResponse input)
        {
            if (input == null) return false;
            if (this.ConfirmedIndex != input.ConfirmedIndex || (this.ConfirmedIndex != null && input.ConfirmedIndex != null && !this.ConfirmedIndex.SequenceEqual(input.ConfirmedIndex))) return false;

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
                if (this.ConfirmedIndex != null) hashCode = hashCode * 59 + this.ConfirmedIndex.GetHashCode();
                return hashCode;
            }
        }
    }
}
