using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 修改订阅主题请求结构体
    /// </summary>
    public class UpdateSubReq 
    {

        /// <summary>
        /// 订阅的回调地址，用于接收对应资源事件的通知消息，例如：https://10.10.10.10:443/callbackurltest。
        /// </summary>
        [JsonProperty("callbackurl", NullValueHandling = NullValueHandling.Ignore)]
        public string Callbackurl { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSubReq {\n");
            sb.Append("  callbackurl: ").Append(Callbackurl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSubReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSubReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Callbackurl == input.Callbackurl ||
                    (this.Callbackurl != null &&
                    this.Callbackurl.Equals(input.Callbackurl))
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
                if (this.Callbackurl != null)
                    hashCode = hashCode * 59 + this.Callbackurl.GetHashCode();
                return hashCode;
            }
        }
    }
}
