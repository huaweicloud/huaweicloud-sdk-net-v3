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
    public class UploadDbObjectTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 是否上传完成。
        /// </summary>
        [JsonProperty("send_success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendSuccess { get; set; }

        /// <summary>
        /// 文件解析状态。 取值：success，failed
        /// </summary>
        [JsonProperty("process_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessStatus { get; set; }

        /// <summary>
        /// 解析成功的行数。
        /// </summary>
        [JsonProperty("parsed_success_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ParsedSuccessNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadDbObjectTemplateResponse {\n");
            sb.Append("  sendSuccess: ").Append(SendSuccess).Append("\n");
            sb.Append("  processStatus: ").Append(ProcessStatus).Append("\n");
            sb.Append("  parsedSuccessNumber: ").Append(ParsedSuccessNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadDbObjectTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadDbObjectTemplateResponse input)
        {
            if (input == null) return false;
            if (this.SendSuccess != input.SendSuccess || (this.SendSuccess != null && !this.SendSuccess.Equals(input.SendSuccess))) return false;
            if (this.ProcessStatus != input.ProcessStatus || (this.ProcessStatus != null && !this.ProcessStatus.Equals(input.ProcessStatus))) return false;
            if (this.ParsedSuccessNumber != input.ParsedSuccessNumber || (this.ParsedSuccessNumber != null && !this.ParsedSuccessNumber.Equals(input.ParsedSuccessNumber))) return false;

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
                if (this.SendSuccess != null) hashCode = hashCode * 59 + this.SendSuccess.GetHashCode();
                if (this.ProcessStatus != null) hashCode = hashCode * 59 + this.ProcessStatus.GetHashCode();
                if (this.ParsedSuccessNumber != null) hashCode = hashCode * 59 + this.ParsedSuccessNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
