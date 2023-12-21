using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ivs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StandardReqDataByVideoAndNameAndId 
    {

        /// <summary>
        /// 被验证人的姓名。
        /// </summary>
        [JsonProperty("verification_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationName { get; set; }

        /// <summary>
        /// 被验证人的身份证号码。
        /// </summary>
        [JsonProperty("verification_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationId { get; set; }

        /// <summary>
        /// 现场拍摄人像视频数据，使用base64编码，要求base64编码后大小不超过10M。
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public string Video { get; set; }

        /// <summary>
        /// 动作代码顺序列表，英文逗号（,）分隔。建议单动作，目前支持的动作有： • 1：左摇头 • 2：右摇头 • 3：点头 • 4：嘴部动作
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public string Actions { get; set; }

        /// <summary>
        /// 该参数为点头动作幅度的判断门限，取值范围：[1,90]，默认为10，单位为度。该值设置越大，则越难判断为点头。
        /// </summary>
        [JsonProperty("nod_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? NodThreshold { get; set; }

        /// <summary>
        /// 响应参数similarity是否详细显示，默认为false。 - true表示响应中的similarity为0~1000的小数。 - false表示响应中的similarity为0~100的整数。
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Detail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardReqDataByVideoAndNameAndId {\n");
            sb.Append("  verificationName: ").Append(VerificationName).Append("\n");
            sb.Append("  verificationId: ").Append(VerificationId).Append("\n");
            sb.Append("  video: ").Append(Video).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  nodThreshold: ").Append(NodThreshold).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StandardReqDataByVideoAndNameAndId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StandardReqDataByVideoAndNameAndId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VerificationName == input.VerificationName ||
                    (this.VerificationName != null &&
                    this.VerificationName.Equals(input.VerificationName))
                ) && 
                (
                    this.VerificationId == input.VerificationId ||
                    (this.VerificationId != null &&
                    this.VerificationId.Equals(input.VerificationId))
                ) && 
                (
                    this.Video == input.Video ||
                    (this.Video != null &&
                    this.Video.Equals(input.Video))
                ) && 
                (
                    this.Actions == input.Actions ||
                    (this.Actions != null &&
                    this.Actions.Equals(input.Actions))
                ) && 
                (
                    this.NodThreshold == input.NodThreshold ||
                    (this.NodThreshold != null &&
                    this.NodThreshold.Equals(input.NodThreshold))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
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
                if (this.VerificationName != null)
                    hashCode = hashCode * 59 + this.VerificationName.GetHashCode();
                if (this.VerificationId != null)
                    hashCode = hashCode * 59 + this.VerificationId.GetHashCode();
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.NodThreshold != null)
                    hashCode = hashCode * 59 + this.NodThreshold.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                return hashCode;
            }
        }
    }
}
