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
    /// 函数挂载配置。
    /// </summary>
    public class MountConfig 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mount_user", NullValueHandling = NullValueHandling.Ignore)]
        public MountUser MountUser { get; set; }

        /// <summary>
        /// 函数挂载列表。
        /// </summary>
        [JsonProperty("func_mounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<FuncMount> FuncMounts { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MountConfig {\n");
            sb.Append("  mountUser: ").Append(MountUser).Append("\n");
            sb.Append("  funcMounts: ").Append(FuncMounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MountConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MountConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MountUser == input.MountUser ||
                    (this.MountUser != null &&
                    this.MountUser.Equals(input.MountUser))
                ) && 
                (
                    this.FuncMounts == input.FuncMounts ||
                    this.FuncMounts != null &&
                    input.FuncMounts != null &&
                    this.FuncMounts.SequenceEqual(input.FuncMounts)
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
                if (this.MountUser != null)
                    hashCode = hashCode * 59 + this.MountUser.GetHashCode();
                if (this.FuncMounts != null)
                    hashCode = hashCode * 59 + this.FuncMounts.GetHashCode();
                return hashCode;
            }
        }
    }
}
