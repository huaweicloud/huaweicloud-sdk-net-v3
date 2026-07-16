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
    /// SSH连接信息。
    /// </summary>
    public class SSHResp 
    {

        /// <summary>
        /// SSH密钥对名称，可以在云服务器控制台（ECS）“密钥对”页面创建和查看。
        /// </summary>
        [JsonProperty("key_pair_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> KeyPairNames { get; set; }

        /// <summary>
        /// SSH连接地址信息。
        /// </summary>
        [JsonProperty("task_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskUrls> TaskUrls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SSHResp {\n");
            sb.Append("  keyPairNames: ").Append(KeyPairNames).Append("\n");
            sb.Append("  taskUrls: ").Append(TaskUrls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SSHResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SSHResp input)
        {
            if (input == null) return false;
            if (this.KeyPairNames != input.KeyPairNames || (this.KeyPairNames != null && input.KeyPairNames != null && !this.KeyPairNames.SequenceEqual(input.KeyPairNames))) return false;
            if (this.TaskUrls != input.TaskUrls || (this.TaskUrls != null && input.TaskUrls != null && !this.TaskUrls.SequenceEqual(input.TaskUrls))) return false;

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
                if (this.KeyPairNames != null) hashCode = hashCode * 59 + this.KeyPairNames.GetHashCode();
                if (this.TaskUrls != null) hashCode = hashCode * 59 + this.TaskUrls.GetHashCode();
                return hashCode;
            }
        }
    }
}
