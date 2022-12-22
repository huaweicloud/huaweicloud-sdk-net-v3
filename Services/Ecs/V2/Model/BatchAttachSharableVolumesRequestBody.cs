using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class BatchAttachSharableVolumesRequestBody 
    {

        /// <summary>
        /// 共享磁盘需要挂载的弹性云服务器列表。
        /// </summary>
        [JsonProperty("serverinfo", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchAttachSharableVolumesOption> Serverinfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAttachSharableVolumesRequestBody {\n");
            sb.Append("  serverinfo: ").Append(Serverinfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAttachSharableVolumesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAttachSharableVolumesRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Serverinfo == input.Serverinfo ||
                    this.Serverinfo != null &&
                    input.Serverinfo != null &&
                    this.Serverinfo.SequenceEqual(input.Serverinfo)
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
                if (this.Serverinfo != null)
                    hashCode = hashCode * 59 + this.Serverinfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
