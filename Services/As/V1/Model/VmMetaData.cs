using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 云服务器元数据
    /// </summary>
    public class VmMetaData 
    {

        /// <summary>
        /// Windows弹性云服务器Administrator用户的密码。
        /// </summary>
        [JsonProperty("admin_pass", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPass { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VmMetaData {\n");
            sb.Append("  adminPass: ").Append(AdminPass).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VmMetaData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VmMetaData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminPass == input.AdminPass ||
                    (this.AdminPass != null &&
                    this.AdminPass.Equals(input.AdminPass))
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
                if (this.AdminPass != null)
                    hashCode = hashCode * 59 + this.AdminPass.GetHashCode();
                return hashCode;
            }
        }
    }
}
