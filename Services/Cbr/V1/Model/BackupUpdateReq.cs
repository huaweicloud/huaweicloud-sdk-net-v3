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
    /// 更新请求参数体
    /// </summary>
    public class BackupUpdateReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup", NullValueHandling = NullValueHandling.Ignore)]
        public BackupUpdate Backup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupUpdateReq {\n");
            sb.Append("  backup: ").Append(Backup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupUpdateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupUpdateReq input)
        {
            if (input == null) return false;
            if (this.Backup != input.Backup || (this.Backup != null && !this.Backup.Equals(input.Backup))) return false;

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
                if (this.Backup != null) hashCode = hashCode * 59 + this.Backup.GetHashCode();
                return hashCode;
            }
        }
    }
}
