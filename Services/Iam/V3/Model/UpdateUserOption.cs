using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateUserOption 
    {

        /// <summary>
        /// IAM用户访问方式。 - default：默认访问模式，编程访问和管理控制台访问。 - programmatic：编程访问。 - console：管理控制台访问。
        /// </summary>
        [JsonProperty("access_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessMode { get; set; }

        /// <summary>
        /// 新IAM用户名，长度1~64之间，只能包含如下字符：大小写字母、空格、数字或特殊字符（-_.）且不能以数字开头。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// IAM用户新密码。 - 系统默认密码最小长度为6字符，在6-32字符之间支持用户自定义密码长度。 - 至少包含以下四种字符中的两种： 大写字母、小写字母、数字和特殊字符。 - 必须满足账户设置中[密码策略](https://support.huaweicloud.com/usermanual-iam/iam_01_0607.html)的要求。 - 新密码不能与当前密码相同。 
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// IAM用户新邮箱，需符合邮箱格式，长度小于等于255字符。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 国家码。必须与手机号同时存在。中国大陆为“0086”。
        /// </summary>
        [JsonProperty("areacode", NullValueHandling = NullValueHandling.Ignore)]
        public string Areacode { get; set; }

        /// <summary>
        /// IAM用户新手机号，纯数字，长度小于等于32字符。必须与国家码同时存在。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 是否启用IAM用户。true为启用，false为停用，默认为true。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// IAM用户密码状态。true：需要修改密码，false：不需要修改密码。
        /// </summary>
        [JsonProperty("pwd_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PwdStatus { get; set; }

        /// <summary>
        /// IAM用户在外部系统中的类型。长度小于等于64字符。xuser_type如果存在，则需要与同一租户中的xaccount_type、xdomain_type校验，须与xuser_id同时存在。 &gt;外部系统指与华为云对接的外部企业管理系统，xaccount_type、xaccount_id、xdomain_type、xdomain_id、xuser_type、xuser_id等参数值，无法在华为云获取，请咨询企业管理员。
        /// </summary>
        [JsonProperty("xuser_type", NullValueHandling = NullValueHandling.Ignore)]
        public string XuserType { get; set; }

        /// <summary>
        /// IAM用户在外部系统中的ID。长度小于等于128字符，必须与xuser_type同时存在。 &gt;外部系统指与华为云对接的外部企业管理系统，xaccount_type、xaccount_id、xdomain_type、xdomain_id、xuser_type、xuser_id等参数值，无法在华为云获取，请咨询企业管理员。
        /// </summary>
        [JsonProperty("xuser_id", NullValueHandling = NullValueHandling.Ignore)]
        public string XuserId { get; set; }

        /// <summary>
        /// IAM用户新描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserOption {\n");
            sb.Append("  accessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  areacode: ").Append(Areacode).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  pwdStatus: ").Append(PwdStatus).Append("\n");
            sb.Append("  xuserType: ").Append(XuserType).Append("\n");
            sb.Append("  xuserId: ").Append(XuserId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateUserOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateUserOption input)
        {
            if (input == null) return false;
            if (this.AccessMode != input.AccessMode || (this.AccessMode != null && !this.AccessMode.Equals(input.AccessMode))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Areacode != input.Areacode || (this.Areacode != null && !this.Areacode.Equals(input.Areacode))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.PwdStatus != input.PwdStatus || (this.PwdStatus != null && !this.PwdStatus.Equals(input.PwdStatus))) return false;
            if (this.XuserType != input.XuserType || (this.XuserType != null && !this.XuserType.Equals(input.XuserType))) return false;
            if (this.XuserId != input.XuserId || (this.XuserId != null && !this.XuserId.Equals(input.XuserId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.AccessMode != null) hashCode = hashCode * 59 + this.AccessMode.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Areacode != null) hashCode = hashCode * 59 + this.Areacode.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.PwdStatus != null) hashCode = hashCode * 59 + this.PwdStatus.GetHashCode();
                if (this.XuserType != null) hashCode = hashCode * 59 + this.XuserType.GetHashCode();
                if (this.XuserId != null) hashCode = hashCode * 59 + this.XuserId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
