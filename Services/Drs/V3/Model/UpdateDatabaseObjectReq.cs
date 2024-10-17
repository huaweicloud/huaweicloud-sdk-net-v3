using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 更新对象选择信息体
    /// </summary>
    public class UpdateDatabaseObjectReq 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 是否进行对象选择，是：自定义迁移对象，否：全部迁移，不填默认为否。
        /// </summary>
        [JsonProperty("selected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Selected { get; set; }

        /// <summary>
        /// 是否库级同步
        /// </summary>
        [JsonProperty("sync_database", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncDatabase { get; set; }

        /// <summary>
        /// 数据对象选择信息，selected为true时必填。
        /// </summary>
        [JsonProperty("job", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseInfo> Job { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDatabaseObjectReq {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  selected: ").Append(Selected).Append("\n");
            sb.Append("  syncDatabase: ").Append(SyncDatabase).Append("\n");
            sb.Append("  job: ").Append(Job).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDatabaseObjectReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDatabaseObjectReq input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Selected != input.Selected || (this.Selected != null && !this.Selected.Equals(input.Selected))) return false;
            if (this.SyncDatabase != input.SyncDatabase || (this.SyncDatabase != null && !this.SyncDatabase.Equals(input.SyncDatabase))) return false;
            if (this.Job != input.Job || (this.Job != null && input.Job != null && !this.Job.SequenceEqual(input.Job))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Selected != null) hashCode = hashCode * 59 + this.Selected.GetHashCode();
                if (this.SyncDatabase != null) hashCode = hashCode * 59 + this.SyncDatabase.GetHashCode();
                if (this.Job != null) hashCode = hashCode * 59 + this.Job.GetHashCode();
                return hashCode;
            }
        }
    }
}
