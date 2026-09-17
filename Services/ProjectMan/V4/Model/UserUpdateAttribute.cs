using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 更细工作项时输入的用户信息
    /// </summary>
    public class UserUpdateAttribute 
    {

        /// <summary>
        /// **参数解释**： 用户ID，可通过[查询项目成员列表](ListProjectUsers.xml)接口获取，响应消息体中的**id**字段的值就是用户ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 用户名称。 **约束限制**： 当**id**属性有值时，优先使用**id**和项目成员进行匹配，匹配失败再按**name**匹配。 **取值范围**： 2~64个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 用户昵称。 **约束限制**： 当**id**，**name**属性有值时，优先使用**id**，**name**和项目成员进行匹配，匹配失败再按**nick_name**匹配。 **取值范围**： 2~30个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUpdateAttribute {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserUpdateAttribute);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserUpdateAttribute input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                return hashCode;
            }
        }
    }
}
