using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDataFilteringResultResponse : SdkResponse
    {

        /// <summary>
        /// 数据过滤规则校验成功的数量
        /// </summary>
        [JsonProperty("success_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SuccessCount { get; set; }

        /// <summary>
        /// 数据过滤规则校验失败的数量
        /// </summary>
        [JsonProperty("failed_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? FailedCount { get; set; }

        /// <summary>
        /// 库表过滤规则校验结果
        /// </summary>
        [JsonProperty("db_object_filtering_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<DbObjectFilteringResult> DbObjectFilteringResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDataFilteringResultResponse {\n");
            sb.Append("  successCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  failedCount: ").Append(FailedCount).Append("\n");
            sb.Append("  dbObjectFilteringResult: ").Append(DbObjectFilteringResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDataFilteringResultResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDataFilteringResultResponse input)
        {
            if (input == null) return false;
            if (this.SuccessCount != input.SuccessCount || (this.SuccessCount != null && !this.SuccessCount.Equals(input.SuccessCount))) return false;
            if (this.FailedCount != input.FailedCount || (this.FailedCount != null && !this.FailedCount.Equals(input.FailedCount))) return false;
            if (this.DbObjectFilteringResult != input.DbObjectFilteringResult || (this.DbObjectFilteringResult != null && input.DbObjectFilteringResult != null && !this.DbObjectFilteringResult.SequenceEqual(input.DbObjectFilteringResult))) return false;

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
                if (this.SuccessCount != null) hashCode = hashCode * 59 + this.SuccessCount.GetHashCode();
                if (this.FailedCount != null) hashCode = hashCode * 59 + this.FailedCount.GetHashCode();
                if (this.DbObjectFilteringResult != null) hashCode = hashCode * 59 + this.DbObjectFilteringResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
