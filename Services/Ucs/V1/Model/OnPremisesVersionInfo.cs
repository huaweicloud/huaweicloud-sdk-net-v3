using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OnPremisesVersionInfo 
    {

        /// <summary>
        /// Kubernetes集群版本
        /// </summary>
        [JsonProperty("kubernetesVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// 发布版本
        /// </summary>
        [JsonProperty("releaseVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// ucs-ctl工具下载链接
        /// </summary>
        [JsonProperty("ucsctlDownloadURL", NullValueHandling = NullValueHandling.Ignore)]
        public string UcsctlDownloadURL { get; set; }

        /// <summary>
        /// 兼容CPU架构
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public string Arch { get; set; }

        /// <summary>
        /// 对象存储服务访问端点
        /// </summary>
        [JsonProperty("obsEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsEndpoint { get; set; }

        /// <summary>
        /// 软件包存储路径
        /// </summary>
        [JsonProperty("packagePath", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagePath { get; set; }

        /// <summary>
        /// 镜像包存储路径
        /// </summary>
        [JsonProperty("imagesPackagePath", NullValueHandling = NullValueHandling.Ignore)]
        public string ImagesPackagePath { get; set; }

        /// <summary>
        /// 目标版本
        /// </summary>
        [JsonProperty("targetVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnPremisesVersionInfo {\n");
            sb.Append("  kubernetesVersion: ").Append(KubernetesVersion).Append("\n");
            sb.Append("  releaseVersion: ").Append(ReleaseVersion).Append("\n");
            sb.Append("  ucsctlDownloadURL: ").Append(UcsctlDownloadURL).Append("\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("  obsEndpoint: ").Append(ObsEndpoint).Append("\n");
            sb.Append("  packagePath: ").Append(PackagePath).Append("\n");
            sb.Append("  imagesPackagePath: ").Append(ImagesPackagePath).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OnPremisesVersionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OnPremisesVersionInfo input)
        {
            if (input == null) return false;
            if (this.KubernetesVersion != input.KubernetesVersion || (this.KubernetesVersion != null && !this.KubernetesVersion.Equals(input.KubernetesVersion))) return false;
            if (this.ReleaseVersion != input.ReleaseVersion || (this.ReleaseVersion != null && !this.ReleaseVersion.Equals(input.ReleaseVersion))) return false;
            if (this.UcsctlDownloadURL != input.UcsctlDownloadURL || (this.UcsctlDownloadURL != null && !this.UcsctlDownloadURL.Equals(input.UcsctlDownloadURL))) return false;
            if (this.Arch != input.Arch || (this.Arch != null && !this.Arch.Equals(input.Arch))) return false;
            if (this.ObsEndpoint != input.ObsEndpoint || (this.ObsEndpoint != null && !this.ObsEndpoint.Equals(input.ObsEndpoint))) return false;
            if (this.PackagePath != input.PackagePath || (this.PackagePath != null && !this.PackagePath.Equals(input.PackagePath))) return false;
            if (this.ImagesPackagePath != input.ImagesPackagePath || (this.ImagesPackagePath != null && !this.ImagesPackagePath.Equals(input.ImagesPackagePath))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;

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
                if (this.KubernetesVersion != null) hashCode = hashCode * 59 + this.KubernetesVersion.GetHashCode();
                if (this.ReleaseVersion != null) hashCode = hashCode * 59 + this.ReleaseVersion.GetHashCode();
                if (this.UcsctlDownloadURL != null) hashCode = hashCode * 59 + this.UcsctlDownloadURL.GetHashCode();
                if (this.Arch != null) hashCode = hashCode * 59 + this.Arch.GetHashCode();
                if (this.ObsEndpoint != null) hashCode = hashCode * 59 + this.ObsEndpoint.GetHashCode();
                if (this.PackagePath != null) hashCode = hashCode * 59 + this.PackagePath.GetHashCode();
                if (this.ImagesPackagePath != null) hashCode = hashCode * 59 + this.ImagesPackagePath.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
