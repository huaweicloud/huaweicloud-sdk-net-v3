using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchImportSecretsResponse : SdkResponse
    {

        /// <summary>
        /// 失败描述
        /// </summary>
        [JsonProperty("error_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorInfo> ErrorList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 成功条数
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public int? Success { get; set; }

        /// <summary>
        /// 失败条数
        /// </summary>
        [JsonProperty("failed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Failed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchImportSecretsResponse {\n");
            sb.Append("  errorList: ").Append(ErrorList).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  failed: ").Append(Failed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchImportSecretsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchImportSecretsResponse input)
        {
            if (input == null) return false;
            if (this.ErrorList != input.ErrorList || (this.ErrorList != null && input.ErrorList != null && !this.ErrorList.SequenceEqual(input.ErrorList))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Success != input.Success || (this.Success != null && !this.Success.Equals(input.Success))) return false;
            if (this.Failed != input.Failed || (this.Failed != null && !this.Failed.Equals(input.Failed))) return false;

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
                if (this.ErrorList != null) hashCode = hashCode * 59 + this.ErrorList.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Failed != null) hashCode = hashCode * 59 + this.Failed.GetHashCode();
                return hashCode;
            }
        }
    }
}
