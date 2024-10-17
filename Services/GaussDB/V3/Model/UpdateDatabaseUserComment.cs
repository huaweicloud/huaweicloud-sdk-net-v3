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
    /// 数据库用户备注信息。
    /// </summary>
    public class UpdateDatabaseUserComment 
    {

        /// <summary>
        /// 数据库用户名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 主机地址。
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// 数据库用户备注,长度不能超过512个字符，不能包含回车和特殊字符!&lt;\&quot;&#x3D;&#39;&gt;&amp;。  该字段只针对新版本的实例生效，必须大于等于指定的内核版本-2.0.13.0，如果不符合内核版本要求，参考升级内核版本升级至最新。
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDatabaseUserComment {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDatabaseUserComment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDatabaseUserComment input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Host != input.Host || (this.Host != null && !this.Host.Equals(input.Host))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;

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
                if (this.Host != null) hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                return hashCode;
            }
        }
    }
}
