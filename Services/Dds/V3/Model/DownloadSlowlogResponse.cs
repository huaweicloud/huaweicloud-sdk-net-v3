using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DownloadSlowlogResponse : SdkResponse
    {

        /// <summary>
        /// 具体信息。
        /// </summary>
        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DownloadSlowlogResult> List { get; set; }

        /// <summary>
        /// 查询状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_record", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalRecord { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadSlowlogResponse {\n");
            sb.Append("  list: ").Append(List).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  totalRecord: ").Append(TotalRecord).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadSlowlogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadSlowlogResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.List == input.List ||
                    this.List != null &&
                    input.List != null &&
                    this.List.SequenceEqual(input.List)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TotalRecord == input.TotalRecord ||
                    (this.TotalRecord != null &&
                    this.TotalRecord.Equals(input.TotalRecord))
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
                if (this.List != null)
                    hashCode = hashCode * 59 + this.List.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TotalRecord != null)
                    hashCode = hashCode * 59 + this.TotalRecord.GetHashCode();
                return hashCode;
            }
        }
    }
}
