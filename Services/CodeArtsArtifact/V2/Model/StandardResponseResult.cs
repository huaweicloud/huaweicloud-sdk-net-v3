using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 返回的具体结果信息
    /// </summary>
    public class StandardResponseResult 
    {

        /// <summary>
        /// 符合条件的结果列表
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReleaseFileVersionDo> Data { get; set; }

        /// <summary>
        /// 符合条件的结果总数
        /// </summary>
        [JsonProperty("total_records", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// 符合条件的结果总页数
        /// </summary>
        [JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardResponseResult {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  totalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  totalPages: ").Append(TotalPages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StandardResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StandardResponseResult input)
        {
            if (input == null) return false;
            if (this.Data != input.Data || (this.Data != null && input.Data != null && !this.Data.SequenceEqual(input.Data))) return false;
            if (this.TotalRecords != input.TotalRecords || (this.TotalRecords != null && !this.TotalRecords.Equals(input.TotalRecords))) return false;
            if (this.TotalPages != input.TotalPages || (this.TotalPages != null && !this.TotalPages.Equals(input.TotalPages))) return false;

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
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.TotalRecords != null) hashCode = hashCode * 59 + this.TotalRecords.GetHashCode();
                if (this.TotalPages != null) hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                return hashCode;
            }
        }
    }
}
