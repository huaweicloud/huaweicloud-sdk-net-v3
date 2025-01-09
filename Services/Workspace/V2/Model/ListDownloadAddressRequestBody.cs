using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListDownloadAddressRequestBody 
    {

        /// <summary>
        /// 录屏记录UUID列表。
        /// </summary>
        [JsonProperty("record_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RecordIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDownloadAddressRequestBody {\n");
            sb.Append("  recordIds: ").Append(RecordIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDownloadAddressRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDownloadAddressRequestBody input)
        {
            if (input == null) return false;
            if (this.RecordIds != input.RecordIds || (this.RecordIds != null && input.RecordIds != null && !this.RecordIds.SequenceEqual(input.RecordIds))) return false;

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
                if (this.RecordIds != null) hashCode = hashCode * 59 + this.RecordIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
