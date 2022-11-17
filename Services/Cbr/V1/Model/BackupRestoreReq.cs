using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 恢复请求body
    /// </summary>
    public class BackupRestoreReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restore", NullValueHandling = NullValueHandling.Ignore)]
        public BackupRestore Restore { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupRestoreReq {\n");
            sb.Append("  restore: ").Append(Restore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupRestoreReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupRestoreReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Restore == input.Restore ||
                    (this.Restore != null &&
                    this.Restore.Equals(input.Restore))
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
                if (this.Restore != null)
                    hashCode = hashCode * 59 + this.Restore.GetHashCode();
                return hashCode;
            }
        }
    }
}
