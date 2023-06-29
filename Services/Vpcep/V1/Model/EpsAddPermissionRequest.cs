using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// 添加终端节点服务白名单请求体。
    /// </summary>
    public class EpsAddPermissionRequest 
    {

        /// <summary>
        /// 权限格式为：iam:domain::domain_id或者organizations:orgPath::org_path其中， ● “iam:domain::”和“organizations:orgPath::”为固定格式。 ● “domain_id”为可连接用户的帐号ID，org_path可连接用户的组织路径 domain_id类型支持输入包括“a~z”、“A~Z”、“0~9”或者“*，最大长度可以传64； org_path类型支持“a~z”、“A~Z”、“0~9”、“/-*?”或者“*”，最大长度可以传1024； 例如：iam:domain::6e9dfd51d1124e8d8498dce894923a0dd或者organizations:orgPath::o-3j59d1231uprgk9yuvlidra7zbzfi578/r-rldbu1vmxdw5ahdkknxnvd5rgag77m2z/ou-7tuddd8nh99rebxltawsm6qct5z7rklv/_*
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public string Permission { get; set; }

        /// <summary>
        /// 终端节点服务白名单描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EpsAddPermissionRequest {\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EpsAddPermissionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EpsAddPermissionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
