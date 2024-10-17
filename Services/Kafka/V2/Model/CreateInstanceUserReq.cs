using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateInstanceUserReq 
    {

        /// <summary>
        /// 用户名称。  创建用户时，为必选参数。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户描述。
        /// </summary>
        [JsonProperty("user_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDesc { get; set; }

        /// <summary>
        /// 用户密码。  创建用户时，为必选参数。  密码不能和用户名相同。 复杂度要求： - 输入长度为8到32位的字符串。 - 必须包含如下四种字符中的三种组合：   - 小写字母   - 大写字母   - 数字   - 特殊字符包括（&#x60;~!@#$%^&amp;*()-_&#x3D;+\\|[{}]:&#39;\&quot;,&lt;.&gt;/?）和空格，并且不能以-开头
        /// </summary>
        [JsonProperty("user_passwd", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPasswd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInstanceUserReq {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userDesc: ").Append(UserDesc).Append("\n");
            sb.Append("  userPasswd: ").Append(UserPasswd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstanceUserReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstanceUserReq input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.UserDesc != input.UserDesc || (this.UserDesc != null && !this.UserDesc.Equals(input.UserDesc))) return false;
            if (this.UserPasswd != input.UserPasswd || (this.UserPasswd != null && !this.UserPasswd.Equals(input.UserPasswd))) return false;

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
                if (this.UserDesc != null) hashCode = hashCode * 59 + this.UserDesc.GetHashCode();
                if (this.UserPasswd != null) hashCode = hashCode * 59 + this.UserPasswd.GetHashCode();
                return hashCode;
            }
        }
    }
}
