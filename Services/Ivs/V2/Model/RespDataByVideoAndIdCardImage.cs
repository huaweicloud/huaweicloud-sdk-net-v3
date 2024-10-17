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
    public class RespDataByVideoAndIdCardImage 
    {

        /// <summary>
        /// 审核校验结果： \&quot;valid\&quot;表示身份审核通过； \&quot;invalid\&quot;表示身份审核不通过； \&quot;nonexistent\&quot;表示数据源没有该身份证号码，这种情况一般是被验证人正在办理户籍迁移，或者被验证人是军人或政要。
        /// </summary>
        [JsonProperty("verification_result", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationResult { get; set; }

        /// <summary>
        /// 审核校验信息，具体参考[校验信息说明](https://support.huaweicloud.com/api-ivs/ivs_02_0017.html)
        /// </summary>
        [JsonProperty("verification_message", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationMessage { get; set; }

        /// <summary>
        /// 审核校验代码，具体参考[校验信息说明](https://support.huaweicloud.com/api-ivs/ivs_02_0017.html)
        /// </summary>
        [JsonProperty("verification_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? VerificationCode { get; set; }

        /// <summary>
        /// 人像相识度，取值默认范围为[0,100]，当入参detail为true时，取值范围为[0,1000]。
        /// </summary>
        [JsonProperty("similarity", NullValueHandling = NullValueHandling.Ignore)]
        public string Similarity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("idcard_result", NullValueHandling = NullValueHandling.Ignore)]
        public IdcardResult IdcardResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_result", NullValueHandling = NullValueHandling.Ignore)]
        public VideoResult VideoResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RespDataByVideoAndIdCardImage {\n");
            sb.Append("  verificationResult: ").Append(VerificationResult).Append("\n");
            sb.Append("  verificationMessage: ").Append(VerificationMessage).Append("\n");
            sb.Append("  verificationCode: ").Append(VerificationCode).Append("\n");
            sb.Append("  similarity: ").Append(Similarity).Append("\n");
            sb.Append("  idcardResult: ").Append(IdcardResult).Append("\n");
            sb.Append("  videoResult: ").Append(VideoResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RespDataByVideoAndIdCardImage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RespDataByVideoAndIdCardImage input)
        {
            if (input == null) return false;
            if (this.VerificationResult != input.VerificationResult || (this.VerificationResult != null && !this.VerificationResult.Equals(input.VerificationResult))) return false;
            if (this.VerificationMessage != input.VerificationMessage || (this.VerificationMessage != null && !this.VerificationMessage.Equals(input.VerificationMessage))) return false;
            if (this.VerificationCode != input.VerificationCode || (this.VerificationCode != null && !this.VerificationCode.Equals(input.VerificationCode))) return false;
            if (this.Similarity != input.Similarity || (this.Similarity != null && !this.Similarity.Equals(input.Similarity))) return false;
            if (this.IdcardResult != input.IdcardResult || (this.IdcardResult != null && !this.IdcardResult.Equals(input.IdcardResult))) return false;
            if (this.VideoResult != input.VideoResult || (this.VideoResult != null && !this.VideoResult.Equals(input.VideoResult))) return false;

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
                if (this.VerificationResult != null) hashCode = hashCode * 59 + this.VerificationResult.GetHashCode();
                if (this.VerificationMessage != null) hashCode = hashCode * 59 + this.VerificationMessage.GetHashCode();
                if (this.VerificationCode != null) hashCode = hashCode * 59 + this.VerificationCode.GetHashCode();
                if (this.Similarity != null) hashCode = hashCode * 59 + this.Similarity.GetHashCode();
                if (this.IdcardResult != null) hashCode = hashCode * 59 + this.IdcardResult.GetHashCode();
                if (this.VideoResult != null) hashCode = hashCode * 59 + this.VideoResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
