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
    /// 
    /// </summary>
    public class BankCardInfoV2 
    {

        /// <summary>
        /// 银行卡账号。 当identifyType为4时，不能为空。 银行账号输入规则：^[0-9a-zA-Z]，可以包含特殊横杠（-）字符。
        /// </summary>
        [JsonProperty("bank_account", NullValueHandling = NullValueHandling.Ignore)]
        public string BankAccount { get; set; }

        /// <summary>
        /// 国家/区号码。 例如：0086：中国大陆区号码。
        /// </summary>
        [JsonProperty("areacode", NullValueHandling = NullValueHandling.Ignore)]
        public string Areacode { get; set; }

        /// <summary>
        /// 手机号码。
        /// </summary>
        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public string Mobile { get; set; }

        /// <summary>
        /// 验证码。 请调用“发送验证码”接口获取。
        /// </summary>
        [JsonProperty("verification_code", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankCardInfoV2 {\n");
            sb.Append("  bankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  areacode: ").Append(Areacode).Append("\n");
            sb.Append("  mobile: ").Append(Mobile).Append("\n");
            sb.Append("  verificationCode: ").Append(VerificationCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BankCardInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BankCardInfoV2 input)
        {
            if (input == null) return false;
            if (this.BankAccount != input.BankAccount || (this.BankAccount != null && !this.BankAccount.Equals(input.BankAccount))) return false;
            if (this.Areacode != input.Areacode || (this.Areacode != null && !this.Areacode.Equals(input.Areacode))) return false;
            if (this.Mobile != input.Mobile || (this.Mobile != null && !this.Mobile.Equals(input.Mobile))) return false;
            if (this.VerificationCode != input.VerificationCode || (this.VerificationCode != null && !this.VerificationCode.Equals(input.VerificationCode))) return false;

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
                if (this.BankAccount != null) hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
                if (this.Areacode != null) hashCode = hashCode * 59 + this.Areacode.GetHashCode();
                if (this.Mobile != null) hashCode = hashCode * 59 + this.Mobile.GetHashCode();
                if (this.VerificationCode != null) hashCode = hashCode * 59 + this.VerificationCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
