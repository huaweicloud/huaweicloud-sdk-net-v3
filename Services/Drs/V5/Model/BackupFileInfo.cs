using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 备份文件信息。
    /// </summary>
    public class BackupFileInfo 
    {

        /// <summary>
        /// 备份文件名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// OBS桶中文件路径。  OBS场景：必选  RDS场景：缺省
        /// </summary>
        [JsonProperty("obs_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsPath { get; set; }

        /// <summary>
        /// bak文件数据库版本。  OBS场景：缺省  RDS场景：必选
        /// </summary>
        [JsonProperty("rds_version", NullValueHandling = NullValueHandling.Ignore)]
        public string RdsVersion { get; set; }

        /// <summary>
        /// bak文件所属实例。  OBS场景：缺省  RDS场景：必选
        /// </summary>
        [JsonProperty("rds_source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RdsSourceInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupFileInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  obsPath: ").Append(ObsPath).Append("\n");
            sb.Append("  rdsVersion: ").Append(RdsVersion).Append("\n");
            sb.Append("  rdsSourceInstanceId: ").Append(RdsSourceInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupFileInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupFileInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ObsPath == input.ObsPath ||
                    (this.ObsPath != null &&
                    this.ObsPath.Equals(input.ObsPath))
                ) && 
                (
                    this.RdsVersion == input.RdsVersion ||
                    (this.RdsVersion != null &&
                    this.RdsVersion.Equals(input.RdsVersion))
                ) && 
                (
                    this.RdsSourceInstanceId == input.RdsSourceInstanceId ||
                    (this.RdsSourceInstanceId != null &&
                    this.RdsSourceInstanceId.Equals(input.RdsSourceInstanceId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ObsPath != null)
                    hashCode = hashCode * 59 + this.ObsPath.GetHashCode();
                if (this.RdsVersion != null)
                    hashCode = hashCode * 59 + this.RdsVersion.GetHashCode();
                if (this.RdsSourceInstanceId != null)
                    hashCode = hashCode * 59 + this.RdsSourceInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
