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
    public class ShowCorpAdminResponse : SdkResponse
    {

        /// <summary>
        /// 用户UUID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 用户帐号（华为云会议帐号）。
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 用户名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 管理员类型。 * 0：默认管理员 * 1：普通管理员 
        /// </summary>
        [JsonProperty("adminType", NullValueHandling = NullValueHandling.Ignore)]
        public int? AdminType { get; set; }

        /// <summary>
        /// 邮箱地址。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 手机号。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// [[手机号所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dept", NullValueHandling = NullValueHandling.Ignore)]
        public DeptBasicDTO Dept { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCorpAdminResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  adminType: ").Append(AdminType).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  dept: ").Append(Dept).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCorpAdminResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCorpAdminResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AdminType != input.AdminType || (this.AdminType != null && !this.AdminType.Equals(input.AdminType))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.Dept != input.Dept || (this.Dept != null && !this.Dept.Equals(input.Dept))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AdminType != null) hashCode = hashCode * 59 + this.AdminType.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Dept != null) hashCode = hashCode * 59 + this.Dept.GetHashCode();
                return hashCode;
            }
        }
    }
}
