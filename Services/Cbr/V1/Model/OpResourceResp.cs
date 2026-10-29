using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OpResourceResp 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public OpResourceExtraInfoResp ExtraInfo { get; set; }

        /// <summary>
        /// **参数解释：** 待备份资源ID，用于标识需要备份的资源。 [获取方法请参见\&quot;[查询存储库绑定资源信息](https://support.huaweicloud.com/api-cbr/ShowVault.html)\&quot;，\&quot;[查询资源可保护性](https://support.huaweicloud.com/api-cbr/ShowProtectable.html)\&quot;。](tag:hws) [获取方法请参见\&quot;[查询存储库绑定资源信息](https://support.huaweicloud.com/intl/zh-cn/api-cbr/ShowVault.html)\&quot;，\&quot;[查询资源可保护性](https://support.huaweicloud.com/intl/zh-cn/api-cbr/ShowProtectable.html)\&quot;。](tag:hws_hk) **取值范围：** 格式为UUID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 待备份资源名称，用于标识待备份的资源名称。 **取值范围：** 长度为0~255个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 待备份资源的类型，用于指定待备份的资源类型，不同类型对应不同的云服务资源。 **取值范围：** [OS::Nova::Server：云服务器； OS::Cinder::Volume：云硬盘；OS::Ironic::BareMetalServer：裸金属服务器；OS::Sfs::Turbo：SFS Turbo文件系统；OS::Workspace::DesktopV2：云桌面。](tag:hws,hws_hk) [OS::Nova::Server：云服务器；OS::Cinder::Volume：云硬盘；OS::Sfs::Turbo：SFS Turbo文件系统。](tag:hk_g42,sbc,dt) [OS::Nova::Server：云服务器；OS::Cinder::Volume：云硬盘；OS::Ironic::BareMetalServer：裸金属服务器；OS::Sfs::Turbo：SFS Turbo文件系统。](tag:fcs_vm,ctc,ocb,tm) [OS::Nova::Server：云服务器；OS::Cinder::Volume：云硬盘。](tag:tlf,cmcc,hcso_dt) [OS::Nova::Server：云服务器；OS::Cinder::Volume：云硬盘；OS::Sfs::Turbo：SFS Turbo文件系统；OS::Workspace::DesktopV2：云桌面。](tag:g42)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpResourceResp {\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpResourceResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpResourceResp input)
        {
            if (input == null) return false;
            if (this.ExtraInfo != input.ExtraInfo || (this.ExtraInfo != null && !this.ExtraInfo.Equals(input.ExtraInfo))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.ExtraInfo != null) hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
