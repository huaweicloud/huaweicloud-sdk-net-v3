using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateAccessControlRequestBody 
    {

        /// <summary>
        /// 访问控制方式。 取值： - white：表示白名单。 - black：表示黑名单。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 控制访问的IP地址数组，最多可添加300个IP地址或网段。
        /// </summary>
        [JsonProperty("ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessControlRule> IpList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccessControlRequestBody {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  ipList: ").Append(IpList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAccessControlRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAccessControlRequestBody input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.IpList != input.IpList || (this.IpList != null && input.IpList != null && !this.IpList.SequenceEqual(input.IpList))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IpList != null) hashCode = hashCode * 59 + this.IpList.GetHashCode();
                return hashCode;
            }
        }
    }
}
