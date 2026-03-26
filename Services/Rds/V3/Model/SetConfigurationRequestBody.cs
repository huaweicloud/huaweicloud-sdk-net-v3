using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetConfigurationRequestBody 
    {

        /// <summary>
        /// 备份方式 - EBACKUP - PHYSICALBACKUP
        /// </summary>
        [JsonProperty("default_backup_method", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBackupMethod { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetConfigurationRequestBody {\n");
            sb.Append("  defaultBackupMethod: ").Append(DefaultBackupMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetConfigurationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetConfigurationRequestBody input)
        {
            if (input == null) return false;
            if (this.DefaultBackupMethod != input.DefaultBackupMethod || (this.DefaultBackupMethod != null && !this.DefaultBackupMethod.Equals(input.DefaultBackupMethod))) return false;

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
                if (this.DefaultBackupMethod != null) hashCode = hashCode * 59 + this.DefaultBackupMethod.GetHashCode();
                return hashCode;
            }
        }
    }
}
