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
    /// 数据库信息。
    /// </summary>
    public class DatabaseForCreation 
    {

        /// <summary>
        /// 数据库名称。 数据库名称长度可在1～64个字符之间，由字母、数字、中划线、下划线或$组成，$累计总长度小于等于10个字符，（MySQL 8.0不可包含$）。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库使用的字符集，例如utf8、gbk、ascii等MySQL支持的字符集。
        /// </summary>
        [JsonProperty("character_set", NullValueHandling = NullValueHandling.Ignore)]
        public string CharacterSet { get; set; }

        /// <summary>
        /// 数据库备注，最大长度512
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseForCreation {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  characterSet: ").Append(CharacterSet).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatabaseForCreation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatabaseForCreation input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CharacterSet != input.CharacterSet || (this.CharacterSet != null && !this.CharacterSet.Equals(input.CharacterSet))) return false;
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
                if (this.CharacterSet != null) hashCode = hashCode * 59 + this.CharacterSet.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                return hashCode;
            }
        }
    }
}
