using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTasksListResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** HTTP响应状态。 **取值范围：** - OK：请求已成功处理，服务器返回了请求的资源或操作结果。 - ACCEPTED：请求已被服务器接受，但处理尚未完成（通常用于异步操作）。 - INTERNAL_SERVER_ERROR：接口内部异常。 - BAD_REQUEST：参数校验异常。
        /// </summary>
        [JsonProperty("httpStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public ShowTasksListResult Result { get; set; }

        /// <summary>
        /// **参数解释：** 接口响应状态。 **取值范围：** - success：接口响应成功。 - error：接口响应失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTasksListResponse {\n");
            sb.Append("  httpStatus: ").Append(HttpStatus).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTasksListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTasksListResponse input)
        {
            if (input == null) return false;
            if (this.HttpStatus != input.HttpStatus || (this.HttpStatus != null && !this.HttpStatus.Equals(input.HttpStatus))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.HttpStatus != null) hashCode = hashCode * 59 + this.HttpStatus.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
