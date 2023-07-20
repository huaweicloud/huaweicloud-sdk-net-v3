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
    /// 数据库信息列表，列表最大长度为50。
    /// </summary>
    public class CreateGaussMySqlDatabase 
    {

        /// <summary>
        /// 数据库名称,数据库名称长度可在1～64个字符之间，由字母、数字、下划线、中划线组成，中划线的累计总长度小于等于10个字符，且不能包含其他特殊字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库备注,长度不能超过512个字符，不能包含回车和特殊字符!&lt;\&quot;&#x3D;&#39;&gt;&amp;。
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 数据库使用的字符集名称，如utf8mb4、gbk。
        /// </summary>
        [JsonProperty("character_set", NullValueHandling = NullValueHandling.Ignore)]
        public string CharacterSet { get; set; }

        /// <summary>
        /// 数据库用户列表，即创建数据库时同步授权给列表中的用户，列表最大长度为50。列表可以为空，即创建数据库时不授予其权限到数据库用户，在需要给该数据库授权某数据库用户时，调用数据库用户授权接口即可。
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public List<GaussMySqlDatabaseUser> Users { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGaussMySqlDatabase {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  characterSet: ").Append(CharacterSet).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateGaussMySqlDatabase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateGaussMySqlDatabase input)
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
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.CharacterSet == input.CharacterSet ||
                    (this.CharacterSet != null &&
                    this.CharacterSet.Equals(input.CharacterSet))
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
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
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.CharacterSet != null)
                    hashCode = hashCode * 59 + this.CharacterSet.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }
    }
}
