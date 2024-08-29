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
    public class CreateManualBackupRequestBody 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 备份名称，4~64个字符，必须以英文字母开头，区分大小写，可以包含英文字母、数字、中划线或者下划线，不能包含其他特殊字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 备份描述，不能包含&gt;!&lt;\&quot;&amp;&#39;&#x3D;特殊字符，不大于256个字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 只支持Microsoft SQL Server，局部备份的用户自建数据库名列表，当有此参数时以局部备份为准。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupDatabase> Databases { get; set; }

        /// <summary>
        /// 是否分库备份，只适用于SQLServer，默认为false
        /// </summary>
        [JsonProperty("backup_database_individually", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BackupDatabaseIndividually { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateManualBackupRequestBody {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("  backupDatabaseIndividually: ").Append(BackupDatabaseIndividually).Append("\n");
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
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Databases == input.Databases ||
                    this.Databases != null &&
                    input.Databases != null &&
                    this.Databases.SequenceEqual(input.Databases)
                ) && 
                (
                    this.BackupDatabaseIndividually == input.BackupDatabaseIndividually ||
                    (this.BackupDatabaseIndividually != null &&
                    this.BackupDatabaseIndividually.Equals(input.BackupDatabaseIndividually))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Databases != null)
                    hashCode = hashCode * 59 + this.Databases.GetHashCode();
                if (this.BackupDatabaseIndividually != null)
                    hashCode = hashCode * 59 + this.BackupDatabaseIndividually.GetHashCode();
                return hashCode;
            }
        }
    }
}
