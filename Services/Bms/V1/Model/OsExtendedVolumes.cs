using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// os-extended-volumes:volumes_attached字段数据结构说明
    /// </summary>
    public class OsExtendedVolumes 
    {

        /// <summary>
        /// 云硬盘ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// 删裸金属服务器时是否一并删除该卷。true：是false：否
        /// </summary>
        [JsonProperty("delete_on_termination", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteOnTermination { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OsExtendedVolumes {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  deleteOnTermination: ").Append(DeleteOnTermination).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OsExtendedVolumes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OsExtendedVolumes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DeleteOnTermination == input.DeleteOnTermination ||
                    (this.DeleteOnTermination != null &&
                    this.DeleteOnTermination.Equals(input.DeleteOnTermination))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DeleteOnTermination != null)
                    hashCode = hashCode * 59 + this.DeleteOnTermination.GetHashCode();
                return hashCode;
            }
        }
    }
}
