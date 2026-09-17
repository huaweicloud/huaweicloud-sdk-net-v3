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
    public class SecretConfig 
    {

        /// <summary>
        /// **参数解释：** 是否在集群中禁用默认插件凭证（paas.elb、paas.aksk secret）。该Secret的data内容是临时AK/SK数据，部分插件在未配置自定义委托时会使用它作为IAM凭证访问其他云服务。 [更多信息请参见[禁用集群中静态存储的临时凭据说明](https://support.huaweicloud.com/usermanual-cce/cce_10_1111.html)。](tag:hws) [更多信息请参见[禁用集群中静态存储的临时凭据说明](https://support.huaweicloud.com/intl/zh-cn/usermanual-cce/cce_10_1111.html)。](tag:hws_hk) **约束限制：** 仅当集群中所有需要访问云服务的插件均已配置自定义委托后，才能禁用该Secret。 **取值范围：** - true: 禁用 - false: 启用  **默认取值：** 新建集群默认true 
        /// </summary>
        [JsonProperty("disableDefaultAddonCredSecret", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableDefaultAddonCredSecret { get; set; }

        /// <summary>
        /// **参数解释：** 是否在集群中禁用节点凭证（node-agency-cred secret）。该Secret的data内容是临时AK/SK数据，节点上安装的系统组件默认使用该凭证。 [更多信息请参见[禁用集群中静态存储的临时凭据说明](https://support.huaweicloud.com/usermanual-cce/cce_10_1111.html)。](tag:hws) [更多信息请参见[禁用集群中静态存储的临时凭据说明](https://support.huaweicloud.com/intl/zh-cn/usermanual-cce/cce_10_1111.html)。](tag:hws_hk) **约束限制：** 需确保已为每个节点/节点池配置委托，且委托至少具备cce:node:get、cce::assumeAgencyForPodIdentity权限，否则禁用该Secret会导致节点安装、运行异常。 **取值范围：** - true: 禁用 - false: 启用  **默认取值：** false 
        /// </summary>
        [JsonProperty("disableNodeAgencyCredSecret", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableNodeAgencyCredSecret { get; set; }

        /// <summary>
        /// **参数解释：** 是否在集群中禁用默认镜像访问凭证（default-secret secret）。该Secret的data内容是SWR临时登录指令，用于SWR的私有镜像拉取。 [更多信息请参见[禁用集群中静态存储的临时凭据说明](https://support.huaweicloud.com/usermanual-cce/cce_10_1111.html)。](tag:hws) [更多信息请参见[禁用集群中静态存储的临时凭据说明](https://support.huaweicloud.com/intl/zh-cn/usermanual-cce/cce_10_1111.html)。](tag:hws_hk) **约束限制：** 需确保集群中的工作负载不使用default-secret作为镜像拉取凭证（配置了镜像免密下载或者使用自定义镜像拉取凭证），否则禁用该Secret后可能会导致镜像拉取失败。 **取值范围：** - true: 禁用 - false: 启用  **默认取值：** false 
        /// </summary>
        [JsonProperty("disableDefaultImagePullSecret", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableDefaultImagePullSecret { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecretConfig {\n");
            sb.Append("  disableDefaultAddonCredSecret: ").Append(DisableDefaultAddonCredSecret).Append("\n");
            sb.Append("  disableNodeAgencyCredSecret: ").Append(DisableNodeAgencyCredSecret).Append("\n");
            sb.Append("  disableDefaultImagePullSecret: ").Append(DisableDefaultImagePullSecret).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecretConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecretConfig input)
        {
            if (input == null) return false;
            if (this.DisableDefaultAddonCredSecret != input.DisableDefaultAddonCredSecret || (this.DisableDefaultAddonCredSecret != null && !this.DisableDefaultAddonCredSecret.Equals(input.DisableDefaultAddonCredSecret))) return false;
            if (this.DisableNodeAgencyCredSecret != input.DisableNodeAgencyCredSecret || (this.DisableNodeAgencyCredSecret != null && !this.DisableNodeAgencyCredSecret.Equals(input.DisableNodeAgencyCredSecret))) return false;
            if (this.DisableDefaultImagePullSecret != input.DisableDefaultImagePullSecret || (this.DisableDefaultImagePullSecret != null && !this.DisableDefaultImagePullSecret.Equals(input.DisableDefaultImagePullSecret))) return false;

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
                if (this.DisableDefaultAddonCredSecret != null) hashCode = hashCode * 59 + this.DisableDefaultAddonCredSecret.GetHashCode();
                if (this.DisableNodeAgencyCredSecret != null) hashCode = hashCode * 59 + this.DisableNodeAgencyCredSecret.GetHashCode();
                if (this.DisableDefaultImagePullSecret != null) hashCode = hashCode * 59 + this.DisableDefaultImagePullSecret.GetHashCode();
                return hashCode;
            }
        }
    }
}
