using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 配额剩余数量信息。
    /// </summary>
    public class ResourceRemainderData 
    {

        /// <summary>
        /// 资源类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 剩余数量。
        /// </summary>
        [JsonProperty("remainder", NullValueHandling = NullValueHandling.Ignore)]
        public long? Remainder { get; set; }

        /// <summary>
        /// 所需资源。
        /// </summary>
        [JsonProperty("need", NullValueHandling = NullValueHandling.Ignore)]
        public long? Need { get; set; }

        /// <summary>
        /// 磁盘类型。type为volume_gigabytes时，会返回该字段。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceRemainderData {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  remainder: ").Append(Remainder).Append("\n");
            sb.Append("  need: ").Append(Need).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceRemainderData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceRemainderData input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Remainder != input.Remainder || (this.Remainder != null && !this.Remainder.Equals(input.Remainder))) return false;
            if (this.Need != input.Need || (this.Need != null && !this.Need.Equals(input.Need))) return false;
            if (this.VolumeType != input.VolumeType || (this.VolumeType != null && !this.VolumeType.Equals(input.VolumeType))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Remainder != null) hashCode = hashCode * 59 + this.Remainder.GetHashCode();
                if (this.Need != null) hashCode = hashCode * 59 + this.Need.GetHashCode();
                if (this.VolumeType != null) hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
