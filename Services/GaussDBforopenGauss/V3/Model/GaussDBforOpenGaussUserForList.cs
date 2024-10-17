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
    /// 数据库用户信息。
    /// </summary>
    public class GaussDBforOpenGaussUserForList 
    {

        /// <summary>
        /// 帐号名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attribute", NullValueHandling = NullValueHandling.Ignore)]
        public GaussDBforOpenGaussUserForListAttribute Attribute { get; set; }

        /// <summary>
        /// 用户的默认权限。
        /// </summary>
        [JsonProperty("memberof", NullValueHandling = NullValueHandling.Ignore)]
        public string Memberof { get; set; }

        /// <summary>
        /// 用户是否被锁，取值为“true”或“false”。
        /// </summary>
        [JsonProperty("lock_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LockStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GaussDBforOpenGaussUserForList {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  attribute: ").Append(Attribute).Append("\n");
            sb.Append("  memberof: ").Append(Memberof).Append("\n");
            sb.Append("  lockStatus: ").Append(LockStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GaussDBforOpenGaussUserForList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GaussDBforOpenGaussUserForList input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Attribute != input.Attribute || (this.Attribute != null && !this.Attribute.Equals(input.Attribute))) return false;
            if (this.Memberof != input.Memberof || (this.Memberof != null && !this.Memberof.Equals(input.Memberof))) return false;
            if (this.LockStatus != input.LockStatus || (this.LockStatus != null && !this.LockStatus.Equals(input.LockStatus))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Attribute != null) hashCode = hashCode * 59 + this.Attribute.GetHashCode();
                if (this.Memberof != null) hashCode = hashCode * 59 + this.Memberof.GetHashCode();
                if (this.LockStatus != null) hashCode = hashCode * 59 + this.LockStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
