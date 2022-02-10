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
    public class MigrateNodeExtendParam 
    {

        /// <summary>
        /// 节点最大允许创建的实例数(Pod)，该数量包含系统默认实例，取值范围为16~256。 该设置的目的为防止节点因管理过多实例而负载过重，请根据您的业务需要进行设置。 
        /// </summary>
        [JsonProperty("maxPods", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPods { get; set; }

        /// <summary>
        /// Docker数据盘配置项。 待迁移节点的磁盘类型须和创建时一致（即“DockerLVMConfigOverride”参数中“diskType”字段的值须和创建时一致），请确保单次接口调用时批量选择的节点磁盘类型一致。 默认配置示例如下： &#x60;&#x60;&#x60; \&quot;DockerLVMConfigOverride\&quot;:\&quot;dockerThinpool&#x3D;vgpaas/90%VG;kubernetesLV&#x3D;vgpaas/10%VG;diskType&#x3D;evs;lvType&#x3D;linear\&quot; &#x60;&#x60;&#x60; 包含如下字段：   - userLV（可选）：用户空间的大小，示例格式：vgpaas/20%VG   - userPath（可选）：用户空间挂载路径，示例格式：/home/wqt-test   - diskType：磁盘类型，目前只有evs、hdd和ssd三种格式   - lvType：逻辑卷的类型，目前支持linear和striped两种，示例格式：striped   - dockerThinpool：Docker盘的空间大小，示例格式：vgpaas/60%VG   - kubernetesLV：Kubelet空间大小，示例格式：vgpaas/20%VG 
        /// </summary>
        [JsonProperty("DockerLVMConfigOverride", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerLVMConfigOverride { get; set; }

        /// <summary>
        /// 安装前执行脚本 &gt; 输入的值需要经过Base64编码，方法为echo -n \&quot;待编码内容\&quot; | base64。 
        /// </summary>
        [JsonProperty("alpha.cce/preInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePreInstall { get; set; }

        /// <summary>
        /// 安装后执行脚本 &gt; 输入的值需要经过Base64编码，方法为echo -n \&quot;待编码内容\&quot; | base64。 
        /// </summary>
        [JsonProperty("alpha.cce/postInstall", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCcePostInstall { get; set; }

        /// <summary>
        /// 指定待切换目标操作系统所使用的用户镜像ID。 当指定“alpha.cce/NodeImageID”参数时，“os”参数必须和用户自定义镜像的操作系统一致。 镜像需满足条件：[使用私有镜像制作工作节点镜像（公测）](https://support.huaweicloud.com/bestpractice-cce/cce_bestpractice_00026.html)或[使用私有镜像制作Turbo集群共池裸机工作节点镜像](https://support.huaweicloud.com/bestpractice-cce/cce_bestpractice_0134.html) 
        /// </summary>
        [JsonProperty("alpha.cce/NodeImageID", NullValueHandling = NullValueHandling.Ignore)]
        public string AlphaCceNodeImageID { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateNodeExtendParam {\n");
            sb.Append("  maxPods: ").Append(MaxPods).Append("\n");
            sb.Append("  dockerLVMConfigOverride: ").Append(DockerLVMConfigOverride).Append("\n");
            sb.Append("  alphaCcePreInstall: ").Append(AlphaCcePreInstall).Append("\n");
            sb.Append("  alphaCcePostInstall: ").Append(AlphaCcePostInstall).Append("\n");
            sb.Append("  alphaCceNodeImageID: ").Append(AlphaCceNodeImageID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateNodeExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateNodeExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxPods == input.MaxPods ||
                    (this.MaxPods != null &&
                    this.MaxPods.Equals(input.MaxPods))
                ) && 
                (
                    this.DockerLVMConfigOverride == input.DockerLVMConfigOverride ||
                    (this.DockerLVMConfigOverride != null &&
                    this.DockerLVMConfigOverride.Equals(input.DockerLVMConfigOverride))
                ) && 
                (
                    this.AlphaCcePreInstall == input.AlphaCcePreInstall ||
                    (this.AlphaCcePreInstall != null &&
                    this.AlphaCcePreInstall.Equals(input.AlphaCcePreInstall))
                ) && 
                (
                    this.AlphaCcePostInstall == input.AlphaCcePostInstall ||
                    (this.AlphaCcePostInstall != null &&
                    this.AlphaCcePostInstall.Equals(input.AlphaCcePostInstall))
                ) && 
                (
                    this.AlphaCceNodeImageID == input.AlphaCceNodeImageID ||
                    (this.AlphaCceNodeImageID != null &&
                    this.AlphaCceNodeImageID.Equals(input.AlphaCceNodeImageID))
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
                if (this.MaxPods != null)
                    hashCode = hashCode * 59 + this.MaxPods.GetHashCode();
                if (this.DockerLVMConfigOverride != null)
                    hashCode = hashCode * 59 + this.DockerLVMConfigOverride.GetHashCode();
                if (this.AlphaCcePreInstall != null)
                    hashCode = hashCode * 59 + this.AlphaCcePreInstall.GetHashCode();
                if (this.AlphaCcePostInstall != null)
                    hashCode = hashCode * 59 + this.AlphaCcePostInstall.GetHashCode();
                if (this.AlphaCceNodeImageID != null)
                    hashCode = hashCode * 59 + this.AlphaCceNodeImageID.GetHashCode();
                return hashCode;
            }
        }
    }
}
