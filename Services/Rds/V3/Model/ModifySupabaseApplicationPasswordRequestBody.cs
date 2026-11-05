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
    /// 修改密码请求。application_password和instance_password可单独传，但不能同时为空。
    /// </summary>
    public class ModifySupabaseApplicationPasswordRequestBody 
    {

        /// <summary>
        /// Supabase应用登录密码。
        /// </summary>
        [JsonProperty("application_password", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationPassword { get; set; }

        /// <summary>
        /// 纳管实例数据库密码。
        /// </summary>
        [JsonProperty("instance_password", NullValueHandling = NullValueHandling.Ignore)]
        public string InstancePassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifySupabaseApplicationPasswordRequestBody {\n");
            sb.Append("  applicationPassword: ").Append(ApplicationPassword).Append("\n");
            sb.Append("  instancePassword: ").Append(InstancePassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifySupabaseApplicationPasswordRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifySupabaseApplicationPasswordRequestBody input)
        {
            if (input == null) return false;
            if (this.ApplicationPassword != input.ApplicationPassword || (this.ApplicationPassword != null && !this.ApplicationPassword.Equals(input.ApplicationPassword))) return false;
            if (this.InstancePassword != input.InstancePassword || (this.InstancePassword != null && !this.InstancePassword.Equals(input.InstancePassword))) return false;

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
                if (this.ApplicationPassword != null) hashCode = hashCode * 59 + this.ApplicationPassword.GetHashCode();
                if (this.InstancePassword != null) hashCode = hashCode * 59 + this.InstancePassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
