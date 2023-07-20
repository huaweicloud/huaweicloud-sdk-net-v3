using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 数据库root用户密码。  8~32个字符。 至少包含以下字符中的三种： 大写字母、小写字母、数字和特殊字符~!@#%^*-_&#x3D;+?,  弱密码校验。
    /// </summary>
    public class PwdResetRequest 
    {

        /// <summary>
        /// 数据库root用户密码。  - 8~32个字符。 - 至少包含以下字符中的三种： - 大写字母、小写字母、数字和特殊字符~!@#%^*-_&#x3D;+?,  - 弱密码校验。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PwdResetRequest {\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PwdResetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PwdResetRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }
    }
}
