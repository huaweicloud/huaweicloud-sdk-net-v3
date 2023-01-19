using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RestoreInstanceFromCollectionRequestBodyCollections 
    {

        /// <summary>
        /// 恢复前表名。
        /// </summary>
        [JsonProperty("old_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OldName { get; set; }

        /// <summary>
        /// 恢复后表名。
        /// </summary>
        [JsonProperty("new_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NewName { get; set; }

        /// <summary>
        /// 数据库集合恢复时间点。UNIX时间戳格式，单位是毫秒，时区是UTC。
        /// </summary>
        [JsonProperty("restore_collection_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreCollectionTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreInstanceFromCollectionRequestBodyCollections {\n");
            sb.Append("  oldName: ").Append(OldName).Append("\n");
            sb.Append("  newName: ").Append(NewName).Append("\n");
            sb.Append("  restoreCollectionTime: ").Append(RestoreCollectionTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreInstanceFromCollectionRequestBodyCollections);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreInstanceFromCollectionRequestBodyCollections input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldName == input.OldName ||
                    (this.OldName != null &&
                    this.OldName.Equals(input.OldName))
                ) && 
                (
                    this.NewName == input.NewName ||
                    (this.NewName != null &&
                    this.NewName.Equals(input.NewName))
                ) && 
                (
                    this.RestoreCollectionTime == input.RestoreCollectionTime ||
                    (this.RestoreCollectionTime != null &&
                    this.RestoreCollectionTime.Equals(input.RestoreCollectionTime))
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
                if (this.OldName != null)
                    hashCode = hashCode * 59 + this.OldName.GetHashCode();
                if (this.NewName != null)
                    hashCode = hashCode * 59 + this.NewName.GetHashCode();
                if (this.RestoreCollectionTime != null)
                    hashCode = hashCode * 59 + this.RestoreCollectionTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
