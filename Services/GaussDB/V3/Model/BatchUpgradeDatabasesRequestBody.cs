using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchUpgradeDatabasesRequestBody 
    {

        /// <summary>
        /// 要版本升级的批量实例。
        /// </summary>
        [JsonProperty("databases_instance_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpgradeDatabasesSingleInstance> DatabasesInstanceInfos { get; set; }

        /// <summary>
        /// 是否延迟升级。
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public string Delay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpgradeDatabasesRequestBody {\n");
            sb.Append("  databasesInstanceInfos: ").Append(DatabasesInstanceInfos).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpgradeDatabasesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpgradeDatabasesRequestBody input)
        {
            if (input == null) return false;
            if (this.DatabasesInstanceInfos != input.DatabasesInstanceInfos || (this.DatabasesInstanceInfos != null && input.DatabasesInstanceInfos != null && !this.DatabasesInstanceInfos.SequenceEqual(input.DatabasesInstanceInfos))) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;

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
                if (this.DatabasesInstanceInfos != null) hashCode = hashCode * 59 + this.DatabasesInstanceInfos.GetHashCode();
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                return hashCode;
            }
        }
    }
}
