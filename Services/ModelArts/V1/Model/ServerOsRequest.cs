using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Lite Server操作系统镜像相关操作请求体。
    /// </summary>
    public class ServerOsRequest 
    {

        /// <summary>
        /// **参数解释**：用于登录服务器密码。注意弹性云服务器和裸金属服务器admin_pass和key_pair_name必须二选一，超节点不支持admin_pass。 **约束限制**：密码规则： - 长度为8至26个 - 至少包含大写字母、小写字母、数字及特殊符号(!@%-_&#x3D;+[{}]:,./?)中的3种 - 不能与用户名或倒序的用户名相同 - 不能包含root或administrator及其逆序 **取值范围**：不涉及 **默认取值**：不涉及
        /// </summary>
        [JsonProperty("admin_pass", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPass { get; set; }

        /// <summary>
        /// **参数解释**：服务器登录密钥对名称。注意admin_pass和key_pair_name必须二选一。 **约束限制**：不涉及。 **取值范围**：不涉及 **默认取值**：不涉及
        /// </summary>
        [JsonProperty("key_pair_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// **参数解释**：镜像ID，切换操作系统场景，该参数必填。 **约束限制**：不涉及。 **取值范围**：不涉及 **默认取值**：不涉及
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// **参数解释**： 创建云服务器过程中待注入实例自定义数据。支持注入文本、文本文件。 示例： base64编码前： * Linux服务器： &#x60;&#x60;&#x60;bash #!/bin/bash echo user_test &gt; /home/user.txt &#x60;&#x60;&#x60; base64编码后： * Linux服务器： &#x60;&#x60;&#x60;bash IyEvYmluL2Jhc2gKZWNobyB1c2VyX3Rlc3QgPiAvaG9tZS91c2VyLnR4dA&#x3D;&#x3D; &#x60;&#x60;&#x60; 了解更多实例自定义数据注入请参考[[用户数据注入](https://support.huaweicloud.com/usermanual-ecs/zh-cn_topic_0032380449.html)](tag:hc)[[用户数据注入](https://support.huaweicloud.com/intl/zh-cn/usermanual-ecs/zh-cn_topic_0032380449.html)][ECS服务“通过实例自定义数据配置ECS实例”章节](tag:fcs,hcso)。 用户需明确user_data的使用效果，可能产生的影响和风险由用户自行承担。 **约束限制**： - user_data的值为base64编码之后的内容。 - 注入内容（编码之前的内容）最大长度为32K。  **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerOsRequest {\n");
            sb.Append("  adminPass: ").Append(AdminPass).Append("\n");
            sb.Append("  keyPairName: ").Append(KeyPairName).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerOsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerOsRequest input)
        {
            if (input == null) return false;
            if (this.AdminPass != input.AdminPass || (this.AdminPass != null && !this.AdminPass.Equals(input.AdminPass))) return false;
            if (this.KeyPairName != input.KeyPairName || (this.KeyPairName != null && !this.KeyPairName.Equals(input.KeyPairName))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.UserData != input.UserData || (this.UserData != null && !this.UserData.Equals(input.UserData))) return false;

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
                if (this.AdminPass != null) hashCode = hashCode * 59 + this.AdminPass.GetHashCode();
                if (this.KeyPairName != null) hashCode = hashCode * 59 + this.KeyPairName.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.UserData != null) hashCode = hashCode * 59 + this.UserData.GetHashCode();
                return hashCode;
            }
        }
    }
}
