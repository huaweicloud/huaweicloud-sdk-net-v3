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
    /// 数据库用户信息。
    /// </summary>
    public class PostgresqlUserForList 
    {

        /// <summary>
        /// 帐号名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用户的权限属性。
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Object Attributes { get; set; }

        /// <summary>
        /// 用户的默认权限。
        /// </summary>
        [JsonProperty("memberof", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Memberof { get; set; }

        /// <summary>
        /// 数据库用户备注。
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostgresqlUserForList {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  attributes: ").Append(Attributes).Append("\n");
            sb.Append("  memberof: ").Append(Memberof).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostgresqlUserForList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostgresqlUserForList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Memberof == input.Memberof ||
                    this.Memberof != null &&
                    input.Memberof != null &&
                    this.Memberof.SequenceEqual(input.Memberof)
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Memberof != null)
                    hashCode = hashCode * 59 + this.Memberof.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                return hashCode;
            }
        }
    }
}
