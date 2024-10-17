using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ExportExcelJobResponse : SdkResponse
    {

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("err_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("err_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportExcelJobResponse {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  link: ").Append(Link).Append("\n");
            sb.Append("  errCode: ").Append(ErrCode).Append("\n");
            sb.Append("  errMsg: ").Append(ErrMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportExcelJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportExcelJobResponse input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.Link != input.Link || (this.Link != null && !this.Link.Equals(input.Link))) return false;
            if (this.ErrCode != input.ErrCode || (this.ErrCode != null && !this.ErrCode.Equals(input.ErrCode))) return false;
            if (this.ErrMsg != input.ErrMsg || (this.ErrMsg != null && !this.ErrMsg.Equals(input.ErrMsg))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Link != null) hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.ErrCode != null) hashCode = hashCode * 59 + this.ErrCode.GetHashCode();
                if (this.ErrMsg != null) hashCode = hashCode * 59 + this.ErrMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
