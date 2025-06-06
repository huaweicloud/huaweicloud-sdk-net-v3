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
    public class RestoreTablesNewRequestBody 
    {

        /// <summary>
        /// 恢复时间戳
        /// </summary>
        [JsonProperty("restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RestoreTime { get; set; }

        /// <summary>
        /// 表信息
        /// </summary>
        [JsonProperty("restore_tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreDatabasesInfoNew> RestoreTables { get; set; }

        /// <summary>
        /// 是否使用极速恢复，可先根据“获取实例是否能使用极速恢复”接口判断本次恢复是否能使用极速恢复。 如果实例使用了XA事务，采用极速恢复的方式会导致恢复失败！
        /// </summary>
        [JsonProperty("is_fast_restore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFastRestore { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreTablesNewRequestBody {\n");
            sb.Append("  restoreTime: ").Append(RestoreTime).Append("\n");
            sb.Append("  restoreTables: ").Append(RestoreTables).Append("\n");
            sb.Append("  isFastRestore: ").Append(IsFastRestore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreTablesNewRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreTablesNewRequestBody input)
        {
            if (input == null) return false;
            if (this.RestoreTime != input.RestoreTime || (this.RestoreTime != null && !this.RestoreTime.Equals(input.RestoreTime))) return false;
            if (this.RestoreTables != input.RestoreTables || (this.RestoreTables != null && input.RestoreTables != null && !this.RestoreTables.SequenceEqual(input.RestoreTables))) return false;
            if (this.IsFastRestore != input.IsFastRestore || (this.IsFastRestore != null && !this.IsFastRestore.Equals(input.IsFastRestore))) return false;

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
                if (this.RestoreTime != null) hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                if (this.RestoreTables != null) hashCode = hashCode * 59 + this.RestoreTables.GetHashCode();
                if (this.IsFastRestore != null) hashCode = hashCode * 59 + this.IsFastRestore.GetHashCode();
                return hashCode;
            }
        }
    }
}
