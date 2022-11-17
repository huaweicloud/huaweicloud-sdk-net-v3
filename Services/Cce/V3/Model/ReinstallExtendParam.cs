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
    /// 重装拓展参数，已废弃。
    /// </summary>
    public class ReinstallExtendParam 
    {

        /// <summary>
        /// 指定待切换目标操作系统所使用的用户镜像ID，已废弃。 指定此参数等价于指定ReinstallVolumeSpec中imageID，原取值将被覆盖。 
        /// </summary>
        [JsonProperty("alpha.cce/NodeImageID", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AlphaCceNodeImageID { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReinstallExtendParam {\n");
            sb.Append("  alphaCceNodeImageID: ").Append(AlphaCceNodeImageID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReinstallExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReinstallExtendParam input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.AlphaCceNodeImageID != null)
                    hashCode = hashCode * 59 + this.AlphaCceNodeImageID.GetHashCode();
                return hashCode;
            }
        }
    }
}
