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
    /// Request Object
    /// </summary>
    public class DeleteMemberRequest 
    {

        /// <summary>
        /// 备份副本id
        /// </summary>
        [SDKProperty("backup_id", IsPath = true)]
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 成员id
        /// </summary>
        [SDKProperty("member_id", IsPath = true)]
        [JsonProperty("member_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteMemberRequest {\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  memberId: ").Append(MemberId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteMemberRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteMemberRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
                ) && 
                (
                    this.MemberId == input.MemberId ||
                    (this.MemberId != null &&
                    this.MemberId.Equals(input.MemberId))
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
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.MemberId != null)
                    hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                return hashCode;
            }
        }
    }
}
