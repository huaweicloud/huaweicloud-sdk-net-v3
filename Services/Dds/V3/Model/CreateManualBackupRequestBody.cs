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
    public class CreateManualBackupRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup", NullValueHandling = NullValueHandling.Ignore)]
        public CreateManualBackupOption Backup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateManualBackupRequestBody {\n");
            sb.Append("  backup: ").Append(Backup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateManualBackupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateManualBackupRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Backup == input.Backup ||
                    (this.Backup != null &&
                    this.Backup.Equals(input.Backup))
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
                if (this.Backup != null)
                    hashCode = hashCode * 59 + this.Backup.GetHashCode();
                return hashCode;
            }
        }
    }
}
