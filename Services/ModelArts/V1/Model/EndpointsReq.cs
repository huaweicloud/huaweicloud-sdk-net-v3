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
    /// 本地IDE（如PyCharm、VS Code）或SSH客户端，通过SSH远程接入Notebook实例时需要的相关配置。
    /// </summary>
    public class EndpointsReq 
    {

        /// <summary>
        /// **参数解释**：支持的服务。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下：  - NOTEBOOK：可以通过https协议访问Notebook。  - SSH：可以通过SSH协议远程连接Notebook。  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        /// <summary>
        /// **参数解释**：SSH密钥对名称，可以在云服务器控制台（ECS）“密钥对”页面创建和查看。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("key_pair_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> KeyPairNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointsReq {\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("  keyPairNames: ").Append(KeyPairNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EndpointsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EndpointsReq input)
        {
            if (input == null) return false;
            if (this.Service != input.Service || (this.Service != null && !this.Service.Equals(input.Service))) return false;
            if (this.KeyPairNames != input.KeyPairNames || (this.KeyPairNames != null && input.KeyPairNames != null && !this.KeyPairNames.SequenceEqual(input.KeyPairNames))) return false;

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
                if (this.Service != null) hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.KeyPairNames != null) hashCode = hashCode * 59 + this.KeyPairNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
