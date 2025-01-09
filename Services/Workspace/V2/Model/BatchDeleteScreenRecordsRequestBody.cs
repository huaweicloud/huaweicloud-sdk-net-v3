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
    public class BatchDeleteScreenRecordsRequestBody 
    {

        /// <summary>
        /// 待删除的录屏ID列表。
        /// </summary>
        [JsonProperty("screen_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchDeleteScreenRecordsRequestBodyScreenRecords> ScreenRecords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteScreenRecordsRequestBody {\n");
            sb.Append("  screenRecords: ").Append(ScreenRecords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteScreenRecordsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteScreenRecordsRequestBody input)
        {
            if (input == null) return false;
            if (this.ScreenRecords != input.ScreenRecords || (this.ScreenRecords != null && input.ScreenRecords != null && !this.ScreenRecords.SequenceEqual(input.ScreenRecords))) return false;

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
                if (this.ScreenRecords != null) hashCode = hashCode * 59 + this.ScreenRecords.GetHashCode();
                return hashCode;
            }
        }
    }
}
