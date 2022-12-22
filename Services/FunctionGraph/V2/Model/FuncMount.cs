using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 函数挂载结构体。
    /// </summary>
    public class FuncMount 
    {

        /// <summary>
        /// 挂载类型(sfs/sfsTurbo/ecs)，func_mounts非空时必选。
        /// </summary>
        [JsonProperty("mount_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MountType { get; set; }

        /// <summary>
        /// 挂载资源ID（对应云服务ID），func_mounts非空时必选。
        /// </summary>
        [JsonProperty("mount_resource", NullValueHandling = NullValueHandling.Ignore)]
        public string MountResource { get; set; }

        /// <summary>
        /// 远端挂载路径（例如192.168.0.12:/data），如果mount_type为ecs，必选。
        /// </summary>
        [JsonProperty("mount_share_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MountSharePath { get; set; }

        /// <summary>
        /// 函数访问路径，func_mounts非空时必选。
        /// </summary>
        [JsonProperty("local_mount_path", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalMountPath { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuncMount {\n");
            sb.Append("  mountType: ").Append(MountType).Append("\n");
            sb.Append("  mountResource: ").Append(MountResource).Append("\n");
            sb.Append("  mountSharePath: ").Append(MountSharePath).Append("\n");
            sb.Append("  localMountPath: ").Append(LocalMountPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FuncMount);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FuncMount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MountType == input.MountType ||
                    (this.MountType != null &&
                    this.MountType.Equals(input.MountType))
                ) && 
                (
                    this.MountResource == input.MountResource ||
                    (this.MountResource != null &&
                    this.MountResource.Equals(input.MountResource))
                ) && 
                (
                    this.MountSharePath == input.MountSharePath ||
                    (this.MountSharePath != null &&
                    this.MountSharePath.Equals(input.MountSharePath))
                ) && 
                (
                    this.LocalMountPath == input.LocalMountPath ||
                    (this.LocalMountPath != null &&
                    this.LocalMountPath.Equals(input.LocalMountPath))
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
                if (this.MountType != null)
                    hashCode = hashCode * 59 + this.MountType.GetHashCode();
                if (this.MountResource != null)
                    hashCode = hashCode * 59 + this.MountResource.GetHashCode();
                if (this.MountSharePath != null)
                    hashCode = hashCode * 59 + this.MountSharePath.GetHashCode();
                if (this.LocalMountPath != null)
                    hashCode = hashCode * 59 + this.LocalMountPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
