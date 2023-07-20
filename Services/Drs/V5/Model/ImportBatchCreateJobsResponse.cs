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
    public class ImportBatchCreateJobsResponse : SdkResponse
    {

        /// <summary>
        /// 批量导入任务id。
        /// </summary>
        [JsonProperty("async_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AsyncJobId { get; set; }

        /// <summary>
        /// 导入失败的错误信息。
        /// </summary>
        [JsonProperty("import_error_messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImportErrorMessageResp> ImportErrorMessages { get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportBatchCreateJobsResponse {\n");
            sb.Append("  asyncJobId: ").Append(AsyncJobId).Append("\n");
            sb.Append("  importErrorMessages: ").Append(ImportErrorMessages).Append("\n");
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
            return this.Equals(input as ImportBatchCreateJobsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportBatchCreateJobsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AsyncJobId == input.AsyncJobId ||
                    (this.AsyncJobId != null &&
                    this.AsyncJobId.Equals(input.AsyncJobId))
                ) && 
                (
                    this.ImportErrorMessages == input.ImportErrorMessages ||
                    this.ImportErrorMessages != null &&
                    input.ImportErrorMessages != null &&
                    this.ImportErrorMessages.SequenceEqual(input.ImportErrorMessages)
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.AsyncJobId != null)
                    hashCode = hashCode * 59 + this.AsyncJobId.GetHashCode();
                if (this.ImportErrorMessages != null)
                    hashCode = hashCode * 59 + this.ImportErrorMessages.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
