using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateCompareTaskResponse : SdkResponse
    {

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("object_level_compare_create_result", NullValueHandling = NullValueHandling.Ignore)]
        public CreateCompareTaskResult ObjectLevelCompareCreateResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_level_compare_create_result", NullValueHandling = NullValueHandling.Ignore)]
        public CreateCompareTaskResult DataLevelCompareCreateResult { get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCompareTaskResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  objectLevelCompareCreateResult: ").Append(ObjectLevelCompareCreateResult).Append("\n");
            sb.Append("  dataLevelCompareCreateResult: ").Append(DataLevelCompareCreateResult).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCompareTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCompareTaskResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.ObjectLevelCompareCreateResult != input.ObjectLevelCompareCreateResult || (this.ObjectLevelCompareCreateResult != null && !this.ObjectLevelCompareCreateResult.Equals(input.ObjectLevelCompareCreateResult))) return false;
            if (this.DataLevelCompareCreateResult != input.DataLevelCompareCreateResult || (this.DataLevelCompareCreateResult != null && !this.DataLevelCompareCreateResult.Equals(input.DataLevelCompareCreateResult))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ObjectLevelCompareCreateResult != null) hashCode = hashCode * 59 + this.ObjectLevelCompareCreateResult.GetHashCode();
                if (this.DataLevelCompareCreateResult != null) hashCode = hashCode * 59 + this.DataLevelCompareCreateResult.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
