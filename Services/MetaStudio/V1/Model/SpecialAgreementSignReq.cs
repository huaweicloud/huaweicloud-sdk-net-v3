using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 增加租户权限
    /// </summary>
    public class SpecialAgreementSignReq 
    {

        /// <summary>
        /// 当前服务协议类型: AUTO_PAY: 自动支付协议
        /// </summary>
        [JsonProperty("agreement_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementType { get; set; }

        /// <summary>
        /// 是否为去签署,true:签署;false:取消签署
        /// </summary>
        [JsonProperty("to_sign", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ToSign { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecialAgreementSignReq {\n");
            sb.Append("  agreementType: ").Append(AgreementType).Append("\n");
            sb.Append("  toSign: ").Append(ToSign).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpecialAgreementSignReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SpecialAgreementSignReq input)
        {
            if (input == null) return false;
            if (this.AgreementType != input.AgreementType || (this.AgreementType != null && !this.AgreementType.Equals(input.AgreementType))) return false;
            if (this.ToSign != input.ToSign || (this.ToSign != null && !this.ToSign.Equals(input.ToSign))) return false;

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
                if (this.AgreementType != null) hashCode = hashCode * 59 + this.AgreementType.GetHashCode();
                if (this.ToSign != null) hashCode = hashCode * 59 + this.ToSign.GetHashCode();
                return hashCode;
            }
        }
    }
}
