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
    /// httpserver配置信息
    /// </summary>
    public class HttpForwarding 
    {

        /// <summary>
        /// **参数说明**：用于接收满足规则条件数据的http服务器地址。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数说明**：证书id，请参见[获取证书ID](https://support.huaweicloud.com/usermanual-iothub/iot_01_0001.html#section3)
        /// </summary>
        [JsonProperty("cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertId { get; set; }

        /// <summary>
        /// **参数说明**：当sni_enable为true时，此字段需要填写，内容为将要请求的服务端证书的域名,举例:domain:8443;当sni_enbale为false时，此字段默认不填写。
        /// </summary>
        [JsonProperty("cn_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CnName { get; set; }

        /// <summary>
        /// **参数说明**：需要https服务端和客户端都支持此功能，默认为false，设成true表明Https的客户端在发起请求时，需要携带cn_name；https服务端根据cn_name返回对应的证书；设为false可关闭此功能。
        /// </summary>
        [JsonProperty("sni_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SniEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpForwarding {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  certId: ").Append(CertId).Append("\n");
            sb.Append("  cnName: ").Append(CnName).Append("\n");
            sb.Append("  sniEnable: ").Append(SniEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpForwarding);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpForwarding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.CertId == input.CertId ||
                    (this.CertId != null &&
                    this.CertId.Equals(input.CertId))
                ) && 
                (
                    this.CnName == input.CnName ||
                    (this.CnName != null &&
                    this.CnName.Equals(input.CnName))
                ) && 
                (
                    this.SniEnable == input.SniEnable ||
                    (this.SniEnable != null &&
                    this.SniEnable.Equals(input.SniEnable))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.CertId != null)
                    hashCode = hashCode * 59 + this.CertId.GetHashCode();
                if (this.CnName != null)
                    hashCode = hashCode * 59 + this.CnName.GetHashCode();
                if (this.SniEnable != null)
                    hashCode = hashCode * 59 + this.SniEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
