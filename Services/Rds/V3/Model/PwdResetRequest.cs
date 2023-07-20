using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PwdResetRequest 
    {

        /// <summary>
        /// 数据库密码
        /// </summary>
        [JsonProperty("db_user_pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUserPwd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PwdResetRequest {\n");
            sb.Append("  dbUserPwd: ").Append(DbUserPwd).Append("\n");
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
                    this.DbUserPwd == input.DbUserPwd ||
                    (this.DbUserPwd != null &&
                    this.DbUserPwd.Equals(input.DbUserPwd))
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
                if (this.DbUserPwd != null)
                    hashCode = hashCode * 59 + this.DbUserPwd.GetHashCode();
                return hashCode;
            }
        }
    }
}
