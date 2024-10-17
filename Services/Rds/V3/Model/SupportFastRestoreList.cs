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
    public class SupportFastRestoreList 
    {

        /// <summary>
        /// 实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 表级恢复是否支持极速恢复。
        /// </summary>
        [JsonProperty("is_support_fast_table_restore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportFastTableRestore { get; set; }

        /// <summary>
        /// 库级恢复是否支持极速恢复。
        /// </summary>
        [JsonProperty("is_support_fast_database_restore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportFastDatabaseRestore { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportFastRestoreList {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  isSupportFastTableRestore: ").Append(IsSupportFastTableRestore).Append("\n");
            sb.Append("  isSupportFastDatabaseRestore: ").Append(IsSupportFastDatabaseRestore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupportFastRestoreList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupportFastRestoreList input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.IsSupportFastTableRestore != input.IsSupportFastTableRestore || (this.IsSupportFastTableRestore != null && !this.IsSupportFastTableRestore.Equals(input.IsSupportFastTableRestore))) return false;
            if (this.IsSupportFastDatabaseRestore != input.IsSupportFastDatabaseRestore || (this.IsSupportFastDatabaseRestore != null && !this.IsSupportFastDatabaseRestore.Equals(input.IsSupportFastDatabaseRestore))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.IsSupportFastTableRestore != null) hashCode = hashCode * 59 + this.IsSupportFastTableRestore.GetHashCode();
                if (this.IsSupportFastDatabaseRestore != null) hashCode = hashCode * 59 + this.IsSupportFastDatabaseRestore.GetHashCode();
                return hashCode;
            }
        }
    }
}
