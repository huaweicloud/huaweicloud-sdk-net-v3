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
    public class SendVerificationCodeV2Req 
    {

        /// <summary>
        /// 发送验证码的类型： 1：发送短信验证码
        /// </summary>
        [JsonProperty("receiver_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReceiverType { get; set; }

        /// <summary>
        /// 发送验证码的超时时间。 此参数不携带或携带值为null时，采用系统默认超时时间10分钟。 此参数值超过60时，取默认值5分钟。 单位：分钟。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 指定发送验证码的手机号。 目前系统只支持中国手机号。 示例：13XXXXXXXXX
        /// </summary>
        [JsonProperty("mobile_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 根据该参数的取值选择发送短信验证码的语言。此参数默认值为“zh-cn：中文”。 zh-cn：中文en-us：英文
        /// </summary>
        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public string Lang { get; set; }

        /// <summary>
        /// 验证码使用的场景，目前支持如下场景： 29：注册场景18：个人银行卡实名认证场景 此参数不携带或携带值为null时，默认值为“29：注册场景”。
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public int? Scene { get; set; }

        /// <summary>
        /// 客户账号ID。您可以调用[查询客户列表](https://support.huaweicloud.com/api-bpconsole/mc_00021.html)接口获取customer_id。 当scene&#x3D;18时此参数必填；除此之外此参数非必填，不携带或携带值为null时均不做处理。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendVerificationCodeV2Req {\n");
            sb.Append("  receiverType: ").Append(ReceiverType).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  mobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  lang: ").Append(Lang).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendVerificationCodeV2Req);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SendVerificationCodeV2Req input)
        {
            if (input == null) return false;
            if (this.ReceiverType != input.ReceiverType || (this.ReceiverType != null && !this.ReceiverType.Equals(input.ReceiverType))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.MobilePhone != input.MobilePhone || (this.MobilePhone != null && !this.MobilePhone.Equals(input.MobilePhone))) return false;
            if (this.Lang != input.Lang || (this.Lang != null && !this.Lang.Equals(input.Lang))) return false;
            if (this.Scene != input.Scene || (this.Scene != null && !this.Scene.Equals(input.Scene))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;

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
                if (this.ReceiverType != null) hashCode = hashCode * 59 + this.ReceiverType.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.MobilePhone != null) hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.Lang != null) hashCode = hashCode * 59 + this.Lang.GetHashCode();
                if (this.Scene != null) hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
