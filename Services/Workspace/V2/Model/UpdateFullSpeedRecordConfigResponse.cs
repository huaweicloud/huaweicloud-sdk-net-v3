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
    /// Response Object
    /// </summary>
    public class UpdateFullSpeedRecordConfigResponse : SdkResponse
    {

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonProperty("result_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFullSpeedRecordConfigResponse {\n");
            sb.Append("  resultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  resultDesc: ").Append(ResultDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateFullSpeedRecordConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateFullSpeedRecordConfigResponse input)
        {
            if (input == null) return false;
            if (this.ResultCode != input.ResultCode || (this.ResultCode != null && !this.ResultCode.Equals(input.ResultCode))) return false;
            if (this.ResultDesc != input.ResultDesc || (this.ResultDesc != null && !this.ResultDesc.Equals(input.ResultDesc))) return false;

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
                if (this.ResultCode != null) hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.ResultDesc != null) hashCode = hashCode * 59 + this.ResultDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
