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
    /// Response Object
    /// </summary>
    public class ShowMetadataResponse : SdkResponse
    {

        /// <summary>
        /// 备份ID
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 云服务器备份信息
        /// </summary>
        [JsonProperty("backups", NullValueHandling = NullValueHandling.Ignore)]
        public string Backups { get; set; }

        /// <summary>
        /// 云服务器规格信息
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 云服务器浮动IP信息
        /// </summary>
        [JsonProperty("floatingips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Floatingips { get; set; }

        /// <summary>
        /// 云服务器接口信息
        /// </summary>
        [JsonProperty("interface", NullValueHandling = NullValueHandling.Ignore)]
        public string Interface { get; set; }

        /// <summary>
        /// 云服务器端口信息
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ports { get; set; }

        /// <summary>
        /// 云服务器信息
        /// </summary>
        [JsonProperty("server", NullValueHandling = NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// 云服务器卷信息
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Volumes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMetadataResponse {\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  backups: ").Append(Backups).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  floatingips: ").Append(Floatingips).Append("\n");
            sb.Append("  Interface: ").Append(Interface).Append("\n");
            sb.Append("  ports: ").Append(Ports).Append("\n");
            sb.Append("  server: ").Append(Server).Append("\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMetadataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMetadataResponse input)
        {
            if (input == null) return false;
            if (this.BackupId != input.BackupId || (this.BackupId != null && !this.BackupId.Equals(input.BackupId))) return false;
            if (this.Backups != input.Backups || (this.Backups != null && !this.Backups.Equals(input.Backups))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.Floatingips != input.Floatingips || (this.Floatingips != null && input.Floatingips != null && !this.Floatingips.SequenceEqual(input.Floatingips))) return false;
            if (this.Interface != input.Interface || (this.Interface != null && !this.Interface.Equals(input.Interface))) return false;
            if (this.Ports != input.Ports || (this.Ports != null && input.Ports != null && !this.Ports.SequenceEqual(input.Ports))) return false;
            if (this.Server != input.Server || (this.Server != null && !this.Server.Equals(input.Server))) return false;
            if (this.Volumes != input.Volumes || (this.Volumes != null && input.Volumes != null && !this.Volumes.SequenceEqual(input.Volumes))) return false;

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
                if (this.BackupId != null) hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.Backups != null) hashCode = hashCode * 59 + this.Backups.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Floatingips != null) hashCode = hashCode * 59 + this.Floatingips.GetHashCode();
                if (this.Interface != null) hashCode = hashCode * 59 + this.Interface.GetHashCode();
                if (this.Ports != null) hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.Server != null) hashCode = hashCode * 59 + this.Server.GetHashCode();
                if (this.Volumes != null) hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
