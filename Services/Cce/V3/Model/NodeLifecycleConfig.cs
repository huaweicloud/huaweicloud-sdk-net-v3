using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 节点自定义生命周期配置
    /// </summary>
    public class NodeLifecycleConfig 
    {

        /// <summary>
        /// 安装前执行脚本 &gt; 输入的值需要经过Base64编码，方法为echo -n \&quot;待编码内容\&quot; | base64。 
        /// </summary>
        [JsonProperty("preInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string PreInstall { get; set; }

        /// <summary>
        /// 安装后执行脚本 &gt; 输入的值需要经过Base64编码，方法为echo -n \&quot;待编码内容\&quot; | base64。 
        /// </summary>
        [JsonProperty("postInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string PostInstall { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeLifecycleConfig {\n");
            sb.Append("  preInstall: ").Append(PreInstall).Append("\n");
            sb.Append("  postInstall: ").Append(PostInstall).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeLifecycleConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeLifecycleConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreInstall == input.PreInstall ||
                    (this.PreInstall != null &&
                    this.PreInstall.Equals(input.PreInstall))
                ) && 
                (
                    this.PostInstall == input.PostInstall ||
                    (this.PostInstall != null &&
                    this.PostInstall.Equals(input.PostInstall))
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
                if (this.PreInstall != null)
                    hashCode = hashCode * 59 + this.PreInstall.GetHashCode();
                if (this.PostInstall != null)
                    hashCode = hashCode * 59 + this.PostInstall.GetHashCode();
                return hashCode;
            }
        }
    }
}
