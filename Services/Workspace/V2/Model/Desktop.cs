using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Desktop 
    {

        /// <summary>
        /// 桌面所属的用户，当桌面创建成功后此用户可以登录该桌面。只允许输入大写字母、小写字母、数字、中划线（-）和下划线（_）。域类型为LITE_AD时，使用小写字母或者大写字母开头，长度范围为[1-20]。当域类型为LOCAL_AD时，用户名可以使用小写字母或者大写字母或者数字开头，长度范围为[1-32]。Windows桌面用户最长支持20个字符，Linux桌面用户最长支持32个字符。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 合法用户邮箱，桌面创建成功后系统会通过发送邮件的方式通知用户。
        /// </summary>
        [JsonProperty("user_email", NullValueHandling = NullValueHandling.Ignore)]
        public string UserEmail { get; set; }

        /// <summary>
        /// 合法用户手机号。
        /// </summary>
        [JsonProperty("user_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPhone { get; set; }

        /// <summary>
        /// 桌面用户所属的用户组。  - sudo：Linux管理员组。 - default：Linux默认用户组。 - administrators：Windows管理员组。管理员拥有对该桌面的完全访问权，可以做任何需要的更改（禁用操作除外）。 - users：Windows标准用户组。标准用户可以使用大多数软件，并可以更改不影响其他用户的系统设置。
        /// </summary>
        [JsonProperty("user_group", NullValueHandling = NullValueHandling.Ignore)]
        public string UserGroup { get; set; }

        /// <summary>
        /// 桌面名，桌面名必须保证唯一。桌面名称只允许输入大写字母、小写字母、中文、数字、中划线，以字母或数字开头、不能以中划线结尾，长度范围为1~15(中文字符长度为2，数字及英文字符长度为1)。
        /// </summary>
        [JsonProperty("computer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputerName { get; set; }

        /// <summary>
        /// 系统计算机名。
        /// </summary>
        [JsonProperty("os_host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OsHostName { get; set; }

        /// <summary>
        /// 桌面名称前缀，不指定\&quot;computer_name\&quot;时生效。
        /// </summary>
        [JsonProperty("desktop_name_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopNamePrefix { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Desktop {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  userPhone: ").Append(UserPhone).Append("\n");
            sb.Append("  userGroup: ").Append(UserGroup).Append("\n");
            sb.Append("  computerName: ").Append(ComputerName).Append("\n");
            sb.Append("  osHostName: ").Append(OsHostName).Append("\n");
            sb.Append("  desktopNamePrefix: ").Append(DesktopNamePrefix).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Desktop);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Desktop input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.UserEmail != input.UserEmail || (this.UserEmail != null && !this.UserEmail.Equals(input.UserEmail))) return false;
            if (this.UserPhone != input.UserPhone || (this.UserPhone != null && !this.UserPhone.Equals(input.UserPhone))) return false;
            if (this.UserGroup != input.UserGroup || (this.UserGroup != null && !this.UserGroup.Equals(input.UserGroup))) return false;
            if (this.ComputerName != input.ComputerName || (this.ComputerName != null && !this.ComputerName.Equals(input.ComputerName))) return false;
            if (this.OsHostName != input.OsHostName || (this.OsHostName != null && !this.OsHostName.Equals(input.OsHostName))) return false;
            if (this.DesktopNamePrefix != input.DesktopNamePrefix || (this.DesktopNamePrefix != null && !this.DesktopNamePrefix.Equals(input.DesktopNamePrefix))) return false;

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
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserEmail != null) hashCode = hashCode * 59 + this.UserEmail.GetHashCode();
                if (this.UserPhone != null) hashCode = hashCode * 59 + this.UserPhone.GetHashCode();
                if (this.UserGroup != null) hashCode = hashCode * 59 + this.UserGroup.GetHashCode();
                if (this.ComputerName != null) hashCode = hashCode * 59 + this.ComputerName.GetHashCode();
                if (this.OsHostName != null) hashCode = hashCode * 59 + this.OsHostName.GetHashCode();
                if (this.DesktopNamePrefix != null) hashCode = hashCode * 59 + this.DesktopNamePrefix.GetHashCode();
                return hashCode;
            }
        }
    }
}
