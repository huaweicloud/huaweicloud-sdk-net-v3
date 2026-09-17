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
    /// 
    /// </summary>
    public class InPlaceMigrateNodeExtendParam 
    {

        /// <summary>
        /// **参数解释**： 安装前执行脚本。 **约束限制**： 安装前/后执行脚本统一计算字符，转码后的字符总数不能超过10240。 输入的值需要经过Base64编码，方法如下：   &#x60;&#x60;&#x60;   echo -n \&quot;待编码内容\&quot; | base64   &#x60;&#x60;&#x60;  **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("alpha.cce/preInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePreInstall { get; set; }

        /// <summary>
        /// **参数解释**： 安装后执行脚本。 **约束限制**： 安装前/后执行脚本统一计算字符，转码后的字符总数不能超过10240。 输入的值需要经过Base64编码，方法如下：   &#x60;&#x60;&#x60;   echo -n \&quot;待编码内容\&quot; | base64   &#x60;&#x60;&#x60;  **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("alpha.cce/postInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePostInstall { get; set; }

        /// <summary>
        /// **参数解释：** 该参数用于控制腾挪节点时， **post-install脚本执行完成前允许节点调度** 的行为。当该参数未设置或者为false时，在kubernetes节点就绪时，容器即可被调度到可用节点。当该参数为true时，在kubernetes节点就绪时且post-install脚本执行完成时，容器才可被调度到可用节点。 **约束限制：** 不涉及 **取值范围：** - false：在kubernetes节点就绪时，容器即可被调度到可用节点。           - true：在kubernetes节点就绪时且post-install脚本执行完成时，容器才可被调度到可用节点。  **默认取值：** false
        /// </summary>
        [JsonProperty("waitPostInstallFinish", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WaitPostInstallFinish { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InPlaceMigrateNodeExtendParam {\n");
            sb.Append("  alphaCcePreInstall: ").Append(AlphaCcePreInstall).Append("\n");
            sb.Append("  alphaCcePostInstall: ").Append(AlphaCcePostInstall).Append("\n");
            sb.Append("  waitPostInstallFinish: ").Append(WaitPostInstallFinish).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InPlaceMigrateNodeExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InPlaceMigrateNodeExtendParam input)
        {
            if (input == null) return false;
            if (this.AlphaCcePreInstall != input.AlphaCcePreInstall || (this.AlphaCcePreInstall != null && !this.AlphaCcePreInstall.Equals(input.AlphaCcePreInstall))) return false;
            if (this.AlphaCcePostInstall != input.AlphaCcePostInstall || (this.AlphaCcePostInstall != null && !this.AlphaCcePostInstall.Equals(input.AlphaCcePostInstall))) return false;
            if (this.WaitPostInstallFinish != input.WaitPostInstallFinish || (this.WaitPostInstallFinish != null && !this.WaitPostInstallFinish.Equals(input.WaitPostInstallFinish))) return false;

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
                if (this.AlphaCcePreInstall != null) hashCode = hashCode * 59 + this.AlphaCcePreInstall.GetHashCode();
                if (this.AlphaCcePostInstall != null) hashCode = hashCode * 59 + this.AlphaCcePostInstall.GetHashCode();
                if (this.WaitPostInstallFinish != null) hashCode = hashCode * 59 + this.WaitPostInstallFinish.GetHashCode();
                return hashCode;
            }
        }
    }
}
