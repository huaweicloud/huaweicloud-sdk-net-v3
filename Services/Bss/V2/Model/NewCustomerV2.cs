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
    public class NewCustomerV2 
    {

        /// <summary>
        /// 企业子账号登录名。
        /// </summary>
        [JsonProperty("customer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        /// <summary>
        /// 企业管理员的手机号码。如果use_pri_mobile_phone取值为Y，则这个参数无效，否则必选。
        /// </summary>
        [JsonProperty("mobile_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 是否使用企业主账号手机号码作为子账号手机号码： Y：是N：否（默认值） 当为Y时，mobile_phone输入无效。
        /// </summary>
        [JsonProperty("use_pri_mobile_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string UsePriMobilePhone { get; set; }

        /// <summary>
        /// 企业子账号的登录密码。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 验证码，只有输入企业子账号的手机号的情况下，才需要填写该字段。 具体请参见发送短信验证码。
        /// </summary>
        [JsonProperty("verification_code", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewCustomerV2 {\n");
            sb.Append("  customerName: ").Append(CustomerName).Append("\n");
            sb.Append("  mobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  usePriMobilePhone: ").Append(UsePriMobilePhone).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  verificationCode: ").Append(VerificationCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NewCustomerV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NewCustomerV2 input)
        {
            if (input == null) return false;
            if (this.CustomerName != input.CustomerName || (this.CustomerName != null && !this.CustomerName.Equals(input.CustomerName))) return false;
            if (this.MobilePhone != input.MobilePhone || (this.MobilePhone != null && !this.MobilePhone.Equals(input.MobilePhone))) return false;
            if (this.UsePriMobilePhone != input.UsePriMobilePhone || (this.UsePriMobilePhone != null && !this.UsePriMobilePhone.Equals(input.UsePriMobilePhone))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
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
                if (this.CustomerName != null) hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.MobilePhone != null) hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.UsePriMobilePhone != null) hashCode = hashCode * 59 + this.UsePriMobilePhone.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.VerificationCode != null) hashCode = hashCode * 59 + this.VerificationCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
