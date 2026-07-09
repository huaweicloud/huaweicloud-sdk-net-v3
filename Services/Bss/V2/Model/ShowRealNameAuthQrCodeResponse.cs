using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRealNameAuthQrCodeResponse : SdkResponse
    {

        /// <summary>
        /// 人脸实名认证二维码地址。该二维码仅限单次使用，扫描后将自动失效。若未在10分钟内完成扫描，系统将自动作废。
        /// </summary>
        [JsonProperty("qr_code_url", NullValueHandling = NullValueHandling.Ignore)]
        public string QrCodeUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRealNameAuthQrCodeResponse {\n");
            sb.Append("  qrCodeUrl: ").Append(QrCodeUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRealNameAuthQrCodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRealNameAuthQrCodeResponse input)
        {
            if (input == null) return false;
            if (this.QrCodeUrl != input.QrCodeUrl || (this.QrCodeUrl != null && !this.QrCodeUrl.Equals(input.QrCodeUrl))) return false;

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
                if (this.QrCodeUrl != null) hashCode = hashCode * 59 + this.QrCodeUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
