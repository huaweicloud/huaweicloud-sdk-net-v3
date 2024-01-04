using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 终端探测详情
    /// </summary>
    public class GetHttpDetectResponseBodyDetail 
    {

        /// <summary>
        /// 探测终端返回的http返回码，0代表用户在黑名单无法发送，-1代表用户终端超过5秒未响应，-2代表队列已满，Http探测任务未执行。其他httpcode为终端实际返回值。
        /// </summary>
        [JsonProperty("httpCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// 终端探测响应体，如果httpCode为0，-1，-2, 2xx时响应体内容固定，由SMN定义。其余httpCode的响应体内容为终端返回内容。
        /// </summary>
        [JsonProperty("httpResponse", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpResponse { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetHttpDetectResponseBodyDetail {\n");
            sb.Append("  httpCode: ").Append(HttpCode).Append("\n");
            sb.Append("  httpResponse: ").Append(HttpResponse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetHttpDetectResponseBodyDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetHttpDetectResponseBodyDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HttpCode == input.HttpCode ||
                    (this.HttpCode != null &&
                    this.HttpCode.Equals(input.HttpCode))
                ) && 
                (
                    this.HttpResponse == input.HttpResponse ||
                    (this.HttpResponse != null &&
                    this.HttpResponse.Equals(input.HttpResponse))
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
                if (this.HttpCode != null)
                    hashCode = hashCode * 59 + this.HttpCode.GetHashCode();
                if (this.HttpResponse != null)
                    hashCode = hashCode * 59 + this.HttpResponse.GetHashCode();
                return hashCode;
            }
        }
    }
}
