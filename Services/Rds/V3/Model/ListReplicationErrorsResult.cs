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
    /// 发布订阅报错详情。
    /// </summary>
    public class ListReplicationErrorsResult 
    {

        /// <summary>
        /// 报错发生时间。
        /// </summary>
        [JsonProperty("occur_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OccurTime { get; set; }

        /// <summary>
        /// 错误源类型id。
        /// </summary>
        [JsonProperty("source_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTypeId { get; set; }

        /// <summary>
        /// 错误源名称。
        /// </summary>
        [JsonProperty("source_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceName { get; set; }

        /// <summary>
        /// 错误代码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误消息。
        /// </summary>
        [JsonProperty("error_text", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorText { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListReplicationErrorsResult {\n");
            sb.Append("  occurTime: ").Append(OccurTime).Append("\n");
            sb.Append("  sourceTypeId: ").Append(SourceTypeId).Append("\n");
            sb.Append("  sourceName: ").Append(SourceName).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorText: ").Append(ErrorText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListReplicationErrorsResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListReplicationErrorsResult input)
        {
            if (input == null) return false;
            if (this.OccurTime != input.OccurTime || (this.OccurTime != null && !this.OccurTime.Equals(input.OccurTime))) return false;
            if (this.SourceTypeId != input.SourceTypeId || (this.SourceTypeId != null && !this.SourceTypeId.Equals(input.SourceTypeId))) return false;
            if (this.SourceName != input.SourceName || (this.SourceName != null && !this.SourceName.Equals(input.SourceName))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorText != input.ErrorText || (this.ErrorText != null && !this.ErrorText.Equals(input.ErrorText))) return false;

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
                if (this.OccurTime != null) hashCode = hashCode * 59 + this.OccurTime.GetHashCode();
                if (this.SourceTypeId != null) hashCode = hashCode * 59 + this.SourceTypeId.GetHashCode();
                if (this.SourceName != null) hashCode = hashCode * 59 + this.SourceName.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorText != null) hashCode = hashCode * 59 + this.ErrorText.GetHashCode();
                return hashCode;
            }
        }
    }
}
