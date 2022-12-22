using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 创建云硬盘的调度参数。
    /// </summary>
    public class CreateVolumeSchedulerHints 
    {

        /// <summary>
        /// 指定专属存储池ID，表示将云硬盘创建在该ID对应的存储池中。
        /// </summary>
        [JsonProperty("dedicated_storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVolumeSchedulerHints {\n");
            sb.Append("  dedicatedStorageId: ").Append(DedicatedStorageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVolumeSchedulerHints);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVolumeSchedulerHints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DedicatedStorageId == input.DedicatedStorageId ||
                    (this.DedicatedStorageId != null &&
                    this.DedicatedStorageId.Equals(input.DedicatedStorageId))
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
                if (this.DedicatedStorageId != null)
                    hashCode = hashCode * 59 + this.DedicatedStorageId.GetHashCode();
                return hashCode;
            }
        }
    }
}
