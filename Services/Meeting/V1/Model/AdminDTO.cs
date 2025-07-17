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
    /// 管理员信息。
    /// </summary>
    public class AdminDTO 
    {

        /// <summary>
        /// 用户帐号，帐号只能包含大小写字母、数字、_、-、.、@符号，不能为纯数字和@后面带.号。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 若携带则以前台携带为准，否则后台默认生成,密码必须满足: * 6-32位 * 不能和帐号的正序和倒序一致 * 至少包含两种字符类型：小写字母、大写字母、数字、特殊字符（&#x60; ~ ! @ # $ % ^ &amp; * ( ) - _ &#x3D; + \\ | [ { } ] ; : \\\&quot; ,&#39; &lt; . &gt; / ?
        /// </summary>
        [JsonProperty("pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string Pwd { get; set; }

        /// <summary>
        /// 邮箱，管理员手机和邮箱必填其一，否则无法重置密码。如果企业短信开关关闭，则邮箱必填。格式必须满足(^$|^[\\\\w-+]+(\\\\.[\\\\w-+]+)*@[\\\\w-]+(\\\\.[\\\\w-]+)*(\\\\.[\\\\w-]{1,})$)。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 手机号，必须加上国家码，例如中国大陆手机+86xxxxxxx，当填写手机号时 “country”参数必填,手机格式必须满足(^$|^[+]?[0-9]+$)。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// [[手机号所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminDTO {\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  pwd: ").Append(Pwd).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdminDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdminDTO input)
        {
            if (input == null) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Pwd != input.Pwd || (this.Pwd != null && !this.Pwd.Equals(input.Pwd))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;

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
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Pwd != null) hashCode = hashCode * 59 + this.Pwd.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                return hashCode;
            }
        }
    }
}
