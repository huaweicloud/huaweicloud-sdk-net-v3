using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SendSlideVerifyCodeResponse : SdkResponse
    {

        /// <summary>
        /// 抠出图形后的原背景图。通过“data:url”方式来定义图片。
        /// </summary>
        [JsonProperty("shadowImage", NullValueHandling = NullValueHandling.Ignore)]
        public string ShadowImage { get; set; }

        /// <summary>
        /// 抠出的图形。
        /// </summary>
        [JsonProperty("cutImage", NullValueHandling = NullValueHandling.Ignore)]
        public string CutImage { get; set; }

        /// <summary>
        /// 抠出图形的Y轴座标。
        /// </summary>
        [JsonProperty("pointY", NullValueHandling = NullValueHandling.Ignore)]
        public int? PointY { get; set; }

        /// <summary>
        /// 验证码Token字符串。
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// 验证码有效时间，单位：秒。
        /// </summary>
        [JsonProperty("expire", NullValueHandling = NullValueHandling.Ignore)]
        public int? Expire { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendSlideVerifyCodeResponse {\n");
            sb.Append("  shadowImage: ").Append(ShadowImage).Append("\n");
            sb.Append("  cutImage: ").Append(CutImage).Append("\n");
            sb.Append("  pointY: ").Append(PointY).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  expire: ").Append(Expire).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendSlideVerifyCodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SendSlideVerifyCodeResponse input)
        {
            if (input == null) return false;
            if (this.ShadowImage != input.ShadowImage || (this.ShadowImage != null && !this.ShadowImage.Equals(input.ShadowImage))) return false;
            if (this.CutImage != input.CutImage || (this.CutImage != null && !this.CutImage.Equals(input.CutImage))) return false;
            if (this.PointY != input.PointY || (this.PointY != null && !this.PointY.Equals(input.PointY))) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
            if (this.Expire != input.Expire || (this.Expire != null && !this.Expire.Equals(input.Expire))) return false;

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
                if (this.ShadowImage != null) hashCode = hashCode * 59 + this.ShadowImage.GetHashCode();
                if (this.CutImage != null) hashCode = hashCode * 59 + this.CutImage.GetHashCode();
                if (this.PointY != null) hashCode = hashCode * 59 + this.PointY.GetHashCode();
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Expire != null) hashCode = hashCode * 59 + this.Expire.GetHashCode();
                return hashCode;
            }
        }
    }
}
